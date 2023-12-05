using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Figure
    {
        private string name;
        public string Name 
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    value = "";
                name = value;
            }
        }

        public abstract float Area2 { get; }

        public Figure(string name)
        {
            Name = name;
        }

        protected abstract float Area();

        public virtual void Print() => Console.WriteLine(Name);
    }
}
