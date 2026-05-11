namespace EST_HanoiTower
{
    partial class Form2
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
            btn_Insert = new Button();
            btn_PreOrder = new Button();
            btn_InOrder = new Button();
            btn_PostOrder = new Button();
            txt_Order = new Label();
            btn_Remove = new Button();
            btn_Clear = new Button();
            btn_Contains = new Button();
            btn_LevelOrder = new Button();
            btn_Height = new Button();
            btn_Max = new Button();
            btn_Min = new Button();
            btn_Count = new Button();
            txt_Info = new Label();
            txt_Tree_Edit = new Label();
            txt_Order_Current = new Label();
            txt_Info_Current = new Label();
            txtb_Insert = new TextBox();
            cmb_Tree_Type = new ComboBox();
            Panel_Tree = new Panel();
            lbl_Result = new Label();
            btn_Classification = new Button();
            label1 = new Label();
            Panel_Tree.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(21, 374);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(75, 23);
            btn_Insert.TabIndex = 0;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_PreOrder
            // 
            btn_PreOrder.Location = new Point(21, 400);
            btn_PreOrder.Name = "btn_PreOrder";
            btn_PreOrder.Size = new Size(75, 23);
            btn_PreOrder.TabIndex = 1;
            btn_PreOrder.Text = "PreOrder";
            btn_PreOrder.UseVisualStyleBackColor = true;
            btn_PreOrder.Click += btn_PreOrder_Click;
            // 
            // btn_InOrder
            // 
            btn_InOrder.Location = new Point(112, 400);
            btn_InOrder.Name = "btn_InOrder";
            btn_InOrder.Size = new Size(75, 23);
            btn_InOrder.TabIndex = 2;
            btn_InOrder.Text = "InOrder";
            btn_InOrder.UseVisualStyleBackColor = true;
            btn_InOrder.Click += btn_InOrder_Click;
            // 
            // btn_PostOrder
            // 
            btn_PostOrder.Location = new Point(205, 400);
            btn_PostOrder.Name = "btn_PostOrder";
            btn_PostOrder.Size = new Size(75, 23);
            btn_PostOrder.TabIndex = 3;
            btn_PostOrder.Text = "PostOrder";
            btn_PostOrder.UseVisualStyleBackColor = true;
            btn_PostOrder.Click += btn_PostOrder_Click;
            // 
            // txt_Order
            // 
            txt_Order.AutoSize = true;
            txt_Order.Location = new Point(433, 404);
            txt_Order.Name = "txt_Order";
            txt_Order.Size = new Size(40, 15);
            txt_Order.TabIndex = 4;
            txt_Order.Text = "Order:";
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(112, 374);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(75, 23);
            btn_Remove.TabIndex = 5;
            btn_Remove.Text = "Remove";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(205, 374);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 23);
            btn_Clear.TabIndex = 6;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Contains
            // 
            btn_Contains.Location = new Point(309, 374);
            btn_Contains.Name = "btn_Contains";
            btn_Contains.Size = new Size(75, 23);
            btn_Contains.TabIndex = 7;
            btn_Contains.Text = "Contains";
            btn_Contains.UseVisualStyleBackColor = true;
            btn_Contains.Click += btn_Contains_Click;
            // 
            // btn_LevelOrder
            // 
            btn_LevelOrder.Location = new Point(309, 400);
            btn_LevelOrder.Name = "btn_LevelOrder";
            btn_LevelOrder.Size = new Size(75, 23);
            btn_LevelOrder.TabIndex = 8;
            btn_LevelOrder.Text = "LevelOrder";
            btn_LevelOrder.UseVisualStyleBackColor = true;
            btn_LevelOrder.Click += btn_LevelOrder_Click;
            // 
            // btn_Height
            // 
            btn_Height.Location = new Point(21, 426);
            btn_Height.Name = "btn_Height";
            btn_Height.Size = new Size(75, 23);
            btn_Height.TabIndex = 11;
            btn_Height.Text = "Height";
            btn_Height.UseVisualStyleBackColor = true;
            btn_Height.Click += btn_Height_Click;
            // 
            // btn_Max
            // 
            btn_Max.Location = new Point(112, 426);
            btn_Max.Name = "btn_Max";
            btn_Max.Size = new Size(75, 23);
            btn_Max.TabIndex = 12;
            btn_Max.Text = "Max";
            btn_Max.UseVisualStyleBackColor = true;
            btn_Max.Click += btn_Max_Click;
            // 
            // btn_Min
            // 
            btn_Min.Location = new Point(205, 426);
            btn_Min.Name = "btn_Min";
            btn_Min.Size = new Size(75, 23);
            btn_Min.TabIndex = 13;
            btn_Min.Text = "Min";
            btn_Min.UseVisualStyleBackColor = true;
            btn_Min.Click += btn_Min_Click;
            // 
            // btn_Count
            // 
            btn_Count.Location = new Point(309, 426);
            btn_Count.Name = "btn_Count";
            btn_Count.Size = new Size(75, 23);
            btn_Count.TabIndex = 14;
            btn_Count.Text = "Count";
            btn_Count.UseVisualStyleBackColor = true;
            btn_Count.Click += btn_Count_Click;
            // 
            // txt_Info
            // 
            txt_Info.AutoSize = true;
            txt_Info.Location = new Point(433, 434);
            txt_Info.Name = "txt_Info";
            txt_Info.Size = new Size(31, 15);
            txt_Info.TabIndex = 15;
            txt_Info.Text = "Info:";
            // 
            // txt_Tree_Edit
            // 
            txt_Tree_Edit.AutoSize = true;
            txt_Tree_Edit.Location = new Point(21, 338);
            txt_Tree_Edit.Name = "txt_Tree_Edit";
            txt_Tree_Edit.Size = new Size(52, 15);
            txt_Tree_Edit.TabIndex = 16;
            txt_Tree_Edit.Text = "Tree Edit";
            // 
            // txt_Order_Current
            // 
            txt_Order_Current.AutoSize = true;
            txt_Order_Current.Location = new Point(487, 404);
            txt_Order_Current.Name = "txt_Order_Current";
            txt_Order_Current.Size = new Size(82, 15);
            txt_Order_Current.TabIndex = 17;
            txt_Order_Current.Text = "Order_Current";
            // 
            // txt_Info_Current
            // 
            txt_Info_Current.AutoSize = true;
            txt_Info_Current.Location = new Point(487, 434);
            txt_Info_Current.Name = "txt_Info_Current";
            txt_Info_Current.Size = new Size(73, 15);
            txt_Info_Current.TabIndex = 18;
            txt_Info_Current.Text = "Info_Current";
            // 
            // txtb_Insert
            // 
            txtb_Insert.Location = new Point(517, 374);
            txtb_Insert.Name = "txtb_Insert";
            txtb_Insert.Size = new Size(132, 23);
            txtb_Insert.TabIndex = 19;
            // 
            // cmb_Tree_Type
            // 
            cmb_Tree_Type.FormattingEnabled = true;
            cmb_Tree_Type.Location = new Point(716, 348);
            cmb_Tree_Type.Name = "cmb_Tree_Type";
            cmb_Tree_Type.Size = new Size(76, 23);
            cmb_Tree_Type.TabIndex = 21;
            cmb_Tree_Type.Text = "Tree Type";
            cmb_Tree_Type.SelectedIndexChanged += cmb_Tree_Type_SelectedIndexChanged_1;
            // 
            // Panel_Tree
            // 
            Panel_Tree.Controls.Add(cmb_Tree_Type);
            Panel_Tree.Location = new Point(5, 2);
            Panel_Tree.Name = "Panel_Tree";
            Panel_Tree.Size = new Size(792, 371);
            Panel_Tree.TabIndex = 20;
            Panel_Tree.Paint += Panel_Tree_Paint;
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Location = new Point(659, 378);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(57, 15);
            lbl_Result.TabIndex = 22;
            lbl_Result.Text = "lbl_Result";
            // 
            // btn_Classification
            // 
            btn_Classification.Location = new Point(416, 374);
            btn_Classification.Name = "btn_Classification";
            btn_Classification.Size = new Size(85, 23);
            btn_Classification.TabIndex = 23;
            btn_Classification.Text = "Classification";
            btn_Classification.UseVisualStyleBackColor = true;
            btn_Classification.Click += btn_Classification_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(726, 409);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 24;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_Classification);
            Controls.Add(lbl_Result);
            Controls.Add(Panel_Tree);
            Controls.Add(txtb_Insert);
            Controls.Add(txt_Info_Current);
            Controls.Add(txt_Order_Current);
            Controls.Add(txt_Tree_Edit);
            Controls.Add(txt_Info);
            Controls.Add(btn_Count);
            Controls.Add(btn_Min);
            Controls.Add(btn_Max);
            Controls.Add(btn_Height);
            Controls.Add(btn_LevelOrder);
            Controls.Add(btn_Contains);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Remove);
            Controls.Add(txt_Order);
            Controls.Add(btn_PostOrder);
            Controls.Add(btn_InOrder);
            Controls.Add(btn_PreOrder);
            Controls.Add(btn_Insert);
            Name = "Form2";
            Text = "Form2";
            Panel_Tree.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Insert;
        private Button btn_PreOrder;
        private Button btn_InOrder;
        private Button btn_PostOrder;
        private Label txt_Order;
        private Button btn_Remove;
        private Button btn_Clear;
        private Button btn_Contains;
        private Button btn_LevelOrder;
        private Button btn_Height;
        private Button btn_Max;
        private Button btn_Min;
        private Button btn_Count;
        private Label txt_Info;
        private Label txt_Tree_Edit;
        private Label txt_Order_Current;
        private Label txt_Info_Current;
        private TextBox txtb_Insert;
        private ComboBox cmb_Tree_Type;
        private Panel Panel_Tree;
        private Label lbl_Result;
        private Button btn_Classification;
        private Label label1;
    }
}