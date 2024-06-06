﻿using ClassLibrary;
using Hl7.Fhir.Utility;
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
            Int32 TestData = 10;
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
        [TestMethod]
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
        [TestMethod]

        public void ProductIdOk()
        {

            // Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            Int32 TestData = 32;
            //assign the data to the product
            AProduct.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductId, TestData);
        }
        [TestMethod]
        public void TestProductIdFound()
        {

            //create an instance of the new class we want to create 
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the results of validation
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok
            Boolean Ok = true;
            //create some test data
            Int32 ProductID = 21;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the product ID
            if (AProduct.ProductId != 21)
            {
                Ok = false;

            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
       
        public void TestNameFound()
        {
            //create an instance of the new class we want to create 
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the results of validation
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok
            Boolean Ok = true;
            //create some test data
            Int32 ProductID = 21;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the product ID
            if (AProduct.Name != "Test Name")
            {
                Ok = false;

            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void Descriptionfound()
        {
            //create an instance of the new class we want to create 
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the results of validation
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok
            Boolean Ok = true;
            //create some test data
            Int32 ProductID = 21;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the product ID
            if (AProduct.Description != "Test Description")
            {
                Ok = false;

            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void Occasionfound()
        {
            //create an instance of the new class we want to create 
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the results of validation
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok
            Boolean Ok = true;
            //create some test data
            Int32 ProductID = 21;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the product ID
            if (AProduct.Occasion != "Test Occasion")
            {
                Ok = false;

            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]

        public void Pricefound()
        {
            //create an instance of the new class we want to create 
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the results of validation
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok
            Boolean Ok = true;
            //create some test data
            Int32 ProductID = 21;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the product ID
            if (AProduct.Price != 10)
            {
                Ok = false;

            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void ScentTypefound()
        {
            //create an instance of the new class we want to create 
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the results of validation
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok
            Boolean Ok = true;
            //create some test data
            Int32 ProductID = 21;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the product ID
            if (AProduct.ScentType != "Test Scent Type")
            {
                Ok = false;

            }
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]

        public void Availabilityfound()
        {
            //create an instance of the new class we want to create 
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the results of validation
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok
            Boolean Ok = true;
            //create some test data
            Int32 ProductID = 21;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the product ID
            if (AProduct.Availability != 5)
            {
                Ok = false;

            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }



















    }
}
