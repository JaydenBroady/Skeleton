using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TestingProduct
    {
        [TestMethod]
        public void InstanceOk()
        {

            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //test to see that it exists
            Assert.IsNotNull(AProduct);
        }
       
            
        [TestMethod]
        public void PriceProductOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            decimal TestData = 10;
            //assign the data to the product
            AProduct.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Price, TestData);
        }
        [TestMethod]
        public void ScentTypeProductOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            string TestData = "What is the scent of Product";
            //assign the data to the product
            AProduct.ScentType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ScentType, TestData);
        }
        [TestMethod]
        public void OccasionProductOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            string TestData = "What is the occasion";
            //assign the data to the product
            AProduct.Occasion = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Occasion, TestData);
        }
        //[TestMethod]
        public void AvailabilityProductOK()
        {
           // Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            Int32 TestData = 32;
            //assign the data to the product
            AProduct.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Availability, TestData);
       }

















    }
}
