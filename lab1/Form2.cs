using lab1.lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab1
{
    public partial class Form2 : Form
    {

        private Arrays array;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(textBox1.Text);
                array = new Arrays(size);
                label2.Text = "Згенерований масив:\r\n" + array.ToStr();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Спочатку згенеруйте масив!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool desc = array.IsDescending();
            label3.Text += "\r\n\r\n" + (desc ? "Масив впорядкований по спаданню" : "Масив не впорядкований");
        }
    }
}
