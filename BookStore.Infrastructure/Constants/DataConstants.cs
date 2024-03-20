using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Constants
{
    public static class DataConstants
    {
        public static class BookConstants
        {
            public const int TitleMax = 200;
            public const int TitleMin = 1;
            public const int DescriptionMax = 2000;
            public const int DescriptionMin = 100;
            public const string PriceMin = "0.99";
            public const string PriceMax = "1000.00";
            public const int AuthorNameMax = 150;
            public const int AuthorNameMin = 3;
        }
        public static class GenreConstants
        {
            public const int NameMax = 50;
            public const int NameMin = 5;
        }
        public static class OrderConstants 
        {

        }
    }
}
