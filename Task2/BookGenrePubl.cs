using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public sealed class BookGenrePubl : BookGenre
    {
        private string publisher;
        public string Publisher
        {
            get => publisher;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    value = "";
                publisher = value;
            }
        }
        public BookGenrePubl(string title, string author, decimal price, string genre, string publisher) : base(title, author, price, genre)
        {
            Publisher = publisher;
        }
    }
}
