namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            books.Add(new Book("Унесенные ветром", "Маргарет Митчелл", 500m));
            books.Add(new Book("Граф Монте-Кристо", "Александр Дюма", 400m));
            books.Add(new Book("А зори здесь тихие…", "Борис Васильев", 450m));

            books.Add(new BookGenre("Зеленая миля", "Стивен Кинг", 600m, "Фантастика"));
            books.Add(new BookGenre("451 градус по Фаренгейту", "Рэй Брэдбери", 359m, "Антиутопия"));

            books.Add(new BookGenrePubl("1984", "Джордж Оруэлл", 349m, "Антиутопия", "Эксмо"));

            foreach (var book in books)
            {
                book.Print();
                Console.WriteLine();
            }
        }
    }
}