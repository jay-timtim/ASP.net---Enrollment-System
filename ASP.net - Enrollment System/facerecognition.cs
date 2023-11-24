using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using FaceRecognition;
namespace ASP.net___Enrollment_System
{
    public partial class facerecognition : Form
    {
        public facerecognition()
        {
            InitializeComponent();
            
        
        }
        FaceRec face = new FaceRec();
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void facerecognition_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            face.Save_IMAGE(username.Text);
            MessageBox.Show("Image Saved");
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            
        }

        

        private void facerecognition_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void username_Click(object sender, EventArgs e)
        {
           
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            
            
               
            }

        private void detectbutton_Click(object sender, EventArgs e)
        {
            face.isTrained = true;
            face.getPersonName(username);
            var login = db.loginuser(username.Text);
            if (login.Any())
            {
                MessageBox.Show("Welcome " + username.Text);
                var result = (from s in db.login_infos where s.Username == username.Text select s).First();
                {
                    if (result.usertype == 0)
                    {
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                        home.namelabel.Text = username.Text;
                    }
                    else
                    {
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                        home.enrollbutton.Visible = false;
                        home.addsectionbutton.Visible = false;
                        home.namelabel.Text = username.Text;
                    }
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            face.openCamera(pictureBox1, pictureBox2);
        }
    }
}
