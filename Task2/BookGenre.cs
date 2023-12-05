using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BookGenre : Book
    {
        private string genre;
        public string Genre
        {
            get => genre;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    value = "";
                genre = value;
            }
        }
        public BookGenre(string title, string author, decimal price, string genre) : base(title, author, price)
        {
            Genre = genre;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Жанр: {Genre}");
        }
    }
}
