namespace CentosCashFlow.ChildForms
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNewTransaction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalMonthExpenditure = new System.Windows.Forms.Label();
            this.labellabelTitleMonthExpenditure = new System.Windows.Forms.Label();
            this.labelTotalMonthIncome = new System.Windows.Forms.Label();
            this.labelTitleMonthIncome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCurrentTransactions = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.chartMonthCashFlow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthCashFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrentBalance, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.36444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.63556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(760, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current balance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrentBalance.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.labelCurrentBalance.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelCurrentBalance.Location = new System.Drawing.Point(28, 0);
            this.labelCurrentBalance.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(760, 28);
            this.labelCurrentBalance.TabIndex = 0;
            this.labelCurrentBalance.Text = "10,001,129 VND";
            this.labelCurrentBalance.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewTransaction, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 28, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnAddNewTransaction
            // 
            this.btnAddNewTransaction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewTransaction.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewTransaction.Location = new System.Drawing.Point(567, 0);
            this.btnAddNewTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewTransaction.Name = "btnAddNewTransaction";
            this.btnAddNewTransaction.Size = new System.Drawing.Size(193, 30);
            this.btnAddNewTransaction.TabIndex = 0;
            this.btnAddNewTransaction.Text = "+ Add new transaction";
            this.btnAddNewTransaction.UseVisualStyleBackColor = true;
            this.btnAddNewTransaction.Click += new System.EventHandler(this.btnAddNewTransaction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(0, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(371, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Income and Expenses this month";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelTotalMonthExpenditure, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labellabelTitleMonthExpenditure, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalMonthIncome, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTitleMonthIncome, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 60);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // labelTotalMonthExpenditure
            // 
            this.labelTotalMonthExpenditure.AutoSize = true;
            this.labelTotalMonthExpenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalMonthExpenditure.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalMonthExpenditure.ForeColor = System.Drawing.Color.LightCoral;
            this.labelTotalMonthExpenditure.Location = new System.Drawing.Point(394, 30);
            this.labelTotalMonthExpenditure.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalMonthExpenditure.Name = "labelTotalMonthExpenditure";
            this.labelTotalMonthExpenditure.Padding = new System.Windows.Forms.Padding(0, 0, 28, 0);
            this.labelTotalMonthExpenditure.Size = new System.Drawing.Size(394, 30);
            this.labelTotalMonthExpenditure.TabIndex = 9;
            this.labelTotalMonthExpenditure.Text = "10,001,129 VND";
            this.labelTotalMonthExpenditure.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labellabelTitleMonthExpenditure
            // 
            this.labellabelTitleMonthExpenditure.AutoSize = true;
            this.labellabelTitleMonthExpenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labellabelTitleMonthExpenditure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellabelTitleMonthExpenditure.ForeColor = System.Drawing.Color.Black;
            this.labellabelTitleMonthExpenditure.Location = new System.Drawing.Point(0, 30);
            this.labellabelTitleMonthExpenditure.Margin = new System.Windows.Forms.Padding(0);
            this.labellabelTitleMonthExpenditure.Name = "labellabelTitleMonthExpenditure";
            this.labellabelTitleMonthExpenditure.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.labellabelTitleMonthExpenditure.Size = new System.Drawing.Size(394, 30);
            this.labellabelTitleMonthExpenditure.TabIndex = 8;
            this.labellabelTitleMonthExpenditure.Text = "Total Expenditures In This Month";
            this.labellabelTitleMonthExpenditure.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelTotalMonthIncome
            // 
            this.labelTotalMonthIncome.AutoSize = true;
            this.labelTotalMonthIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalMonthIncome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMonthIncome.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelTotalMonthIncome.Location = new System.Drawing.Point(394, 0);
            this.labelTotalMonthIncome.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalMonthIncome.Name = "labelTotalMonthIncome";
            this.labelTotalMonthIncome.Padding = new System.Windows.Forms.Padding(0, 0, 28, 0);
            this.labelTotalMonthIncome.Size = new System.Drawing.Size(394, 30);
            this.labelTotalMonthIncome.TabIndex = 7;
            this.labelTotalMonthIncome.Text = "10,001,129 VND";
            this.labelTotalMonthIncome.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelTitleMonthIncome
            // 
            this.labelTitleMonthIncome.AutoSize = true;
            this.labelTitleMonthIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleMonthIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleMonthIncome.ForeColor = System.Drawing.Color.Black;
            this.labelTitleMonthIncome.Location = new System.Drawing.Point(0, 0);
            this.labelTitleMonthIncome.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleMonthIncome.Name = "labelTitleMonthIncome";
            this.labelTitleMonthIncome.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.labelTitleMonthIncome.Size = new System.Drawing.Size(394, 30);
            this.labelTitleMonthIncome.TabIndex = 6;
            this.labelTitleMonthIncome.Text = "Total Income In This Month";
            this.labelTitleMonthIncome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chartMonthCashFlow);
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(32, 12, 32, 32);
            this.panel1.Size = new System.Drawing.Size(788, 922);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelCurrentTransactions);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(32, 404);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel2.Size = new System.Drawing.Size(724, 486);
            this.panel2.TabIndex = 11;
            // 
            // panelCurrentTransactions
            // 
            this.panelCurrentTransactions.AutoScroll = true;
            this.panelCurrentTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentTransactions.Location = new System.Drawing.Point(0, 73);
            this.panelCurrentTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.panelCurrentTransactions.Name = "panelCurrentTransactions";
            this.panelCurrentTransactions.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.panelCurrentTransactions.Size = new System.Drawing.Size(724, 413);
            this.panelCurrentTransactions.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(724, 53);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkViolet;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(724, 53);
            this.label8.TabIndex = 3;
            this.label8.Text = "Current Transactions";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartMonthCashFlow
            // 
            chartArea9.Name = "ChartArea1";
            this.chartMonthCashFlow.ChartAreas.Add(chartArea9);
            this.chartMonthCashFlow.Dock = System.Windows.Forms.DockStyle.Top;
            legend9.Name = "Legend1";
            this.chartMonthCashFlow.Legends.Add(legend9);
            this.chartMonthCashFlow.Location = new System.Drawing.Point(32, 12);
            this.chartMonthCashFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMonthCashFlow.Name = "chartMonthCashFlow";
            this.chartMonthCashFlow.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series9.BorderColor = System.Drawing.Color.Black;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            series9.IsValueShownAsLabel = true;
            series9.IsXValueIndexed = true;
            series9.LabelBackColor = System.Drawing.Color.White;
            series9.LabelBorderColor = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.Name = "Cash Flow";
            this.chartMonthCashFlow.Series.Add(series9);
            this.chartMonthCashFlow.Size = new System.Drawing.Size(724, 392);
            this.chartMonthCashFlow.TabIndex = 10;
            this.chartMonthCashFlow.Text = "chart1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(788, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthCashFlow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddNewTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelTotalMonthExpenditure;
        private System.Windows.Forms.Label labellabelTitleMonthExpenditure;
        private System.Windows.Forms.Label labelTotalMonthIncome;
        private System.Windows.Forms.Label labelTitleMonthIncome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthCashFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCurrentTransactions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label8;
    }
}