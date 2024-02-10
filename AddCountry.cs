using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToysApp
{
    public partial class AddCountry : Form
    {
        private Form _after;
        public string countryNew { get; set; }
        public AddCountry(Form form)
        {
            InitializeComponent();
            countryNew = string.Empty;
            _after = form;
            _after.Visible = false;
            FormClosed += (s, e) => _after.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.BackColor = Color.Red;
                return;
            }
            countryNew = textBox1.Text;
            Close();
        }
    }
}
