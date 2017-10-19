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
            string xianshu = jieshou_dianshu.EditValue.ToString();
            MessageBox.Show(xianshu);
        }
        #endregion

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.CheckAll())
            {
                return;
            }

            // this.Get总接收点数();
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
    }
}
