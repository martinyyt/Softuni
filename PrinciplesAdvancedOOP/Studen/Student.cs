using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        private string firstName = null;
        private string secondName = null;
        private string thirdName = null;
        private string course = null;
        private string speciality = null;
        private string university = null;
        private string email = null;
        private string phoneNumber = null;

        static int studentCount = 0;

        public Student()
        {
            FirstName = "unknown";
            SecondName = "unknown";
            ThirdName = "unknown";
            Course = "unknown";
            Speciality = "unknown";
            University = "unknown";
            Email = "unknown";
            PhoneNumber = "unknown";

            studentCount++;
        }
        public Student(string firstName, string secondName, string thirdName, string course, 
            string speciality, string university, string email, string phoneNumber)
        {
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            Course = course;
            Speciality = speciality;
            University = university;
            Email = email;
            PhoneNumber = phoneNumber;

            studentCount++;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string ThirdName { get => thirdName; set => thirdName = value; }
        public string AllNames
        {
            get {return string.Format("{0} {1} {2}", this.FirstName,  this.SecondName,  this.ThirdName); }
        }
        public string Course { get => course; set => course = value; }
        public string Speciality { get => speciality; set => speciality = value; }
        public string University { get => university; set => university = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        static void Main(string[] args)
        {
            Student goshko = new Student();
            goshko.Course = "aads";
            goshko.FirstName = "gos";
            goshko.SecondName = "wtf";
            goshko.ThirdName = "ade";
            goshko.PrintStudentInfo();
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Names: "+this.AllNames);
            Console.WriteLine();
            Console.WriteLine("Course: "+this.Course);
            Console.WriteLine();
            Console.WriteLine("Specialaity: "+this.Speciality);
            Console.WriteLine();
            Console.WriteLine("University: "+this.University);
            Console.WriteLine();
            Console.WriteLine("Email: "+this.Email);
            Console.WriteLine();
            Console.WriteLine("Phone number: "+this.PhoneNumber);
            Console.WriteLine();
        }
    }
}
