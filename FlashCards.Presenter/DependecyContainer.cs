using FlashCards.UseCases.GetQuestCards;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Presenter
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddQuestPresenters(this IServiceCollection services)
        {
            services.AddScoped<IGetQuestCardsOutputPort, GetQuestCardsPresenter>();
            return services;
        }
    }
}
