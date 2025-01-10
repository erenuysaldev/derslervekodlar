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

        public BasketController(IBasketService basketService, IToastNotification toaster, IProductService productService)
        {
            _basketService = basketService;
            _toaster = toaster;
            _productService = productService;
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

                    // Login öncesi ürün bilgilerini TempData'ya kaydet
                    TempData["PendingProductId"] = productId;
                    TempData["PendingQuantity"] = quantity;
                    TempData["ReturnController"] = "Basket";
                    TempData["ReturnAction"] = "AddToBasket";
                    
                    _toaster.AddInfoToastMessage("Sepete ekleme işlemi için giriş sayfasına yönlendirildiniz!", new ToastrOptions { TimeOut = 3000 });
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
                    _toaster.AddErrorToastMessage("Profilinizde bir sorun var, sepete ekleme işlemi yapılamıyor, lütfen yönetim ile iletişime geçiniz!");
                    return RedirectToAction("Index", "Home");
                }
                BasketItemModel basketItemModel = new()
                {
                    BasketId = basket.Id,
                    ProductId = productId,
                    Quantity = quantity
                };
                await _basketService.AddToBasketAsync(basketItemModel);
                _toaster.AddSuccessToastMessage($"{quantity} adet {product.Name} sepete eklenmiştir.");
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _toaster.AddErrorToastMessage(ex.Message);
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
