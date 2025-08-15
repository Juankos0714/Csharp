namespace WinFormsApp1
{
    partial class calculadora
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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

            // ======== Pantalla ========
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Size = new Size(765, 60);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Text = "";
            label1.Click += label1_Click;

            // ======== Botones de operaciones ========
            btnSum.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btnSum.Size = new Size(115, 90);
            btnSum.BackColor = Color.SkyBlue;
            btnSum.Location = new Point(440, 100);
            btnSum.Name = "btnSum";
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = false;
            btnSum.Click += btnSum_Click;

            btnRest.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btnRest.Size = new Size(115, 90);
            btnRest.BackColor = Color.SkyBlue;
            btnRest.Location = new Point(565, 100);
            btnRest.Name = "btnRest";
            btnRest.Text = "-";
            btnRest.UseVisualStyleBackColor = false;
            btnRest.Click += btnRest_Click;

            btnMult.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btnMult.Size = new Size(115, 90);
            btnMult.BackColor = Color.SkyBlue;
            btnMult.Location = new Point(440, 200);
            btnMult.Name = "btnMult";
            btnMult.Text = "X";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;

            btnDiv.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btnDiv.Size = new Size(115, 90);
            btnDiv.BackColor = Color.SkyBlue;
            btnDiv.Location = new Point(565, 200);
            btnDiv.Name = "btnDiv";
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;

            // ======== Botones numéricos ========
            Button[] numButtons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0 };
            int[,] positions = {
                {12, 100}, {133, 100}, {254, 100},
                {12, 200}, {133, 200}, {254, 200},
                {12, 300}, {133, 300}, {254, 300},
                {133, 400}
            };
            for (int i = 0; i < numButtons.Length; i++)
            {
                numButtons[i].Font = new Font("Segoe UI", 20F, FontStyle.Bold);
                numButtons[i].Size = new Size(115, 90);
                numButtons[i].BackColor = Color.LightGray;
                numButtons[i].FlatStyle = FlatStyle.Flat;
                numButtons[i].FlatAppearance.BorderSize = 0;
                numButtons[i].Location = new Point(positions[i, 0], positions[i, 1]);
                numButtons[i].UseVisualStyleBackColor = false;
            }

            btn1.Text = "1"; btn1.Click += button1_Click;
            btn2.Text = "2"; btn2.Click += btn2_Click;
            btn3.Text = "3"; btn3.Click += btn3_Click;
            btn4.Text = "4"; btn4.Click += btn4_Click;
            btn5.Text = "5"; btn5.Click += btn5_Click;
            btn6.Text = "6"; btn6.Click += btn6_Click;
            btn7.Text = "7"; btn7.Click += btn7_Click;
            btn8.Text = "8"; btn8.Click += btn8_Click;
            btn9.Text = "9"; btn9.Click += btn9_Click;
            btn0.Text = "0"; btn0.Click += btn0_Click;

            // ======== Botón DEL ========
            btnDel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnDel.Size = new Size(115, 90);
            btnDel.BackColor = Color.Orange;
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(254, 400);
            btnDel.Name = "btnDel";
            btnDel.Text = "DEL";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;

            // ======== Botón CE ========
            btnCe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnCe.Size = new Size(115, 90);
            btnCe.BackColor = Color.Red;
            btnCe.ForeColor = Color.White;
            btnCe.Location = new Point(12, 400);
            btnCe.Name = "btnCe";
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = false;
            btnCe.Click += btnCe_Click;

            // ======== Botón igual ========
            btnEquals.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            btnEquals.Size = new Size(115, 190);
            btnEquals.BackColor = Color.LightGreen;
            btnEquals.Location = new Point(690, 100);
            btnEquals.Name = "btnEquals";
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;

            // ======== Form ========
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 520);
            Controls.Add(label1);
            Controls.Add(btnSum);
            Controls.Add(btnRest);
            Controls.Add(btnMult);
            Controls.Add(btnDiv);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btnDel);
            Controls.Add(btnCe);
            Controls.Add(btnEquals);
            Name = "calculadora";
            Text = "Calculadora Mejorada";
            Load += calculadora_Load;
            ResumeLayout(false);
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