using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            textBox1.Text += "!!!Введите значение x!!!";
            textBox2.Text += "!!!Введите значение b!!!";
            textBox3.Text += "Тут пока ничего нет";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            int i=0;
            double x = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double f = 0;
            double g = 0;
            if (radioButton1.Checked)
                {
                    f = Math.Sinh(x);
                    richTextBox1.Text = "Выброная функция sinh(x)" + Environment.NewLine;
                }
            if (radioButton2.Checked)
                {
                    f = Math.Pow(x, 2);
                    richTextBox1.Text = "Выброная функция x²" + Environment.NewLine;
                }
            if (radioButton3.Checked)
                {
                    f = Math.Exp(x);
                    richTextBox1.Text = "Выброная функция Exp(x)" + Environment.NewLine;
                }
            if (x * b < 10 && x * b > 0.5)
                {
                    g = Math.Exp(f - Math.Abs(b));
                    i = 1;
                }
            else if (x * b < 0.5 && x * b > 0.1)
                {
                    g = Math.Sqrt(Math.Abs(f + b));
                    i = 2;
                }
            else
                {
                    g = 2 * Math.Pow(f, 2);
                    i = 3;
                }
            richTextBox1.Text += Environment.NewLine + "Результат:" + Environment.NewLine;
            richTextBox1.Text += "x=" + x.ToString()+Environment.NewLine;
            richTextBox1.Text += "b=" + b.ToString() + Environment.NewLine;
            richTextBox1.Text += "Вычеслено выражение №" + i.ToString() + Environment.NewLine;
            richTextBox1.Text += "______________________________________________";
            textBox3.Text = g.ToString();
            this.textBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.Color.Gray;
        }
    }
}