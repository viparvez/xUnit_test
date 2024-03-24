namespace Calculations.Test
{
    [Collection("Customer")]
    public class CustomerDetailsTest
    {
        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            var customer = new Customer();
            var fullName = customer.GetFullName("Sirajum", "Munira");
            Assert.Equal("Sirajum Munira", fullName);
        }
    }
}
