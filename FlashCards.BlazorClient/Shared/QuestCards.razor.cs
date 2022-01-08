using FlashCards.Core.Entities;
using Microsoft.AspNetCore.Components;

namespace FlashCards.BlazorClient.Shared
{
    public partial class QuestCards
    {
        [Parameter]
        public IEnumerable<QuestCard> Cards { get; set; }

        string Flipped(QuestCard quest)
        {
            if (quest.Flipped) return "flipped";
            else return string.Empty;
        }
    }
}
