using DrUalcman.Exceptions;
using FlashCards.ApiClient;
using FlashCards.Core.Entities;
using FlashCards.UseCases.GetQuestCards;
using Microsoft.AspNetCore.Components;

namespace FlashCards.BlazorClient.Pages
{
    public partial class Index
    {
        [Inject]
        public CardsApiClient Client { get; set; }

        IEnumerable<QuestCard> Cards;

        protected override async Task OnInitializedAsync()
        {
            Cards = await Client.GetAllCards();            
        }
    }
}
