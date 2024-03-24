namespace Calculations.Test
{
    [Collection("Customer")]
    public class CustomerDetailsTest
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerDetailsTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            var customer = _customerFixture.Customer;
            var fullName = customer.GetFullName("Sirajum", "Munira");
            Assert.Equal("Sirajum Munira", fullName);
        }
    }
}
