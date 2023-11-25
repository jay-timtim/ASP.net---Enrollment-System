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
    public partial class SECTIONLIST : Form
    {
        public SECTIONLIST()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sectionsearch(course.Text,year.Text);
        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sectionsearch(course.Text, year.Text);
        }

        private void SECTIONLIST_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sectionlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sectionlist();
            course.Text = "";
            year.Text = "";
        }
    }
}
