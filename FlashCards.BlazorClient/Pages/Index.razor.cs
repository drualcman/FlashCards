using FlashCards.Core.Entities;
using FlashCards.UseCases.GetQuestCards;
using Microsoft.AspNetCore.Components;

namespace FlashCards.BlazorClient.Pages
{
    public partial class Index
    {
        [Inject]
        public IGetQuestCardsController QuestCardsController { get; set; }

        IEnumerable<QuestCard> Cards;

        protected override async Task OnInitializedAsync()
        {
            Cards = await QuestCardsController.GetQuestCards();
        }
    }
}
