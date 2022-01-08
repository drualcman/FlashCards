using FlashCards.UseCases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.UseCases.Interfaces
{
    public interface IQuestRepository
    {
        Task<IEnumerable<ExamQuest>> GetExams();
        Task<IEnumerable<ExamQuest>> GetQuests(string code);
    }
}
