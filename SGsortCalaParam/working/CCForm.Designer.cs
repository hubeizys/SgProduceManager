namespace SGsortCalaParam.working
{
    partial class CCForm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.te_xmax = new DevExpress.XtraEditors.TextEdit();
            this.te_daoju = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.te_sli = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.te_nnum = new DevExpress.XtraEditors.TextEdit();
            this.te_Rnum = new DevExpress.XtraEditors.TextEdit();
            this.te_Enum = new DevExpress.XtraEditors.TextEdit();
            this.te_ShotsCell = new DevExpress.XtraEditors.TextEdit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_xmax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_daoju.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_sli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_nnum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Rnum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Enum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_ShotsCell.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(785, 622);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.SelectedPageIndex = 0;
            this.tabPane1.Size = new System.Drawing.Size(785, 622);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "tabNavigationPage1";
            this.tabNavigationPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(767, 576);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(767, 576);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "tabNavigationPage3";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(767, 576);
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(3, 153);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.View = splineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(761, 420);
            this.chartControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chartControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 576);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 144);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.te_sli);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.te_daoju);
            this.groupBox1.Controls.Add(this.te_xmax);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础值设定";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textEdit5);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.textEdit3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(267, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "快速设置";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "2*Xmax/△X";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "纵向最大偏移距（Xmax）";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(79, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "道距（△X\t）";
            // 
            // te_xmax
            // 
            this.te_xmax.Location = new System.Drawing.Point(159, 15);
            this.te_xmax.Name = "te_xmax";
            this.te_xmax.Size = new System.Drawing.Size(100, 20);
            this.te_xmax.TabIndex = 3;
            // 
            // te_daoju
            // 
            this.te_daoju.Location = new System.Drawing.Point(159, 54);
            this.te_daoju.Name = "te_daoju";
            this.te_daoju.Size = new System.Drawing.Size(100, 20);
            this.te_daoju.TabIndex = 4;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(97, 38);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(66, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "炮线距（SLI）";
            // 
            // te_sli
            // 
            this.te_sli.Location = new System.Drawing.Point(159, 92);
            this.te_sli.Name = "te_sli";
            this.te_sli.Size = new System.Drawing.Size(100, 20);
            this.te_sli.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(43, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 14);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "SLI/△X";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(97, 82);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(100, 20);
            this.textEdit5.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.te_ShotsCell);
            this.groupBox3.Controls.Add(this.te_Enum);
            this.groupBox3.Controls.Add(this.te_Rnum);
            this.groupBox3.Controls.Add(this.te_nnum);
            this.groupBox3.Controls.Add(this.labelControl9);
            this.groupBox3.Controls.Add(this.labelControl8);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.labelControl6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(484, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "变量值";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(51, 21);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(103, 14);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "增加接收线数（n）";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(75, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 14);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "接收线数（R）";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(51, 85);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(103, 14);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "投入采集道数（E）";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(9, 117);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(145, 14);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "单元模板炮数（ShotsCell）";
            // 
            // te_nnum
            // 
            this.te_nnum.Location = new System.Drawing.Point(156, 18);
            this.te_nnum.Name = "te_nnum";
            this.te_nnum.Size = new System.Drawing.Size(100, 20);
            this.te_nnum.TabIndex = 6;
            // 
            // te_Rnum
            // 
            this.te_Rnum.Location = new System.Drawing.Point(156, 50);
            this.te_Rnum.Name = "te_Rnum";
            this.te_Rnum.Size = new System.Drawing.Size(100, 20);
            this.te_Rnum.TabIndex = 7;
            // 
            // te_Enum
            // 
            this.te_Enum.Location = new System.Drawing.Point(156, 82);
            this.te_Enum.Name = "te_Enum";
            this.te_Enum.Size = new System.Drawing.Size(100, 20);
            this.te_Enum.TabIndex = 8;
            // 
            // te_ShotsCell
            // 
            this.te_ShotsCell.Location = new System.Drawing.Point(156, 114);
            this.te_ShotsCell.Name = "te_ShotsCell";
            this.te_ShotsCell.Size = new System.Drawing.Size(100, 20);
            this.te_ShotsCell.TabIndex = 9;
            // 
            // CCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 622);
            this.Controls.Add(this.tabPane1);
            this.Name = "CCForm";
            this.Text = "CCForm";
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_xmax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_daoju.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_sli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_nnum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Rnum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Enum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_ShotsCell.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit te_xmax;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit te_daoju;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit te_sli;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit te_ShotsCell;
        private DevExpress.XtraEditors.TextEdit te_Enum;
        private DevExpress.XtraEditors.TextEdit te_Rnum;
        private DevExpress.XtraEditors.TextEdit te_nnum;
    }
}