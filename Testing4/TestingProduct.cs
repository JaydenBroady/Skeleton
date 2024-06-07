using ClassLibrary;
using Hl7.Fhir.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing4
{
    [TestClass]
    public class TestingProduct
    {

        //good test data 
        int Availability = 11;
        string Occasion = "Outside";
        int Price = 10;
        string Description = "Smells good";
        string ScentType = "Vesartile";

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
        [TestMethod]

        public void ValidMethodOk()
        {
            //create an instance we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store an error message 
            String Error = "";
            //invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void AvailabilityMinLessOne()
        {
            // create an instance
            clsProduct AProduct = new clsProduct();
            //string c=variable to store an error 
            String Error = "";
            //create some test data 
            int Availability = 0; //this triggers an error
            //invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AvailabilityNoMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int Availability = 1; //this should be ok
                                  //invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AvailabilityMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Availability = 2; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AvailabilityMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Availability = 99; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AvailabilityMax()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Availability = 100; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AvailabilityMid()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Availability = 50; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        // Occasion tests
        [TestMethod]
        public void OccasionMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Occasion = ""; // this should fail
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OccasionMin()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Occasion = "a"; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OccasionMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Occasion = "aa"; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OccasionMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Occasion = new string('a', 49); // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OccasionMax()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Occasion = new string('a', 50); // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OccasionMid()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Occasion = new string('a', 25); // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // Price tests
        [TestMethod]
        public void PriceMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Price = -1; // this should fail
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Price = 0; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Price = 1; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Price = 999; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Price = 1000; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            int Price = 500; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // Description tests
        [TestMethod]
        public void DescriptionMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Description = ""; // this should fail
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Description = "a"; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Description = "aa"; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Description = new string('a', 499); // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Description = new string('a', 500); // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Description = new string('a', 250); // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // ScentType tests
        [TestMethod]
        public void ScentTypeMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string ScentType = ""; // this should fail
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScentTypeMin()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string ScentType = "a"; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScentTypeMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string ScentType = "aa"; // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScentTypeMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string ScentType = new string('a', 49); // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScentTypeMax()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string ScentType = new string('a', 50); // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScentTypeMid()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string ScentType = new string('a', 25); // this should be ok
            // invoke the method
            Error = AProduct.Valid(Availability, Occasion, ScentType, Price, Description);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



















    }
}
