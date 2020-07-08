using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        public form1()
        {
            InitializeComponent();
        }

        private void Studentadd_Click(object sender, EventArgs e)
        {
            Student student = null;

            try
            {
                string name = Studentname.Text;
                string fname = Studentfam.Text;
                string dob = Studentday.Text + "/" + Studentmonth.Text + "/" + Studentyear.Text;
                int age = int.Parse(Studentage.Text);
                string egn = Studentegn.Text;
                string FakNumber = Studentfacnumber.Text;
                bool gender;
                if (Studentgender.Text == "Male")
                {
                    gender = true;
                }
                else
                {
                    gender = false;
                }

                student = new Student(name, fname, dob, age, egn, gender, FakNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid info");
            }
            if (student != null)
            {
                students.Add(student);
                ClearTexboxesStudent();
                PopulateStudent();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void ClearTexboxesStudent()
        {
            Studentname.Text = "";
            Studentfam.Text = "";
            Studentday.Text = "";
            Studentmonth.Text = "";
            Studentyear.Text = "";
            Studentage.Text = "";
            Studentegn.Text = "";
            Studentfacnumber.Text = "";
        }
        private void ClearTexboxesTeacher()
        {
            Teachername.Text = "";
            Teacherfam.Text = "";
            Teacherday.Text = "";
            Teachermonth.Text = "";
            Teacheryear.Text = "";
            Teacherage.Text = "";
            Teacheregn.Text = "";
            Teachersub.Text = "";
        }

        private void Teacheradd_Click(object sender, EventArgs e)
        {
            Teacher teacher = null;

            try
            {
                string name = Teachername.Text;
                string fname = Teacherfam.Text;
                string dob = Teacherday.Text + "/" + Teachermonth.Text + "/" + Teacheryear.Text;
                int age = int.Parse(Teacherage.Text);
                string egn = Teacheregn.Text;
                string subject = Teachersub.Text;
                bool gender;
                if (Studentgender.Text == "Male")
                {
                    gender = true;
                }
                else
                {
                    gender = false;
                }

                teacher = new Teacher(name, fname, dob, age, egn, gender, subject);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid info");
            }
            if (teacher != null)
            {
                teachers.Add(teacher);
                ClearTexboxesTeacher();
                PopulateTeacher();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        public void PopulateStudent()
        {
            Studenttab.Rows.Clear();
         
            for (int i = 0; i < students.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)Studenttab.Rows[0].Clone();
                row.Cells[0].Value = students[i].Name;
                row.Cells[1].Value = students[i].FName;
                row.Cells[2].Value = students[i].DoB;
                row.Cells[3].Value = students[i].Age;
                row.Cells[4].Value = students[i].Egn;
                if (students[i].Gender == false)
                {
                    row.Cells[5].Value = "Female";
                }
                else
                {
                    row.Cells[5].Value = "Male";
                }
                row.Cells[6].Value = students[i].FakNumber;
                Studenttab.Rows.Add(row);
            }
        }
        public void PopulateTeacher()
        {
            Teachertab.Rows.Clear();

            for (int i = 0; i < teachers.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)Teachertab.Rows[0].Clone();
                row.Cells[0].Value = teachers[i].Name;
                row.Cells[1].Value = teachers[i].FName;
                row.Cells[2].Value = teachers[i].DoB;
                row.Cells[3].Value = teachers[i].Age;
                row.Cells[4].Value = teachers[i].Egn;
                if (teachers[i].Gender == false)
                {
                    row.Cells[5].Value = "Female";
                }
                else
                {
                    row.Cells[5].Value = "Male";
                }
                row.Cells[6].Value = teachers[i].Subject;
                Teachertab.Rows.Add(row);
            }
        }
    }
}
