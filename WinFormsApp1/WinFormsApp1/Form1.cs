using System;
using System.Collections;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ArrayList scoreList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string score = textBox2.Text;

            if (name == "")
            {
                MessageBox.Show("이름을 입력하세요.");
                return;
            }

            bool isNumber = true;
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] < '0' || score[i] > '9')
                {
                    isNumber = false;
                    break;
                }
            }

            if (score == "" || !isNumber)
            {
                MessageBox.Show("점수를 정수로 입력하세요.");
                return;
            }

           
            scoreList.Add(name + ":" + score);

           
            listBox1.Items.Clear();
            foreach (string item in scoreList)
            {
                listBox1.Items.Add(item);
            }

            
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
