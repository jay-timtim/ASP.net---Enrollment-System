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
    public partial class USERSETTINGS : Form
    {
        public USERSETTINGS()
        {
            InitializeComponent();
        }

        private void USERSETTINGS_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CHANGEPASS change = new CHANGEPASS();
            change.Show();
            change.username.Text = username.Text; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            facerecognition face = new facerecognition();
            face.Show();
            face.username.Text = username.Text;
            face.detectbutton.Visible = false;
        }
    }
}
