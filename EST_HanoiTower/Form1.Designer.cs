namespace EST_HanoiTower
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
            TowerA = new ListBox();
            TowerB = new ListBox();
            TowerC = new ListBox();
            txtTowerA = new Label();
            txtTowerB = new Label();
            txtTowerC = new Label();
            btnMoveA = new Button();
            btnMoveB = new Button();
            btnMoveC = new Button();
            btnSelectA = new Button();
            btnSelectB = new Button();
            btnSelectC = new Button();
            txtCant = new TextBox();
            btnStart = new Button();
            lblMinimos = new Label();
            lblMovimientos = new Label();
            SuspendLayout();
            // 
            // TowerA
            // 
            TowerA.FormattingEnabled = true;
            TowerA.Location = new Point(32, 76);
            TowerA.Name = "TowerA";
            TowerA.Size = new Size(120, 94);
            TowerA.TabIndex = 0;
            // 
            // TowerB
            // 
            TowerB.FormattingEnabled = true;
            TowerB.Location = new Point(344, 76);
            TowerB.Name = "TowerB";
            TowerB.Size = new Size(120, 94);
            TowerB.TabIndex = 1;
            // 
            // TowerC
            // 
            TowerC.FormattingEnabled = true;
            TowerC.Location = new Point(658, 76);
            TowerC.Name = "TowerC";
            TowerC.Size = new Size(120, 94);
            TowerC.TabIndex = 2;
            // 
            // txtTowerA
            // 
            txtTowerA.AutoSize = true;
            txtTowerA.Location = new Point(32, 58);
            txtTowerA.Name = "txtTowerA";
            txtTowerA.Size = new Size(64, 15);
            txtTowerA.TabIndex = 3;
            txtTowerA.Text = "Temporary";
            // 
            // txtTowerB
            // 
            txtTowerB.AutoSize = true;
            txtTowerB.Location = new Point(344, 58);
            txtTowerB.Name = "txtTowerB";
            txtTowerB.Size = new Size(64, 15);
            txtTowerB.TabIndex = 4;
            txtTowerB.Text = "Temporary";
            // 
            // txtTowerC
            // 
            txtTowerC.AutoSize = true;
            txtTowerC.Location = new Point(658, 58);
            txtTowerC.Name = "txtTowerC";
            txtTowerC.Size = new Size(64, 15);
            txtTowerC.TabIndex = 5;
            txtTowerC.Text = "Temporary";
            // 
            // btnMoveA
            // 
            btnMoveA.Location = new Point(32, 211);
            btnMoveA.Name = "btnMoveA";
            btnMoveA.Size = new Size(75, 23);
            btnMoveA.TabIndex = 9;
            btnMoveA.Text = "Move";
            btnMoveA.UseVisualStyleBackColor = true;
            btnMoveA.Click += btnMoveA_Click;
            // 
            // btnMoveB
            // 
            btnMoveB.Location = new Point(344, 211);
            btnMoveB.Name = "btnMoveB";
            btnMoveB.Size = new Size(75, 23);
            btnMoveB.TabIndex = 10;
            btnMoveB.Text = "Move";
            btnMoveB.UseVisualStyleBackColor = true;
            btnMoveB.Click += btnMoveB_Click;
            // 
            // btnMoveC
            // 
            btnMoveC.Location = new Point(658, 211);
            btnMoveC.Name = "btnMoveC";
            btnMoveC.Size = new Size(75, 23);
            btnMoveC.TabIndex = 11;
            btnMoveC.Text = "Move";
            btnMoveC.UseVisualStyleBackColor = true;
            btnMoveC.Click += btnMoveC_Click;
            // 
            // btnSelectA
            // 
            btnSelectA.Location = new Point(32, 182);
            btnSelectA.Name = "btnSelectA";
            btnSelectA.Size = new Size(75, 23);
            btnSelectA.TabIndex = 12;
            btnSelectA.Text = "Select";
            btnSelectA.UseVisualStyleBackColor = true;
            btnSelectA.Click += btnSelectA_Click;
            // 
            // btnSelectB
            // 
            btnSelectB.Location = new Point(344, 182);
            btnSelectB.Name = "btnSelectB";
            btnSelectB.Size = new Size(75, 23);
            btnSelectB.TabIndex = 13;
            btnSelectB.Text = "Select";
            btnSelectB.UseVisualStyleBackColor = true;
            btnSelectB.Click += btnSelectB_Click;
            // 
            // btnSelectC
            // 
            btnSelectC.Location = new Point(658, 182);
            btnSelectC.Name = "btnSelectC";
            btnSelectC.Size = new Size(75, 23);
            btnSelectC.TabIndex = 14;
            btnSelectC.Text = "Select";
            btnSelectC.UseVisualStyleBackColor = true;
            btnSelectC.Click += btnSelectC_Click;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(41, 328);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(100, 23);
            txtCant.TabIndex = 15;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(161, 328);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 16;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblMinimos
            // 
            lblMinimos.AutoSize = true;
            lblMinimos.Location = new Point(41, 293);
            lblMinimos.Name = "lblMinimos";
            lblMinimos.Size = new Size(130, 15);
            lblMinimos.TabIndex = 17;
            lblMinimos.Text = "Movimientos Mínimos:";
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Location = new Point(41, 310);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(138, 15);
            lblMovimientos.TabIndex = 18;
            lblMovimientos.Text = "Movimientos Realizados:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMovimientos);
            Controls.Add(lblMinimos);
            Controls.Add(btnStart);
            Controls.Add(txtCant);
            Controls.Add(btnSelectC);
            Controls.Add(btnSelectB);
            Controls.Add(btnSelectA);
            Controls.Add(btnMoveC);
            Controls.Add(btnMoveB);
            Controls.Add(btnMoveA);
            Controls.Add(txtTowerC);
            Controls.Add(txtTowerB);
            Controls.Add(txtTowerA);
            Controls.Add(TowerC);
            Controls.Add(TowerB);
            Controls.Add(TowerA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox TowerA;
        private ListBox TowerB;
        private ListBox TowerC;
        private Label txtTowerA;
        private Label txtTowerB;
        private Label txtTowerC;
        private Button btnMoveA;
        private Button btnMoveB;
        private Button btnMoveC;
        private Button btnSelectA;
        private Button btnSelectB;
        private Button btnSelectC;
        private TextBox txtCant;
        private Button btnStart;
        private Label lblMinimos;
        private Label lblMovimientos;
    }
}
