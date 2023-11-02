namespace CentosCashFlow.ChildForms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePickerOverview = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTotalExpenditures = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.chartMoneyOut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelExpendituresMonth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTotalIncome = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.chartMoneyIn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelIncomeMonth = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyOut)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyIn)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 36);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePickerOverview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(35, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 30);
            this.panel3.TabIndex = 6;
            // 
            // dateTimePickerOverview
            // 
            this.dateTimePickerOverview.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePickerOverview.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerOverview.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerOverview.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerOverview.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerOverview.MaximumSize = new System.Drawing.Size(210, 28);
            this.dateTimePickerOverview.MinimumSize = new System.Drawing.Size(210, 28);
            this.dateTimePickerOverview.Name = "dateTimePickerOverview";
            this.dateTimePickerOverview.Size = new System.Drawing.Size(210, 28);
            this.dateTimePickerOverview.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTotalExpenditures);
            this.panel2.Controls.Add(this.tableLayoutPanel6);
            this.panel2.Controls.Add(this.chartMoneyOut);
            this.panel2.Controls.Add(this.tableLayoutPanel5);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panelTotalIncome);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Controls.Add(this.chartMoneyIn);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(32, 10, 32, 32);
            this.panel2.Size = new System.Drawing.Size(823, 1711);
            this.panel2.TabIndex = 8;
            // 
            // panelTotalExpenditures
            // 
            this.panelTotalExpenditures.AutoScroll = true;
            this.panelTotalExpenditures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalExpenditures.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotalExpenditures.Location = new System.Drawing.Point(32, 1316);
            this.panelTotalExpenditures.Margin = new System.Windows.Forms.Padding(0);
            this.panelTotalExpenditures.Name = "panelTotalExpenditures";
            this.panelTotalExpenditures.Padding = new System.Windows.Forms.Padding(16);
            this.panelTotalExpenditures.Size = new System.Drawing.Size(759, 350);
            this.panelTotalExpenditures.TabIndex = 27;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(32, 1276);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(759, 40);
            this.tableLayoutPanel6.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(759, 40);
            this.label15.TabIndex = 1;
            this.label15.Text = "Expenditures list";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartMoneyOut
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMoneyOut.ChartAreas.Add(chartArea1);
            this.chartMoneyOut.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chartMoneyOut.Legends.Add(legend1);
            this.chartMoneyOut.Location = new System.Drawing.Point(32, 935);
            this.chartMoneyOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMoneyOut.Name = "chartMoneyOut";
            this.chartMoneyOut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            series1.Legend = "Legend1";
            series1.Name = "Money out";
            this.chartMoneyOut.Series.Add(series1);
            this.chartMoneyOut.Size = new System.Drawing.Size(759, 341);
            this.chartMoneyOut.TabIndex = 25;
            this.chartMoneyOut.Text = "chart2";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.LightCoral;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label10, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelExpendituresMonth, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(32, 855);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(759, 80);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(382, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 40);
            this.label10.TabIndex = 3;
            this.label10.Text = "15.000.000 VND";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(373, 40);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExpendituresMonth
            // 
            this.labelExpendituresMonth.AutoSize = true;
            this.labelExpendituresMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExpendituresMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpendituresMonth.ForeColor = System.Drawing.Color.White;
            this.labelExpendituresMonth.Location = new System.Drawing.Point(3, 0);
            this.labelExpendituresMonth.Name = "labelExpendituresMonth";
            this.labelExpendituresMonth.Size = new System.Drawing.Size(373, 40);
            this.labelExpendituresMonth.TabIndex = 0;
            this.labelExpendituresMonth.Text = "Expenditures";
            this.labelExpendituresMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(32, 821);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 34);
            this.panel1.TabIndex = 23;
            // 
            // panelTotalIncome
            // 
            this.panelTotalIncome.AutoScroll = true;
            this.panelTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotalIncome.Location = new System.Drawing.Point(32, 471);
            this.panelTotalIncome.Margin = new System.Windows.Forms.Padding(0);
            this.panelTotalIncome.Name = "panelTotalIncome";
            this.panelTotalIncome.Padding = new System.Windows.Forms.Padding(16);
            this.panelTotalIncome.Size = new System.Drawing.Size(759, 350);
            this.panelTotalIncome.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(32, 431);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(759, 40);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(759, 40);
            this.label14.TabIndex = 0;
            this.label14.Text = "Income list";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartMoneyIn
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMoneyIn.ChartAreas.Add(chartArea2);
            this.chartMoneyIn.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chartMoneyIn.Legends.Add(legend2);
            this.chartMoneyIn.Location = new System.Drawing.Point(32, 90);
            this.chartMoneyIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMoneyIn.Name = "chartMoneyIn";
            this.chartMoneyIn.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Money in";
            this.chartMoneyIn.Series.Add(series2);
            this.chartMoneyIn.Size = new System.Drawing.Size(759, 341);
            this.chartMoneyIn.TabIndex = 7;
            this.chartMoneyIn.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelIncomeMonth, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(32, 10);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(759, 80);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(379, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(380, 40);
            this.label9.TabIndex = 3;
            this.label9.Text = "15.000.000 VND";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(379, 40);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIncomeMonth
            // 
            this.labelIncomeMonth.AutoSize = true;
            this.labelIncomeMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIncomeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncomeMonth.ForeColor = System.Drawing.Color.White;
            this.labelIncomeMonth.Location = new System.Drawing.Point(0, 0);
            this.labelIncomeMonth.Margin = new System.Windows.Forms.Padding(0);
            this.labelIncomeMonth.Name = "labelIncomeMonth";
            this.labelIncomeMonth.Size = new System.Drawing.Size(379, 40);
            this.labelIncomeMonth.TabIndex = 0;
            this.labelIncomeMonth.Text = "Income";
            this.labelIncomeMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(844, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Overview";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyOut)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyIn)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoneyIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelIncomeMonth;
        private System.Windows.Forms.Panel panelTotalExpenditures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoneyOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelExpendituresMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTotalIncome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePickerOverview;
    }
}