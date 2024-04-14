namespace BookStore.Core.Models.Review
{
    public class AllReviewsQueryModel
    {
        public int ReviewsPerPage { get; } = 16;
        public string SearchTerm { get; set; } = string.Empty;
        public int CurrentPage { get; set; } = 1;
        public int TotalReviewsCount { get; set; }
        public IEnumerable<ReviewCardModel> Reviews { get; set; } = new List<ReviewCardModel>();
    }
}
