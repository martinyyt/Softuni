using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTypes
{
    class PlayWithHumans
    {
        /*static void Main()
        {
            Human pesho = new Student(5, "pesho", "petrov"); //upcasting; pesho is Human, but he uses ToString() from class Student
            Worker ivan = new Worker(25, 4, "Ivan", "Dobrev");
            Student studentGosho = new Student(6, "gosho", "petkov");
            Console.WriteLine(studentGosho);
            Console.WriteLine(pesho);
            Console.WriteLine(ivan);
            Console.WriteLine("{0}\n" +
                "He earns {1} per hour",ivan,ivan.GetEarningsPerHour());
            studentGosho.CompareTo(pesho);
        }*/
        static void Main()
        {
            Student[] students = new Student[] { new Student(5, "pesho", "petrov") ,
            new Student(4.5, "ivan", "petrov"),
            new Student(5.5, "tisho", "petrov"),
            new Student(3, "misho", "petrov"),
            new Student(6, "petko", "petrov"),
            new Student(4.5, "asen", "petrov"),
            new Student(6.2, "slavi", "petrov"),
            new Student(5, "martin", "petrov")};
            students=students.OrderByDescending(x => x).ToArray(); 
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Worker[] angryWorkers = new Worker[] { new Worker(25, 4, "Ivan", "Dobrev"),
            new Worker(25, 5, "stas", "Dobrev"),
            new Worker(8, 4, "mitko", "Dobrev"),
            new Worker(23, 7, "Ivan", "peshev"),
            new Worker(85, 12, "martin", "Dobrev"),
            new Worker(48, 6, "stancho", "Dobrev"),
            new Worker(35, 3, "stavri", "Dobrev"),
            new Worker(51, 9, "Ivan", "mitkov"),
            new Worker(95, 5, "dobri", "Dobrev"),
            new Worker(12, 4, "Ivan", "petrov")};
            Array.Sort(angryWorkers);
            foreach (var worker in angryWorkers)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
