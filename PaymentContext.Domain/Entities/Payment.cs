using System;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        public Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string number, Address address, Document document, string owner, Email email)
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

            AddNotifications(new Contract()
            .Requires()
            .IsLowerOrEqualsThan(0,Total,"Payment.Total","O Total não pode ser zero")
            .IsGreaterOrEqualsThan(Total,TotalPaid,"Payment.Total","O Valor pago é menor que o valor do pagamento")
            );
        }

        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Number { get; private set; }
        public Address Address { get; private set; }
        public Document Document { get; private set; }
        public string Owner { get; private set; }
        public Email Email { get; private set; }

    }
  
   
}