using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentTest
    {
        private static Student mitko;
        private static Student goshko;
        private static Student toshko;

        static StudentTest()
        {
            mitko = new Student();
            goshko = new Student();
            toshko = new Student();
        }

        public static Student Mitko { get => mitko; set => mitko = value; }
        public static Student Goshko { get => goshko; set => goshko = value; }
        public static Student Toshko { get => toshko; set => toshko = value; }



        static void Main()
        {
            Mitko.PrintStudentInfo();
            Goshko.PrintStudentInfo();
            Toshko.PrintStudentInfo();

            Student[] group = new Student[10];

            for (int i = 0; i < group.Length; i++)
            {
                group[i] = new Student(i.ToString(), "xxx", "xxx", "xxx", "xxx", "xxx", "xxx", "xxx");
                group[i].PrintStudentInfo();
                
            }

            Student.PrintCountOfStudents();
        }
    }
}
