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
            public const int RatingMax = 5;
            public const int RatingMin = 1;
        }
        public static class GenreConstants
        {
            public const int NameMax = 50;
            public const int NameMin = 5;
        }
        public static class ReviewConstants 
        {
            public const int ReviewContentMin = 100;
            public const int ReviewContentMax = 2000;
        }
        public static class AppUserConstants
        {
            public const int UsernameMax = 30;
            public const int UsernameMin = 3;
        }
    }
}
