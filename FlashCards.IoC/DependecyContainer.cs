using FlashCards.Controllers;
using FlashCards.MemoryRepository;
using FlashCards.Presenter;
using FlashCards.UseCases;
using FlashCards.UseCases.GetQuestCards;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.IoC
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddQuestServices(this IServiceCollection services)
        {
            services.AddQuestRepositories();
            services.AddQuestCases();
            services.AddQuestPresenters();
            services.AddQuestControllers();
            return services;
        }
    }
}
