using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Sum(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text)).ToString());
        }

        public int Sum(int a, int b)
        {
            return a = b;
        }

     
    }
}
