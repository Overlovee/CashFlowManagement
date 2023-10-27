
namespace CentosCashFlow
{
    partial class Transaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxt_note = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_Income = new System.Windows.Forms.RadioButton();
            this.rb_Expense = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Transaction";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rtxt_note);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rb_Income);
            this.panel1.Controls.Add(this.rb_Expense);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_category);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(208, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 409);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(538, 243);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(151, 48);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Write note";
            // 
            // rtxt_note
            // 
            this.rtxt_note.Location = new System.Drawing.Point(313, 186);
            this.rtxt_note.Name = "rtxt_note";
            this.rtxt_note.Size = new System.Drawing.Size(186, 166);
            this.rtxt_note.TabIndex = 9;
            this.rtxt_note.Text = "";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 186);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select category";
            // 
            // rb_Income
            // 
            this.rb_Income.AutoSize = true;
            this.rb_Income.Location = new System.Drawing.Point(401, 109);
            this.rb_Income.Name = "rb_Income";
            this.rb_Income.Size = new System.Drawing.Size(108, 30);
            this.rb_Income.TabIndex = 5;
            this.rb_Income.TabStop = true;
            this.rb_Income.Text = "Income";
            this.rb_Income.UseVisualStyleBackColor = true;
            // 
            // rb_Expense
            // 
            this.rb_Expense.AutoSize = true;
            this.rb_Expense.Location = new System.Drawing.Point(268, 109);
            this.rb_Expense.Name = "rb_Expense";
            this.rb_Expense.Size = new System.Drawing.Size(118, 30);
            this.rb_Expense.TabIndex = 4;
            this.rb_Expense.TabStop = true;
            this.rb_Expense.Text = "Expense";
            this.rb_Expense.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select transaction type";
            // 
            // cmb_category
            // 
            this.cmb_category.DisplayMember = "aaa";
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(268, 56);
            this.cmb_category.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(421, 33);
            this.cmb_category.TabIndex = 2;
            this.cmb_category.ValueMember = "aaa";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(268, 7);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(421, 34);
            this.txt_amount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the amount";
            // 
            // Form_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 745);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Transaction";
            this.Text = "Form Transaction";
            this.Load += new System.EventHandler(this.Form_Transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_Income;
        private System.Windows.Forms.RadioButton rb_Expense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxt_note;
        private System.Windows.Forms.Button btn_Save;
    }
}

