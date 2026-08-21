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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }
        // double vl1, vl2, result;


  //      vl1=double.Parse(textValue1.Text);

    //    vl2 = double.Parse(textValue2.Text);

      //  result = vl1 + vl2;
       //     textResult.Text=result.ToString();
        private void button1_Click(object sender, EventArgs e)
                    
        {
            textValue1.Text += "2";
        }
        double vl1, vl2,Result;
        string operacao;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void textValue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            textValue1.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textValue1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textValue1.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textValue1.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textValue1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textValue1.Text += "7";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textValue1.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textValue1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textValue1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vl1 += double.Parse(textValue1.Text);
            operacao = "+";
            textValue1.Clear();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            vl1 += double.Parse(textValue1.Text);
            operacao = "x";
            textValue1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            vl1 += double.Parse(textValue1.Text);
            operacao = "/";
            textValue1.Clear();

        }

        private void button14_Click(object sender, EventArgs e)
        {

            textValue1.Clear();

            vl1 = 0;
            vl2 = 0;
            Result = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vl1 += double.Parse(textValue1.Text);
            operacao = "-";
            textValue1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vl2 = double.Parse(textValue1.Text);
            if (operacao == "+")
            {
                textValue1.Clear();
                Result = vl1 + vl2;
                textValue1.Text = Result.ToString();
                vl1 = 0;
            }
            else if (operacao == "-")
            {
                textValue1.Clear();
                Result = vl1 - vl2;
                textValue1.Text = Result.ToString();
                vl1 = 0;
            }
            else if (operacao == "x")
            {
                textValue1.Clear();
                Result = vl1 *vl2;
                textValue1.Text = Result.ToString();
                vl1 = 0;
            }
            else if (operacao == "/")
            {
                textValue1.Clear();
                Result = vl1 / vl2;
                textValue1.Text = Result.ToString();
                vl1 = 0;
            }
         
        }
        
        
    }
}
