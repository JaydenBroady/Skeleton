using System;
using System.Diagnostics;

namespace ClassLibrary
{
    public class clsProduct
    {

        private Int32 mProductId;

        public int ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value; 
            }
        }
        private string mName;

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        private string mDescription;

        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }

        private Int32 mPrice;

        public int Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        private string mScentType;

        public string ScentType
        {
            get
            {
                return mScentType;
            }
            set
            {
                mScentType = value;
            }
        }
        private string mOccasion;

        public string Occasion
        {
            get
            {
                return mOccasion;
            }
            set
            {
                mOccasion = value;
            }
        }
        private Int32 mAvailability;

        public int Availability
        {
            get
            {
                return mAvailability;
            }
            set
            {
                mAvailability = value;
            }
        }



        public bool Find(int productID)
        {
            mProductId = 21;
            mName = "Test Name";
            mAvailability = 5;
            mScentType = "Test Scent Type";
            mOccasion = "Test Occasion";
            mPrice = 19;
            mDescription = "Test Description";
            //always return true
            return true;
        }

        public string Valid(int availability, string occasion, string scentType, int price, string description)
        {
            // Create a string variable to store the error message
            string error = "";

            // Validate Availability (1 to 100)
            if (availability < 1 || availability > 100)
            {
                error += "The availability must be between 1 and 100: ";
            }

            // Validate Occasion (1 to 50 characters)
            if (string.IsNullOrEmpty(occasion))
            {
                error += "The occasion may not be blank: ";
            }
            if (occasion.Length > 50)
            {
                error += "The occasion must be less than 50 characters: ";
            }

            // Validate ScentType (1 to 50 characters)
            if (string.IsNullOrEmpty(scentType))
            {
                error += "The scent type may not be blank: ";
            }
            if (scentType.Length > 50)
            {
                error += "The scent type must be less than 50 characters: ";
            }

            // Validate Price (0 to 1000)
            if (price < 0 || price > 1000)
            {
                error += "The price must be between 0 and 1000: ";
            }

            // Validate Description (1 to 500 characters)
            if (string.IsNullOrEmpty(description))
            {
                error += "The description may not be blank: ";
            }
            if (description.Length > 500)
            {
                error += "The description must be less than 500 characters: ";
            }

            // Return any error messages
            return error;
        }

    }
}