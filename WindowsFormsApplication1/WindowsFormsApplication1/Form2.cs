using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Double result = 0;
        List<Double> list = new List<Double>(2);
        public Form2()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (list.Count==2) {
                result = list[0] + list[1];
                list.Clear();
                this.textBox1.Text = this.textBox1.Text + "=" + result + "\r\n";
            }
                
            

            //加法
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (list.Count==2) {
                result = list[0] - list[1];
                list.Clear();
                this.textBox1.Text = this.textBox1.Text + "=" + result + "\r\n";
            }
            
            //减法
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (list.Count==2) {
                result = list[0] * list[1];
                list.Clear();
                this.textBox1.Text = this.textBox1.Text + "=" + result + "\r\n";
            }
             //乘法
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (list.Count==2) {
                result = list[0] / list[1];
                list.Clear();
                this.textBox1.Text = this.textBox1.Text + "=" + result + "\r\n";
            }
            
            //除法
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(1); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(2); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(3); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(4); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(5); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(6); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(7); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(8); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(9); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (list.Count < 2) { list.Add(0); }
        }
    }
}
