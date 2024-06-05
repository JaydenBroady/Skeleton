using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TestProductID
    {
        [TestMethod]
        public void ProductIdOk()
        {

            // Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            Int32 TestData = 32;
            //assign the data to the product
            AProduct.ProuctId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductId, TestData);
        }
    }
}
