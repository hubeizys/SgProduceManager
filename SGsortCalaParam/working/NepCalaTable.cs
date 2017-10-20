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
        private DataTable dt = new DataTable();


        public DataTable DDT {
            set { this.dt = value; }
            get { return this.dt; }
        }

        public void reflash()
        {
            if (this.gridControl1 != null)
            {
                gridControl1.RefreshDataSource();
            }
        }


        /*
         *                     dr["bushe_xianshu"] = Convert.ToString(i);
                    dr["bushe_daoshu"] = Convert.ToString(i);
                    dr["bushe_zongdaoshu"] = Convert.ToString(i);
                    dr["banqian_daoshu"] = Convert.ToString(i);
                    dr["ke_caiji"] = Convert.ToString(i);
                    dr["banjia_daoshu"] = Convert.ToString(i);
                    dr["hengxiangchang"] = Convert.ToString(i);
                    dr["zongxiangchang"] = Convert.ToString(i);
                    dr["zonghengbi"] = Convert.ToString(i);
         */

        public NepCalaTable()
        {
            dt.Columns.Add("bushe_xianshu", Type.GetType("System.String"));
            dt.Columns.Add("bushe_daoshu", Type.GetType("System.String"));
            dt.Columns.Add("bushe_zongdaoshu", Type.GetType("System.String"));
            dt.Columns.Add("banqian_daoshu", Type.GetType("System.String"));
            dt.Columns.Add("ke_caiji", Type.GetType("System.String"));
            dt.Columns.Add("banjia_daoshu", Type.GetType("System.String"));
            dt.Columns.Add("hengxiangchang", Type.GetType("System.String"));
            dt.Columns.Add("zongxiangchang", Type.GetType("System.String"));
            dt.Columns.Add("zonghengbi", Type.GetType("System.String"));    
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



        #region （15）布设接受线单线接收道数 =（布设激发线数-1）*纵向滚动道数+接收点数（默认计算得出，但允许变量）
        private string Get布设接受线单线接收道数()
        {
            string bushe_jifaxianshu = "";
            return bushe_jifaxianshu;
        }
        #endregion


        #region 初始设置一下
        private void GridInit()
        {
            DataRow dr = dt.NewRow();
            dr["bushe_xianshu"] = "asdasdasdasdasdsad";
            dr["bushe_zongdaoshu"] = "sdsd";
            dt.Rows.Add(dr);

            for (int i=0 ; i <= 40 ; i++)
            {
                // 如果是偶数的话
                if (i % 2 == 0)
                {
                    dr["bushe_xianshu"] = Convert.ToString(i);
                    dr["bushe_daoshu"] = Convert.ToString(i);
                    dr["bushe_zongdaoshu"] = Convert.ToString(i);
                    dr["banqian_daoshu"] = Convert.ToString(i);
                    dr["ke_caiji"] = Convert.ToString(i);
                    dr["banjia_daoshu"] = Convert.ToString(i);
                    dr["hengxiangchang"] = Convert.ToString(i);
                    dr["zongxiangchang"] = Convert.ToString(i);
                    dr["zonghengbi"] = Convert.ToString(i);
                }
            }
            this.gridControl1.DataSource = dt;
        }
        #endregion

        private void gridControl1_Load(object sender, EventArgs e)
        {
            // this.GridInit();      
            this.gridControl1.DataSource = this.dt;          
        }
    }
}
