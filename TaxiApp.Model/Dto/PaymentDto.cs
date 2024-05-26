using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Entities;

namespace TaxiApp.Domain.Dto
{
    public class PaymentDto
    {
        public int PaymentId { get; set; }

        public int? RideId { get; set; }

        public decimal Amount { get; set; }

        public string Method { get; set; } = null!;

        public DateTime? PaymentTime { get; set; }
       
    }
}
