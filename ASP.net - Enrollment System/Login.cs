using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ASP.net___Enrollment_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string user = username.Text;
            string pass = password.Text;
            var login = db.pro_login(user, pass);
            if (login.Any())
            {
                var result = (from s in db.login_infos where s.Username == user select s).First();
                {
                    if(result.usertype == 0)
                    {
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                        home.namelabel.Text = user;
                    }
                    else 
                    {
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                        home.enrollbutton.Visible = false;
                        home.addsectionbutton.Visible = false;
                        home.namelabel.Text = user;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            facerecognition face = new facerecognition();   
            face.Show();
            face.savebutton.Visible = false;
            face.username.Visible = false;
            face.detectbutton.Visible = true;
        }
    }
}
