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
            //cc.ShowDialog();
            cc.Dock = DockStyle.Fill;
            cc.TopLevel = false;
            this.xtraTabControl1.SelectedTabPage.Controls.Add(cc);
            cc.BringToFront();
            cc.Show();
        }
    }
}