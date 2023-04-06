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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public List<double> priceproduct = new List<double> { 40, 50, 70, 78 };

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = priceproduct[comboBox1.SelectedIndex].ToString();

        }

private void label2_Click(object sender, EventArgs e)
        {

        }
private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    private void button1_Click(object sender, EventArgs e)
{
    ListViewItem NewItem = listView1.Items.Add(comboBox1.SelectedItem.ToString());
    NewItem.SubItems.Add(textBox1.Text);
    NewItem.SubItems.Add(textBox2.Text);
    NewItem.SubItems.Add(textBox3.Text);
    double r = 0;
    foreach (ListViewItem lvi in listView1.Items)
    {
        r = Convert.ToDouble(lvi.SubItems[3].Text) + r;
    }
    textBox4.Text = (r + "som").ToString();
    Clear();
}
    void Clear()
    {
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
        label10.Text = "";
    }
private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        if (textBox2.Text != "")
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text.Replace(".", ",")));
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (textBox5.Text != "" && textBox6.Text != "")
            {
                comboBox1.Items.Add(textBox5.Text);
                priceproduct.Add(Convert.ToDouble(textBox6.Text));
                ClearTextBox();
            }
            else
            {
                Random rnd = new Random();
                label10.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                label10.Text = "Пиши цену товара и название!!!";

            }       
        }
        void ClearTextBox()
        {
            textBox5.Text = "";
            textBox6.Text = "";
            label10.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }

            if (textBox1.Text != "")
            {
                int index = 0;
                int value = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < priceproduct.ToArray().Length; i++)
                {
                    if (priceproduct[i] == value)
                    {
                        index = i;
                    }
                }
                priceproduct.RemoveAt(index);
                Clear();
            }
            else
            {
                Random rnd = new Random();
                label10.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                label10.Text = "Выберите товар для удаления ❌";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "" && textBox1.Text != "")
            {

                int value = Convert.ToInt32(textBox1.Text);
                int index = 0;
                for (int i = 0; i < priceproduct.ToArray().Length; i++)
                {
                    if (priceproduct[i] == value)
                    {
                        index = i;
                    }
                }
                double newPrice;

                newPrice = Convert.ToDouble(textBox8.Text);
                priceproduct[index] = newPrice;
                textBox1.Text = priceproduct[index].ToString();
                label12.Text = "";
                textBox8.Text = "";
            }
            else
            {
                Random rnd = new Random();
                label12.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                label12.Text = "Напишите цена товара";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    


    }
}
