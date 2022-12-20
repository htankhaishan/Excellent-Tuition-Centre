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
    }
}