using PersonLib;
using StudentLib;

namespace TeacherLib
{
    public class Teacher : Person
    {

        static Teacher[] teachers = new Teacher[]
        {
            new Teacher("Юрий", "Кузьмин", 45),
            new Teacher("Никита", "Иванов", 60),
            new Teacher("Мирон", "Яковлев", 30),
            new Teacher("Александр", "Николаев", 55),
            new Teacher("Михаил", "Мухин", 56),
            new Teacher("Эмиль", "Макаров", 62),
            new Teacher("Максим", "Сергеев", 49),
            new Teacher("Захар", "Филимонов", 50),
            new Teacher("Александр", "Комаров", 61),
            new Teacher("Лев", "Филиппов", 52)
        };

        public List<Student> Students { get; private set; }
        public Teacher(string firstName, string lastName, int age, IEnumerable<Student> students = null) 
            : base(firstName, lastName, age)
        {
            AssignStudents(students);
        }

        public Teacher(Guid id, string firstName, string lastName, int age, IEnumerable<Student> students = null)
            : base(id, firstName, lastName, age)
        {
            AssignStudents(students);
        }

        public void AssignStudents(IEnumerable<Student> students)
        {
            if (students == null)
                return;

            if(Students == null)
                Students = new List<Student>();

            foreach (var student in students)
                Students.Add(student);
        }

        public static Teacher GetRandomTeacher()
        {
            var teacher = teachers[rnd.Next(teachers.Length)];

            return teacher;
        }

        public override Person Clone()
        {
            List<Student> clonedStudents = new();
            if(Students != null)
                foreach (var student in Students)
                    clonedStudents.Add(student.Clone() as Student);

            return new Teacher(ID, FirstName, LastName, Age, clonedStudents);
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += $"\nСтуденты:";
            if (Students != null)
            {
                foreach (var student in Students)
                    result += $"\n{student.GetFullName()}";
            }
            else
                result += $" - ";
            return result;
        }

        public override int GetHashCode()
        {
            return $"T{ID}".GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            var result = base.Equals(obj);
            if(result)
            {
                Teacher t2 = obj as Teacher;
                var except = Students.Except(t2.Students);
                result = except.Count() == 0;
            }

            return result;
        }
    }
}