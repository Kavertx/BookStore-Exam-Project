using BookStore.Core.Services;
using BookStore.Infrastructure.Data;
using BookStore.Infrastructure.Data.Common;
using BookStore.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace BookStore.UnitTests.CoreTests.ServiceTests
{
    public class BookServiceTests
    {
        // tests don't work :) 
        [Test]
        public async Task AllAsync_NoFilters_ReturnsAllBooksOrderedAlphabetically()
        {
            // Arrange
            var mockRepository = new Mock<IRepository>();
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Book A" },
                new Book { Id = 2, Title = "Book B" },
                new Book { Id = 3, Title = "Book C" }
            };
            //var asyncEnumBooks = books.AsAsyncEnumerable();
            mockRepository.Setup(r => r.AllReadOnly<Book>()).Returns(books.AsQueryable());

            var service = new BookService(mockRepository.Object);

            // Act
            var result = await service.AllAsync();

            // Assert
            Assert.That(3.Equals(result.TotalBooksCount));
            Assert.That(3.Equals( result.Books.Count()));
            Assert.That("Book A".Equals(result.Books.ToList()[0].Title));
            Assert.That("Book B".Equals(result.Books.ToList()[1].Title));
            Assert.That("Book C".Equals(result.Books.ToList()[2].Title) );
        }

        [Test]
        public async Task AllGenresAsync_ReturnsAllGenres()
        {
            // Arrange
            var mockRepository = new Mock<IRepository>();
            var genres = new List<Genre>
            {
                new Genre { Id = 1, Name = "Fantasy" },
                new Genre { Id = 2, Name = "Science Fiction" },
                new Genre { Id = 3, Name = "Mystery" }
            };
            mockRepository.Setup(r => r.AllReadOnly<Genre>()).Returns(genres.AsQueryable());

            var service = new BookService(mockRepository.Object);

            // Act
            var result = await service.AllGenresAsync();

            // Assert
            Assert.That(3.Equals(result.Count()));
            Assert.That(result.Any( g => g.Id == 1 && g.Name == "Fantasy"));
            Assert.That(result.Any(g => g.Id == 2 && g.Name == "Science Fiction"));
            Assert.That(result.Any(g => g.Id == 3 && g.Name == "Mystery"));
        }

        [Test]
        public async Task AllBookBooksAsync_FilterBySearchTerm_ReturnsBooksContainingSearchTerm()
        {
            // Arrange
            var mockRepository = new Mock<IRepository>();
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Harry Potter", Description = "A fantasy novel", AuthorName = "J.K. Rowling" },
                new Book { Id = 2, Title = "Lord of the Rings", Description = "A epic fantasy novel", AuthorName = "J.R.R. Tolkien" },
                new Book { Id = 3, Title = "The Hobbit", Description = "A fantasy adventure novel", AuthorName = "J.R.R. Tolkien" }
            };
            mockRepository.Setup(r => r.AllReadOnly<Book>()).Returns(books.AsQueryable());

            var service = new BookService(mockRepository.Object);
            

            // Act
            var booksQ = await service.AllBookBooksAsync();
            var result = booksQ.Where(b => b.AuthorName == "J.R.R. Tolkien");

            // Assert
            Assert.That(2.Equals(result.Count()));
            //Assert.Equal(!3,result.Count());
            Assert.That("Harry Potter".Equals(result.ToList()[0].Title));
            Assert.That("Lord of the Rings".Equals(result.ToList()[1].Title));
            Assert.That("The Hobbit".Equals(result.ToList()[2].Title));       
        }


        [Test]
        public async Task AllGenresAsync_EmptyRepository_ReturnsEmptyList()
        {
            // Arrange
            var mockRepository = new Mock<IRepository>();
            mockRepository.Setup(r => r.AllReadOnly<Genre>()).Returns(new List<Genre>().AsQueryable());

            var service = new BookService(mockRepository.Object);

            // Act
            var result = await service.AllGenresAsync();

            // Assert
            Assert.That(!result.Any());
        }

    }
}
