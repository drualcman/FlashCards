using FlashCards.Core.Entities;
using System.Net.Http.Json;
using DrUalcman.Exceptions;
using DrUalcman.Exceptions.Models;

namespace FlashCards.ApiClient
{
    public class CardsApiClient
    {
        const string CreateOrderEndpoint = "quests";
        readonly HttpClient Client;

        public CardsApiClient(HttpClient client)
        {
            Client = client;
        }

        public async Task<IEnumerable<QuestCard>> GetAllCards()
        {
            using HttpResponseMessage response = await Client.GetAsync($"{CreateOrderEndpoint}/get-all-cards");
            List<QuestCard> result = new List<QuestCard>();
            if (response.IsSuccessStatusCode)
            {
                result = new List<QuestCard>(await response.Content.ReadFromJsonAsync<IEnumerable<QuestCard>>());                
            }
            else
            {
                var problemDetails = await response.Content.ReadFromJsonAsync<ProblemDetails>();
                throw new ProblemDetailsException("No se han podido obtener los datos.", new ProblemDetails
                {
                    Instance = $"{Client.BaseAddress}{CreateOrderEndpoint}/get-all-cards",
                    Title = "Error de conexion con la API.",
                    Detail = $"{(int)response?.StatusCode!} {response.ReasonPhrase}",
                    Status = StatusCodes.Status502BadGateway,
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.3"
                });
            }
            return result!;
        }
    }
}