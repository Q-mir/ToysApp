namespace ToysApp
{
    public partial class Form1 : Form
    {
        
        Connection connection = new Connection();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Form form = new ShowForm(this);
            form.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
