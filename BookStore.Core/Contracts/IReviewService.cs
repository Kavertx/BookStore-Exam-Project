using BookStore.Core.Models.Review;
using BookStore.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewCardModel>> GetAllReviewsAsync();
        Task<IEnumerable<Review>> GetAllClientReviewsAsync(int clientId);
        Task<Review?> GetReviewByIdAsync(int id);
        Task<int> CreateAsync(ReviewFormModel model, int clientId);
        Task<ReviewQueryServiceModel> AllAsync(string? searchTerm = null, int currentPage = 1, int reviewsPerPage = 16, bool isApproved = true);
        Task<ReviewCardModel?> GetReviewDetailsByIdAsync(int id);
        Task<bool> DeleteAsync(int id);
        Task ApproveReviewAsync(int id);

    }
}
