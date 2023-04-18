using System;
using System.Collections;
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

        private int checkPriority(string c)
        {
            if (c == "+" || c == "-") return 1;
            if (c == "*" || c == "/") return 2;
            return 0;
        }
        private string handleCalculator(string eps)
        {
            eps = eps.Replace(" ", "");
            Queue<string> myQueue = new Queue<string>();
            Stack<string> myStack = new Stack<string>();

            MatchCollection matches = Regex.Matches(eps, @"([\d]+|[\+\-\*/\(\)])");

            if (!Regex.IsMatch(eps, @"([\d]+|[\+\-\*/\(\)])")) return "Invalid Input";

            foreach (Match match in matches)
            {
                if (Regex.IsMatch(match.Value, @"[\d]+")) myQueue.Enqueue(match.Value);

                if (match.Value == "(") myStack.Push(match.Value);

                if (match.Value == ")")
                {
                    while (myStack.Peek() != "(") {
                        myQueue.Enqueue(myStack.Pop());
                    }
                    myStack.Pop(); //bỏ luôn cả dấu "("
                }

                if (Regex.IsMatch(match.Value, @"[\+\-\*/]"))  // nếu là toán tử
                {
                    if (myStack.Count == 0) myStack.Push(match.Value);
                    else
                    {
                        if (!Regex.IsMatch(myStack.Peek(), @"[\+\-\*/]")) myStack.Push(match.Value);
                        else
                        {
                            if (checkPriority(match.Value) - checkPriority(myStack.Peek()) > 0) myStack.Push(match.Value);
                            else
                            {
                                while (myStack.Count > 0)
                                {
                                    if (!Regex.IsMatch(myStack.Peek(), @"[\+\-\*/]")) break;
                                    myQueue.Enqueue(myStack.Pop());
                                }
                                myStack.Push(match.Value);
                            }
                        }
                    }

                }

            }

            while (myStack.Count > 0)
            {
                myQueue.Enqueue(myStack.Pop());
            }

            foreach (var elemen in myQueue)
            {
                if (Regex.IsMatch(elemen, @"[\+\-\*/]"))
                {
                    int num1 = int.Parse(myStack.Pop());
                    int num2 = int.Parse(myStack.Pop());
                    if (elemen == "+") myStack.Push((num2 + num1).ToString());
                    if (elemen == "-") myStack.Push((num2 - num1).ToString());
                    if (elemen == "*") myStack.Push((num2 * num1).ToString());
                    if (elemen == "/") myStack.Push((num2 / num1).ToString());

                } else myStack.Push(elemen);
            }

            return myStack.Peek();

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnResult;
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

        private void btnResult_Click(object sender, EventArgs e)
        {
            string result = handleCalculator(txtBox.Text);
            if (result == "Invalid Input") txtBox.Text = result;
            else
            {
                txtBox.Text = txtBox.Text.Replace(" ", "");
                txtBox.AppendText("=" + result);
            }
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("/");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("*");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("-");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtBox.AppendText(")");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtBox.AppendText("(");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "") return;
            txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
        }


 

        private void btnResult_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void frm1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void frm1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnResult.PerformClick();
            }
        }
    }
}
