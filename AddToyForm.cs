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
    public partial class AddToyForm : Form
    {
        private Form _after;

        List<string> _countrys = new List<string>() { "Добавить новую страну...", "Russia", "China", "USA" };
        public AddToyForm(Form form)
        {
            InitializeComponent();
            _after = form;
            _after.Visible = false;
            FormClosed += (s, e) => _after.Visible = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            InitializeComboBoxCountry(comboBox1);
            comboBox1.SelectedIndexChanged += (s, e) =>
            {
                if (comboBox1.SelectedItem.ToString() == _countrys[0]) AddComboBoxItem();
            };
            button1.Enabled = false;
            textBox1.TextChanged += TextBox1_TextChanged;
            


        }

        private void AddComboBoxItem()
        {
            AddCountry addCountry = new AddCountry(this);
            addCountry.ShowDialog();
            _countrys.Insert(1, addCountry.countryNew);
            InitializeComboBoxCountry(comboBox1);
        }
        private void InitializeComboBoxCountry(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (string country in _countrys)
            {
                comboBox.Items.Add(country);
            }
        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) button1.Enabled = false;
            else button1.Enabled = true;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || numericUpDown1.Value == 0)
            {
                textBox1.BackColor = Color.Red;
                numericUpDown1.BackColor = Color.Red;
                MessageBox.Show("Заполните необходимые поля!");
                return;
            }
            using (Connection context = new Connection())
            {
                ToyObj obj = new ToyObj();
                obj.Name = textBox1.Text;
                obj.DateOfСreation = dateTimePicker1.Value.ToString();
                obj.Producter = comboBox1.Text;
                obj.Price = (int)numericUpDown1.Value;
                obj.Weight = (int)numericUpDown2.Value;
                obj.AgeLimit = (int)numericUpDown3.Value;
                obj.DateOfLastSale = dateTimePicker1.Value.ToString();
                context.Add(obj);
                context.SaveChanges();
            }

            

            MessageBox.Show("Товар добавлен!"); 
            
            Close();
        }
    }
}
