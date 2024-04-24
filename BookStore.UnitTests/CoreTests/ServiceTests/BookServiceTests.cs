using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
using BookStore.Core.Services;
using BookStore.Infrastructure.Data;
using BookStore.Infrastructure.Data.Common;
using BookStore.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace BookStore.UnitTests.CoreTests.ServiceTests
{


    [TestFixture]
    public class BookServiceTests
    {
        private ApplicationDbContext context;
        private IRepository repository;
        private IBookService bookService;
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
            await context.Books.AddRangeAsync(books);
            await context.Genres.AddRangeAsync(genres);
            await context.Clients.AddAsync(client);
            await context.SaveChangesAsync();
            repository = new Repository(context);
            bookService = new BookService(repository);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        // tests don't work :) 
        [Test]
        public async Task BookDetailsAsync()
        {
            var bookA = await bookService.BookDetailsByIdAsync(1);
            var bookB = await bookService.BookDetailsByIdAsync(2);
            var bookC = await bookService.BookDetailsByIdAsync(3);

            Assert.That(3.Equals((await bookService.AllGenresNamesAsync()).Count()));
            Assert.That(3.Equals((await bookService.AllBookBooksAsync()).Count()));
            Assert.That("Book A".Equals(bookA.Title));
            Assert.That("Book B".Equals(bookB.Title));
            Assert.That("Book C".Equals(bookC.Title));
        }

        [Test]
        public async Task AllGenresAsync_ReturnsAllGenres()
        {
            var result = await bookService.AllGenresAsync();

            // Assert
            Assert.That(3.Equals(result.Count()));
            Assert.That(result.Any(g => g.Id == 1 && g.Name == "Genre A"));
            Assert.That(result.Any(g => g.Id == 2 && g.Name == "Genre B"));
            Assert.That(result.Any(g => g.Id == 3 && g.Name == "Genre C"));
        }

        [Test]
        public async Task AllBookBooksAsync()
        {


            // Act
            var booksQ = await bookService.AllBookBooksAsync();

            // Assert
            Assert.That(3.Equals(booksQ.Count()));
            Assert.That(booksQ.First(b=> b.Id ==1).ClientId==1);
            Assert.That(
                booksQ.
                First(b => b.Id == 2).Description == "Test DescriptionTest DescriptionTest DescriptionTest DescriptionTest Description"
                );
            Assert.That(booksQ.First(b => b.Id == 3).Price == 10);
            Assert.That(booksQ.First(b => b.Id == 3).AuthorName == "Test3");
        }

        [Test]
        public async Task AllGenresAsync()
        {
            // Act
            var result = await bookService.AllGenresAsync();

            // Assert
            Assert.That(result.Any());
            Assert.That(result.Count()==3);
            Assert.That(result.First().Name == "Genre A");

        }

        [Test]
        public async Task AllAsync_SearchTermAsync()
        {
            var searchTerm = "Test3";
            var res = await bookService.AllAsync(null,searchTerm);

            Assert.That(res.TotalBooksCount == 1);
            Assert.That(res.Books.First().Id == 3);
            Assert.That(res.Books.First().Author == searchTerm);

            Assert.That(!(await bookService.AllAsync("Genre B", searchTerm)).Books.Any());
            Assert.That((await bookService.AllAsync("Genre C", searchTerm)).Books.Any());
            Assert.That(!(await bookService.AllAsync("Genre C", searchTerm, 0,1, 16, false)).Books.Any());
            Assert.That((await bookService.AllAsync(null,null,0,1,16,true)).Books.Count()==3);
            Assert.That((await bookService.AllAsync("Genre A", "Test1")).Books.Any());

        }

        [Test]
        public async Task ApproveBookAsync()
        {
            Book book = new Book()
            {
                Id =4, 
                AuthorName = "Author",
                IsApproved =false,
                ClientId=1,
                Description= "TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST ",
                ImageUrl= "test",
                GenreId = 2,
                Price=10,
                Title = "TEST",
                InStock=true,
                Rating=5,
            };
            await context.AddAsync<Book>(book);
            await context.SaveChangesAsync();
            await bookService.ApproveBookAsync(book.Id);

            Assert.That((await bookService.BookDetailsByIdAsync(book.Id)).IsApproved == true);
        }

        public async Task GetGenreIdByNameAsync()
        {
            var genreName = "Genre A";
            Assert.That((await bookService.GetGenreIdByNameAsync(genreName))==1);
            Assert.That((await bookService.GetGenreIdByNameAsync(genreName)) != 2);
        }

        [Test]
        public async Task BookExistsByIdAsync()
        {
            var id1 = 1;
            var id2 = 2;
            var id6 = 6;
            Assert.That((await bookService.BookExistsByIdAsync(id1)));
            Assert.That((await bookService.BookExistsByIdAsync(id2)));
            Assert.That(!(await bookService.BookExistsByIdAsync(id6)));
        }

        [Test]
        public async Task DeleteAsync()
        {
            var allBooks = await bookService.AllBookBooksAsync();
            var bookId = 1;

            Assert.That(allBooks.Count() == 3);

            await bookService.DeleteAsync(bookId);

            allBooks = await bookService.AllBookBooksAsync();
            Assert.That(allBooks.Count() == 2);

        }
        [Test]
        public async Task CreateAsync()
        {
            BookFormModel bfm = new BookFormModel()
            {
                AuthorName = "Test123",
                Description = "Description TEST Description TEST Description TEST Description TEST Description TEST Description TEST ",
                GenreId = 1,
                ImageUrl = "test",
                Price = 6,
                Rating=2,
                Title = "AAAAAAAAAAAAAAAAA"
            };
            var clientId = 1;
            Assert.That((await bookService.CreateAsync(bfm, clientId)) == 4);
            Assert.That((await bookService.AllBookBooksAsync()).Count() == 4);
        }

        [Test]
        public async Task GenreExistsAsync()
        {
            int id1 = 1;
            int id5 = 5;
            Assert.That((await bookService.GenreExistsAsync(id1)));
            Assert.That(!(await bookService.GenreExistsAsync(id5)));
        }
    }
}
