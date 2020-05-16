using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLib;

    
namespace Math_Calculator
{
    public partial class Form1 : Form
    {

        Double firstValue = 0;
        Double secondValue = 0;
        Double result = 0;
        AddSubstract addsub = new AddSubstract();
        MultiplyDivide multdiv = new MultiplyDivide();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFirstvalue.Text = "0";
            txtSecondvalue.Text = "0";
            txtResult.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(txtFirstvalue.Text);
            secondValue = Convert.ToDouble(txtSecondvalue.Text);
            // result = (firstValue + secondValue);
            result = addsub.Add(firstValue, secondValue);
            txtResult.Text = result.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(txtFirstvalue.Text);
            secondValue = Convert.ToDouble(txtSecondvalue.Text);
           // result = (firstValue - secondValue);
            result = addsub.Subtract(firstValue, secondValue);
            txtResult.Text = result.ToString();

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(txtFirstvalue.Text);
            secondValue = Convert.ToDouble(txtSecondvalue.Text);
            //result = (firstValue * secondValue);
            result = multdiv.Multiply(firstValue, secondValue);
            txtResult.Text = result.ToString();

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(txtFirstvalue.Text);
            secondValue = Convert.ToDouble(txtSecondvalue.Text);
           // result = (firstValue / secondValue);
            result = multdiv.Divide(firstValue, secondValue);
            txtResult.Text = result.ToString();
        }

        private void btnClearall_Click(object sender, EventArgs e)
        {
            txtFirstvalue.Text = "0";
            txtSecondvalue.Text = "0";
            txtResult.Text = "0";
        }
    }
}
