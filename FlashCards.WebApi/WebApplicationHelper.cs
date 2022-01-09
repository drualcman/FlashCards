using DrUalcman.Exceptions.Extensions;
using DrUalcman.Exceptions.Interfaces;
using DrUalcman.Exceptions.MiddleWare;
using FlashCards.IoC;

namespace FlashCards.WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebApplication(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddQuestServices();
            builder.Services.AddExceptionsHandlerPresenter();
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            return builder.Build();
        }

        public static WebApplication ConfigureWebApplication(this WebApplication app)
        {
            app.UseExceptionHandler(builder =>
                builder.UseExceptionHandlerPresenter(
                    app.Environment,
                    app.Services.GetService<IExceptionPresenter>()));


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors();

            app.UseApplicationEndpints();

            return app;
        }
    }
}
