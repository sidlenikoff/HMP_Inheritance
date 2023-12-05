using PersonLib;
using StudentLib;
using TeacherLib;

namespace StudentWithAdvisorLib
{
    public class StudentWithAdvisor : Student
    {

        static StudentWithAdvisor[] students = new StudentWithAdvisor[]
        {
            new StudentWithAdvisor("Данила", "Ильинский", 20, Teacher.GetRandomTeacher()),
            new StudentWithAdvisor("Михаил", "Кудряшов", 20, Teacher.GetRandomTeacher()),
            new StudentWithAdvisor("Кирилл", "Никитин", 21, Teacher.GetRandomTeacher()),
            new StudentWithAdvisor("Владимир", "Кузнецов", 22, Teacher.GetRandomTeacher()),
            new StudentWithAdvisor("Леон", "Мельников", 18, Teacher.GetRandomTeacher()),
            new StudentWithAdvisor("Макар", "Агафонов", 25, Teacher.GetRandomTeacher()),
            new StudentWithAdvisor("Фёдор", "Королев", 19, Teacher.GetRandomTeacher()),
            new StudentWithAdvisor("Арсений", "Климов", 18, Teacher.GetRandomTeacher()),
            new StudentWithAdvisor("Олег", "Николаев", 17, Teacher.GetRandomTeacher()),
            new StudentWithAdvisor("Артём", "Зотов", 21, Teacher.GetRandomTeacher())
        };

        public Teacher Teacher { get; set; }

        public StudentWithAdvisor(string firstName, string lastName, int age, Teacher teacher=null) : base(firstName, lastName, age)
        {
            AssignToTeacher(teacher);
        }
        public StudentWithAdvisor(Guid id, string firstName, string lastName, int age, Teacher teacher=null) 
            : base(id, firstName, lastName, age)
        {
            AssignToTeacher(teacher);
        }

        public void AssignToTeacher(Teacher teacher)
        {
            if (teacher == null)
                return;

            Teacher = teacher;
        }

        public static StudentWithAdvisor GetRandomStudent()
        {
            return students[rnd.Next(students.Length)];
        }

        public override Person Clone()
        {
  
            var result = new StudentWithAdvisor(ID, FirstName, LastName, Age);
            if (Teacher != null)
                result.AssignToTeacher(Teacher.Clone() as Teacher);
            return result;
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += "\nПреподаватель:";
            if (Teacher != null)
                result += $" {Teacher.GetFullName()}";
            else
                result += " - ";
            return result;
        }
    }
}