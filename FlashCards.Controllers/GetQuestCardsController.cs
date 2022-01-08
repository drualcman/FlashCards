using FlashCards.Core.Entities;
using FlashCards.Core.Interfaces;
using FlashCards.UseCases.GetQuestCards;

namespace FlashCards.Controllers
{
    public class GetQuestCardsController : IGetQuestCardsController
    {
        readonly IGetQuestCardsInputPort InputPort;
        readonly IGetQuestCardsOutputPort OutputPort;

        public GetQuestCardsController(IGetQuestCardsInputPort inputPort, IGetQuestCardsOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }

        public async ValueTask<IEnumerable<QuestCard>> GetQuestCards()
        {
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<QuestCard>>)OutputPort).Content;
        }
    }
}