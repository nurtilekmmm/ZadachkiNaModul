using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationmodul
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Молоко", 2, 3, "Umut&Ko", 2 * 3, "12.12.2022", "15.12.2022");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
               textBox1.Text,
               textBox2.Text,
               textBox3.Text,
               textBox4.Text,
               Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text),
               textBox5.Text,
               textBox6.Text
               );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = "текущий товар " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() + " по цене " +
                   dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString() + " имеется в наличии " + dataGridView1[2,
                   dataGridView1.CurrentRow.Index].Value.ToString();
            dataGridView1.CurrentRow.Cells[3].Value = (Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value) *
                Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value));

            double sum = 0;
            for (int i = 0; i != dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1[3, i].Value = (Convert.ToDouble(dataGridView1[2, i].Value) * Convert.ToDouble(dataGridView1[1, i].Value));
                sum += Convert.ToDouble(dataGridView1[3, i].Value);
            }
            label4.Text = "Итого " + sum.ToString();
        }

    }
}
