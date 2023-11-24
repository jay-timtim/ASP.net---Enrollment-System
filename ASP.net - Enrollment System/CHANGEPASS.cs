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
    public partial class CHANGEPASS : Form
    {
        public CHANGEPASS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataClasses1DataContext db = new DataClasses1DataContext();
            string user = username.Text;
            string currentpass = currentpassword.Text;
            var check = db.pro_login(user, currentpass);
            if (check.Any())
            {
                if (newpassword.Text == confirmpassword.Text)
                {
                    db.changepass(user, newpassword.Text);
                    MessageBox.Show("Password Changed");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void CHANGEPASS_Load(object sender, EventArgs e)
        {

        }
    }
}
