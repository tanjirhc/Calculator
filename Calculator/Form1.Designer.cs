namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn10 = new Button();
            btnMultiplication = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnDivision = new Button();
            btnEqual = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(13, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(324, 52);
            txtTotal.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(13, 85);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 52);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(96, 85);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 52);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button1_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(181, 85);
            btn3.Name = "btn3";
            btn3.Size = new Size(68, 52);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(181, 162);
            btn6.Name = "btn6";
            btn6.Size = new Size(68, 52);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(96, 162);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 52);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(13, 162);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 52);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(181, 238);
            btn9.Name = "btn9";
            btn9.Size = new Size(68, 52);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(96, 238);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 52);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(13, 238);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 52);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn10
            // 
            btn10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn10.Location = new Point(13, 318);
            btn10.Name = "btn10";
            btn10.Size = new Size(68, 52);
            btn10.TabIndex = 10;
            btn10.Text = "0";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn10_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMultiplication.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplication.Location = new Point(265, 238);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(68, 52);
            btnMultiplication.TabIndex = 13;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMinus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(265, 162);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(68, 52);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPlus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(265, 85);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(68, 52);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDivision
            // 
            btnDivision.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDivision.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(265, 318);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(68, 52);
            btnDivision.TabIndex = 14;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(96, 318);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(153, 52);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(13, 382);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(320, 52);
            btnClear.TabIndex = 17;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 446);
            Controls.Add(btnClear);
            Controls.Add(btnEqual);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplication);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn10);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn10;
        private Button btnMultiplication;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnDivision;
        private Button btnEqual;
        private Button btnClear;
    }
}
