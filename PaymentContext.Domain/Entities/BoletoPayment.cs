using System;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string number, string address, string document, string owner, string email): base( paidDate, expireDate, total, totalPaid, number, address,  document,  owner,  email)
        {
            BarCode = barCode;
            BoletoCode = boletoCode;
        }

        public string BarCode { get; private set; }
        public string BoletoCode { get; private set; }
    }
}