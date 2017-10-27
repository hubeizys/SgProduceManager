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
        // 每次用微软的技术 我都有种 我是弱智的感觉 
        // 总是有各种匪夷所思的现象发生， 时时刻刻的侮辱我的智商。 
        // DataTable  在外面new  居然 给我凭空的多出了 我预想要add的 列名 。 还强制个给我设定string 类型 
        // 我感觉我的智商受到了侮辱。 
        private DataTable dt;
        public DataTable DDT {
            set { this.dt = value; }
            get { return  this.dt; }
        }

        public void reflash()
        {
   
            if (this.gridControl1 != null)
            {
                gridControl1.RefreshDataSource();
            }
        }



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



        #region （15）布设接受线单线接收道数 =（布设激发线数-1）*纵向滚动道数+接收点数（默认计算得出，但允许变量）

        private string Get布设接受线单线接收道数()
        {
            string bushe_jifaxianshu = "";
            return bushe_jifaxianshu;
        }
        #endregion


        private void gridControl1_Load(object sender, EventArgs e)
        {

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

        private void NepCalaTable_Load(object sender, EventArgs e)
        {
            dt  = new DataTable();

            dt.Columns.Add("bushe_xianshu", typeof(int));
            //MessageBox.Show(dt.Columns["bushe_xianshu"].DataType.ToString());
            dt.Columns.Add("bushe_daoshu", typeof(int));
            dt.Columns.Add("bushe_zongdaoshu", typeof(int));
            dt.Columns.Add("banqian_daoshu", typeof(int));
            dt.Columns.Add("ke_caiji", typeof(int));
            dt.Columns.Add("banjia_daoshu", typeof(int));
            dt.Columns.Add("hengxiangchang", typeof(int));
            dt.Columns.Add("zongxiangchang", typeof(int));
            dt.Columns.Add("zonghengbi", typeof(double));

            foreach (DataColumn dc in dt.Columns)
            {
                Console.Write(string.Format("列名：{0} ,数据类型：{1}\n", dc.ColumnName, dc.DataType));
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int i = this.gridView1.FocusedRowHandle;
                //MessageBox.Show(string.Format("将要操作 第{0}行", i));
                Console.WriteLine(string.Format("将要操作 第{0}行", i));
            }
        }
    }
}
