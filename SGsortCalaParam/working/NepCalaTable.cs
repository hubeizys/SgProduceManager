using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGsortCalaParam.working
{
    public partial class NepCalaTable : UserControl
    {
        public NepCalaTable()
        {
            InitializeComponent();
        }
        public string 
        JSDianshu {
            get { return this.textEdit_zongdianshu.Text.ToString(); }
            set { this.textEdit_zongdianshu.Text = value; }
        }

        public string
            GDDaoshu
        {
            get { return this.textEdit_zongdaoshu.Text.ToString(); }
            set { this.textEdit_zongdaoshu.Text = value; }
        }

        public string 
            CJPaoco
        {
            get { return this.textEdit_paoci.Text.ToString(); }
            set { this.textEdit_paoci.Text = value; }
        }
        
        public string
            JSDaoshu
            {
                get { return this.textEdit_jsdaoshu.Text.ToString(); }
                set { this.textEdit_jsdaoshu.Text = value; }
            }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            DataTable nn = new DataTable();
            this.gridControl1.DataSource = nn;
        }
    }
}
