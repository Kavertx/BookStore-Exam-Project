using BookStore.Core.Contracts;
using BookStore.Core.Enums;
using BookStore.Core.Models.Book;
using BookStore.Core.Models.Review;
using BookStore.Infrastructure.Data.Common;
using BookStore.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository repository;
        public ReviewService(IRepository _repository)
        { 
            repository = _repository;
        }

        public async Task<int> CreateAsync(ReviewFormModel model, int clientId)
        {
            Review review = new Review()
            {
                BookId = model.BookId,
                ClientId = clientId,
                ReviewContent = model.ReviewContent,
                TimeOfReview = DateTime.Now,
            };
            await repository.AddAsync<Review>(review);
            await repository.SaveChangesAsync();
            return review.Id;
        }

        public async Task<IEnumerable<Review>> GetAllClientReviewsAsync(int clientId)
        {
            return await repository.AllReadOnly<Review>().Where(r=> r.ClientId == clientId).ToListAsync();
        }

        public async Task<ReviewQueryServiceModel> AllAsync(string? searchTerm = null, int currentPage = 1, int reviewsPerPage = 16)
        {
            var reviewsToShow = repository.AllReadOnly<Review>();

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                string normalisedSearchTerm = searchTerm.ToLower();
                reviewsToShow = reviewsToShow
                    .Where(r => (r.Book.AuthorName.ToLower().Contains(normalisedSearchTerm) ||
                                r.Book.Title.ToLower().Contains(normalisedSearchTerm) ||
                                r.ReviewContent.ToLower().Contains(normalisedSearchTerm)));
            }

            reviewsToShow.OrderBy(r => r.Book.Title);

            var reviews = await reviewsToShow
                .Skip((currentPage - 1) * reviewsPerPage)
                .Take(reviewsPerPage)
                .ProjectToReviewCardViewModel()
                .ToListAsync();
            int totalReviews = await reviewsToShow.CountAsync();
            return new ReviewQueryServiceModel()
            {
                Reviews = reviews,
                TotalReviewsCount = totalReviews
            };
        }
        public async Task<IEnumerable<ReviewCardModel>> GetAllReviewsAsync()
        {
            return await repository.AllReadOnly<Review>().ProjectToReviewCardViewModel().ToListAsync();
        }

        public async Task<Review?> GetReviewByIdAsync(int id)
        {
            return await repository.GetByIdAsync<Review>(id);
        }
        public async Task<ReviewCardModel?> GetReviewDetailsByIdAsync(int id)
        {
            return await repository.AllReadOnly<Review>().Where(r => r.Id == id).ProjectToReviewCardViewModel().FirstOrDefaultAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var review = await repository.GetByIdAsync<Review>(id) ?? throw new NullReferenceException("Review with this id does not exist");
                await repository.DeleteAsync<Review>(id);
                await repository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

            
        }
    }
}
