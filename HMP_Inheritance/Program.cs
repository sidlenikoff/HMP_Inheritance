using PersonLib;
using StudentLib;
using StudentWithAdvisorLib;
using TeacherLib;

namespace HMP_Inheritance
{
    internal class Program
    {
        static Random rnd = new Random();
        static string firstNames = "Лев Егор Владислав Максим Марк Тимофей Фёдор Сергей Михаил Илья Павел Ярослав Александр Даниил Арсений Руслан Евгений Владимир Иван Билал";
        static string lastNames = "Абрамов Ковалев Давыдов Корнеев Рыбаков Соколов Морозов Шаповалов Завьялов Иванов Гуляев Беликов Комаров Сорокин Зотов Казаков Плотников Олейников Цветков Севастьянов";

        static void Main(string[] args)
        {
            

            List<StudentWithAdvisor> students = new List<StudentWithAdvisor>();
            List<Teacher> teachers = new List<Teacher>();
            GenerateStudentsAndTeachers(ref students, ref teachers);

            List<Person> people = new List<Person>();

            for (int i = 0; i < 3; i++)
                people.Add(Person.GetRandomPerson());
            people.AddRange(students);
            people.AddRange(teachers);

            for (int i = 0; i < 3; i++)
                people.Add(StudentWithAdvisor.GetRandomStudent());
            for (int i = 0; i < 3; i++)
                people.Add(Teacher.GetRandomTeacher());

            foreach (var person in people)
            {
                person.Print();
                Console.WriteLine();
            }
        }

        static void GenerateStudentsAndTeachers(ref List<StudentWithAdvisor> students, ref List<Teacher> teachers)
        {
            List<string> FirstNames = firstNames.Split(' ').ToList();
            List<string> LastNames = lastNames.Split(' ').ToList();

            for (int i = 0; i < 3; i++)
            {
                string fName = FirstNames[rnd.Next(FirstNames.Count)];
                string lName = LastNames[rnd.Next(LastNames.Count)];
                students.Add(new StudentWithAdvisor(fName, lName, rnd.Next(18, 26)));

            }

            
            for (int i = 0; i < 3; i++)
            {
                string fName = FirstNames[rnd.Next(FirstNames.Count)];
                string lName = LastNames[rnd.Next(LastNames.Count)];
                teachers.Add(new Teacher(fName, lName, rnd.Next(35, 76)));

                int index = rnd.Next(0, students.Count);
                int count = rnd.Next(1, students.Count - index);
                var studentsToAssign = students.GetRange(index, count);
                teachers[teachers.Count - 1].AssignStudents(studentsToAssign);
                foreach (var student in studentsToAssign)
                    student.AssignToTeacher(teachers[teachers.Count - 1]);
            }
        }
    }
}