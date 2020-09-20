using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjectsSSS
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(firstName,3,"Name.FirstName","Nome deve conter pelo menos 3 caracteres")
            .HasMinLen(lastName,3,"Name.LastName","Sobrenome deve conter pelo menos 3 caracteres")
            .HasMinLen(firstName,40,"Name.FirstName","Nome deve conter 40 caracteres")
            );


            if (string.IsNullOrEmpty(FirstName))
            {
                AddNotification("Name.FirstName", "Nome inválido");
            }
            
            if (string.IsNullOrEmpty(LastName))
            {
                AddNotification("Name.LastName", "Sobrenome inválido");
            }
            
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}