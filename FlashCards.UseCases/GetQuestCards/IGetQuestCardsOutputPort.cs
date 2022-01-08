using FlashCards.Core.Interfaces;
using FlashCards.UseCases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.UseCases.GetQuestCards
{
    public interface IGetQuestCardsOutputPort : IPort<IEnumerable<ExamQuest>>
    {
    }
}
