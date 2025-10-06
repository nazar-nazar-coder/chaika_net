using Lab1.lab1;
using net;
using System.Globalization;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabul tabul = new();
            double xn, xk, h, a;
            xn = Convert.ToDouble(this.textBox1.Text, CultureInfo.InvariantCulture);
            xk = Convert.ToDouble(this.textBox2.Text, CultureInfo.InvariantCulture);
            h = Convert.ToDouble(this.textBox3.Text, CultureInfo.InvariantCulture);
            a = Convert.ToDouble(this.textBox4.Text, CultureInfo.InvariantCulture);

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul.calculate(xn, xk, h, a);

            for (int i = 0; i < tabul.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul.xy_array[i, 0], 2).ToString(),
                    Math.Round(tabul.xy_array[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabul.xy_array[i, 0], tabul.xy_array[i, 1]);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void îäíîâèì³ðí³ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void äâîâèì³ðí³ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void unitTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}
