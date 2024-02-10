

using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace ToysApp
{
    public partial class ShowForm : Form
    {

        private Form _form;
        private User _user;
        private List<ToyObj> _toys;
        public ShowForm(Form form, User user)
        {
            InitializeComponent();
            _user = user;
            _form = form;
            form.Visible = false;
            button1.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            label9.Text = "Режим просмотра";
            FormClosed += (s, e) => _form.Visible = true;
            if(user.Role)
            {
                listBox1.DoubleClick += ListBox1_DoubleClick;
                button1.Enabled = true;
                label9.Text = "Чтобы удалить, нажите дважды на элемент";
            }
            
            


            AllProductAsync();

            comboBox1.Items.Add("По цене >");
            comboBox1.Items.Add("По цене <");
            comboBox1.Items.Add("По алфавиту >");
            comboBox1.Items.Add("По алфавиту <");
            comboBox1.Items.Add("По странам");
            comboBox1.SelectedIndexChanged += (s, e) =>
            {
                string message = comboBox1.Text;
                switch (message)
                {
                    case "По цене >": SortDesc(x => x.Price); break;
                    case "По цене <": SortAsc(x => x.Price); break;
                    case "По алфавиту >": SortDesc(x => x.Name); break;
                    case "По алфавиту <": SortAsc(x => x.Name); break;
                    case "По странам": SortAsc(x => x.Producter); break;
                }
            };


            listBox1.SelectedIndexChanged += (s, e) =>
            {
                int index = listBox1.SelectedIndex;

                if (index != -1)
                {
                    label1.Text = $"Id: {_toys[index].Id}";
                    label2.Text = $"Name: {_toys[index].Name}";
                    label3.Text = $"DateOfCreation: {_toys[index].DateOfСreation}";
                    label4.Text = $"Country: {_toys[index].Producter}";
                    label5.Text = $"Price: {_toys[index].Price}";
                    label6.Text = $"Weight: {_toys[index].Weight}";
                    label7.Text = $"AgeLimit: {_toys[index].AgeLimit}";
                    label8.Text = $"DateOfLastSale: {_toys[index].DateOfLastSale}";
                }

            };
        }
        
        private void SortAsc<T>(Func<ToyObj, T> funct)
        {
            _toys = _toys.OrderBy(row => row.Name).ToList();
            ShowAllProducts();
        }

        private void SortDesc<T>(Func<ToyObj, T> funct)
        {
            _toys = _toys.OrderByDescending(funct).ToList();
            ShowAllProducts();
        }
        private async void ListBox1_DoubleClick(object? sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Вы уверены?", "Удалить?", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel) return;
                int index = listBox1.SelectedIndex;
                if (index > -1)
                {
                    ToyObj del = _toys[index];
                    using (Connection context = new Connection())
                    {
                        context.Remove(del);
                        await context.SaveChangesAsync();
                        AllProductAsync();
                    }
                }
            }
        }


        public async void AllProductAsync()
        {
            using (Connection context = new Connection())
            {
                _toys = await context.Toys.ToListAsync();
            }
            ShowAllProducts();
        }



        public void ShowAllProducts()
        {
            listBox1.Items.Clear();
            foreach (ToyObj toy in _toys)
            {
                listBox1.Items.Add($"# {toy.Id} : {toy.Name}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToyForm addToyForm = new AddToyForm(this);
            addToyForm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllProductAsync();
        }
    }
}
