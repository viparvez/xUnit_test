﻿namespace Calculations.Test
{
    [Collection("Customer")]
    public class CustomerTest
    {
        [Fact]
        public void CheckName_NotEmpty()
        {
            var customer = new Customer();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrWhiteSpace(customer.Name));
        }

        [Fact]
        public void CheckAge_GreaterThanTwenty()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 20, 40);
        }

        [Fact]
        public void GetOrdersByName_EmptyName_ThrowsException()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));
            Assert.Equal("Name is null or empty", exceptionDetails.Message);
        }

        [Fact]
        public void LoyalCustomerForOrgersG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(109);
            var loyalCusttomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCusttomer.Discount);
        }
    }
}
