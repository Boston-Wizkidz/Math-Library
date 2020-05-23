using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLib;

namespace GeometricAreaCalculator
{
    public partial class Form1 : Form
    {
        Double SqrLength = 0;
        Double RactLength = 0;
        Double RactWidth = 0;
        Double Radius = 0;
        Double Pi = 3.14;
        Double Ciresult = 0;
        Double TriangleBase = 0;
        Double TriangleHeight = 0;
        Double Tri2 = 2;
        Double Triresult = 0;
        Double result = 0;
        Double Edge = 0;
        Double Cube6 = 6;
        Double Cuberesult = 0;
        Double Integer = 0;
        Double Exponent = 0;
        Double ExpoValue = 0;
        Double ExpoStart = 0;
        Double Count = 1;
        Double BaseA = 0;
        Double BaseB = 0;
        Double TrapHeight = 0;
        Double Addresult = 0;
        Double Divresult = 0;
        AddSubstract addsub = new AddSubstract();
        MultiplyDivide multdiv = new MultiplyDivide();
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

            else
                 if (cbShapeType.SelectedItem.ToString() == "Cube")
            {
                txtCubeEdge.Text = "0";
                txtResult.Text = "0";
                lblCubeEdge.Visible = true;
                txtCubeEdge.Visible = true;
                btnAreaofCube.Visible = true;
            }

            else
                if (cbShapeType.SelectedItem.ToString() == "Exponents")
            {
                txtResult.Text = "0";
                txtInteger.Text = "0";
                txtExponent.Text = "0";
                btnAnswer.Visible = true;
                lblInteger.Visible = true;
                txtInteger.Visible = true;
                txtExponent.Visible = true;
                lblExponent.Visible = true;


            }

            else
                 if (cbShapeType.SelectedItem.ToString() == "Trapezoid")
            {
                txtBaseA.Text = "0";
                txtBaseB.Text = "0";
                txtResult.Text = "0";
                txtTrapHeight.Text = "0";
                txtBaseA.Visible = true;
                txtBaseB.Visible = true;
                txtTrapHeight.Visible = true;
                lblBaseA.Visible = true;
                lblBaseB.Visible = true;
                lblTrapHeight.Visible = true;
                btnAreaofTrapezoid.Visible = true;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Radius = Convert.ToDouble(txtRadius.Text);
            //result = (Radius * Radius * Pi);
            result = multdiv.Multiply(Radius, Radius);
            Ciresult = multdiv.Multiply(Radius, Radius);
            result = multdiv.Multiply(Ciresult, Pi);
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
            //result = (RactLength * RactWidth);
            result = multdiv.Multiply(RactLength, RactWidth);
            txtResult.Text = result.ToString();
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void btnAreaofSquare_Click(object sender, EventArgs e)
        {
            SqrLength = Convert.ToDouble(txtSqrLength.Text);
            //result = (SqrLength * SqrLength);
            txtResult.Text = result.ToString();
            result = multdiv.Multiply(SqrLength, SqrLength);
        }

        private void btnAreaofTriangle_Click(object sender, EventArgs e)
        {
            TriangleBase = Convert.ToDouble(txtTriangleBase.Text);
            TriangleHeight = Convert.ToDouble(txtTriangleHeight.Text);
            //result = (TriangleBase / Tri2 * TriangleHeight);
            result = multdiv.Divide(TriangleBase, Tri2);
            Triresult = multdiv.Divide(TriangleBase, Tri2);
            result = multdiv.Multiply(Triresult, TriangleHeight);
            txtResult.Text = result.ToString();
        }

        private void btnAreaofCube_Click(object sender, EventArgs e)
        {
            Edge = Convert.ToDouble(txtCubeEdge.Text);
            //result = (Edge * Edge * Cube6);
            result = multdiv.Multiply( Edge, Edge);
            Cuberesult = multdiv.Multiply(Edge, Edge);
            result = multdiv.Multiply(Cuberesult, Cube6);
            txtResult.Text = result.ToString();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            result = 0;
            Count = 0;
            Integer = Convert.ToDouble(txtInteger.Text);
        Exponent = Convert.ToDouble(txtExponent.Text);
                    ExpoValue = Integer;
                    while (Count < Exponent)
                    {
                        ExpoValue = ExpoValue * Integer;
                        
                        Count = Count + 1;
                    }
            result = ExpoValue;
            txtResult.Text = result.ToString();
        }

        private void btnAreaofTrapezoid_Click(object sender, EventArgs e)
        {
            BaseA = Convert.ToDouble(txtBaseA.Text);
            BaseB = Convert.ToDouble(txtBaseB.Text);
            TrapHeight = Convert.ToDouble(txtTrapHeight.Text);
            //result =(BaseA + BaseB / 2 * TrapHeight);
            result = addsub.Add(BaseA, BaseB);
            Addresult = addsub.Add(BaseA, BaseB);
            result = multdiv.Divide(Addresult, 2);
            Divresult = multdiv.Divide(Addresult, 2);
            result = multdiv.Multiply(Divresult, TrapHeight);
            txtResult.Text = result.ToString();
        }
    }
}
