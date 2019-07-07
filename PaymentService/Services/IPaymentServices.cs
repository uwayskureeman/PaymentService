using PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Services
{
    public interface IPaymentServices
    {
        PaymentTransactions AddPaymentTransactions(PaymentTransactions transactions);

        Dictionary<string, PaymentTransactions> GetPaymentTransactions();
    }
}
