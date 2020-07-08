using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string name, string fname, string dob, int age, string egn, bool gender, string subject) : base(name, fname, dob, age, egn, gender)
        {
            Subject = subject;
        }
    }
}
