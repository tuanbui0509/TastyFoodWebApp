using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConectionString = "TastyFoodDb";

        public class AppSettings
        {
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
            public const string LocalAddress = "LocalAddress";
        }

        public class ProductSettings
        {
            public const int NumberOfFeaturedProducts = 8;
            public const int NumberOfLatestProducts = 8;
            public const int NumberOfBestSellerProducts = 6;
        }

        public class ProductConstants
        {
            public const string NA = "N/A";
        }
    }
}