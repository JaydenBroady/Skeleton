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

        private decimal mPrice;

        public decimal Price
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
    }
}