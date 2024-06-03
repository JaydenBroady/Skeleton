using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TestDescriptionProduct
    {
        [TestMethod]
        public void DescriptionProductOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            string TestData = "Describe the Product";
            //assign the data to the product
            AProduct.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Description, TestData);
        }
    }
}
