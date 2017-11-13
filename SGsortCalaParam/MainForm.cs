using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SGsortCalaParam.working;
using DevExpress.XtraTab;

namespace SGsortCalaParam
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        working.NepCalaTable active_nepCalaTable = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void bt_chongfupailiemaizhijisuan_Click(object sender, EventArgs e)
        {
            shunpaoxian _l_spx = new shunpaoxian();
            _l_spx.Dock = DockStyle.Fill;
            _l_spx.TopLevel = false;
            this.xtraTabControl1.SelectedTabPage.Controls.Add(_l_spx);
            _l_spx.BringToFront();
            _l_spx.Show();
        }

        private void bt_zhuangbei_touru_Click(object sender, EventArgs e)
        {
            CCForm cc = new CCForm();
            cc.Dock = DockStyle.Fill;
            cc.TopLevel = false;
            this.xtraTabControl1.SelectedTabPage.Controls.Add(cc);
            cc.BringToFront();
            cc.Show();
        }

        private void sb_newwork_Click(object sender, EventArgs e)
        {
            XtraTabPage xinka = new XtraTabPage();
            xinka.Name = "xin";
            xinka.Text = "新工作区";
            NepCalaTable xintab = new NepCalaTable();
            xintab.Dock = DockStyle.Fill;
            xinka.Controls.Add(xintab);
            this.xtraTabControl1.TabPages.Add(xinka);
            this.xtraTabControl1.SelectedTabPage = xinka;
            this.active_nepCalaTable = xintab;
        }

        public  string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs EArg = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            Console.WriteLine(this.xtraTabControl1.ShowHeaderFocus.ToString());
            this.xtraTabControl1.TabPages.RemoveAt(this.xtraTabControl1.SelectedTabPageIndex);
        }

        private void textEdit1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void textEdit1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_DoubleClick(object sender, EventArgs e)
        {
            if (this.textEdit1.Enabled)
            {
                this.textEdit1.Enabled = false;
                this.xtraTabControl1.SelectedTabPage.Text = this.textEdit1.Text;
            }
            else
            {
                this.textEdit1.Enabled = true;
            }
        }

        private void sb_rename_Click(object sender, EventArgs e)
        {
            if (this.textEdit1.Enabled)
            {
                this.textEdit1.Enabled = false;
                this.xtraTabControl1.SelectedTabPage.Text = this.textEdit1.Text;
            }
            else
            {
                this.textEdit1.Enabled = true;
            }
        }
    }
}