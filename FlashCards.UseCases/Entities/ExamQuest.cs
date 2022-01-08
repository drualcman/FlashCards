using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.UseCases.Entities
{
    /// <summary>
    /// Exam definition
    /// </summary>
    public class ExamQuest
    {
        /// <summary>
        /// identity code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Exam name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Subjects to include
        /// </summary>
        public IEnumerable<Subject> Subjects { get; set; }
    }
}
