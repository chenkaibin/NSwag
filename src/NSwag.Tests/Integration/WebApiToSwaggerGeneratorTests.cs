﻿using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSwag.CodeGeneration.SwaggerGenerators.WebApi;
using NSwag.Demo.Web.Controllers;

namespace NSwag.Tests.Integration
{
    [TestClass]
    public class WebApiToSwaggerGeneratorTests
    {
        [TestMethod]
        public void When_generating_swagger_from_controller_than_all_required_operations_are_available()
        {
            //// Arrange
            var generator = new WebApiToSwaggerGenerator("api/{controller}/{action}/{id}");

            //// Act
            var service = generator.Generate<PersonsController>();
            var swaggerSpecification = service.ToJson();

            //// Assert
            Assert.AreEqual(8, service.Operations.Count());
        }
    }
}
