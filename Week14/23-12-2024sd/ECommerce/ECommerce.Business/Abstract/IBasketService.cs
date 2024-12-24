using ECommerce.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    //Data Transfer Object - DTO
    public interface IBasketService
    {
        Task<BasketDTO> GetBasketAsync(int id);
        Task<IEnumerable<BasketDTO>> GetBasketsAsync();
    }
}
