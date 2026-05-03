using System;
using System.Collections;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private ArrayList lines = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            textBox1.Multiline = true;
            textBox1.Width = 400;
            textBox1.Height = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            lines.Clear(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.Trim();

            if (text != "")
            {
                
                lines.Clear(); 
                string[] split = text.Split('\n'); 

                for (int i = 0; i < split.Length; i++)
                {
                    string line = split[i].Trim();
                    if (line != "")
                    {
                        lines.Add(line); 
                    }
                }

                string result = "";
                for (int i = 0; i < lines.Count; i++)
                {
                    result += (string)lines[i];
                    if (i < lines.Count - 1)
                        result += "\n";
                }

                Clipboard.SetText(result);
                MessageBox.Show("클립보드 복사");
            }
            else
            {
                MessageBox.Show("복사할 내용이 없습니다.");
            }
        }
    }
}
