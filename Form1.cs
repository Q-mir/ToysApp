namespace ToysApp
{
    public partial class Form1 : Form
    {

        Connection connection = new Connection();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            Form form = new EntryForm(this);
            form.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //registration
        {

        }

        private void button1_Click(object sender, EventArgs e)  //entry
        {
            Form form = new EntryForm(this);
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm(this);
            form.ShowDialog();
        }
    }
}
