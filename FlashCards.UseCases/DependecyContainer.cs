using FlashCards.UseCases.GetQuestCards;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.UseCases
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddQuestCases(this IServiceCollection services)
        {
            services.AddScoped<IGetQuestCardsInputPort, GetQuestCardsInteractor>();
            return services;
        }
    }
}
