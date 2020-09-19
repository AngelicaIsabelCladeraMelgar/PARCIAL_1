using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialIsabelCladera.Controllers;

namespace UnitTestProjectParcialIsabelCladera.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            CountriesController countriesController = new CountriesController();

            //Act
            var ListaCountry = countriesController.GetCountries();

            //Assert
            Assert.IsNotNull(ListaCountry);
        }
    }
}
