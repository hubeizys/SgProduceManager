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


        #region（11）纵向滚动道数 =激发点距/接收点距        private void Get纵向滚动道数()
        {
            string jifa = jifa_dianju.EditValue.ToString();
            Int32 i_jifa = Convert.ToInt32(jifa);

            string jieshou = jieshou_dianju.EditValue.ToString();
            Int32 i_jieshou = Convert.ToInt32(jieshou);

            this.active_nepCalaTable.GDDaoshu = Convert.ToString(i_jifa/i_jieshou);

        }



        #endregion

        #region （13）布设排列片可采集炮次 =[（布设接收线数-接受线数）*接收线距/模板纵向滚动距离+1]*模板炮        private void Get布设排列片可采集炮次()
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


        #region 布设接受线单线接收道数 =（布设激发线数-1）*纵向滚动道数+接收点数（默认计算得出，但允许变量）        private void Get布设接受线单线接收道数()
        {

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
    }
}
