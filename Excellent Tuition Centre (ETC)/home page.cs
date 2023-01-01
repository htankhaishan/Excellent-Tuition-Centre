using Excellent_Tuition_Centre__ETC_.NewFolder;

namespace Excellent_Tuition_Centre__ETC_
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!");
            lblRice.Text = "I commited this thingy - Rice";
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
      
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            student_page obj1 = new student_page();
            this.Hide();
            obj1.ShowDialog();
        }
    }
}