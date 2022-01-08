using FlashCards.UseCases.GetQuestCards;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Controllers
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddQuestControllers(this IServiceCollection services)
        {
            services.AddScoped<IGetQuestCardsController, GetQuestCardsController>();
            return services;
        }
    }
}
