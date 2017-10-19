namespace SGsortCalaParam.working
{
    partial class NepCalaTable
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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3});
            this.navigationPane1.RegularSize = new System.Drawing.Size(900, 600);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.SelectedPageIndex = 0;
            this.navigationPane1.Size = new System.Drawing.Size(900, 600);
            this.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Collapsed;
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "图1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "图表1";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(0, 900);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "图表2";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(0, 900);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "图表3";
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(0, 900);
            // 
            // NepCalaTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationPane1);
            this.Name = "NepCalaTable";
            this.Size = new System.Drawing.Size(900, 600);
            this.navigationPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
    }
}
