using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentService.Models;

namespace PaymentService.Services
{
    public class PaymentServices : IPaymentServices
    {
        private readonly Dictionary<string, PaymentTransactions> _paymentTransactions;

        public PaymentServices()
        {
            _paymentTransactions = new Dictionary<string, PaymentTransactions>();
        }


        public PaymentTransactions AddPaymentTransactions(PaymentTransactions transactions)
        {
            _paymentTransactions.Add(transactions.TransactionId, transactions);

            //Here we should connect to the Bank and authenticate card number, expiry date and so on before proceeding.

            return transactions;
        }

        public Dictionary<string, PaymentTransactions> GetPaymentTransactions()
        {
            return _paymentTransactions;
        }
    }
}
