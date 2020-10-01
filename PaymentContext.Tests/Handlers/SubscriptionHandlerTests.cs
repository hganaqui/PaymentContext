using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        //Red, Green, Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "balta.io@gmail.com";
            command.BarCode = "123456789";
            command.BoletoCode = "123123";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.PayerEmail = "Teste@teste";
            command.PaymentNumber = "1223131321";
            command.Street = "asdasdas";
            command.Number = "asdasdas";
            command.Neighborhood = "asdasdas";
            command.City = "asdasdas";
            command.State = "asdasdas";
            command.Country = "asdasdas";
            command.ZipCode = "asdasdas";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}