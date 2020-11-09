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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int i;
        int n;
        public Form1()
        {
           
            InitializeComponent();
            Random r = new Random();
            n = r.Next(100);
            Console.WriteLine(n);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }         
private void button1_Click(object sender, EventArgs e)
        {
            String str;  
                if (i > n)
                {
                str = "大了:" + i;
                MessageBox.Show(str);
                this.textBox2.Text = this.textBox2.Text + str + "\r\n";
            }
                else if (i < n)
                {
                str = "小了:" + i;
                MessageBox.Show(str);
                this.textBox2.Text = this.textBox2.Text + str + "\r\n";
              
            }
            else {  
                this.textBox1.Text = "";
                str = "对了，数字为:" + n;
                MessageBox.Show(str);
                this.textBox2.Text = this.textBox2.Text + str + "\r\n";
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String str = textBox1.Text.Trim();
            
            if (Regex.IsMatch(str,"\\d+"))
            {
                i = Convert.ToInt32(str);
                }
            else {
                i = 0;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
