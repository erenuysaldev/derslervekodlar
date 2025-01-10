using ECommerce.MVC.Abstract;
using ECommerce.MVC.Models;
using System.Text.Json;

namespace ECommerce.MVC.Services
{
    public class BasketService : BaseService, IBasketService
    {
        public BasketService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

        public async Task AddToBasketAsync(BasketItemModel basketItemModel)
        {
            try
            {
                var client = GetHttpClient();
                var response = await client.PostAsJsonAsync("baskets/addtobasket", basketItemModel);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException("API hata verdi");
                }
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<BasketItemModel>>(jsonString, _jsonSerializerOptions);
                if (result?.Errors != null || result?.Errors?.Count > 0)
                {
                    throw new Exception($"Hata var: {string.Join(",", result.Errors)}");
                }
                if (result.Data == null)
                {
                    throw new Exception("Veri gelmedi");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw;
            }
        }

        public Task<bool> ChangeQuantityAsync(int basketItemId, int quantity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ClearBasketAsync(string applicationUserId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateBasketAsync(BasketModel basketModel)
        {
            throw new NotImplementedException();
        }

        public async Task<BasketModel> GetBasketAsync(string applicationUserId)
        {
            try
            {
                var client = GetHttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"baskets/{applicationUserId}");
                //client.DefaultRequestHeaders.Authorization
                var response = await client.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    return new BasketModel();
                }
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseModel<BasketModel>>(jsonString, _jsonSerializerOptions);
                //Klasik hata kontrollerini yap
                return result.Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new BasketModel();
            }
        }

        public Task RemoveFromBasketAsync(int basketItemId)
        {
            throw new NotImplementedException();
        }
    }
}
