namespace Calculator
{
    partial class FCalculator
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
            lblEquation = new Label();
            lblIO = new Label();
            btnMemoryClear = new Button();
            btnMemoryReturn = new Button();
            btnMemoryAdd = new Button();
            btnMemorySubtract = new Button();
            btnMemorySave = new Button();
            btnPercent = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnBackspace = new Button();
            btnInverse = new Button();
            btnSquare = new Button();
            btnRoot = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAdd = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSolve = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnNegate = new Button();
            tlpMain = new TableLayoutPanel();
            tlpKeys = new TableLayoutPanel();
            tlpMemory = new TableLayoutPanel();
            tlpMain.SuspendLayout();
            tlpKeys.SuspendLayout();
            tlpMemory.SuspendLayout();
            SuspendLayout();
            // 
            // lblEquation
            // 
            lblEquation.AutoSize = true;
            lblEquation.Dock = DockStyle.Fill;
            lblEquation.ForeColor = SystemColors.ControlDarkDark;
            lblEquation.Location = new Point(3, 0);
            lblEquation.Name = "lblEquation";
            lblEquation.Size = new Size(267, 32);
            lblEquation.TabIndex = 0;
            lblEquation.Text = "0";
            lblEquation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIO
            // 
            lblIO.AutoSize = true;
            lblIO.Dock = DockStyle.Fill;
            lblIO.Location = new Point(3, 32);
            lblIO.Name = "lblIO";
            lblIO.Size = new Size(267, 64);
            lblIO.TabIndex = 1;
            lblIO.Text = "0";
            lblIO.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Dock = DockStyle.Fill;
            btnMemoryClear.Location = new Point(3, 3);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(47, 24);
            btnMemoryClear.TabIndex = 2;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // btnMemoryReturn
            // 
            btnMemoryReturn.Dock = DockStyle.Fill;
            btnMemoryReturn.Location = new Point(56, 3);
            btnMemoryReturn.Name = "btnMemoryReturn";
            btnMemoryReturn.Size = new Size(47, 24);
            btnMemoryReturn.TabIndex = 3;
            btnMemoryReturn.Text = "MR";
            btnMemoryReturn.UseVisualStyleBackColor = true;
            btnMemoryReturn.Click += btnMemoryReturn_Click;
            // 
            // btnMemoryAdd
            // 
            btnMemoryAdd.Dock = DockStyle.Fill;
            btnMemoryAdd.Location = new Point(109, 3);
            btnMemoryAdd.Name = "btnMemoryAdd";
            btnMemoryAdd.Size = new Size(47, 24);
            btnMemoryAdd.TabIndex = 4;
            btnMemoryAdd.Text = "M+";
            btnMemoryAdd.UseVisualStyleBackColor = true;
            btnMemoryAdd.Click += btnMemoryAdd_Click;
            // 
            // btnMemorySubtract
            // 
            btnMemorySubtract.Dock = DockStyle.Fill;
            btnMemorySubtract.Location = new Point(162, 3);
            btnMemorySubtract.Name = "btnMemorySubtract";
            btnMemorySubtract.Size = new Size(47, 24);
            btnMemorySubtract.TabIndex = 5;
            btnMemorySubtract.Text = "M-";
            btnMemorySubtract.UseVisualStyleBackColor = true;
            btnMemorySubtract.Click += btnMemorySubtract_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.Dock = DockStyle.Fill;
            btnMemorySave.Location = new Point(215, 3);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(49, 24);
            btnMemorySave.TabIndex = 6;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Location = new Point(3, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(60, 30);
            btnPercent.TabIndex = 8;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Dock = DockStyle.Fill;
            btnClearEntry.Location = new Point(69, 3);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(60, 30);
            btnClearEntry.TabIndex = 9;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(135, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 30);
            btnClear.TabIndex = 10;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Location = new Point(201, 3);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(63, 30);
            btnBackspace.TabIndex = 11;
            btnBackspace.Text = "BCK";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnInverse
            // 
            btnInverse.Dock = DockStyle.Fill;
            btnInverse.Location = new Point(3, 39);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(60, 30);
            btnInverse.TabIndex = 12;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = true;
            btnInverse.Click += btnInverse_Click;
            // 
            // btnSquare
            // 
            btnSquare.Dock = DockStyle.Fill;
            btnSquare.Location = new Point(69, 39);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(60, 30);
            btnSquare.TabIndex = 13;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnRoot
            // 
            btnRoot.Dock = DockStyle.Fill;
            btnRoot.Location = new Point(135, 39);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(60, 30);
            btnRoot.TabIndex = 14;
            btnRoot.Text = "sqrt(x)";
            btnRoot.UseVisualStyleBackColor = true;
            btnRoot.Click += btnRoot_Click;
            // 
            // btnDivide
            // 
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Location = new Point(201, 39);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(63, 30);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(3, 75);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 30);
            btn7.TabIndex = 16;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(69, 75);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 30);
            btn8.TabIndex = 17;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(135, 75);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 30);
            btn9.TabIndex = 18;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Location = new Point(201, 75);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(63, 30);
            btnMultiply.TabIndex = 19;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Location = new Point(201, 111);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(63, 30);
            btnSubtract.TabIndex = 23;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(135, 111);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 30);
            btn6.TabIndex = 22;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(69, 111);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 30);
            btn5.TabIndex = 21;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(3, 111);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 30);
            btn4.TabIndex = 20;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(201, 147);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 30);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(135, 147);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 30);
            btn3.TabIndex = 26;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(69, 147);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 30);
            btn2.TabIndex = 25;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 147);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 30);
            btn1.TabIndex = 24;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnSolve
            // 
            btnSolve.Dock = DockStyle.Fill;
            btnSolve.Location = new Point(201, 183);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(63, 35);
            btnSolve.TabIndex = 31;
            btnSolve.Text = "=";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.Location = new Point(135, 183);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(60, 35);
            btnDecimal.TabIndex = 30;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Location = new Point(69, 183);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 35);
            btn0.TabIndex = 29;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnNegate
            // 
            btnNegate.Dock = DockStyle.Fill;
            btnNegate.Location = new Point(3, 183);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(60, 35);
            btnNegate.TabIndex = 28;
            btnNegate.Text = "+/-";
            btnNegate.UseVisualStyleBackColor = true;
            btnNegate.Click += btnNegate_Click;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpKeys, 0, 3);
            tlpMain.Controls.Add(tlpMemory, 0, 2);
            tlpMain.Controls.Add(lblEquation, 0, 0);
            tlpMain.Controls.Add(lblIO, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(273, 359);
            tlpMain.TabIndex = 32;
            // 
            // tlpKeys
            // 
            tlpKeys.ColumnCount = 4;
            tlpKeys.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKeys.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKeys.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKeys.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKeys.Controls.Add(btnPercent, 0, 0);
            tlpKeys.Controls.Add(btnDecimal, 2, 5);
            tlpKeys.Controls.Add(btnSolve, 3, 5);
            tlpKeys.Controls.Add(btn0, 1, 5);
            tlpKeys.Controls.Add(btnBackspace, 3, 0);
            tlpKeys.Controls.Add(btnNegate, 0, 5);
            tlpKeys.Controls.Add(btnDivide, 3, 1);
            tlpKeys.Controls.Add(btn3, 2, 4);
            tlpKeys.Controls.Add(btnMultiply, 3, 2);
            tlpKeys.Controls.Add(btn2, 1, 4);
            tlpKeys.Controls.Add(btnSubtract, 3, 3);
            tlpKeys.Controls.Add(btn1, 0, 4);
            tlpKeys.Controls.Add(btnAdd, 3, 4);
            tlpKeys.Controls.Add(btn6, 2, 3);
            tlpKeys.Controls.Add(btnClearEntry, 1, 0);
            tlpKeys.Controls.Add(btn5, 1, 3);
            tlpKeys.Controls.Add(btnClear, 2, 0);
            tlpKeys.Controls.Add(btn4, 0, 3);
            tlpKeys.Controls.Add(btnInverse, 0, 1);
            tlpKeys.Controls.Add(btn9, 2, 2);
            tlpKeys.Controls.Add(btnSquare, 1, 1);
            tlpKeys.Controls.Add(btn8, 1, 2);
            tlpKeys.Controls.Add(btnRoot, 2, 1);
            tlpKeys.Controls.Add(btn7, 0, 2);
            tlpKeys.Dock = DockStyle.Fill;
            tlpKeys.Location = new Point(3, 135);
            tlpKeys.Name = "tlpKeys";
            tlpKeys.RowCount = 6;
            tlpKeys.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpKeys.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpKeys.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpKeys.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpKeys.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpKeys.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpKeys.Size = new Size(267, 221);
            tlpKeys.TabIndex = 33;
            // 
            // tlpMemory
            // 
            tlpMemory.ColumnCount = 5;
            tlpMemory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMemory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMemory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMemory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMemory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMemory.Controls.Add(btnMemoryClear, 0, 0);
            tlpMemory.Controls.Add(btnMemoryReturn, 1, 0);
            tlpMemory.Controls.Add(btnMemoryAdd, 2, 0);
            tlpMemory.Controls.Add(btnMemorySubtract, 3, 0);
            tlpMemory.Controls.Add(btnMemorySave, 4, 0);
            tlpMemory.Dock = DockStyle.Fill;
            tlpMemory.Location = new Point(3, 99);
            tlpMemory.Name = "tlpMemory";
            tlpMemory.RowCount = 1;
            tlpMemory.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMemory.Size = new Size(267, 30);
            tlpMemory.TabIndex = 33;
            // 
            // FCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 359);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += FCalculator_Load;
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tlpKeys.ResumeLayout(false);
            tlpMemory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblEquation;
        private Label lblIO;
        private Button btnMemoryClear;
        private Button btnMemoryReturn;
        private Button btnMemoryAdd;
        private Button btnMemorySubtract;
        private Button btnMemorySave;
        private Button btnPercent;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnBackspace;
        private Button btnInverse;
        private Button btnSquare;
        private Button btnRoot;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAdd;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSolve;
        private Button btnDecimal;
        private Button btn0;
        private Button btnNegate;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpKeys;
        private TableLayoutPanel tlpMemory;
    }
}