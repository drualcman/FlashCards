using FlashCards.UseCases.GetQuestCards;
using FlashCards.UseCases.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.MemoryRepository
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddQuestRepositories(this IServiceCollection services)
        {
            services.AddScoped<IQuestRepository, MemoryRepository>();
            return services;
        }
    }
}
