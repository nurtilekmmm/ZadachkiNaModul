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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 editForm = new Form4();

            if (editForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            ListViewItem newItem = listView1.Items.Add(editForm.Firstname);
            newItem.SubItems.Add(editForm.Lastname);
            newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];
            Form4 editForm = new Form4();
            editForm.Firstname = item.Text;
            editForm.Lastname = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt16(item.SubItems[2].Text);
            if (editForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            item.Text = editForm.Firstname;
            item.SubItems[1].Text = editForm.Lastname;
            item.SubItems[2].Text = editForm.Age.ToString();
        }

    }
}
