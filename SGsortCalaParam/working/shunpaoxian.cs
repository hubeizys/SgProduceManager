using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGsortCalaParam.working
{
    public partial class shunpaoxian : Form
    {
        private int SJjieshouxianshu { set; get; }
        private int BSjieshouxianshu { set; get; }
        private int BSpailiedaoshu { set; get; }
        private int BSpailiefeidaoshu { set; get; }
        private int GDcishu1 { set; get; }
        private int GDcishu { set; get; }
        private int SJdanxianjieshoudaoshu { set; get; }
        public shunpaoxian()
        {
            InitializeComponent();

        }
        public int Get重复使用但不搬埋排列()  
        {
            try
            {
                /*
                int i_bushe_jieshou = Convert.ToInt32(this.bushe_jieshouxianshu.Text);
                // int i_gundong_cishu = Convert.ToInt32(this.gundong_cishu.Text);
                int i_sheji_jieshou_xianshu = Convert.ToInt32(this.sheji_jieshouxianshu.Text);
                int i_sheji_danxian_jieshoudaoshu = Convert.ToInt32(this.sheji_danxianjieshoudaoshu.Text);
                */
                // （布设接收线数 * 2 - 设计接收线数）*设计单线接收道数
                int i_ret = (BSjieshouxianshu * 2 - SJjieshouxianshu) * SJdanxianjieshoudaoshu;
                Console.WriteLine(string.Format("Get重复搬埋排列Lite == {0}", i_ret));
                this.chongfu_shiyongbupanmaipailie.Text = i_ret.ToString();
                return i_ret;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format( "获得重复搬埋排列好像出现了点问题 == {0}", err.Message));
            }
            return 0;
        }

        public int Get重复搬埋排列Lite()
        {
            try
            {
                /*
                 （（布设排列标准模板单线接收道数* 滚动次数+布设排列非标准模板【无附加段】单线接收道数* 滚动次数）-设计单线接收道数）*（设计接收线数 -（布设接收线数 * 2 - 设计接收线数）*/
                int i_ret = ((this.BSpailiedaoshu * this.GDcishu1 + BSpailiefeidaoshu * GDcishu) - SJdanxianjieshoudaoshu) * (SJjieshouxianshu- (BSjieshouxianshu * 2 - SJjieshouxianshu));
                this.chongfu_banmaipailie.Text = i_ret.ToString();
                return i_ret;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("获得重复使用但不搬埋排列出现了问题", err.Message));
            }
            return 0;
        }

        public int Get重复搬埋排列Big()
        {
            try
            {
                /*
                 * （（布设排列标准模板单线接收道数*滚动次数+布设排列非标准模板【无附加段】单线接收道数*滚动次数）-设计单线接收道数）*设计接收线数
                 */

                int i_ret = ((this.BSpailiedaoshu * this.GDcishu1 + this.BSpailiefeidaoshu * GDcishu) - SJdanxianjieshoudaoshu) * this.SJjieshouxianshu;
                this.chongfu_banmaipailie.Text = i_ret.ToString();
                return i_ret;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("获得重复搬埋排列出现了问题",err.Message));
            }
            return 0;
        }

        private void sheji_danxianjieshoudaoshu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sheji_jieshouxianshu_EditValueChanged(object sender, EventArgs e)
        {
            
            Console.WriteLine(sheji_jieshouxianshu.Text);
        }

        private bool CheckCanCala()
        {

            return true;
        }


      
        private void sheji_jieshouxianshu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int ret = 0;
            if (sheji_jieshouxianshu.Text == "" || !int.TryParse(sheji_jieshouxianshu.Text, out ret))
            {
                MessageBox.Show("设计接收线数不是正常的数值");
                e.Cancel = true;
            }
            this.SJjieshouxianshu = ret;
            /*
            Get重复搬埋排列Lite();
            Get重复使用但不搬埋排列();
            Get重复搬埋排列Big();*/
            sheTest();
        }

        private void bushe_jieshouxianshu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int ret = 0;
            if (bushe_jieshouxianshu.Text == "" || !int.TryParse(bushe_jieshouxianshu.Text, out ret))
            {
                MessageBox.Show("布设接收线数不是正常的数值");
                e.Cancel = true;
            }
            this.BSjieshouxianshu = ret;
            sheTest();
        }

        private void bushe_pailie_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int ret = 0;
            if (bushe_pailie.Text == "" || !int.TryParse(bushe_pailie.Text, out ret))
            {
                MessageBox.Show("布设排列标准模板单线接收道数不是正常的数值");
                e.Cancel = true;
            }
            this.BSpailiedaoshu = ret;
            sheTest();
        }

        private void bushe_pailiefei_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int ret = 0;
            if (bushe_pailiefei.Text == "" || !int.TryParse(bushe_pailiefei.Text, out ret))
            {
                MessageBox.Show("布设排列非标准模板【无附加段】单线接收道数不是正常的数值");
                e.Cancel = true;
            }
            this.BSpailiefeidaoshu = ret;
            sheTest();
        }

        private void gundong_cishu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int ret = 0;
            if (gundong_cishu.Text == "" || !int.TryParse(gundong_cishu.Text, out ret))
            {
                MessageBox.Show("滚动次数不是正常的数值");
                e.Cancel = true;
            }
            this.GDcishu = ret;
            sheTest();
        }

        private void sheTest()
        {
            if (BSjieshouxianshu == 0)
            {
                BSjieshouxianshu = 1;
            }
            if (SJjieshouxianshu/BSjieshouxianshu >= 2)
            {
                Get重复搬埋排列Big();
                chongfu_shiyongbupanmaipailie.Visible = false;
                lb_cf.Visible = false;
                label1.Visible = false;
            }
            else
            {
                chongfu_shiyongbupanmaipailie.Visible = true;
                lb_cf.Visible = true;
                label1.Visible = true;
                Get重复搬埋排列Lite();
                Get重复使用但不搬埋排列();
            }
        }

        private void sheji_danxianjieshoudaoshu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int ret = 0;
            if (sheji_danxianjieshoudaoshu.Text == "" || !int.TryParse(sheji_danxianjieshoudaoshu.Text, out ret))
            {
                MessageBox.Show("设计单线接收道数不是正常的数值");
                e.Cancel = true;
            }
            this.SJdanxianjieshoudaoshu = ret;
            sheTest();
        }

        private void gundong_cishu1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int ret = 0;
            if (gundong_cishu1.Text == "" || !int.TryParse(gundong_cishu1.Text, out ret))
            {
                MessageBox.Show("设计单线接收道数不是正常的数值");
                e.Cancel = true;
            }
            this.GDcishu1 = ret;
            sheTest();
        }
    }
}
