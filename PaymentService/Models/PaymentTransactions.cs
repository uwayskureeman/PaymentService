using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Models
{
    public class PaymentTransactions
    {
        public string TransactionId { get; set; }
        public double CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public double CVV { get; set; }
    }
}
