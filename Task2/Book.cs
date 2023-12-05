using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Book
    {
        private string title;
        public string Title 
        {
            get => title;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    value = "";
                title = value;
            }
        }

        private string author;
        public string Author 
        {
            get => author; 
            set
            {
                if (String.IsNullOrEmpty(value))
                    value = "";
                author = value;
            }
        }

        
        private decimal price;
        public decimal Price 
        {
            get => price;
            set
            {
                if (value < 0)
                    value = 0;
                price = value;
            }
        }

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Название: {Title}\nАвтор: {Author}\nЦена: {String.Format("{0:C2}", Price)}");
        }
    }
}
