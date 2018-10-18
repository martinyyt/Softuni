using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTypes
{
    class Student : Human, System.IComparable
    {
        private double mark = 2.0;
        public double Mark { get => mark; set => mark = value; }
        public Student(double mark, string firstName, string thirdName) : base(firstName, thirdName)
        {
            this.Mark = mark;
        }
        public override string ToString()
        {
            return string.Format($"{FirstName} {ThirdName}\nMark: {Mark}");
        }

        public int CompareTo(object obj)
        {
            Student student = (Student)obj;
            return Mark.CompareTo(student.Mark);
        }
    }
}
