using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Core.Interfaces
{
    /// <summary>
    /// Abstraction to manage ports without data
    /// </summary>
    public interface IPort
    {
        ValueTask Handle();
    }

    /// <summary>
    /// Abstraction to manage ports with data
    /// </summary>
    public interface IPort<InputType>
    {
        ValueTask Handle(InputType input);
    }
}
