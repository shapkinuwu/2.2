using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая__3_разработка_кода
{
    public partial class Form1 : Form
    {
        public Dictionary<int, int> nums = new Dictionary<int, int>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nums.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }


        private async void btnAdd_Click_1(object sender, EventArgs e)
        {
            string keyy = textBox1.Text;
            
            string valuee = textBox2.Text;


            if (!string.IsNullOrEmpty(keyy) && !string.IsNullOrEmpty(valuee))
            {

                int key = Int32.Parse(keyy);
                int value = Int32.Parse(valuee);
                textBox1.Text = keyy;
                textBox2.Text = valuee;
                nums.Add(key, value);
                MessageBox.Show("Элемент успешно добавлен в словарь.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(textBox2, "Строка пустая");
                await Task.Delay(2000);
                errorProvider1.SetError(textBox2, "");

                errorProvider2 = new ErrorProvider();
                errorProvider2.SetError(textBox1, "Строка пустая");
                await Task.Delay(2000);
                errorProvider2.SetError(textBox1, "");

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
        }
    }
}

