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
    public partial class ENROLLSTUDENT : Form
    {
        public ENROLLSTUDENT()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
            ENROLLSTUDENT2 enroll = new ENROLLSTUDENT2();
            enroll.Show();
            enroll.course.Text = course.Text;
            enroll.year.Text = year.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
