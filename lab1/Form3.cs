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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class Form3 : Form
    {

        private Arrays2D matrix;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a1 = int.Parse(textBox1.Text);
                int a2 = int.Parse(textBox2.Text);
                int a3 = int.Parse(textBox3.Text);

                matrix = new Arrays2D(a1, a2, a3);

                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 3;
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Columns[j].Width = 70;
                    dataGridView1.Columns[j].HeaderText = $"j={j + 1}";
                }

                for (int i = 0; i < 3; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].HeaderCell.Value = $"i={i + 1}";
                }

                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
