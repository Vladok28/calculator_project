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
        public string d;
        public string N;
        public bool N2;
        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(N2)
            {
                N2 = false;
                textBox1.Text ="0";
            }
            Button b = (Button)sender;
            if(textBox1.Text =="0")
                textBox1.Text = b.Text;
            else
                textBox1.Text = textBox1.Text + b.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        /// Умножение,деление,сложение, вычитание
        private void button20_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            d = b.Text;
            N = textBox1.Text; // набранное число в textbox

            N2 = true;
        }

        //Кнопка равно
        private void button24_Click(object sender, EventArgs e)
        {
            //преобразовываем переменную N в double
            double DN1, DN2, result;
            result = 0;
            DN1 = Convert.ToDouble(N); 
            DN2 = Convert.ToDouble(textBox1.Text);
            if (d == "+")
            {
                result = DN1 + DN2;
            }
            if (d == "-")
            {
                result = DN1 - DN2;
            }
            if (d == "X")
            {
                result = DN1 * DN2;
            }
            if (d == "/")
            {
                result = DN1 / DN2;
            }
           

            d = "=";
            N2 = true;
            textBox1.Text = result.ToString();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        
        
        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button21_Click(object sender, EventArgs e)
        {
           
        }
        // точка
        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",")) 
            textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
        //проверка ввода на символы
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

