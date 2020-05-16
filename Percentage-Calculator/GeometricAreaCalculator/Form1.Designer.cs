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
            this.lblRadius.Location = new System.Drawing.Point(189, 168);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(52, 17);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius";
            this.lblRadius.Visible = false;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(308, 168);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(121, 22);
            this.txtRadius.TabIndex = 3;
            this.txtRadius.Visible = false;
            // 
            // btnAreaofCircle
            // 
            this.btnAreaofCircle.Location = new System.Drawing.Point(308, 265);
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
            this.lblLength.Location = new System.Drawing.Point(189, 143);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(52, 17);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length";
            this.lblLength.Visible = false;
            // 
            // txtRactLength
            // 
            this.txtRactLength.Location = new System.Drawing.Point(308, 140);
            this.txtRactLength.Name = "txtRactLength";
            this.txtRactLength.Size = new System.Drawing.Size(121, 22);
            this.txtRactLength.TabIndex = 6;
            this.txtRactLength.Visible = false;
            // 
            // txtRactWidth
            // 
            this.txtRactWidth.Location = new System.Drawing.Point(308, 224);
            this.txtRactWidth.Name = "txtRactWidth";
            this.txtRactWidth.Size = new System.Drawing.Size(121, 22);
            this.txtRactWidth.TabIndex = 7;
            this.txtRactWidth.Visible = false;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(192, 224);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 17);
            this.lblWidth.TabIndex = 8;
            this.lblWidth.Text = "Width";
            this.lblWidth.Visible = false;
            // 
            // btnAreaofRectangle
            // 
            this.btnAreaofRectangle.Location = new System.Drawing.Point(308, 327);
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
            this.lblBase.Location = new System.Drawing.Point(196, 112);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(40, 17);
            this.lblBase.TabIndex = 10;
            this.lblBase.Text = "Base";
            this.lblBase.Visible = false;
            this.lblBase.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtTriangleBase
            // 
            this.txtTriangleBase.Location = new System.Drawing.Point(308, 112);
            this.txtTriangleBase.Name = "txtTriangleBase";
            this.txtTriangleBase.Size = new System.Drawing.Size(121, 22);
            this.txtTriangleBase.TabIndex = 11;
            this.txtTriangleBase.Visible = false;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(195, 196);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Height";
            this.lblHeight.Visible = false;
            // 
            // txtTriangleHeight
            // 
            this.txtTriangleHeight.Location = new System.Drawing.Point(308, 196);
            this.txtTriangleHeight.Name = "txtTriangleHeight";
            this.txtTriangleHeight.Size = new System.Drawing.Size(121, 22);
            this.txtTriangleHeight.TabIndex = 13;
            this.txtTriangleHeight.Visible = false;
            // 
            // btnAreaofTriangle
            // 
            this.btnAreaofTriangle.Location = new System.Drawing.Point(308, 294);
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
            this.lblSqrLength.Location = new System.Drawing.Point(192, 84);
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
            "Circle"});
            this.cbShapeType.Location = new System.Drawing.Point(308, 25);
            this.cbShapeType.Name = "cbShapeType";
            this.cbShapeType.Size = new System.Drawing.Size(121, 24);
            this.cbShapeType.TabIndex = 0;
            this.cbShapeType.SelectedIndexChanged += new System.EventHandler(this.cbShapeType_SelectedIndexChanged);
            // 
            // txtSqrLength
            // 
            this.txtSqrLength.Location = new System.Drawing.Point(308, 84);
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
            this.btnAreaofSquare.Location = new System.Drawing.Point(308, 360);
            this.btnAreaofSquare.Name = "btnAreaofSquare";
            this.btnAreaofSquare.Size = new System.Drawing.Size(159, 29);
            this.btnAreaofSquare.TabIndex = 19;
            this.btnAreaofSquare.Text = "Area Of Square";
            this.btnAreaofSquare.UseVisualStyleBackColor = true;
            this.btnAreaofSquare.Visible = false;
            this.btnAreaofSquare.Click += new System.EventHandler(this.btnAreaofSquare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

