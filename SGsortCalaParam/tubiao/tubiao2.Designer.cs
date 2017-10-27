namespace SGsortCalaParam.tubiao
{
    partial class tubiao2
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
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_mubanpaoshu2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_zjjieshouxianshu2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_zjpaoxianshu2 = new DevExpress.XtraEditors.TextEdit();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_mubanpaoshu2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_zjjieshouxianshu2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_zjpaoxianshu2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(460, 23);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(72, 14);
            this.labelControl17.TabIndex = 30;
            this.labelControl17.Text = "单元模板炮数";
            // 
            // textEdit_mubanpaoshu2
            // 
            this.textEdit_mubanpaoshu2.Location = new System.Drawing.Point(538, 20);
            this.textEdit_mubanpaoshu2.Name = "textEdit_mubanpaoshu2";
            this.textEdit_mubanpaoshu2.Size = new System.Drawing.Size(100, 20);
            this.textEdit_mubanpaoshu2.TabIndex = 29;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton3.Location = new System.Drawing.Point(659, 17);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(100, 29);
            this.simpleButton3.TabIndex = 28;
            this.simpleButton3.Text = "运算";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(224, 23);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(103, 14);
            this.labelControl15.TabIndex = 27;
            this.labelControl15.Text = "增加接收线数（n）";
            // 
            // textEdit_zjjieshouxianshu2
            // 
            this.textEdit_zjjieshouxianshu2.Location = new System.Drawing.Point(333, 20);
            this.textEdit_zjjieshouxianshu2.Name = "textEdit_zjjieshouxianshu2";
            this.textEdit_zjjieshouxianshu2.Size = new System.Drawing.Size(100, 20);
            this.textEdit_zjjieshouxianshu2.TabIndex = 26;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(18, 23);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(94, 14);
            this.labelControl16.TabIndex = 25;
            this.labelControl16.Text = "增加炮线数（m）";
            // 
            // textEdit_zjpaoxianshu2
            // 
            this.textEdit_zjpaoxianshu2.Location = new System.Drawing.Point(118, 20);
            this.textEdit_zjpaoxianshu2.Name = "textEdit_zjpaoxianshu2";
            this.textEdit_zjpaoxianshu2.Size = new System.Drawing.Size(100, 20);
            this.textEdit_zjpaoxianshu2.TabIndex = 24;
            // 
            // chartControl2
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Location = new System.Drawing.Point(5, 60);
            this.chartControl2.Name = "chartControl2";
            series1.Name = "激发炮数";
            series1.View = splineSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl2.Size = new System.Drawing.Size(767, 480);
            this.chartControl2.TabIndex = 23;
            // 
            // tubiao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 548);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.textEdit_mubanpaoshu2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.textEdit_zjjieshouxianshu2);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.textEdit_zjpaoxianshu2);
            this.Controls.Add(this.chartControl2);
            this.Name = "tubiao2";
            this.Text = "tubiao2";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_mubanpaoshu2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_zjjieshouxianshu2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_zjpaoxianshu2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit textEdit_mubanpaoshu2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit textEdit_zjjieshouxianshu2;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit textEdit_zjpaoxianshu2;
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}