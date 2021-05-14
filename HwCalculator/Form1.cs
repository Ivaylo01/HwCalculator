using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HwCalculator
{
    public partial class Form1 : Form
    {
        Double Result_Value = 0;
        String Operator_Performed = " ";
        bool PerformedOp = false;
        private string MemoryStore;
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // numbers button and point
            if (textBox_Result.Text == "0" || PerformedOp)
                textBox_Result.Clear();

            PerformedOp = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }

            else
                textBox_Result.Text += button.Text;
        }

        private void Operator_click_Event(object sender, EventArgs e)
        {
           
            Button button = (Button)sender;

            if (Result_Value != 0)
            {
                button16.PerformClick();
                Operator_Performed = button.Text;
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
            else
            {

                Operator_Performed = button.Text;
                Result_Value = Double.Parse(textBox_Result.Text);
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            textBox_Result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            textBox_Result.Text = "0";
            Result_Value = 0;
            label_Show_Op.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
            switch (Operator_Performed)
            {
                case "+":
                    textBox_Result.Text = (Result_Value + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (Result_Value - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (Result_Value * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (Result_Value / Double.Parse(textBox_Result.Text)).ToString();
                    break;
               

                default:
                    break;

            }
            Result_Value = Double.Parse(textBox_Result.Text);
            label_Show_Op.Text = " ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";

        }

        private void button19_Click(object sender, EventArgs e)
        {

            textBox_Result.Text = this.MemoryStore.ToString();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            MemoryStore = textBox_Result.Text;
            textBox_Result.Text = this.MemoryStore.ToString();

        }

        private void button22_Click(object sender, EventArgs e)
        {
           double result = Convert.ToDouble(MemoryStore) + Double.Parse(textBox_Result.Text);
            textBox_Result.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.MemoryStore = "0";
            
        }
    }
}
