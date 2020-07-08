using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class Student : Person
    {
        public string FakNumber { get; set; }
        public Student(string name, string fname, string dob, int age, string egn, bool gender, string FakNumber) : base(name, fname, dob, age, egn, gender)
        {
            this.FakNumber = FakNumber;
        }
    }
}
