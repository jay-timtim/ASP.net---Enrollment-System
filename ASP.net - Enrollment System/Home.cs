using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASP.net___Enrollment_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            ENROLLSTUDENT enroll = new ENROLLSTUDENT();
            enroll.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           AddSection add = new AddSection();
            add.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
                    var count = db.Stud_infos.Count();
            
                   studentcount.Text = count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            STUDENTLIST list = new STUDENTLIST();
            list.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SECTIONLIST list = new SECTIONLIST();
            list.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            USERSETTINGS settings = new USERSETTINGS();
            settings.Show();
            settings.username.Text = namelabel.Text;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var result = (from s in db.login_infos where s.Username == namelabel.Text select s).First();
            settings.accname.Text = result.Fname + " " + result.Lname;
            if (result.usertype == 0)
            {
                settings.acctype.Text = "ADMIN";
            }
            else
            {
                settings.acctype.Text = "USER";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var count = db.Stud_infos.Count();

            studentcount.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
           Home home = new Home();
            home.Show();

        }
    }
}
