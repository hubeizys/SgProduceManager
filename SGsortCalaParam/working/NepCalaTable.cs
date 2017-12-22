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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

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
            set { this.gridControl1.DataSource = value; this.Refresh(); }
            get { return  this.dt; }
        }
        
        public GridView GC { get { return this.gridView1; } }

        public DataTable GCDS { get { return this.gridControl1.DataSource as DataTable; } }

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

        /*
        public string
            GDDaoshu
        {
            get { return this.mobanpao.Text.ToString(); }
            set { this.mobanpao.Text = value; }
        }*/
        public string
            GDDaoshu{get;set;}

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


        /*
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
        */

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


        /*

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
        */
        private void NepCalaTable_Load(object sender, EventArgs e)
        {
            this.createTable();
        }

        private void createTable()
        {
            dt = new DataTable();
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
            dt.Columns.Add("paodaobi", typeof(double));
            foreach (DataColumn dc in dt.Columns)
            {
                Console.Write(string.Format("列名：{0} ,数据类型：{1}\n", dc.ColumnName, dc.DataType));
            }
        }

        /// <summary>
        /// 插入行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int i = this.gridView1.FocusedRowHandle;
            if (i < 0)
            {
                return;
            }
            // MessageBox.Show("asdasdasdasd :" +  i);
            DataTable dt =  this.DDT;

            DataRow dr = dt.NewRow();
            foreach (DataColumn dc in dr.Table.Columns)
            {
                if (dr[dc.ColumnName].GetType() == typeof(int))
                { dr[dc.ColumnName] = 0; }
                else
                {
                    dr[dc.ColumnName] = 0;
                }
            }

            dt.Rows.InsertAt(dr, i);
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


        #region 总接收点数 =接收线数*接收点数
        private void Get总接收点数()
        {
            string dianshu = jieshou_dianshu.EditValue.ToString();
            Int32 i_dianshu = Convert.ToInt32(dianshu);
            string xianshu = jieshou_xianshu.EditValue.ToString();
            Int32 i_xianshu = Convert.ToInt32(xianshu);


            Console.WriteLine("jieshou_dianshu := " + jieshou_dianshu.Text);
            // 当前工作区项目
            this.JSDianshu = Convert.ToString(i_xianshu * i_dianshu);
        }
        #endregion

        #region（11）纵向滚动道数 =激发线距/接收点距
        private void Get纵向滚动道数()
        {
            string jifa = jifa_xianju.EditValue.ToString();
            Int32 i_jifa = Convert.ToInt32(jifa);
            string jieshou = jieshou_dianju.EditValue.ToString();
            Int32 i_jieshou = Convert.ToInt32(jieshou);
            this.GDDaoshu = Convert.ToString(i_jifa / i_jieshou);
        }
        #endregion

        #region （13）布设排列片可采集炮次 =[（布设接收线数-接受线数）*接收线距/模板纵向滚动距离+1]*模板炮
        private void Get布设排列片可采集炮次()
        {
            //布设接收线数
            string bushe_jieshou = bushe_jieshouxianshu.EditValue.ToString();
            Int32 i_bushe_jieshou = Convert.ToInt32(bushe_jieshou);

            // 接受线数
            string js_xianshu = jieshou_xianshu.EditValue.ToString();
            Int32 i_js_xianshu = Convert.ToInt32(js_xianshu);

            // 接收线距
            string js_xianju = jieshou_xianju.EditValue.ToString();
            Int32 i_js_xianju = Convert.ToInt32(js_xianju);

            // 模板纵向滚动距离
            string mb_zongxiang = muban_zong.EditValue.ToString();
            Int32 i_mb_zongxiang = Convert.ToInt32(mb_zongxiang);

            // m
            string mb_pao = mobanpao.EditValue.ToString();
            Int32 i_mb_pao = Convert.ToInt32(mb_pao);



            Int32 bushe_pailie_kecaijipaoci = (((i_bushe_jieshou - i_js_xianshu) * i_js_xianju) / i_mb_zongxiang + 1) * i_mb_pao;


            // 布设排列片可采集炮次 
            string i_bushe_pailie_kecaijipaoci = Convert.ToString(bushe_pailie_kecaijipaoci);
            this.CJPaoco = i_bushe_pailie_kecaijipaoci;
        }
        #endregion

        #region 布设接受线单线接收道数 =（布设激发线数-1）*纵向滚动道数+接收点数（默认计算得出，但允许变量）
        private int Get布设接受线单线接收道数(Int32 p_bushe_jifashu)
        {
            int r_bushe = 0;
            try
            {
                string GunDongDaoshu = this.GDDaoshu;
                int i_GD_Daoshu = Convert.ToInt32(GunDongDaoshu);
                r_bushe = (i_GD_Daoshu * (p_bushe_jifashu - 1)) + Convert.ToInt32(jieshou_dianshu.EditValue);
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【布设接受线单线接收道数】出现异常 : {0}", err));
            }
            return r_bushe;
        }
        #endregion

        #region （16）布设排列总道数 =（15）布设接受线单线接收道数*（12）布设接收线数
        private int Get布设排列总道数(Int32 p_bushe_danxiandaoshu)
        {
            int r_bushe_pailie = 0;
            try
            {
                string t_bushe_jieshouxianshu = bushe_jieshouxianshu.EditValue.ToString();
                int i_bushe_jieshouxianshu = Convert.ToInt32(t_bushe_jieshouxianshu);
                r_bushe_pailie = p_bushe_danxiandaoshu * i_bushe_jieshouxianshu;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【布设排列总道数】出现异常 : {0}", err));
            }
            return r_bushe_pailie;
        }
        #endregion

        #region （17）搬迁道数 =（14）布设激发线数*（11）纵向滚动道数*（12）布设接收线数
        private int Get搬迁道数(Int32 p_bushe_jifashu)
        {
            int r_banqian_daoshu = 0;
            try
            {
                string GunDongDaoshu = this.GDDaoshu;
                int i_GD_Daoshu = Convert.ToInt32(GunDongDaoshu);

                string t_bushe_jieshouxianshu = bushe_jieshouxianshu.EditValue.ToString();
                int i_bushe_jieshouxianshu = Convert.ToInt32(t_bushe_jieshouxianshu);
                r_banqian_daoshu = p_bushe_jifashu * i_GD_Daoshu * i_bushe_jieshouxianshu;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【搬迁道数】出现异常 : {0}", err));
            }
            return r_banqian_daoshu;

        }
        #endregion

        #region （18）可采集炮次 =（14）布设激发线数*（13）布设排列片可采集炮次
        private int Get可采集炮次(Int32 p_bushe_jifashu)
        {
            int r_kecaiji_paoci = 0;
            try
            {
                string kecaiji_paoci = this.CJPaoco;
                Int32 i_kecaiji_paoci = Convert.ToInt32(kecaiji_paoci);
                r_kecaiji_paoci = p_bushe_jifashu * i_kecaiji_paoci;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【可采集炮次】出现异常 : {0}", err));
            }
            return r_kecaiji_paoci;
        }
        #endregion

        #region （19）搬家排列道数 =（18）可采集炮次/（14）布设激发线数/模板炮*（15）布设接受线单线接收道数

        private int Get搬家排列道数(Int32 p_bushe_jifashu, int ke_caiji, int p_bushe_danxian_jieshou)
        {
            int r_banjia_pailie_daoshu = 0;
            try
            {
                string t_mobanpao = this.mobanpao.EditValue.ToString();
                int i_mobanpao = Convert.ToInt32(t_mobanpao);
                if (p_bushe_jifashu == 0)
                {
                    r_banjia_pailie_daoshu = 0;
                }
                else
                {
                    r_banjia_pailie_daoshu = ke_caiji / p_bushe_jifashu / i_mobanpao * p_bushe_danxian_jieshou;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【搬家排列道数】出现异常 : {0}", err));
            }
            return r_banjia_pailie_daoshu;
        }
        #endregion

        #region （20）横向长度 =(（15）布设接受线单线接收道数-1)*道距
        private int Get横向长度(Int32 p_bushe_jieshoudaoshu)
        {
            int r_hengxiangchangdu = 0;
            try
            {
                string t_jieshou_dianju = jieshou_dianju.EditValue.ToString();
                int i_jieshou_dianju = Convert.ToInt32(t_jieshou_dianju);
                r_hengxiangchangdu = (p_bushe_jieshoudaoshu - 1) * i_jieshou_dianju;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【横向长度】出现异常 : {0}", err));
            }
            return r_hengxiangchangdu;
        }
        #endregion

        #region （21）纵向长度 =接收线距*（布设接收线数-1）
        private int Get纵向长度()
        {
            int r_zongxiang_changdu = 0;
            try
            {
                string t_jieshou_xianju = jieshou_xianju.EditValue.ToString();
                Int32 i_jieshou_xianju = Convert.ToInt32(t_jieshou_xianju);

                string t_jieshou_xianshu = bushe_jieshouxianshu.EditValue.ToString();
                Int32 i_jieshou_xianshu = Convert.ToInt32(t_jieshou_xianshu);

                r_zongxiang_changdu = i_jieshou_xianju * (i_jieshou_xianshu - 1);
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【纵向长度】出现异常 : {0}", err));
            }

            return r_zongxiang_changdu;
        }


        #endregion


        #region 炮道比 = （18 ）采集炮次 / （16） 布设排列总道数
        private string Get炮道比(Int32 p_caijipaoci, Int32 p_bushe_pailiezongdaosuh)
        {
            Console.WriteLine("采集炮次 == "  + p_caijipaoci + " == " + p_bushe_pailiezongdaosuh);
            if (p_bushe_pailiezongdaosuh <= 0)
            {
                MessageBox.Show("布设排列总道数有错误");
                return "-1";
            }
            string str1 = String.Format("{0:N2}", (double)p_caijipaoci / (double)p_bushe_pailiezongdaosuh);
            // MessageBox.Show(str1);
            //MessageBox.Show(((float)((double)p_caijipaoci / (double)p_bushe_pailiezongdaosuh)).ToString() );
            Console.WriteLine("str 1 ;  " +  str1);
            return str1;
            //return Math.Round( (double)p_caijipaoci / (double)p_bushe_pailiezongdaosuh, 2);
        }
        #endregion

        #region （22）纵横比 =纵/横（保留小数点后 2 位）

        private string Get纵横比(int p_zong, int p_heng)
        {
            double r_zhonghengbi = 0;
            string sr_zhonghengbi = "1.00";
            try
            {
                r_zhonghengbi = (double)p_zong / (double)p_heng;
                // r_zhonghengbi = Math.Round(r_zhonghengbi, 2);
                sr_zhonghengbi =  string.Format("{0:00.00}", r_zhonghengbi);
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【纵横比】出现异常 : {0}", err));
            }
            return sr_zhonghengbi;
        }

        #endregion

        #region 初始设置一下
        private void GridInit()
        {
            // 获得范围
            int i_bushe_jifaxianshu;
            if( !Int32.TryParse(bushe_jifaxianshu.Text, out i_bushe_jifaxianshu))
            {
                MessageBox.Show("布设激发线数好像不正常");
                return;
            }

            int _i_start = 0;
            if (i_bushe_jifaxianshu <= 20)
            {
                _i_start = 1;
            }
            else
            {
                _i_start = i_bushe_jifaxianshu - 20;
            }

            int _i_end = 0;
            if (i_bushe_jifaxianshu < 0)
            {
                _i_end = 20;
            }
            else
            {
                _i_end = i_bushe_jifaxianshu + 20;
            }

            DataTable dt = this.DDT;
            if (_i_start != 1)
            {
                GetOnce(1);
            }
            for (int i = _i_start; i <= _i_end; i++)
            {
                GetOnce(i);
            }
            Console.WriteLine(" this.DDT.Rows.Count   : == " + this.DDT.Rows.Count);
            this.gridControl1.DataSource = this.DDT;
            this.reflash();
        }
        #endregion

        private void GetOnce(int i)
        {
            DataRow dr = this.dt.NewRow();
            dt.Rows.Add(dr);
            dr["bushe_xianshu"] = Convert.ToInt32(i);
            dr["bushe_daoshu"] = Get布设接受线单线接收道数(i).ToString();
            dr["bushe_zongdaoshu"] = Get布设排列总道数(Convert.ToInt32(dr["bushe_daoshu"])).ToString();
            dr["banqian_daoshu"] = Get搬迁道数(i).ToString();
            dr["ke_caiji"] = Get可采集炮次(i);
            dr["banjia_daoshu"] = Get搬家排列道数(i, Convert.ToInt32(dr["ke_caiji"]), Convert.ToInt32(dr["bushe_daoshu"]));
            dr["hengxiangchang"] = Get横向长度(Convert.ToInt32(dr["bushe_daoshu"]));
            dr["zongxiangchang"] = Get纵向长度();
            dr["zonghengbi"] = Get纵横比(Convert.ToInt32(dr["zongxiangchang"]), Convert.ToInt32(dr["hengxiangchang"]));
            dr["paodaobi"] = Get炮道比(Convert.ToInt32(dr["ke_caiji"]), Convert.ToInt32(dr["bushe_zongdaoshu"]));
        }

        #region  判断是不是整形
        private bool CheckInt(object ed_value, string name)
        {
            if (ed_value == null)
            {
                MessageBox.Show(string.Format("{0} 不能为空", name));
                return false;
            }

            int number;
            bool result = Int32.TryParse(ed_value.ToString(), out number);
            Console.WriteLine("num {0}", number);
            if (result)
            {
                return result;
            }
            MessageBox.Show(string.Format("{0} 输入的不是整形数字", name));
            return result;
        }
        #endregion

        private bool CheckAll()
        {
            if (!CheckInt(jifa_dianju.EditValue, "激发点距"))
            {
                return false;
            }

            if (!CheckInt(jifa_xianju.EditValue, "激发线距"))
            {
                return false;
            }

            if (!CheckInt(jieshou_dianju.EditValue, "接收点距"))
            {
                return false;
            }
            if (!CheckInt(jieshou_xianju.EditValue, "接收线距"))
            {
                return false;
            }
            if (!CheckInt(jieshou_xianshu.EditValue, "接收线数"))
            {
                return false;
            }
            if (!CheckInt(jieshou_dianshu.EditValue, "接收点数"))
            {
                return false;
            }
            if (!CheckInt(muban_heng.EditValue, "模板横向滚动"))
            {
                return false;
            }
            if (!CheckInt(muban_zong.EditValue, "模板纵向滚动"))
            {
                return false;
            }
            if (!CheckInt(mobanpao.EditValue, "模板炮"))
            {
                return false;
            }

            if (!CheckInt(bushe_jieshouxianshu.EditValue, "布设接收线数"))
            {
                return false;
            }

            return true;
        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (!this.CheckAll())
            {
                return;
            }
            createTable();
            this.Get总接收点数();
            this.Get纵向滚动道数();
            this.Get布设排列片可采集炮次();
            GridInit();
        }


        /// <summary>
        ///  删除行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int i = this.gridView1.FocusedRowHandle;
            if (i < 0)
            {
                return;
            }
            // MessageBox.Show("asdasdasdasd :" +  i);
            DataTable dt = this.DDT;

            /*
            DataRow dr = dt.NewRow();
            foreach (DataColumn dc in dr.Table.Columns)
            {
                if (dr[dc.ColumnName].GetType() == typeof(int))
                { dr[dc.ColumnName] = 0; }
                else
                {
                    dr[dc.ColumnName] = 0;
                }
            }
            */
            dt.Rows.RemoveAt( i);
        }

        private void gridControl1_TextChanged(object sender, EventArgs e)
        {
            DataRow dr =  this.gridView1.GetFocusedDataRow();
            Console.WriteLine(string.Format( "第一行=={0} 第二行{1}", dr[0], dr[1]));
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            /*
            this.gridControl1.Refresh();
           
            Console.WriteLine(string.Format("第一行=={0} 第二行{1}", dr[0], dr[1]));
            */
            DataRow dr = this.gridView1.GetFocusedDataRow();
            // DataRow dr = this.dt.NewRow();
            // dt.Rows.Add(dr);
            Console.WriteLine(string.Format("第一行=={0} 第二行{1}", dr[0], dr[1]));
            // MessageBox.Show(dr[0].ToString());
            int i = Convert.ToInt32(dr[0].ToString());
            dr["bushe_xianshu"] = i;
            if (this.gridView1.FocusedColumn.AbsoluteIndex == 1)
            {
                //Console.WriteLine("this.gridView1.FocusedColumn.AbsoluteIndex" + this.gridView1.FocusedColumn.AbsoluteIndex);
                //Console.WriteLine(" e.Column.AbsoluteIndex" + e.Column.AbsoluteIndex);
                dr["bushe_daoshu"] = Convert.ToInt32(dr[1].ToString());
            }
            else
            { dr["bushe_daoshu"] = Get布设接受线单线接收道数(i).ToString(); }
            dr["bushe_zongdaoshu"] = Get布设排列总道数(Convert.ToInt32(dr["bushe_daoshu"])).ToString();
            dr["banqian_daoshu"] = Get搬迁道数(i).ToString();
            dr["ke_caiji"] = Get可采集炮次(i);
            dr["banjia_daoshu"] = Get搬家排列道数(i, Convert.ToInt32(dr["ke_caiji"]), Convert.ToInt32(dr["bushe_daoshu"]));
            dr["hengxiangchang"] = Get横向长度(Convert.ToInt32(dr["bushe_daoshu"]));
            dr["zongxiangchang"] = Get纵向长度();
            dr["zonghengbi"] = Get纵横比( Convert.ToInt32(dr["zongxiangchang"]),Convert.ToInt32(dr["hengxiangchang"]));
            dr["paodaobi"] = Get炮道比(Convert.ToInt32(dr["ke_caiji"]), Convert.ToInt32(dr["bushe_zongdaoshu"]));
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }
    }
}
