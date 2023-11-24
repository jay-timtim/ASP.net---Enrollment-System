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

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
