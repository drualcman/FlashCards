using FlashCards.UseCases.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.UseCases.Entities
{
    /// <summary>
    /// Subject taught in a course and part of a study program
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// subject name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Questions and answers
        /// </summary>
        public IEnumerable<Quest> Quests { get; set; }
        /// <summary>
        /// If also have other subjects
        /// </summary>
        public IEnumerable<Subject> Subjects { get; set; }
    }
}
