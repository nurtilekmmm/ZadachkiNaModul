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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Form2 child = new Form2();
            //child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 child = new Form2();
            //child.Show();
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 child = new Form2();
            //child.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 child = new Form2();
            //child.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 child = new Form2();
            //child.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form3 child = new Form3();
            child.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form5 child = new Form5();
            child.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form6 child = new Form6();
            child.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form7 child = new Form7();
            child.Show();
        }

    }
}
