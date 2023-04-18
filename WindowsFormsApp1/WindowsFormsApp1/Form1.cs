using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtBox.Text);
            int tong = 10;
            tong += int.Parse(txtBox.Text);
            Console.WriteLine(tong);
            txtBox.Text = tong.ToString();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        int checkPriority(string c)
        {
            if (c == "+" || c == "-") return 1;
            if (c == "*" || c == "/") return 2;
            return 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("8");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("5");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("9");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("6");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("2");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("1");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("4");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("0");
        }
    }
}
