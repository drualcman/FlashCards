using FlashCards.UseCases.GetQuestCards;

namespace FlashCards.WebApi
{
    public static class EndpointsHelper
    {
        public static WebApplication UseApplicationEndpints(this WebApplication app)
        {
            app.MapGet("/quests/get-all-cards", async (IGetQuestCardsController controller) => 
                Results.Ok(await controller.GetQuestCards()));
            return app;
        }
    }
}
