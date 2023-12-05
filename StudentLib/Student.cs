using PersonLib;

namespace StudentLib
{
    public abstract class Student : Person
    {
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public Student(Guid id, string firstName, string lastName, int age) : base(id, firstName, lastName, age)
        {

        }

        public override int GetHashCode()
        {
            return $"S{ID}".GetHashCode();
        }
    }
}