using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGsortCalaParam
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        working.NepCalaTable active_nepCalaTable = null;
        public Form1()
        {
            InitializeComponent();
               
        }


        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barEditItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #region 总接收点数 =接收线数*接收点数
        private void Get总接收点数()
        {
            string dianshu = jieshou_dianshu.EditValue.ToString();
            Int32 i_dianshu =  Convert.ToInt32(dianshu);
            string xianshu = jieshou_xianshu.EditValue.ToString();
            Int32 i_xianshu = Convert.ToInt32(xianshu);
            // 当前工作区项目
            this.active_nepCalaTable.JSDianshu = Convert.ToString(i_xianshu * i_dianshu);
        }

        #endregion


        #region（11）纵向滚动道数 =激发线距/接收点距
        private void Get纵向滚动道数()
        {
            string jifa = jifa_xianju.EditValue.ToString();
            Int32 i_jifa = Convert.ToInt32(jifa);

            string jieshou = jieshou_dianju.EditValue.ToString();
            Int32 i_jieshou = Convert.ToInt32(jieshou);

            this.active_nepCalaTable.GDDaoshu = Convert.ToString(i_jifa/i_jieshou);
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
            this.active_nepCalaTable.CJPaoco = i_bushe_pailie_kecaijipaoci;
        }
        #endregion


        #region 布设接受线单线接收道数 =（布设激发线数-1）*纵向滚动道数+接收点数（默认计算得出，但允许变量）
        private int Get布设接受线单线接收道数(Int32 p_bushe_jifashu)
        {
            int r_bushe = 0;
            try
            {
                string GunDongDaoshu = this.active_nepCalaTable.GDDaoshu;
                int i_GD_Daoshu = Convert.ToInt32(GunDongDaoshu);
                r_bushe = (i_GD_Daoshu * p_bushe_jifashu) + Convert.ToInt32(jieshou_dianshu.EditValue);
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【布设接受线单线接收道数】出现异常 : {0}", err));
            }
            return r_bushe;
        }
        #endregion



        #region （16）布设排列总道数 =（15）布设接受线单线接收道数*（12）布设接收线数        private int Get布设排列总道数(Int32 p_bushe_danxiandaoshu)
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
                string GunDongDaoshu = this.active_nepCalaTable.GDDaoshu;
                int i_GD_Daoshu = Convert.ToInt32(GunDongDaoshu);

                string bushe_jieshouxianshu = jieshou_xianshu.EditValue.ToString();
                int i_bushe_jieshouxianshu = Convert.ToInt32(bushe_jieshouxianshu);
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
                string kecaiji_paoci =  this.active_nepCalaTable.CJPaoco;
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

        #region （21）纵向长度 =接收线距*（接收线数-1）
        private int Get纵向长度()
        {
            int r_zongxiang_changdu = 0;
            try
            {
                string t_jieshou_xianju =  jieshou_xianju.EditValue.ToString();
                Int32 i_jieshou_xianju = Convert.ToInt32(t_jieshou_xianju);

                string t_jieshou_xianshu = jieshou_xianshu.EditValue.ToString();
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

        #region （22）纵横比 =纵/横（保留小数点后 2 位）
        private double Get纵横比(int p_zong, int p_heng)
        {
            double r_zhonghengbi = 0;
            try
            {
                r_zhonghengbi = (double)p_zong / (double)p_heng;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("【纵横比】出现异常 : {0}", err));
            }
            return r_zhonghengbi;
        }

        #endregion


        #region 初始设置一下
        private void GridInit()
        {
            DataTable dt = this.active_nepCalaTable.DDT;            
            for (int i = 0; i <= 40; i++)
            {
                // 如果是偶数的话
                if (i % 2 == 0)
                {
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                    dr["bushe_xianshu"] = Convert.ToString(i);
                    dr["bushe_daoshu"] = Get布设接受线单线接收道数(i).ToString();
                    dr["bushe_zongdaoshu"] = Get布设排列总道数(Convert.ToInt32(dr["bushe_daoshu"])).ToString();
                    dr["banqian_daoshu"] = Get搬迁道数(i).ToString();
                    dr["ke_caiji"] = Get可采集炮次(i);
                    dr["banjia_daoshu"] = Get搬家排列道数(i, Convert.ToInt32( dr["ke_caiji"]), Convert.ToInt32(dr["bushe_daoshu"]));
                    dr["hengxiangchang"] = Get横向长度(Convert.ToInt32(dr["bushe_daoshu"]));
                    dr["zongxiangchang"] = Get纵向长度();
                    dr["zonghengbi"] = Get纵横比(Convert.ToInt32(dr["hengxiangchang"]), Convert.ToInt32(dr["zongxiangchang"]));
                }
            }
            this.active_nepCalaTable.reflash();
        }
        #endregion



        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.CheckAll())
            {
                return;
            }

            this.Get总接收点数();
            this.Get纵向滚动道数();
            this.Get布设排列片可采集炮次();
            this.GridInit();
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
            MessageBox.Show( string.Format("{0} 输入的不是整形数字" ,name));
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


        private void jieshou_xianshu_EditValueChanged(object sender, EventArgs e)
        {
            // CheckInt(jieshou_xianshu.EditValue.ToString(), "接收线距") ? Console.WriteLine("s") : jieshou_xianshu.EditValue ;

        }

        private void barEditItem6_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barEditItem4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barEditItem5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void jieshou_dianshu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barEditItem9_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barEditItem10_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barEditItem11_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.active_nepCalaTable = this.nepCalaTable1;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
