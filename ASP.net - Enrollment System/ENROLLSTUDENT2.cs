using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASP.net___Enrollment_System
{
    public partial class ENROLLSTUDENT2 : Form
    {
        public ENROLLSTUDENT2()
        {
            InitializeComponent();
        }
            
        
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void enrollbutton_Click(object sender, EventArgs e)
        {
            
            if (Fname.Text == "")
            {
                MessageBox.Show("Please enter your First Name");
            }
            else if (Lname.Text == "")
            {
                MessageBox.Show("Please enter your Last Name");
            }
            else if (Mname.Text == "")
            {
                MessageBox.Show("Please enter your Middle Name");
            }
            
            else if (LRN.Text == "")
            {

                MessageBox.Show("Please enter your LRN");
            }
            else if (Address.Text == "")
            {
                MessageBox.Show("Please enter your Address");
            }
            else if (Pnum.Text == "")
            {
                MessageBox.Show("Please enter your Phone Number");
            }
            else if (Pnum.Text.Length < 11)
            {
                MessageBox.Show("Please enter a valid Phone Number");
            }
             else if (Email.Text == "")
            {
                MessageBox.Show("Please enter your Email");
            }
            else if (!Email.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid Email");
            }
            else if (course.Text == "")
            {
                MessageBox.Show("Please enter your Course");
            }
            else if (year.Text == "")
            {
                MessageBox.Show("Please enter your Year");
            }
            else if(male.Checked == false && fem.Checked == false)
                {
                    MessageBox.Show("Please Select a Gender");
                }
            
            else if (Bday.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Please enter a valid Birthday");
            }

            else
            {
                string gender = "";
                if(male.Checked == true)
                {
                    gender = "MALE";
                }
                else { gender = "FEMALE"; }

                
                string fname = Fname.Text;
                string lname = Lname.Text;
                string mname = Mname.Text;
                string sname = Sname.Text;
                DateTime bday = Bday.Value.Date;
                long lrn = Convert.ToInt64(LRN.Text);
                string address = Address.Text;
                long pnum = Convert.ToInt64(Pnum.Text);
                string email = Email.Text;
                string course = this.course.Text;
                string year = this.year.Text;
                var check = db.check_section(course, year);

                if (check.Any())
                {
                db.enroll_student(fname, lname, mname, sname,gender, bday, lrn, address, pnum, email, course, year );
                db.add_capacity(course, year);
                                MessageBox.Show("Enrolled Successfully");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No Available Section for this course and year");
                }
                
            }









        }

        private void courselabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
       
        private void Pnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }
        
        private void LRN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            fem.Checked = false;
           
        }

        private void fem_CheckedChanged(object sender, EventArgs e)
        {
            male.Checked = false;
            
        }

        private void Pnum_TextChanged(object sender, EventArgs e)
        {
            if (Pnum.Text.Length > 11)
            {
                MessageBox.Show("Please enter a valid Phone Number");
                Pnum.Text = Pnum.Text.Remove(Pnum.Text.Length - 1);
            }
        }

        private void ENROLLSTUDENT2_Load(object sender, EventArgs e)
        {

        }
    }
}
