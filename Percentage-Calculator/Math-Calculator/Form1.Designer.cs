namespace Math_Calculator
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.txtFirstvalue = new System.Windows.Forms.TextBox();
            this.txtSecondvalue = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblFirstvalue = new System.Windows.Forms.Label();
            this.lblSecondvalue = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClearall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(233, 188);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(91, 23);
            this.btnSubstract.TabIndex = 1;
            this.btnSubstract.Text = "Substract";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // txtFirstvalue
            // 
            this.txtFirstvalue.Location = new System.Drawing.Point(224, 90);
            this.txtFirstvalue.Name = "txtFirstvalue";
            this.txtFirstvalue.Size = new System.Drawing.Size(168, 22);
            this.txtFirstvalue.TabIndex = 3;
            // 
            // txtSecondvalue
            // 
            this.txtSecondvalue.Location = new System.Drawing.Point(224, 131);
            this.txtSecondvalue.Name = "txtSecondvalue";
            this.txtSecondvalue.Size = new System.Drawing.Size(168, 22);
            this.txtSecondvalue.TabIndex = 4;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(349, 187);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 24);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(470, 186);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblFirstvalue
            // 
            this.lblFirstvalue.AutoSize = true;
            this.lblFirstvalue.Location = new System.Drawing.Point(106, 94);
            this.lblFirstvalue.Name = "lblFirstvalue";
            this.lblFirstvalue.Size = new System.Drawing.Size(79, 17);
            this.lblFirstvalue.TabIndex = 7;
            this.lblFirstvalue.Text = "First Value:";
            // 
            // lblSecondvalue
            // 
            this.lblSecondvalue.AutoSize = true;
            this.lblSecondvalue.Location = new System.Drawing.Point(106, 134);
            this.lblSecondvalue.Name = "lblSecondvalue";
            this.lblSecondvalue.Size = new System.Drawing.Size(100, 17);
            this.lblSecondvalue.TabIndex = 8;
            this.lblSecondvalue.Text = "Second Value:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(106, 268);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Result:";
            this.lblResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(224, 268);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(168, 22);
            this.txtResult.TabIndex = 10;
            // 
            // btnClearall
            // 
            this.btnClearall.Location = new System.Drawing.Point(441, 267);
            this.btnClearall.Name = "btnClearall";
            this.btnClearall.Size = new System.Drawing.Size(75, 23);
            this.btnClearall.TabIndex = 11;
            this.btnClearall.Text = "Clear All";
            this.btnClearall.UseVisualStyleBackColor = true;
            this.btnClearall.Click += new System.EventHandler(this.btnClearall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearall);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondvalue);
            this.Controls.Add(this.lblFirstvalue);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.txtSecondvalue);
            this.Controls.Add(this.txtFirstvalue);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.TextBox txtFirstvalue;
        private System.Windows.Forms.TextBox txtSecondvalue;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblFirstvalue;
        private System.Windows.Forms.Label lblSecondvalue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClearall;
    }
}

