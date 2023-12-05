using PersonLib;
using StudentWithAdvisorLib;
using TeacherLib;

namespace Tests
{
    [TestClass]
    public class Task1Tests
    {
        [TestMethod]
        public void CreatePerson()
        {
            string fName = "Иван";
            string lName = "Иванов";
            int age = 20;
            var person = new Person(fName, lName, age);

            Assert.IsInstanceOfType(person, typeof(Person));
            Assert.AreEqual(fName, person.FirstName);
            Assert.AreEqual(lName, person.LastName);
            Assert.AreEqual(age, person.Age);
        }

        [TestMethod]
        public void CreateStudent()
        {
            string fName = "Иван";
            string lName = "Иванов";
            int age = 20;
            var person = new StudentWithAdvisor(fName, lName, age);

            Assert.IsInstanceOfType(person, typeof(StudentWithAdvisor));
            Assert.AreEqual(fName, person.FirstName);
            Assert.AreEqual(lName, person.LastName);
            Assert.AreEqual(age, person.Age);
        }

        [TestMethod]
        public void CreateTeacher()
        {
            string fName = "Иван";
            string lName = "Иванов";
            int age = 20;
            var person = new Teacher(fName, lName, age);

            Assert.IsInstanceOfType(person, typeof(Teacher));
            Assert.AreEqual(fName, person.FirstName);
            Assert.AreEqual(lName, person.LastName);
            Assert.AreEqual(age, person.Age);
        }

        [TestMethod]
        public void IsDifferentTypeEqual()
        {
            Guid id = Guid.NewGuid();
            string fName = "Иван";
            string lName = "Иванов";
            int age = 20;
            Person person1 = new Teacher(id, fName, lName, age);
            Person person2 = new Person(id, fName, lName, age);
            Person person3 = new StudentWithAdvisor(id, fName, lName, age);

            Assert.IsFalse(person1.Equals(person2));
            Assert.IsFalse(person2.Equals(person3));
            Assert.IsFalse(person1.Equals(person3));
        }

        [TestMethod]
        public void IsSamePersonsEqual()
        {
            Guid id = Guid.NewGuid();
            string fName = "Иван";
            string lName = "Иванов";
            int age = 20;

            var student1 = new StudentWithAdvisor(id, fName, lName, age);
            var student2 = new StudentWithAdvisor(id, fName, lName, age);

            Assert.IsTrue(student1.Equals(student2));

            var teacher1 = new Teacher(id, fName, lName, age);
            var teacher2 = new Teacher(id, fName, lName, age);

            Assert.IsTrue(teacher1.Equals(teacher2));

            var person1 = new Person(id, fName, lName, age);
            var person2 = new Person(id, fName, lName, age);

            Assert.IsTrue(person1.Equals(person2));
        }

        [TestMethod]
        public void TestClone()
        {
            Guid id = Guid.NewGuid();
            string fName = "Иван";
            string lName = "Иванов";
            int age = 20;

            var student1 = new StudentWithAdvisor(id, fName, lName, age);
            var student2 = student1.Clone();

            Assert.IsTrue(student1.Equals(student2));

            var teacher1 = new Teacher(id, fName, lName, age);
            var teacher2 = teacher1.Clone();

            Assert.IsTrue(teacher1.Equals(teacher2));

            var person1 = new Person(id, fName, lName, age);
            var person2 = person1.Clone();

            Assert.IsTrue(person1.Equals(person2));
        }

        [TestMethod]
        public void IsDifferentPersonEqual()
        {
            var student1 = new StudentWithAdvisor("1", "1", 20);
            var student2 = new StudentWithAdvisor("2", "2", 20);

            Assert.IsFalse(student1.Equals(student2));

            var person1 = new Person("1", "1", 20);
            var person2 = new Person("2", "2", 20);

            Assert.IsFalse(person1.Equals(person2));

            var teacher1 = new Teacher("1", "1", 20);
            var teacher2 = new Teacher("2", "2", 20);

            Assert.IsFalse(teacher1.Equals(teacher2));
        }

        [TestMethod]
        public void IsTeachersWithDifferentStudentsEqual()
        {
            List<StudentWithAdvisor> students = new List<StudentWithAdvisor>()
            {
                StudentWithAdvisor.GetRandomStudent(),
                StudentWithAdvisor.GetRandomStudent()
            };

            var teacher1 = new Teacher("1", "1", 20, students);

            List<StudentWithAdvisor> students2 = new List<StudentWithAdvisor>()
            {
                StudentWithAdvisor.GetRandomStudent(),
                StudentWithAdvisor.GetRandomStudent(),
                StudentWithAdvisor.GetRandomStudent()
            };
            var teacher2 = new Teacher("1", "1", 20, students);

            Assert.IsFalse(teacher1.Equals(teacher2));
        }

        [TestMethod]
        public void IsClonedTeachersEqual()
        {
            List<StudentWithAdvisor> students = new List<StudentWithAdvisor>()
            {
                StudentWithAdvisor.GetRandomStudent(),
                StudentWithAdvisor.GetRandomStudent()
            };

            Teacher teacher1 = new Teacher("1", "1", 20, students);
            Teacher teacher2 = teacher1.Clone() as Teacher;

            Assert.IsTrue(teacher1.Equals(teacher2));
        }
    }
}