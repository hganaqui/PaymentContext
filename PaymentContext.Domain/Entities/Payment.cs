using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string number, string address, string document, string owner, string email)
        {
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            Address = address;
            Document = document;
            Owner = owner;
            Email = email;
        }

        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Number { get; private set; }
        public string Address { get; private set; }
        public string Document { get; private set; }
        public string Owner { get; private set; }
        public string Email { get; private set; }

    }
  
   
}