using ECommerce.MVC.Abstract;
using ECommerce.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Claims;

namespace ECommerce.MVC.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IProductService _productService;
        private readonly IToastNotification _toaster;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AddToBasket(int productId, int quantity)
        {
            try
            {
                if (!User.Identity.IsAuthenticated)
                {
                    _toaster.AddInfoToastMessage("Sepete ekleme işlemi için giriş sayfasına yönlendiriliyorsunuz.", new ToastrOptions { TimeOut = 3000 });
                    return RedirectToAction("Login", "Auth");
                }
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var product = await _productService.GetAsync(productId);
                if (product == null)
                {
                    return NotFound();

                }
                var basket = await _basketService.GetBasketAsync(userId);
                if (basket == null)
                {
                    _toaster.AddErrorToastMessage("Profilinizde bi soru var, sepete eklenemiyor,lütfen adminle iletişime geçiniz");
                    return RedirectToAction("Index", "Home");
                }
                BasketItemModel basketItemModel = new()
                {
                    BasketId = basket.Id,
                    ProductId = productId,
                    Quantity = quantity
                };
                await _basketService.AddToBasketAsync(basketItemModel);
                _toaster.AddSuccessToastMessage($"{quantity}adet {product.Name}sepete eklenmiştir.");
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _toaster.AddErrorToastMessage(ex.Message);
                return RedirectToAction("Index", "Home");   

            }
            return View();
        }
    }
}
