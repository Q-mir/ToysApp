using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToysApp
{
    public partial class EntryForm : Form
    {
        private Form prevForm;
        public EntryForm(Form form)
        {

            InitializeComponent();
            prevForm = form;
            prevForm.Visible = false;
            FormClosed += (s, e) => prevForm.Visible = true;
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button1_Click(s, e);
                }
            };
        }
        private async void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                return;
            if (textBox1.Text.Length < 3) return;
            if (textBox2.Text.Length < 4) return;

            button1.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) button1_Click_1(s, e);

            };

            using (Connection context = new Connection())
            {
                User? client = await context.Users
                          .FirstOrDefaultAsync(row => row.Login == textBox1.Text
                                                        && row.Password == textBox2.Text);
                if (client != null)
                {
                    Form mainForm = new ShowForm(this, client);
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                return;
            if (textBox1.Text.Length < 3) return;
            if (textBox2.Text.Length < 4) return;

            button1.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) button1_Click(s, e);
            };

            using (Connection context = new Connection())
            {
                User? client = await context.Users
                                            .FirstOrDefaultAsync(row => row.Login == textBox1.Text
                                                                     && row.Password == textBox2.Text);
                if (client != null)
                {
                    ShowForm showForm = new ShowForm(this, client);
                    showForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
