using FlashCards.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.UseCases.GetQuestCards
{
    public interface IGetQuestCardsController
    {
        ValueTask<IEnumerable<QuestCard>> GetQuestCards();
    }
}
