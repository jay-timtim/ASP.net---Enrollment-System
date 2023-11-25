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
    public partial class STUDENTLIST : Form
    {
        public STUDENTLIST()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void STUDENTLIST_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.studentlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.searchstudent(search.Text);
        }
    }
}
