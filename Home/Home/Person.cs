using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class Person
    {
        public string Name { get; set; }
        public string FName { get; set; }
        public string DoB { get; set; }//Dob=date of birth
        public int Age { get; set; }
        public string Egn { get; set; }
        public bool Gender { get; set; }// false - female true -male
        public Person(string name, string fname, string dob, int age, string egn, bool gender)
        {
            Name = name;
            FName = fname;
            DoB = dob;
            Age = age;
            Egn = egn;
            Gender = gender;
        }
    }
}
