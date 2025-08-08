namespace WinFormsApp1
{
    partial class calculadora
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
            btnDiv = new Button();
            btnMult = new Button();
            btnSum = new Button();
            btnRest = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btnDel = new Button();
            btnCe = new Button();
            label1 = new Label();
            btnEquals = new Button();
            SuspendLayout();
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 48F);
            btnDiv.Location = new Point(617, 341);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(171, 97);
            btnDiv.TabIndex = 0;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 46F);
            btnMult.Location = new Point(440, 341);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(171, 97);
            btnMult.TabIndex = 1;
            btnMult.Text = "X";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnSum
            // 
            btnSum.Font = new Font("Segoe UI", 48F);
            btnSum.Location = new Point(440, 238);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(171, 97);
            btnSum.TabIndex = 2;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnRest
            // 
            btnRest.Font = new Font("Segoe UI", 48F);
            btnRest.Location = new Point(617, 238);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(171, 97);
            btnRest.TabIndex = 3;
            btnRest.Text = "-";
            btnRest.UseVisualStyleBackColor = true;
            btnRest.Click += btnRest_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 12);
            btn1.Name = "btn1";
            btn1.Size = new Size(115, 99);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(133, 12);
            btn2.Name = "btn2";
            btn2.Size = new Size(115, 99);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(254, 12);
            btn3.Name = "btn3";
            btn3.Size = new Size(115, 99);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(254, 117);
            btn6.Name = "btn6";
            btn6.Size = new Size(115, 99);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(133, 117);
            btn5.Name = "btn5";
            btn5.Size = new Size(115, 99);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 117);
            btn4.Name = "btn4";
            btn4.Size = new Size(115, 99);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(254, 222);
            btn9.Name = "btn9";
            btn9.Size = new Size(115, 104);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(133, 222);
            btn8.Name = "btn8";
            btn8.Size = new Size(115, 104);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 222);
            btn7.Name = "btn7";
            btn7.Size = new Size(115, 104);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(133, 332);
            btn0.Name = "btn0";
            btn0.Size = new Size(115, 104);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(254, 332);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(115, 104);
            btnDel.TabIndex = 14;
            btnDel.Text = "DEL";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnCe
            // 
            btnCe.Location = new Point(12, 332);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(115, 104);
            btnCe.TabIndex = 15;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = true;
            btnCe.Click += btnCe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 117);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 16;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.Transparent;
            btnEquals.Font = new Font("Segoe UI", 48F);
            btnEquals.ForeColor = Color.Black;
            btnEquals.Location = new Point(806, 238);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(171, 198);
            btnEquals.TabIndex = 17;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 451);
            Controls.Add(btnEquals);
            Controls.Add(label1);
            Controls.Add(btnCe);
            Controls.Add(btnDel);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnRest);
            Controls.Add(btnSum);
            Controls.Add(btnMult);
            Controls.Add(btnDiv);
            Name = "calculadora";
            Text = "calculadora";
            Load += calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDiv;
        private Button btnMult;
        private Button btnSum;
        private Button btnRest;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn0;
        private Button btnDel;
        private Button btnCe;
        private Label label1;
        private Button btnEquals;
    }
}