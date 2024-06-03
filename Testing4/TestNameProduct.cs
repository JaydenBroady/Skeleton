using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TestNameProduct
    {
        [TestMethod]
        public void NameProductOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            string TestData = "Name of Product";
            //assign the data to the product
            AProduct.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Name, TestData);
        }
    }
}
