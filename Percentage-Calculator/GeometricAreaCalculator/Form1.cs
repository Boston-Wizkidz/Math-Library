using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricAreaCalculator
{
    public partial class Form1 : Form
    {
        Double SqrLength = 0;
        Double RactLength = 0;
        Double RactWidth = 0;
        Double Radius = 0;
        Double Pi = 3.14;
        Double TriangleBase = 0;
        Double TriangleHeight = 0;
        Double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void cbShapeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected item is: " + cbShapeType.SelectedItem);

            if (cbShapeType.SelectedItem.ToString() == "Circle")
            {
                txtRadius.Text = "0";
                txtResult.Text = "0";
                lblRadius.Visible = true;
                txtRadius.Visible = true;
                btnAreaofCircle.Visible = true;
            }
            else
            
                if (cbShapeType.SelectedItem.ToString() == "Rectangle")
                {
                    txtRactLength.Text = "0";
                    txtRactWidth.Text = "0";
                    txtResult.Text = "0";
                    lblLength.Visible = true;
                    txtRactLength.Visible = true;
                    lblWidth.Visible = true;
                    txtRactWidth.Visible = true;
                    btnAreaofRectangle.Visible = true;
                }
                
            
            else
            
                if (cbShapeType.SelectedItem.ToString() == "Triangle")
                {
                txtTriangleBase.Text = "0";
                txtTriangleHeight.Text = "0";
                txtResult.Text = "0";
                lblBase.Visible = true;
                txtTriangleBase.Visible = true;
                lblHeight.Visible = true;
                txtTriangleHeight.Visible = true;
                btnAreaofTriangle.Visible = true;
                }
            else
                 if (cbShapeType.SelectedItem.ToString() == "Square")
            {
                txtSqrLength.Text = "0";
                txtResult.Text = "0";
                lblSqrLength.Visible = true;
                txtSqrLength.Visible = true;
                btnAreaofSquare.Visible = true;

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Radius = Convert.ToDouble(txtRadius.Text);
            result = (Radius * Radius * Pi);
            txtResult.Text = result.ToString();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            if (cbShapeType.SelectedItem.ToString() == "Rectangle")
            {

                lblLength.Visible = true;
                txtRactLength.Visible = true;
                lblWidth.Visible = true;
                txtRactWidth.Visible = true;

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAreaofRectangle_Click(object sender, EventArgs e)
        {
            RactLength = Convert.ToDouble(txtRactLength.Text);
            RactWidth = Convert.ToDouble(txtRactWidth.Text);
            result = (RactLength * RactWidth);
            txtResult.Text = result.ToString();
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void btnAreaofSquare_Click(object sender, EventArgs e)
        {
            SqrLength = Convert.ToDouble(txtSqrLength.Text);
            result = (SqrLength * SqrLength);
            txtResult.Text = result.ToString();

        }

        private void btnAreaofTriangle_Click(object sender, EventArgs e)
        {
            TriangleBase = Convert.ToDouble(txtTriangleBase.Text);
            TriangleHeight = Convert.ToDouble(txtTriangleHeight.Text);
            result = (TriangleBase / 2 * TriangleHeight);
            txtResult.Text = result.ToString();
        }

        private void btnClearall_Click(object sender, EventArgs e)
        {


            txtResult.Text = "0";

        }
    }
}
