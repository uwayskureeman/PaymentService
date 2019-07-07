using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentService.Models;
using PaymentService.Services;

namespace PaymentService.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentServices _services;
        public PaymentController(IPaymentServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("AddPaymentTransactions")]
        public ActionResult<PaymentTransactions> AddPaymentTransactions(PaymentTransactions transactions)
        {
            var paymentTransactions = _services.AddPaymentTransactions(transactions);

            if (paymentTransactions == null)
            {
                return NotFound();
            }

            return paymentTransactions;
        }

        [HttpGet]
        [Route("GetPaymentTransactions")]
        public ActionResult<Dictionary<string, PaymentTransactions>> GetPaymentTransactions()
        {
            var paymentTransactions = _services.GetPaymentTransactions();

            //Here we cna add check on transaction ID, if we need an API to fetch only a particular transaction.

            if (paymentTransactions.Count == 0)
            {
                return NotFound();
            }

            return paymentTransactions;

        }
    }
}