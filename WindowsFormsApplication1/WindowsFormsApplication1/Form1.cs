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
        Random r = new Random();
        int n;
        public Form1()
        {
           
            InitializeComponent();
            n= r.Next(100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        
        }

      
            
           
private void button1_Click(object sender, EventArgs e)
        {
            
                
                if (i > n)
                {
                    MessageBox.Show("大了");
                }
                else if (i < n)
                {
                    MessageBox.Show("小了");
            }else {
                MessageBox.Show("对了，数字为:" + n);
                this.textBox1.Text = "";
                this.listBox1.SelectedValue = "" + n;
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
    }
}
