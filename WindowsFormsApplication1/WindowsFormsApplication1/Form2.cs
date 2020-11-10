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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Double result = 0;
        List<Double> list = new List<Double>(2);
        String str = "";
        String Flag = "";
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
            
            if (str.Length > 0&&list.Count==0) {
                list.Add(Convert.ToDouble(str));
                Flag = "plus";
                str = "";
            }     
           

            //加法
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            if (str.Length > 0&&list.Count==0)
            {
                list.Add(Convert.ToDouble(str));
                Flag = "cut";
                str = "";
            }
            //减法
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            if (str.Length > 0&&list.Count==0)
            {
                list.Add(Convert.ToDouble(str));
                Flag = "multi";
                str = "";
            }
            //乘法
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (str.Length > 0&&list.Count==0)
            {
                list.Add(Convert.ToDouble(str));
                Flag = "minus";
                str = "";
            }
            //除法
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = str + 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str = str + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str = str + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            str = str + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str = str + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            str = str + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            str = str + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            str = str + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            str = str + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            str = str + 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(result); ;
            //保存运算结果
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result = 0;//清空运算结果
            this.textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (str.Length>0&&str.Split('.').Length==1) {
                str = str + ".";
            } //小数点
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (list.Count ==1&& str.Length > 0) {
                list.Add(Convert.ToDouble(str));
                str = "";
            }
            //运算
            if (list.Count==2&&Flag=="plus") {
                  result = list[0] + list[1];
                 
            }
          if (list.Count==2&&Flag=="cut") {
                 result = list[0] - list[1];
                 
                
            }
          if (list.Count==2&&Flag=="multi") {
                   result = list[0] * list[1];   
            }
            if (list.Count==2&&Flag=="minus") {
                  result = list[0] / list[1]; 
            }

                list.Clear();
                this.textBox1.Text = this.textBox1.Text + "=" + result + "\r\n";
            
        }
        
    }
}
