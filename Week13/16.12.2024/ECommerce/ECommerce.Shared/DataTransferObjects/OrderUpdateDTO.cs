using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.DataTransferObjects
{
    public class OrderUpdateDTO
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public IEnumerable<OrderItemCreateDTO> OrderItems { get; set; }
    }
}
