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
    public partial class AddSection : Form
    {
        public AddSection()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void addbutton_Click(object sender, EventArgs e)
        {
            string coursename = course.Text;
            string yearlvl = year.Text;
            string section = sectionname.Text;
            int maxcap = Convert.ToInt32(maxcapacity.Text);

            if (coursename == "" || yearlvl == "" || section == "" || maxcap == 0)
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else if (maxcap < 0)
            {
                MessageBox.Show("Max Capacity Cannot Be Negative");
            }
            else if (maxcap < 15)
            {
                MessageBox.Show("Max Capacity Cannot Be Less Than 15");
            }
            else if (maxcap > 50)
            {
                MessageBox.Show("Max Capacity Cannot Be More Than 50");
            }
            else
            {
                var checkname = db.checksectionname(coursename,yearlvl,section);
            if (checkname.Any())
            {
                MessageBox.Show("Section Name Already Exist");
            }
            else
            {
                db.addnewsection(coursename, yearlvl, section, maxcap);
                MessageBox.Show("Section Added");
                this.Hide();
            }
            }


            

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
