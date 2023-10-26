namespace CashFlowManagementProject.ChildForms
{
    partial class Overview
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ChooseMonth = new System.Windows.Forms.ComboBox();
            this.wide1 = new CashFlowManagementProject.ChildForms.Wide();
            this.wide2 = new CashFlowManagementProject.ChildForms.Wide();
            this.wide3 = new CashFlowManagementProject.ChildForms.Wide();
            this.wide4 = new CashFlowManagementProject.ChildForms.Wide();
            this.wide5 = new CashFlowManagementProject.ChildForms.Wide();
            this.wide6 = new CashFlowManagementProject.ChildForms.Wide();
            this.panel_Main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.Controls.Add(this.wide6);
            this.panel_Main.Controls.Add(this.wide5);
            this.panel_Main.Controls.Add(this.wide4);
            this.panel_Main.Controls.Add(this.wide1);
            this.panel_Main.Controls.Add(this.wide2);
            this.panel_Main.Controls.Add(this.wide3);
            this.panel_Main.Controls.Add(this.panel2);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1015, 1030);
            this.panel_Main.TabIndex = 0;
            this.panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 222);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox_ChooseMonth);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 222);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(872, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "450000VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(884, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "10000VNĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày 30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tháng";
            // 
            // comboBox_ChooseMonth
            // 
            this.comboBox_ChooseMonth.FormattingEnabled = true;
            this.comboBox_ChooseMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_ChooseMonth.Location = new System.Drawing.Point(124, 22);
            this.comboBox_ChooseMonth.Name = "comboBox_ChooseMonth";
            this.comboBox_ChooseMonth.Size = new System.Drawing.Size(182, 33);
            this.comboBox_ChooseMonth.TabIndex = 7;
            // 
            // wide1
            // 
            this.wide1.Location = new System.Drawing.Point(53, 249);
            this.wide1.Name = "wide1";
            this.wide1.Size = new System.Drawing.Size(379, 121);
            this.wide1.TabIndex = 3;
            // 
            // wide2
            // 
            this.wide2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wide2.Location = new System.Drawing.Point(438, 249);
            this.wide2.Name = "wide2";
            this.wide2.Size = new System.Drawing.Size(379, 121);
            this.wide2.TabIndex = 4;
            // 
            // wide3
            // 
            this.wide3.Location = new System.Drawing.Point(53, 376);
            this.wide3.Name = "wide3";
            this.wide3.Size = new System.Drawing.Size(379, 121);
            this.wide3.TabIndex = 5;
            // 
            // wide4
            // 
            this.wide4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wide4.Location = new System.Drawing.Point(448, 409);
            this.wide4.Name = "wide4";
            this.wide4.Size = new System.Drawing.Size(379, 121);
            this.wide4.TabIndex = 6;
            // 
            // wide5
            // 
            this.wide5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wide5.Location = new System.Drawing.Point(475, 591);
            this.wide5.Name = "wide5";
            this.wide5.Size = new System.Drawing.Size(379, 121);
            this.wide5.TabIndex = 7;
            // 
            // wide6
            // 
            this.wide6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wide6.Location = new System.Drawing.Point(475, 887);
            this.wide6.Name = "wide6";
            this.wide6.Size = new System.Drawing.Size(379, 121);
            this.wide6.TabIndex = 8;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1015, 1030);
            this.Controls.Add(this.panel_Main);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Overview";
            this.Text = "Overview";
            this.panel_Main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Main;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_ChooseMonth;
        private Wide wide6;
        private Wide wide5;
        private Wide wide4;
        private Wide wide1;
        private Wide wide2;
        private Wide wide3;
    }
}