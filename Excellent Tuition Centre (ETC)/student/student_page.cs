using Excellent_Tuition_Centre__ETC_.student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excellent_Tuition_Centre__ETC_.NewFolder
{
    public partial class student_page : Form
    {
        public student_page()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void student_page_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {

        }

        private void cmbChangeSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChangeSubject.Text == "Request to Change the Subject")
            {
                Request_To_Change_Subject obj1 = new Request_To_Change_Subject();
                this.Hide();
                obj1.ShowDialog();
            }
        }
    }
}
