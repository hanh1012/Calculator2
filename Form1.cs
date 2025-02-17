using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, tong;
            a = int.Parse(txta.Text);
            b = int.Parse(txtb.Text);
            tong = a + b;
            txtkq.Text = tong.ToString();
        }

        private void bttru_Click(object sender, EventArgs e)
        {
            int a, b, tong;
            a = int.Parse(txta.Text);
            b = int.Parse(txtb.Text);
            tong = a - b;
            txtkq.Text = tong.ToString();
        }
    }
}
