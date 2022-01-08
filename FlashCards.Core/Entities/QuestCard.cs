using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Core.Entities
{
    /// <summary>
    /// Card to show to the user.
    /// </summary>
    public class QuestCard
    {
        public string Quest { get; set; }
        public string Solution { get; set; }
        public bool Flipped { get; set; } = false;
    }
}
