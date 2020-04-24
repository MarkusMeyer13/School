namespace School
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMathGrade = new System.Windows.Forms.Label();
            this.txtMathGrade1 = new System.Windows.Forms.TextBox();
            this.txtMathGrade2 = new System.Windows.Forms.TextBox();
            this.txtMathGrade3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtGermanGrade3 = new System.Windows.Forms.TextBox();
            this.txtGermanGrade2 = new System.Windows.Forms.TextBox();
            this.txtGermanGrade1 = new System.Windows.Forms.TextBox();
            this.lblGermanGrade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mathe";
            // 
            // lblMathGrade
            // 
            this.lblMathGrade.AutoSize = true;
            this.lblMathGrade.Location = new System.Drawing.Point(560, 53);
            this.lblMathGrade.Name = "lblMathGrade";
            this.lblMathGrade.Size = new System.Drawing.Size(42, 25);
            this.lblMathGrade.TabIndex = 1;
            this.lblMathGrade.Text = "0,0";
            // 
            // txtMathGrade1
            // 
            this.txtMathGrade1.Location = new System.Drawing.Point(158, 53);
            this.txtMathGrade1.Name = "txtMathGrade1";
            this.txtMathGrade1.Size = new System.Drawing.Size(100, 31);
            this.txtMathGrade1.TabIndex = 2;
            // 
            // txtMathGrade2
            // 
            this.txtMathGrade2.Location = new System.Drawing.Point(297, 53);
            this.txtMathGrade2.Name = "txtMathGrade2";
            this.txtMathGrade2.Size = new System.Drawing.Size(100, 31);
            this.txtMathGrade2.TabIndex = 3;
            // 
            // txtMathGrade3
            // 
            this.txtMathGrade3.Location = new System.Drawing.Point(433, 53);
            this.txtMathGrade3.Name = "txtMathGrade3";
            this.txtMathGrade3.Size = new System.Drawing.Size(100, 31);
            this.txtMathGrade3.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(624, 339);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(127, 58);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtGermanGrade3
            // 
            this.txtGermanGrade3.Location = new System.Drawing.Point(433, 135);
            this.txtGermanGrade3.Name = "txtGermanGrade3";
            this.txtGermanGrade3.Size = new System.Drawing.Size(100, 31);
            this.txtGermanGrade3.TabIndex = 10;
            // 
            // txtGermanGrade2
            // 
            this.txtGermanGrade2.Location = new System.Drawing.Point(297, 135);
            this.txtGermanGrade2.Name = "txtGermanGrade2";
            this.txtGermanGrade2.Size = new System.Drawing.Size(100, 31);
            this.txtGermanGrade2.TabIndex = 9;
            // 
            // txtGermanGrade1
            // 
            this.txtGermanGrade1.Location = new System.Drawing.Point(158, 135);
            this.txtGermanGrade1.Name = "txtGermanGrade1";
            this.txtGermanGrade1.Size = new System.Drawing.Size(100, 31);
            this.txtGermanGrade1.TabIndex = 8;
            // 
            // lblGermanGrade
            // 
            this.lblGermanGrade.AutoSize = true;
            this.lblGermanGrade.Location = new System.Drawing.Point(560, 135);
            this.lblGermanGrade.Name = "lblGermanGrade";
            this.lblGermanGrade.Size = new System.Drawing.Size(42, 25);
            this.lblGermanGrade.TabIndex = 7;
            this.lblGermanGrade.Text = "0,0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deutsch";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(347, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 58);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGermanGrade3);
            this.Controls.Add(this.txtGermanGrade2);
            this.Controls.Add(this.txtGermanGrade1);
            this.Controls.Add(this.lblGermanGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMathGrade3);
            this.Controls.Add(this.txtMathGrade2);
            this.Controls.Add(this.txtMathGrade1);
            this.Controls.Add(this.lblMathGrade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMathGrade;
        private System.Windows.Forms.TextBox txtMathGrade1;
        private System.Windows.Forms.TextBox txtMathGrade2;
        private System.Windows.Forms.TextBox txtMathGrade3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtGermanGrade3;
        private System.Windows.Forms.TextBox txtGermanGrade2;
        private System.Windows.Forms.TextBox txtGermanGrade1;
        private System.Windows.Forms.Label lblGermanGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
    }
}

