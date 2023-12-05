namespace PersonLib
{
    public class Person
    {
        protected static Random rnd = new Random();
        static Person[] people = new Person[]
        {
            new Person("Никита", "Кудряшов", 20),
            new Person("Максим", "Родионов", 20),
            new Person("Василий", "Бабушкин", 21),
            new Person("Лев", "Чижов", 22),
            new Person("Артём", "Шевцов", 18),
            new Person("Демид", "Смирнов", 25),
            new Person("Артём", "Селезнев", 19),
            new Person("Роман", "Данилов", 18),
            new Person("Владимир", "Абрамов", 17),
            new Person("Михаил", "Алексеев", 21)
        };

        public Guid ID { get; private set; }

        private string fName = "";
        public string FirstName 
        {
            get => fName;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    value = "";
                fName = value;
            }
        }

        private string lName = "";
        public string LastName 
        {
            get => lName;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    value = "";
                lName = value;
            }
        }

        private int age;
        public int Age 
        {
            get => age;
            private set
            {
                if (value < 0)
                    value = 0;
                age = value;
            }
        }

        public Person(string firstName, string lastName, int age) 
        {
            ID = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(Guid id, string firstName, string lastName, int age)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string GetFullName() => $"{FirstName} {LastName}";

        public virtual void Print() => Console.WriteLine(this.ToString());

        public virtual Person Clone()
        {
            return new Person(ID, FirstName, LastName, Age);
        }

        public static Person GetRandomPerson()
        {
            return people[rnd.Next(people.Length)];
        }

        public override string ToString()
        {
            return $"Имя: {FirstName} {LastName}\nВозраст: {Age}";
        }

        public override int GetHashCode()
        {
            return $"P{ID}".GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return obj != null && obj.GetType() == this.GetType()
                && obj.GetHashCode() == this.GetHashCode();
        }
    }
}