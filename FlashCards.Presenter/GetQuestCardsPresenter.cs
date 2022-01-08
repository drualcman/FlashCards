using FlashCards.Core.Entities;
using FlashCards.Core.Interfaces;
using FlashCards.UseCases.Entities;
using FlashCards.UseCases.GetQuestCards;
using FlashCards.UseCases.ValueObjects;

namespace FlashCards.Presenter
{
    public class GetQuestCardsPresenter : IPresenter<IEnumerable<QuestCard>>, IGetQuestCardsOutputPort
    {
        public IEnumerable<QuestCard> Content { get; private set; }

        readonly List<QuestCard> Quests = new List<QuestCard>();

        public ValueTask Handle(IEnumerable<ExamQuest> input)
        {
            foreach (ExamQuest exam in input)
            {
                foreach (Subject subject in exam.Subjects)
                {
                    GetQuests(subject);
                }
            }
            Content = Quests;
            return ValueTask.CompletedTask;
        }

        private void GetQuests(Subject subject)
        {
            if (subject.Subjects is not null && subject.Subjects.Any())
            {
                foreach (Subject sub in subject.Subjects)
                {
                    GetQuests(sub);
                }
            }
            else
            {
                foreach (Quest quest in subject.Quests)
                {
                    AddQuest(quest);
                }
            }
        }

        private void AddQuest(Quest quest) => 
            Quests.Add(new QuestCard
            {
                Quest = quest.Query,
                Solution = quest.Answer
            });
    }
}