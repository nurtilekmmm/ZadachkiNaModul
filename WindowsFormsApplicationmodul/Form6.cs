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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public class Gruzovoi
        {

            public int p = 0;
            public Gruzovoi(int p)
            {

                this.p = p;
            }

            public int Getp()
            {
                return p;
            }
        }
        public class Legkovoi
        {
            public int v = 0;
            public Legkovoi(int v)
            {
                this.v = v;
            }
            public int Getv()
            {
                return v;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R = Convert.ToDouble(textBox1.Text);
            string vidavto = (textBox2.Text);
            if (vidavto == "Грузовой")
            {



                int p = Convert.ToInt32(textBox3.Text);
                Gruzovoi gruzovoi = new Gruzovoi(p);
                int power = gruzovoi.Getp();
                listBox1.Items.Add(vidavto);
                listBox1.Items.Add("M: " + (Math.Sqrt(power) * R));


            }
            else
            {
                int v = Convert.ToInt32(textBox4.Text);

                Legkovoi legkovoi = new Legkovoi(v);
                int legk = legkovoi.Getv();
                listBox1.Items.Add(vidavto);
                listBox1.Items.Add("M: " + (0.005 * v * R));
            }
        }
    }
}
