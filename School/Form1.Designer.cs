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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "0,0";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

