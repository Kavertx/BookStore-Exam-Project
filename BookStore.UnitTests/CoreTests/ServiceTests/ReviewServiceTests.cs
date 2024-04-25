using BookStore.Core.Contracts;
using BookStore.Core.Services;
using BookStore.Infrastructure.Data.Common;
using BookStore.Infrastructure.Data.Models;
using BookStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Core.Models.Review;

namespace BookStore.UnitTests.CoreTests.ServiceTests
{
    [TestFixture]
    public class ReviewServiceTests
    {
        private ApplicationDbContext context;
        private IRepository repository;
        private IBookService bookService;
        private IReviewService reviewService;
        private string testUserId = "5c35b64b-b218-4548-ba50-5b75879a422f";
        [SetUp]
        public async Task Setup()
        {

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDb")
                .Options;
            context = new ApplicationDbContext(options);
            var books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "Book A",
                    AuthorName = "Test1",
                    ClientId =1,
                    IsApproved=true,
                    Description = "Test DescriptionTest DescriptionTest DescriptionTest DescriptionTest Description",
                    GenreId = 1,
                    ImageUrl = "test",
                    InStock = true,
                    Price = 10,
                    Rating = 5
                },
                new Book
                {
                    Id = 2,
                    Title = "Book B",
                    AuthorName = "Test2",
                    ClientId =1,
                    IsApproved=true,
                    Description = "Test DescriptionTest DescriptionTest DescriptionTest DescriptionTest Description",
                    GenreId = 2,
                    ImageUrl = "test",
                    InStock = true,
                    Price = 10,
                    Rating = 5
                },
                new Book
                {
                    Id = 3,
                    Title = "Book C",
                    AuthorName = "Test3",
                    ClientId =1,
                    IsApproved=true,
                    Description = "Test DescriptionTest DescriptionTest DescriptionTest DescriptionTest Description",
                    GenreId = 3,
                    ImageUrl = "test",
                    InStock = true,
                    Price = 10,
                    Rating = 5
                }
            };
            var genres = new List<Genre>
            {
                new Genre
                {
                    Id= 1,
                    Name = "Genre A"
                },
                new Genre
                {
                    Id= 2,
                    Name = "Genre B"
                },
                new Genre
                {
                    Id= 3,
                    Name = "Genre C"
                }
            };
            var client = new Client
            {
                Id = 1,
                UserId = testUserId,
                UserName = "Test Client",
            };
            var review = new Review
            {
                IsApproved = false,
                BookId = 1,
                ClientId = 1,
                Id = 1,
                ReviewContent = "TEST REVIEW TEST REVIEW TEST REVIEW TEST REVIEW TEST REVIEW TEST REVIEW TEST REVIEW TEST REVIEW ",
                TimeOfReview = DateTime.Now
            };
            await context.Books.AddRangeAsync(books);
            await context.Genres.AddRangeAsync(genres);
            await context.Clients.AddAsync(client);
            await context.Reviews.AddAsync(review);
            await context.SaveChangesAsync();
            repository = new Repository(context);
            bookService = new BookService(repository);
            reviewService = new ReviewService(repository);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task AllAsync()
        {
            var searchTerm = "test";


            var reviewsApproved = await reviewService.AllAsync(searchTerm);
            var reviewsNotApproved = await reviewService.AllAsync(searchTerm, 1, 16, false);
            Assert.That(!reviewsApproved.Reviews.Any());
            Assert.That(reviewsNotApproved.Reviews.Any());
            Assert.That(reviewsNotApproved.Reviews.Count()==1);
            Assert.That((await reviewService.AllAsync(null, 1, 16, false)).Reviews.Count() == 1);

        }

        [Test]
        public async Task GetReviewByIdAsync()
        {
            var rFromContext = (await context.Reviews.FirstAsync(r => r.Id == 1));
            var review1 = await reviewService.GetReviewByIdAsync(1);

            Assert.That(review1 != null);
            Assert.That(review1 == rFromContext);
            
        }
        [Test]
        public async Task CreateAsync()
        {
            var book = (await bookService.AllBookBooksAsync()).FirstOrDefault(book => book.Id == 1);
            var form = new ReviewFormModel()
            {
                AuthorName = book.AuthorName,
                BookId = book.Id,
                BookTitle = book.Title,
                ImageUrl = book.ImageUrl,
                ReviewContent = "Test review Test review Test review Test review Test review Test review Test review Test review Test review Test review Test review Test review ",
            };
            var clientId = 1;
            var reviewId = await reviewService.CreateAsync(form, clientId);

            Assert.That(reviewId!=default);
            Assert.That(reviewId == 2);
            Assert.That((await repository.GetByIdAsync<Review>(reviewId))!=null);
            Assert.That((await repository.GetByIdAsync<Review>(reviewId)).Id==2);
            Assert.That((await repository.AllReadOnly<Review>().ToListAsync()).Count==2);
        }

        [Test]
        public async Task GetReviewDetailsByIdAsync()
        {
            var reviewId = 1;
            var reviewDetails = await reviewService.GetReviewDetailsByIdAsync(reviewId);
            var reviewFromContext = await context.Reviews.FindAsync(reviewId);
            Assert.That(reviewDetails!=null);
            Assert.That(reviewDetails.Id == reviewFromContext.Id);
            Assert.That(reviewDetails.ClientId == reviewFromContext.ClientId);
            Assert.That(reviewDetails.BookId == reviewFromContext.BookId);
            Assert.That(reviewDetails.ReviewContent == reviewFromContext.ReviewContent);
            Assert.That(reviewDetails.IsApproved == reviewFromContext.IsApproved);
        }

        [Test]
        public async Task DeleteAsync()
        {
            var reviewId = 1;
            var res = await reviewService.DeleteAsync(reviewId);
            Assert.That(res);
            Assert.That((await repository.GetByIdAsync<Review>(reviewId)) == null);
        }
        [Test]
        public async Task ApproveReviewAsync()
        {
            var reviewId = 1;
            await reviewService.ApproveReviewAsync(reviewId);
            Assert.That((await repository.GetByIdAsync<Review>(reviewId)).IsApproved);
        }
    }
}
