namespace Matrix_Calculator
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
            this.Matrix2Panel = new System.Windows.Forms.Panel();
            this.Matrix2Label = new System.Windows.Forms.Label();
            this.Matrix2Y = new System.Windows.Forms.TextBox();
            this.Matrix2X = new System.Windows.Forms.TextBox();
            this.MatrixPanel = new System.Windows.Forms.Panel();
            this.MatrixButtonPanel = new System.Windows.Forms.Panel();
            this.MatrixSizeButton = new System.Windows.Forms.Button();
            this.Matrix1Panel = new System.Windows.Forms.Panel();
            this.Matrix1Label = new System.Windows.Forms.Label();
            this.Matrix1Y = new System.Windows.Forms.TextBox();
            this.Matrix1X = new System.Windows.Forms.TextBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.CentrePanel = new System.Windows.Forms.Panel();
            this.MatrixDivision = new System.Windows.Forms.Button();
            this.MatrixSumm = new System.Windows.Forms.Button();
            this.MatrixMultiplication = new System.Windows.Forms.Button();
            this.MatrixMinus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Matrix2Panel.SuspendLayout();
            this.MatrixPanel.SuspendLayout();
            this.MatrixButtonPanel.SuspendLayout();
            this.Matrix1Panel.SuspendLayout();
            this.CentrePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Matrix2Panel
            // 
            this.Matrix2Panel.Controls.Add(this.Matrix2Label);
            this.Matrix2Panel.Controls.Add(this.Matrix2Y);
            this.Matrix2Panel.Controls.Add(this.Matrix2X);
            this.Matrix2Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Matrix2Panel.Location = new System.Drawing.Point(421, 0);
            this.Matrix2Panel.Name = "Matrix2Panel";
            this.Matrix2Panel.Size = new System.Drawing.Size(108, 58);
            this.Matrix2Panel.TabIndex = 1;
            // 
            // Matrix2Label
            // 
            this.Matrix2Label.AutoSize = true;
            this.Matrix2Label.Location = new System.Drawing.Point(30, 9);
            this.Matrix2Label.Name = "Matrix2Label";
            this.Matrix2Label.Size = new System.Drawing.Size(50, 15);
            this.Matrix2Label.TabIndex = 5;
            this.Matrix2Label.Text = "Matrix 2";
            // 
            // Matrix2Y
            // 
            this.Matrix2Y.Location = new System.Drawing.Point(10, 27);
            this.Matrix2Y.Name = "Matrix2Y";
            this.Matrix2Y.Size = new System.Drawing.Size(39, 23);
            this.Matrix2Y.TabIndex = 3;
            // 
            // Matrix2X
            // 
            this.Matrix2X.Location = new System.Drawing.Point(59, 27);
            this.Matrix2X.Name = "Matrix2X";
            this.Matrix2X.Size = new System.Drawing.Size(39, 23);
            this.Matrix2X.TabIndex = 4;
            // 
            // MatrixPanel
            // 
            this.MatrixPanel.Controls.Add(this.MatrixButtonPanel);
            this.MatrixPanel.Controls.Add(this.Matrix1Panel);
            this.MatrixPanel.Controls.Add(this.Matrix2Panel);
            this.MatrixPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MatrixPanel.Location = new System.Drawing.Point(0, 0);
            this.MatrixPanel.Name = "MatrixPanel";
            this.MatrixPanel.Size = new System.Drawing.Size(529, 58);
            this.MatrixPanel.TabIndex = 0;
            // 
            // MatrixButtonPanel
            // 
            this.MatrixButtonPanel.Controls.Add(this.MatrixSizeButton);
            this.MatrixButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixButtonPanel.Location = new System.Drawing.Point(108, 0);
            this.MatrixButtonPanel.Name = "MatrixButtonPanel";
            this.MatrixButtonPanel.Size = new System.Drawing.Size(313, 58);
            this.MatrixButtonPanel.TabIndex = 7;
            // 
            // MatrixSizeButton
            // 
            this.MatrixSizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MatrixSizeButton.Location = new System.Drawing.Point(110, 12);
            this.MatrixSizeButton.Name = "MatrixSizeButton";
            this.MatrixSizeButton.Size = new System.Drawing.Size(100, 23);
            this.MatrixSizeButton.TabIndex = 7;
            this.MatrixSizeButton.Text = "Change the size";
            this.MatrixSizeButton.UseVisualStyleBackColor = true;
            // 
            // Matrix1Panel
            // 
            this.Matrix1Panel.Controls.Add(this.Matrix1Label);
            this.Matrix1Panel.Controls.Add(this.Matrix1Y);
            this.Matrix1Panel.Controls.Add(this.Matrix1X);
            this.Matrix1Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Matrix1Panel.Location = new System.Drawing.Point(0, 0);
            this.Matrix1Panel.Name = "Matrix1Panel";
            this.Matrix1Panel.Size = new System.Drawing.Size(108, 58);
            this.Matrix1Panel.TabIndex = 6;
            // 
            // Matrix1Label
            // 
            this.Matrix1Label.AutoSize = true;
            this.Matrix1Label.Location = new System.Drawing.Point(30, 9);
            this.Matrix1Label.Name = "Matrix1Label";
            this.Matrix1Label.Size = new System.Drawing.Size(50, 15);
            this.Matrix1Label.TabIndex = 5;
            this.Matrix1Label.Text = "Matrix 1";
            // 
            // Matrix1Y
            // 
            this.Matrix1Y.Location = new System.Drawing.Point(10, 27);
            this.Matrix1Y.Name = "Matrix1Y";
            this.Matrix1Y.Size = new System.Drawing.Size(39, 23);
            this.Matrix1Y.TabIndex = 3;
            // 
            // Matrix1X
            // 
            this.Matrix1X.Location = new System.Drawing.Point(59, 27);
            this.Matrix1X.Name = "Matrix1X";
            this.Matrix1X.Size = new System.Drawing.Size(39, 23);
            this.Matrix1X.TabIndex = 4;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftPanel.Location = new System.Drawing.Point(0, 58);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(210, 361);
            this.LeftPanel.TabIndex = 1;
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.Location = new System.Drawing.Point(319, 58);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(210, 361);
            this.RightPanel.TabIndex = 2;
            // 
            // CentrePanel
            // 
            this.CentrePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CentrePanel.Controls.Add(this.MatrixDivision);
            this.CentrePanel.Controls.Add(this.MatrixSumm);
            this.CentrePanel.Controls.Add(this.MatrixMultiplication);
            this.CentrePanel.Controls.Add(this.MatrixMinus);
            this.CentrePanel.Location = new System.Drawing.Point(210, 58);
            this.CentrePanel.Name = "CentrePanel";
            this.CentrePanel.Size = new System.Drawing.Size(109, 361);
            this.CentrePanel.TabIndex = 3;
            // 
            // MatrixDivision
            // 
            this.MatrixDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MatrixDivision.Location = new System.Drawing.Point(17, 115);
            this.MatrixDivision.Name = "MatrixDivision";
            this.MatrixDivision.Size = new System.Drawing.Size(76, 23);
            this.MatrixDivision.TabIndex = 3;
            this.MatrixDivision.Text = "button1";
            this.MatrixDivision.UseVisualStyleBackColor = true;
            this.MatrixDivision.Click += new System.EventHandler(this.MatrixDivision_Click);
            // 
            // MatrixSumm
            // 
            this.MatrixSumm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MatrixSumm.Location = new System.Drawing.Point(17, 16);
            this.MatrixSumm.Name = "MatrixSumm";
            this.MatrixSumm.Size = new System.Drawing.Size(76, 23);
            this.MatrixSumm.TabIndex = 0;
            this.MatrixSumm.Text = "button1";
            this.MatrixSumm.UseVisualStyleBackColor = true;
            this.MatrixSumm.Click += new System.EventHandler(this.MatrixSumm_Click);
            // 
            // MatrixMultiplication
            // 
            this.MatrixMultiplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MatrixMultiplication.Location = new System.Drawing.Point(17, 82);
            this.MatrixMultiplication.Name = "MatrixMultiplication";
            this.MatrixMultiplication.Size = new System.Drawing.Size(76, 23);
            this.MatrixMultiplication.TabIndex = 2;
            this.MatrixMultiplication.Text = "button1";
            this.MatrixMultiplication.UseVisualStyleBackColor = true;
            this.MatrixMultiplication.Click += new System.EventHandler(this.MatrixMultiplication_Click);
            // 
            // MatrixMinus
            // 
            this.MatrixMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MatrixMinus.Location = new System.Drawing.Point(17, 49);
            this.MatrixMinus.Name = "MatrixMinus";
            this.MatrixMinus.Size = new System.Drawing.Size(76, 23);
            this.MatrixMinus.TabIndex = 1;
            this.MatrixMinus.Text = "button1";
            this.MatrixMinus.UseVisualStyleBackColor = true;
            this.MatrixMinus.Click += new System.EventHandler(this.MatrixMinus_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 100);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CentrePanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.MatrixPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Matrix2Panel.ResumeLayout(false);
            this.Matrix2Panel.PerformLayout();
            this.MatrixPanel.ResumeLayout(false);
            this.MatrixButtonPanel.ResumeLayout(false);
            this.Matrix1Panel.ResumeLayout(false);
            this.Matrix1Panel.PerformLayout();
            this.CentrePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Matrix2Panel;
        private Label Matrix2Label;
        private TextBox Matrix2Y;
        private TextBox Matrix2X;
        private Panel MatrixPanel;
        private Panel Matrix1Panel;
        private Label Matrix1Label;
        private TextBox Matrix1Y;
        private TextBox Matrix1X;
        private Panel MatrixButtonPanel;
        private Button MatrixSizeButton;
        private Panel LeftPanel;
        private Panel RightPanel;
        private Panel CentrePanel;
        private Button MatrixMultiplication;
        private Button MatrixMinus;
        private Button MatrixSumm;
        private Button MatrixDivision;
        private Panel panel1;
    }
}