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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string Firstname
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Lastname
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public int Age
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
