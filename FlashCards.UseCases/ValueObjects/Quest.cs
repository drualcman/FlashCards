using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.UseCases.ValueObjects
{
    public record struct Quest(string Query, string Answer);
}
