namespace GeometricAreaCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblShapeType = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnAreaofCircle = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtRactLength = new System.Windows.Forms.TextBox();
            this.txtRactWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnAreaofRectangle = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtTriangleBase = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtTriangleHeight = new System.Windows.Forms.TextBox();
            this.btnAreaofTriangle = new System.Windows.Forms.Button();
            this.lblSqrLength = new System.Windows.Forms.Label();
            this.cbShapeType = new System.Windows.Forms.ComboBox();
            this.txtSqrLength = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAreaofSquare = new System.Windows.Forms.Button();
            this.lblCubeEdge = new System.Windows.Forms.Label();
            this.txtCubeEdge = new System.Windows.Forms.TextBox();
            this.btnAreaofCube = new System.Windows.Forms.Button();
            this.lblInteger = new System.Windows.Forms.Label();
            this.txtInteger = new System.Windows.Forms.TextBox();
            this.lblExponent = new System.Windows.Forms.Label();
            this.txtExponent = new System.Windows.Forms.TextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblBaseA = new System.Windows.Forms.Label();
            this.txtBaseA = new System.Windows.Forms.TextBox();
            this.lblBaseB = new System.Windows.Forms.Label();
            this.txtBaseB = new System.Windows.Forms.TextBox();
            this.btnAreaofTrapezoid = new System.Windows.Forms.Button();
            this.lblTrapHeight = new System.Windows.Forms.Label();
            this.txtTrapHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblShapeType
            // 
            this.lblShapeType.AutoSize = true;
            this.lblShapeType.Location = new System.Drawing.Point(189, 25);
            this.lblShapeType.Name = "lblShapeType";
            this.lblShapeType.Size = new System.Drawing.Size(85, 17);
            this.lblShapeType.TabIndex = 1;
            this.lblShapeType.Text = "ShapeType:";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(75, 173);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(52, 17);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius";
            this.lblRadius.Visible = false;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(165, 174);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(121, 22);
            this.txtRadius.TabIndex = 3;
            this.txtRadius.Visible = false;
            // 
            // btnAreaofCircle
            // 
            this.btnAreaofCircle.Location = new System.Drawing.Point(115, 275);
            this.btnAreaofCircle.Name = "btnAreaofCircle";
            this.btnAreaofCircle.Size = new System.Drawing.Size(159, 23);
            this.btnAreaofCircle.TabIndex = 4;
            this.btnAreaofCircle.Text = "Area of Circle";
            this.btnAreaofCircle.UseVisualStyleBackColor = true;
            this.btnAreaofCircle.Visible = false;
            this.btnAreaofCircle.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(75, 145);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(52, 17);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length";
            this.lblLength.Visible = false;
            // 
            // txtRactLength
            // 
            this.txtRactLength.Location = new System.Drawing.Point(165, 146);
            this.txtRactLength.Name = "txtRactLength";
            this.txtRactLength.Size = new System.Drawing.Size(121, 22);
            this.txtRactLength.TabIndex = 6;
            this.txtRactLength.Visible = false;
            // 
            // txtRactWidth
            // 
            this.txtRactWidth.Location = new System.Drawing.Point(165, 230);
            this.txtRactWidth.Name = "txtRactWidth";
            this.txtRactWidth.Size = new System.Drawing.Size(121, 22);
            this.txtRactWidth.TabIndex = 7;
            this.txtRactWidth.Visible = false;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(83, 229);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 17);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Width";
            this.lblWidth.Visible = false;
            // 
            // btnAreaofRectangle
            // 
            this.btnAreaofRectangle.Location = new System.Drawing.Point(115, 337);
            this.btnAreaofRectangle.Name = "btnAreaofRectangle";
            this.btnAreaofRectangle.Size = new System.Drawing.Size(159, 27);
            this.btnAreaofRectangle.TabIndex = 9;
            this.btnAreaofRectangle.Text = "Area of Rectangle";
            this.btnAreaofRectangle.UseVisualStyleBackColor = true;
            this.btnAreaofRectangle.Visible = false;
            this.btnAreaofRectangle.Click += new System.EventHandler(this.btnAreaofRectangle_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(75, 117);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(40, 17);
            this.lblBase.TabIndex = 10;
            this.lblBase.Text = "Base";
            this.lblBase.Visible = false;
            this.lblBase.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtTriangleBase
            // 
            this.txtTriangleBase.Location = new System.Drawing.Point(165, 118);
            this.txtTriangleBase.Name = "txtTriangleBase";
            this.txtTriangleBase.Size = new System.Drawing.Size(121, 22);
            this.txtTriangleBase.TabIndex = 11;
            this.txtTriangleBase.Visible = false;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(78, 201);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Height";
            this.lblHeight.Visible = false;
            // 
            // txtTriangleHeight
            // 
            this.txtTriangleHeight.Location = new System.Drawing.Point(165, 202);
            this.txtTriangleHeight.Name = "txtTriangleHeight";
            this.txtTriangleHeight.Size = new System.Drawing.Size(121, 22);
            this.txtTriangleHeight.TabIndex = 13;
            this.txtTriangleHeight.Visible = false;
            // 
            // btnAreaofTriangle
            // 
            this.btnAreaofTriangle.Location = new System.Drawing.Point(115, 304);
            this.btnAreaofTriangle.Name = "btnAreaofTriangle";
            this.btnAreaofTriangle.Size = new System.Drawing.Size(159, 27);
            this.btnAreaofTriangle.TabIndex = 14;
            this.btnAreaofTriangle.Text = "Area of Triangle";
            this.btnAreaofTriangle.UseVisualStyleBackColor = true;
            this.btnAreaofTriangle.Visible = false;
            this.btnAreaofTriangle.Click += new System.EventHandler(this.btnAreaofTriangle_Click);
            // 
            // lblSqrLength
            // 
            this.lblSqrLength.AutoSize = true;
            this.lblSqrLength.Location = new System.Drawing.Point(75, 84);
            this.lblSqrLength.Name = "lblSqrLength";
            this.lblSqrLength.Size = new System.Drawing.Size(52, 17);
            this.lblSqrLength.TabIndex = 15;
            this.lblSqrLength.Text = "Length";
            this.lblSqrLength.Visible = false;
            // 
            // cbShapeType
            // 
            this.cbShapeType.FormattingEnabled = true;
            this.cbShapeType.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Triangle",
            "Circle",
            "Trapezoid",
            "Cube",
            "Exponents"});
            this.cbShapeType.Location = new System.Drawing.Point(308, 25);
            this.cbShapeType.Name = "cbShapeType";
            this.cbShapeType.Size = new System.Drawing.Size(121, 24);
            this.cbShapeType.TabIndex = 0;
            this.cbShapeType.SelectedIndexChanged += new System.EventHandler(this.cbShapeType_SelectedIndexChanged);
            // 
            // txtSqrLength
            // 
            this.txtSqrLength.Location = new System.Drawing.Point(165, 84);
            this.txtSqrLength.Name = "txtSqrLength";
            this.txtSqrLength.Size = new System.Drawing.Size(121, 22);
            this.txtSqrLength.TabIndex = 16;
            this.txtSqrLength.Visible = false;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(196, 400);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 17;
            this.Result.Text = "Result";
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(308, 395);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 18;
            // 
            // btnAreaofSquare
            // 
            this.btnAreaofSquare.Location = new System.Drawing.Point(115, 370);
            this.btnAreaofSquare.Name = "btnAreaofSquare";
            this.btnAreaofSquare.Size = new System.Drawing.Size(159, 29);
            this.btnAreaofSquare.TabIndex = 19;
            this.btnAreaofSquare.Text = "Area Of Square";
            this.btnAreaofSquare.UseVisualStyleBackColor = true;
            this.btnAreaofSquare.Visible = false;
            this.btnAreaofSquare.Click += new System.EventHandler(this.btnAreaofSquare_Click);
            // 
            // lblCubeEdge
            // 
            this.lblCubeEdge.AutoSize = true;
            this.lblCubeEdge.Location = new System.Drawing.Point(443, 84);
            this.lblCubeEdge.Name = "lblCubeEdge";
            this.lblCubeEdge.Size = new System.Drawing.Size(41, 17);
            this.lblCubeEdge.TabIndex = 20;
            this.lblCubeEdge.Text = "Edge";
            this.lblCubeEdge.Visible = false;
            // 
            // txtCubeEdge
            // 
            this.txtCubeEdge.Location = new System.Drawing.Point(530, 78);
            this.txtCubeEdge.Name = "txtCubeEdge";
            this.txtCubeEdge.Size = new System.Drawing.Size(100, 22);
            this.txtCubeEdge.TabIndex = 21;
            this.txtCubeEdge.Visible = false;
            // 
            // btnAreaofCube
            // 
            this.btnAreaofCube.Location = new System.Drawing.Point(456, 275);
            this.btnAreaofCube.Name = "btnAreaofCube";
            this.btnAreaofCube.Size = new System.Drawing.Size(133, 30);
            this.btnAreaofCube.TabIndex = 22;
            this.btnAreaofCube.Text = "Area of Cube";
            this.btnAreaofCube.UseVisualStyleBackColor = true;
            this.btnAreaofCube.Visible = false;
            this.btnAreaofCube.Click += new System.EventHandler(this.btnAreaofCube_Click);
            // 
            // lblInteger
            // 
            this.lblInteger.AutoSize = true;
            this.lblInteger.Location = new System.Drawing.Point(443, 115);
            this.lblInteger.Name = "lblInteger";
            this.lblInteger.Size = new System.Drawing.Size(52, 17);
            this.lblInteger.TabIndex = 23;
            this.lblInteger.Text = "Integer";
            this.lblInteger.Visible = false;
            // 
            // txtInteger
            // 
            this.txtInteger.Location = new System.Drawing.Point(530, 112);
            this.txtInteger.Name = "txtInteger";
            this.txtInteger.Size = new System.Drawing.Size(100, 22);
            this.txtInteger.TabIndex = 24;
            this.txtInteger.Visible = false;
            // 
            // lblExponent
            // 
            this.lblExponent.AutoSize = true;
            this.lblExponent.Location = new System.Drawing.Point(443, 149);
            this.lblExponent.Name = "lblExponent";
            this.lblExponent.Size = new System.Drawing.Size(67, 17);
            this.lblExponent.TabIndex = 25;
            this.lblExponent.Text = "Exponent";
            this.lblExponent.Visible = false;
            // 
            // txtExponent
            // 
            this.txtExponent.Location = new System.Drawing.Point(530, 146);
            this.txtExponent.Name = "txtExponent";
            this.txtExponent.Size = new System.Drawing.Size(100, 22);
            this.txtExponent.TabIndex = 26;
            this.txtExponent.Visible = false;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(456, 312);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(133, 23);
            this.btnAnswer.TabIndex = 27;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Visible = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblBaseA
            // 
            this.lblBaseA.AutoSize = true;
            this.lblBaseA.Location = new System.Drawing.Point(446, 178);
            this.lblBaseA.Name = "lblBaseA";
            this.lblBaseA.Size = new System.Drawing.Size(79, 17);
            this.lblBaseA.TabIndex = 28;
            this.lblBaseA.Text = "BaseUpper";
            this.lblBaseA.Visible = false;
            // 
            // txtBaseA
            // 
            this.txtBaseA.Location = new System.Drawing.Point(530, 178);
            this.txtBaseA.Name = "txtBaseA";
            this.txtBaseA.Size = new System.Drawing.Size(100, 22);
            this.txtBaseA.TabIndex = 29;
            this.txtBaseA.Visible = false;
            // 
            // lblBaseB
            // 
            this.lblBaseB.AutoSize = true;
            this.lblBaseB.Location = new System.Drawing.Point(446, 212);
            this.lblBaseB.Name = "lblBaseB";
            this.lblBaseB.Size = new System.Drawing.Size(78, 17);
            this.lblBaseB.TabIndex = 30;
            this.lblBaseB.Text = "BaseLower";
            this.lblBaseB.Visible = false;
            // 
            // txtBaseB
            // 
            this.txtBaseB.Location = new System.Drawing.Point(530, 207);
            this.txtBaseB.Name = "txtBaseB";
            this.txtBaseB.Size = new System.Drawing.Size(100, 22);
            this.txtBaseB.TabIndex = 31;
            this.txtBaseB.Visible = false;
            // 
            // btnAreaofTrapezoid
            // 
            this.btnAreaofTrapezoid.Location = new System.Drawing.Point(456, 342);
            this.btnAreaofTrapezoid.Name = "btnAreaofTrapezoid";
            this.btnAreaofTrapezoid.Size = new System.Drawing.Size(133, 29);
            this.btnAreaofTrapezoid.TabIndex = 32;
            this.btnAreaofTrapezoid.Text = "Area of Trapezoid";
            this.btnAreaofTrapezoid.UseVisualStyleBackColor = true;
            this.btnAreaofTrapezoid.Visible = false;
            this.btnAreaofTrapezoid.Click += new System.EventHandler(this.btnAreaofTrapezoid_Click);
            // 
            // lblTrapHeight
            // 
            this.lblTrapHeight.AutoSize = true;
            this.lblTrapHeight.Location = new System.Drawing.Point(449, 252);
            this.lblTrapHeight.Name = "lblTrapHeight";
            this.lblTrapHeight.Size = new System.Drawing.Size(49, 17);
            this.lblTrapHeight.TabIndex = 33;
            this.lblTrapHeight.Text = "Height";
            this.lblTrapHeight.Visible = false;
            // 
            // txtTrapHeight
            // 
            this.txtTrapHeight.Location = new System.Drawing.Point(530, 252);
            this.txtTrapHeight.Name = "txtTrapHeight";
            this.txtTrapHeight.Size = new System.Drawing.Size(100, 22);
            this.txtTrapHeight.TabIndex = 34;
            this.txtTrapHeight.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTrapHeight);
            this.Controls.Add(this.lblTrapHeight);
            this.Controls.Add(this.btnAreaofTrapezoid);
            this.Controls.Add(this.txtBaseB);
            this.Controls.Add(this.lblBaseB);
            this.Controls.Add(this.txtBaseA);
            this.Controls.Add(this.lblBaseA);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.txtExponent);
            this.Controls.Add(this.lblExponent);
            this.Controls.Add(this.txtInteger);
            this.Controls.Add(this.lblInteger);
            this.Controls.Add(this.btnAreaofCube);
            this.Controls.Add(this.txtCubeEdge);
            this.Controls.Add(this.lblCubeEdge);
            this.Controls.Add(this.btnAreaofSquare);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.txtSqrLength);
            this.Controls.Add(this.lblSqrLength);
            this.Controls.Add(this.btnAreaofTriangle);
            this.Controls.Add(this.txtTriangleHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtTriangleBase);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnAreaofRectangle);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtRactWidth);
            this.Controls.Add(this.txtRactLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnAreaofCircle);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblShapeType);
            this.Controls.Add(this.cbShapeType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblShapeType;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnAreaofCircle;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtRactLength;
        private System.Windows.Forms.TextBox txtRactWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnAreaofRectangle;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtTriangleBase;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtTriangleHeight;
        private System.Windows.Forms.Button btnAreaofTriangle;
        private System.Windows.Forms.Label lblSqrLength;
        private System.Windows.Forms.ComboBox cbShapeType;
        private System.Windows.Forms.TextBox txtSqrLength;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAreaofSquare;
        private System.Windows.Forms.Label lblCubeEdge;
        private System.Windows.Forms.TextBox txtCubeEdge;
        private System.Windows.Forms.Button btnAreaofCube;
        private System.Windows.Forms.Label lblInteger;
        private System.Windows.Forms.TextBox txtInteger;
        private System.Windows.Forms.Label lblExponent;
        private System.Windows.Forms.TextBox txtExponent;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblBaseA;
        private System.Windows.Forms.TextBox txtBaseA;
        private System.Windows.Forms.Label lblBaseB;
        private System.Windows.Forms.TextBox txtBaseB;
        private System.Windows.Forms.Button btnAreaofTrapezoid;
        private System.Windows.Forms.Label lblTrapHeight;
        private System.Windows.Forms.TextBox txtTrapHeight;
    }
}

