using System;
using Xunit;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using DynamicsGPJDFAPI;

namespace XUnitDynamicsAPITest
{
    public class CustomerControllerTest
    {
        DynamicsGPJDFAPI.Controllers.CustomersController customerController;
        DynamicsGPJDFAPI.Services.IGenericEFFactory genericEFFactory;
        public CustomerControllerTest()
        {
            
            customerController = new DynamicsGPJDFAPI.Controllers.CustomersController(genericEFFactory);
        }
        [Fact]
        public void GetAllCustomers()
        {
            // Act
            var okResult = customerController.Get();

            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }
        [Fact]
        public void GetSpecificCustomer()
        {

        }
    }
}
