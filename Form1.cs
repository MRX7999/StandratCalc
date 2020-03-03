using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Простой_калькулятор_лайт_эдишен
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {




        float a, b; // переменные для подсчетов где не требуется переменная double
        double d, c; // переменные для подсчетов там где требуется их наличие К примеру логорифм, и т.д почти все из  библиотеки match
        int cout; // переменная нужная для вывода и предварительных подсчетов моего калькулятора
        bool suka = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetroStyleManager metroStyleManager1 = null;
            this.StyleManager = metroStyleManager1;
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

   
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            cout = 1;
            label1.Text = a.ToString() + "+";
            suka = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            {
            
            }
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            cout = 4;
            label1.Text = a.ToString() + "/";
            suka = true;
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            cout = 4;
            label1.Text = a.ToString() + "*";
            suka = true;
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            cout = 4;
            label1.Text = a.ToString() + "-";
            suka = true;
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 10000;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            if (suka == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                suka = false;
            }
            else if (suka == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                suka = true;

            }
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }
        private void calculate() // Подсчет Основного функционала калькулятора, идет отдельно так как возникают конфликты при подсчете
        {
            switch (cout)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text); // сложение
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text); // вычитание
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text); // умножение
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text); // деление
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = a / 100 * float.Parse(textBox1.Text); // Возведение процентов
                    textBox1.Text = b.ToString();
                    break;


                default:
                    break;
            }

        }
    }
}
