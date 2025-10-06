using net.lab3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитуємо введені значення
                double a1 = Convert.ToDouble(textBox1.Text);
                double a2 = Convert.ToDouble(textBox2.Text);
                double a3 = Convert.ToDouble(textBox3.Text);

                // Створюємо об’єкт класу Calculation_abc
                Calculation_abc calc = new Calculation_abc(a1, a2, a3);

                // Виконуємо обчислення
                double result = calc.Calculate();

                // Виводимо результат у Label
                label5.Text = $"Відповідь: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть правильні числові значення!",
                                "Помилка вводу",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}",
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox4.Text);
                int b = Convert.ToInt32(textBox5.Text);

                Calculation_ab calc = new Calculation_ab(a, b);

                long result = calc.Calculate();

                label10.Text = $"Відповідь: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть правильні цілі числа!",
                                "Помилка вводу",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}",
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
