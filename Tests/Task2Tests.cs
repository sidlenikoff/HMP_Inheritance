using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Tests
{
    [TestClass]
    public class Task2Tests
    {

        [TestMethod]
        public void CreateBook()
        {
            var title = "Унесенные ветром";
            var author = "Маргарет Митчелл";
            var price = 500m;
            var book = new Book(title, author, price);

            Assert.IsInstanceOfType(book, typeof(Book));
            Assert.AreEqual(title, book.Title);
            Assert.AreEqual(author, book.Author);
            Assert.AreEqual(price, book.Price);
        }

        [TestMethod]
        public void CreateBookGenre()
        {
            var title = "Унесенные ветром";
            var author = "Маргарет Митчелл";
            var genre = "Реализм";
            var price = 500m;
            var book = new BookGenre(title, author, price, genre);

            Assert.IsInstanceOfType(book, typeof(BookGenre));
            Assert.AreEqual(title, book.Title);
            Assert.AreEqual(author, book.Author);
            Assert.AreEqual(price, book.Price);
            Assert.AreEqual(genre, book.Genre);
        }

        [TestMethod]
        public void CreateBookGenrePubl()
        {
            var title = "Унесенные ветром";
            var author = "Маргарет Митчелл";
            var genre = "Реализм";
            var publ = "Эксмо-Пресс";
            var price = 500m;
            var book = new BookGenrePubl(title, author, price, genre, publ);

            Assert.IsInstanceOfType(book, typeof(BookGenrePubl));
            Assert.AreEqual(title, book.Title);
            Assert.AreEqual(author, book.Author);
            Assert.AreEqual(price, book.Price);
            Assert.AreEqual(genre, book.Genre);
            Assert.AreEqual(publ, book.Publisher);
        }
    }
}
