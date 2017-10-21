using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

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


        #region 重复排列埋置数量=（（15）布设接受线单线接收道数*施工轮次（新
        //变量）-整个工区设计单接收线道数（新变量））*整个工区设计接收线条数（新
        //变量））

        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        #region 投入采集道数
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_jieshoudianshu"> 接收点数</param>
        /// <param name="p_jifaxianju">激发线距 -- （炮线距）</param>
        /// <param name="p_daoju">道距 -- （接收点距）</param>
        /// <param name="p_jieshouxianshu">接收线数</param>
        /// <param name="pz_paoxianshu">增加炮线数</param>
        /// <param name="pz_jieshouxianshu">增加接收线数</param>
        /// <returns></returns>
        private int Get投入采集道数(int p_jieshoudianshu, int p_jifaxianju, int p_daoju, int p_jieshouxianshu, int pz_paoxianshu, int pz_jieshouxianshu)
        {
            int ret_e = (p_jieshoudianshu + (p_jifaxianju / p_daoju * pz_paoxianshu)) * (pz_jieshouxianshu * p_jieshouxianshu);
            return ret_e;
        }
        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int i_jieshoudianshu;
            int i_jiefaxianju;
            int i_daoju;
            int i_jieshouxianshu;
            int iz_paoxianshu;
            int iz_jieshouxianshu;

            #region 判断参数是不是正常  、、  正常情况下不应该依赖于 异常抓取 。 （请以此为戒）
            try
            {
                //接收点数
                string t_jieshoudianshu = this.textEdit_jieshoudianshu1.EditValue.ToString();
                i_jieshoudianshu = Convert.ToInt32(t_jieshoudianshu);

                // 激发线距 
                string t_jiefaxianju = this.textEdit_paoxianju1.EditValue.ToString();
                i_jiefaxianju = Convert.ToInt32(t_jiefaxianju);

                // 道距
                string t_daoju = this.textEdit_daoju1.EditValue.ToString();
                i_daoju = Convert.ToInt32(t_daoju);

                // 接收线距
                string t_jieshouxianshu = this.textEdit_jieshouxianshu1.EditValue.ToString();
                i_jieshouxianshu = Convert.ToInt32(t_jieshouxianshu);

                // 增加 炮线数 
                string tz_paoxianshu = this.textEdit_zjpaoxianshu1.EditValue.ToString();
                iz_paoxianshu = Convert.ToInt32(tz_paoxianshu);

                // 增加 接收线数
                string tz_jieshouxianshu = this.textEdit_zjjieshouxianshu1.EditValue.ToString();
                iz_jieshouxianshu = Convert.ToInt32(tz_jieshouxianshu);  
            }
            catch (NullReferenceException err)
            {
                MessageBox.Show(string.Format( "有相关的变量没有填写上去 {0}", err.Message));
                return;
            }
            #endregion



            try
            {
                this.chartControl1.Series["设备数"].Points.Clear();

                for (int i = 1;i<= iz_jieshouxianshu; i++)
                {
                    int pot_value = this.Get投入采集道数(i_jieshoudianshu, i_jiefaxianju, i_daoju, i_jieshouxianshu, iz_paoxianshu, i);
                    this.chartControl1.Series["设备数"].Points.Add(new SeriesPoint(i, pot_value));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format(" 生成节点出现了错误 {0}", err.Message ));
            }

        }

        #region 激发炮数
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pz_paoxianshu">增加炮线数</param>
        /// <param name="pz_jieshouxianshu">接收线数</param>
        /// <param name="P_danyuanmuban">单元模板炮数</param>
        /// <returns></returns>
        private int Get激发炮数(int pz_paoxianshu, int pz_jieshouxianshu, int P_danyuanmuban)
        {
            int r_jifapaoshu = (pz_paoxianshu + 1) * (pz_jieshouxianshu + 1) * P_danyuanmuban;
            return r_jifapaoshu;
        }
        #endregion



        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int i_pz_paoxianshu;
            int i_pz_jieshouxianshu;
            int i_P_danyuanmuban;
            try
            {
                string t_pz_paoxianshu = textEdit_zjpaoxianshu2.EditValue.ToString();
                i_pz_paoxianshu = Convert.ToInt32(t_pz_paoxianshu);

                string t_pz_jieshouxianshu = textEdit_zjjieshouxianshu2.EditValue.ToString();
                i_pz_jieshouxianshu = Convert.ToInt32(t_pz_jieshouxianshu);

                string t_P_danyuanmuban = textEdit_mubanpaoshu2.EditValue.ToString();
                i_P_danyuanmuban = Convert.ToInt32(t_P_danyuanmuban);


            }
            catch (NullReferenceException err)
            {
                MessageBox.Show(string.Format("有相关的变量没有填写上去 {0}", err.Message));
                return;
            }

            try
            {
                this.chartControl2.Series["激发炮数"].Points.Clear();
                for (int i = 1; i <= i_pz_paoxianshu; i++)
                {
                    int pot_value = Get激发炮数(i, i_pz_jieshouxianshu, i_P_danyuanmuban);
                    this.chartControl2.Series["激发炮数"].Points.Add(new SeriesPoint(i, pot_value));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format(" 生成节点出现了错误 {0}", err.Message));
            }
        }
    }
}
