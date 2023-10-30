namespace CentosCashFlow.ChildForms
{
    partial class UserAccountItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditingUserAccount = new System.Windows.Forms.Button();
            this.btnDeleteUserAccount = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBoxAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(60, 60);
            this.panel1.MinimumSize = new System.Drawing.Size(60, 60);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAvatar.Image = global::CentosCashFlow.Properties.Resources.user;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditingUserAccount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteUserAccount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelUserEmail, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 58);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnEditingUserAccount
            // 
            this.btnEditingUserAccount.BackColor = System.Drawing.Color.DarkViolet;
            this.btnEditingUserAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditingUserAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEditingUserAccount.FlatAppearance.BorderSize = 0;
            this.btnEditingUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditingUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditingUserAccount.ForeColor = System.Drawing.Color.White;
            this.btnEditingUserAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditingUserAccount.Location = new System.Drawing.Point(448, 10);
            this.btnEditingUserAccount.Margin = new System.Windows.Forms.Padding(10);
            this.btnEditingUserAccount.Name = "btnEditingUserAccount";
            this.btnEditingUserAccount.Size = new System.Drawing.Size(80, 38);
            this.btnEditingUserAccount.TabIndex = 41;
            this.btnEditingUserAccount.Text = "Edit";
            this.btnEditingUserAccount.UseVisualStyleBackColor = false;
            this.btnEditingUserAccount.Click += new System.EventHandler(this.btnEditingUserAccount_Click);
            // 
            // btnDeleteUserAccount
            // 
            this.btnDeleteUserAccount.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteUserAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteUserAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDeleteUserAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteUserAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUserAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUserAccount.Location = new System.Drawing.Point(548, 10);
            this.btnDeleteUserAccount.Margin = new System.Windows.Forms.Padding(10);
            this.btnDeleteUserAccount.Name = "btnDeleteUserAccount";
            this.btnDeleteUserAccount.Size = new System.Drawing.Size(80, 38);
            this.btnDeleteUserAccount.TabIndex = 40;
            this.btnDeleteUserAccount.Text = "Delete";
            this.btnDeleteUserAccount.UseVisualStyleBackColor = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelUserName.Location = new System.Drawing.Point(0, 0);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(219, 58);
            this.labelUserName.TabIndex = 39;
            this.labelUserName.Text = "John Dor";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelUserEmail.Location = new System.Drawing.Point(219, 0);
            this.labelUserEmail.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserEmail.Name = "labelUserEmail";
            this.labelUserEmail.Size = new System.Drawing.Size(219, 58);
            this.labelUserEmail.TabIndex = 38;
            this.labelUserEmail.Text = "example123@gmail.com";
            this.labelUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserAccountItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(500, 60);
            this.Name = "UserAccountItem";
            this.Size = new System.Drawing.Size(698, 58);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEditingUserAccount;
        private System.Windows.Forms.Button btnDeleteUserAccount;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserEmail;
    }
}
