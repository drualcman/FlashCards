using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Core.Interfaces
{
    /// <summary>
    /// Abstraction definition to return a content to avoid DRY
    /// </summary>
    /// <typeparam name="ContentType"></typeparam>
    public interface IPresenter<ContentType>
    {
        ContentType Content { get; }
    }
}
