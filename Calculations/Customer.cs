namespace Calculations
{
    public class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
        public virtual int GetOrdersByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is null or empty");
            }

            // Assume that this method will access the database
            // and return the number of orders for the customer
            return 100;
        }
        public string Name => "Sirajum";
        public int Age => 32;
    }

    public class LoyalCustomer : Customer
    {
        public int Discount { get; set; }
        public LoyalCustomer()
        {
            Discount = 10;
        }

        public override int GetOrdersByName(string name)
        {
            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount > 100)
            {
                return new LoyalCustomer();
            }
            return new Customer();
        }
    }
}
