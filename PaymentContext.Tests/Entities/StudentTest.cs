using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjectsSSS;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Teste", "teste");
            foreach (var not in name.Notifications)
            {
                // not.Messakge;
            }
        }
    }
}
