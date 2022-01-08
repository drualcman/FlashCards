using FlashCards.UseCases.Entities;
using FlashCards.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.UseCases.GetQuestCards
{
    public class GetQuestCardsInteractor : IGetQuestCardsInputPort
    {
        readonly IGetQuestCardsOutputPort Output;
        readonly IQuestRepository Repository;

        public GetQuestCardsInteractor(IGetQuestCardsOutputPort output, IQuestRepository repository)
        {
            Output = output;
            Repository = repository;
        }

        public async ValueTask Handle()
        {
            IEnumerable<ExamQuest> exams = await Repository.GetExams();
            await Output.Handle(exams);
        }
    }
}
