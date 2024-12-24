using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.DTOs.Auth
{
    public class TokenDTO
    {
        public string AccesToken { get; set; } //JWT
        public DateTime ExpirationDate { get; set; } //JTW ömrü
    }
}
