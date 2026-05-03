using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string correctPassword = "1234";
        private string enteredPassword = ""; 
        public Form1()
        {
            InitializeComponent();

            label1.Text = "비밀번호 4자리를 입력하세요";

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "CLEAR";

            button1.Click += new EventHandler(button_Click);
            button2.Click += new EventHandler(button_Click);
            button3.Click += new EventHandler(button_Click);
            button4.Click += new EventHandler(button_Click);
            button5.Click += new EventHandler(button_Click);
            button6.Click += new EventHandler(button_Click);
            button7.Click += new EventHandler(button_Click);
            button8.Click += new EventHandler(button_Click);
            button9.Click += new EventHandler(button_Click);

            button10.Click += new EventHandler(buttonClear_Click);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if(enteredPassword.Length < 4)
            {
                Button button = (Button)sender;
                enteredPassword += button.Text;
                textBox1.Text = enteredPassword;
            }

            if (enteredPassword.Length == 4)
            {
                CheckPassword();
            }
        }
        
        private void CheckPassword()
        {
            if (enteredPassword == correctPassword)
            {
                MessageBox.Show("비밀번호가 맞습니다.");
                enteredPassword = "";
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("비밀번호가 틀립니다. 다시 입력해주세요.");
                enteredPassword = "";
                textBox1.Clear();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            enteredPassword = "";
            textBox1.Clear();
        }
 
    }
}
