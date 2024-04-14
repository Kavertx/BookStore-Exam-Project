using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models.Review
{
    public class ReviewQueryServiceModel
    {
        public int TotalReviewsCount { get; set; }
        public IEnumerable<ReviewCardModel> Reviews { get; set; } = new List<ReviewCardModel>();
    }
}
