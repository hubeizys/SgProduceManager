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
    public partial class CCForm : Form
    {
        public CCForm()
        {
            InitializeComponent();
        }

        private Int32 EValue { get; set; }
        private Int32 SValue { get; set; }
        private Int32 Nvalue { set; get; }
        private Int32 Rvalue { get; set; }
        //2*Xmax/△X	
        private Int32 XmaxX2CDeltaX { get; set; }
        //SLI/△X	
        private Int32 SliCDeltaX { get; set; }
        private Int32 ShotsCell { get; set; }

        private Int32 GetXmax()
        {
            try
            {
                Int32 ret = 1;
                Int32.TryParse(this.te_xmax.Text, out ret);
                return ret;
            }
            catch (Exception err)
            {
                Console.WriteLine(String.Format("获得DeltaX 出现错误{0}== {1}", this.te_daoju.Text, err.Message));
                this.te_xmax.Invoke(new Action(()=> {
                    this.te_xmax.Text = "1";
                }));
                return 1;
            }
        }

        private Int32 GetSli()
        {
            try
            {
                Int32 ret = 0;
                Int32.TryParse(this.te_sli.Text, out ret);
                return ret;
            }
            catch (Exception err)
            {
                Console.WriteLine(String.Format("获得DeltaX 出现错误{0}== {1}", this.te_daoju.Text, err.Message));
                te_sli.Invoke(new Action(()=> {
                    this.te_sli.Text = "1";
                }));

                return 1;
            }
        }

        private Int32 GetDeltaX()
        {
            try {
                Int32 ret = 1;
                Int32.TryParse(this.te_daoju.Text, out ret);
                return ret;
            }
            catch (Exception err)
            {
                Console.WriteLine(String.Format("获得DeltaX 出现错误{0}== {1}", this.te_daoju.Text, err.Message));
                this.te_daoju.Invoke(new Action(()=> {
                    this.te_daoju.Text = "1";
                }));
                return 0;
            }
        }

        private Int32 GetXmaxX2CDeltaX(int Xmax, int DeltaX)
        {
            if (DeltaX == 0)
            {
                DeltaX = 1; 
            }
            this.XmaxX2CDeltaX = Xmax * 2 / DeltaX;
            MessageBox.Show("XmaxX2CDeltaX : " + XmaxX2CDeltaX);
            return XmaxX2CDeltaX;
        }

        private Int32 GetSliCDeltaX(int Sli, int DeltaX)
        {
            if (DeltaX == 0)
            {
                DeltaX = 1;
            }
            this.SliCDeltaX = Sli / DeltaX;
            return SliCDeltaX;
        }

        /// <summary>
        /// 
        /// M值
        /// </summary>
        /// <param name="p_EValue"></param>
        /// <param name="n_num"></param>
        /// <returns></returns>
        private Double GetM值ByE(int p_EValue, Int32 n_num)
        {
            try
            {
                if (SliCDeltaX == 0)
                {
                    SliCDeltaX = 1;
                }
                double _l_m_value = 0;
                // （E 值 / （增加 接收线数【N】 + 接收线数【R】）  - （2 * 纵向最大偏移距 【Xmax】） ）/ (炮线距/道距) 
                _l_m_value = Convert.ToDouble(p_EValue / (Rvalue + n_num) - this.XmaxX2CDeltaX) / SliCDeltaX;
                Console.WriteLine(string.Format("m值为： == {0}", _l_m_value));
                return _l_m_value;
            }
            catch (Exception err)
            {
                //MessageBox.Show(string.Format("获得M值的时候出现了异常 : {0} ", err.Message));
                return 0;
            }
        }

        private Double GetS值(int p_nnum)
        {
            double _l_mvalue = this.GetM值ByE(this.EValue, p_nnum);
            // (m +1 ) *( n+1 ) * shotscell
            // （增加炮线数 + 1 ） * （增加接收线数 +1 ） * 单元模板炮数
            Double _l_svalue = (_l_mvalue + 1) * (p_nnum + 1) * ShotsCell;
            return _l_svalue;
        }


        private Double GetM值ByS(int p_SValue, Int32 n_num)
        {
            try {
                if (ShotsCell == 0)
                {
                    ShotsCell = 1;
                }
                int _l_mvalue = Convert.ToInt32( p_SValue) / ShotsCell / (n_num + 1) - 1;
                Console.WriteLine(string.Format("m值为： == {0}", _l_mvalue));
                return _l_mvalue;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("获得M值的时候出现了异常 : {0} ", err.Message));
                return 0;
            }
        }

        private Double GetE值(int p_num)
        {
            try
            {
                double _l_mvalue = GetM值ByS(SValue, p_num);
                double _l_evalue = (this.XmaxX2CDeltaX + SliCDeltaX * _l_mvalue) * (p_num + Rvalue);
                return _l_mvalue;
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format( "获得E值的过程中出现异常: {0}", err.Message ));
                return 0;
            }
        }

        private void te_zonghe1_EditValueChanged(object sender, EventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_zonghe1.Text, out r_ret))
            {
                //e.Cancel = true;
                // MessageBox.Show("请输入数字");

            }
            te_zonghe1.Text = "0";
        }

        private void te_xmax_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_xmax.Text, out r_ret) )
            {
                e.Cancel = true;
                MessageBox.Show("请输入数字");
            }

            // 计算 2*Xmax/△X
            //  Int32 _l_xmax = Convert.ToInt32(te_xmax.Text);

            Int32 DeltaX = this.GetDeltaX();
            this.te_zonghe1.Invoke(new Action(()=> {
                int aaaa = GetXmaxX2CDeltaX(r_ret, DeltaX);
                //  MessageBox.Show("aa " + aaaa);
                this.te_zonghe1.Text = aaaa.ToString();
                //  this.te_zonghe1.Refresh();
            }));

        }

        private void te_daoju_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_daoju.Text, out r_ret))
            {
                
                e.Cancel = true;

                MessageBox.Show("请输入数字");
            }

            /*
            Int32 _l_sli = GetSli();
            te_sli.Invoke(new Action(()=> {
                te_sli.Text = Convert.ToString(GetSliCDeltaX(_l_sli, r_ret));
                te_sli.Refresh();
            }));*/
            // Int32 DeltaX = this.GetDeltaX();
            Int32 _l_xmax = GetXmax();
            this.te_zonghe1.Invoke(new Action(() => {
                this.te_zonghe1.Text = GetXmaxX2CDeltaX(_l_xmax, r_ret).ToString();
                this.te_zonghe1.Refresh();
            }));

            Int32 _l_cli = GetSli();
            this.te_zonghe2.Invoke(new Action(()=> {
                this.te_zonghe2.Text = GetSliCDeltaX(_l_cli, r_ret).ToString();
            }));
        }

        private void te_daoju_EditValueChanged(object sender, EventArgs e)
        {
            if (te_daoju.Text == "0")
            {
                MessageBox.Show("道距等于0 不合理");
            }
        }

        private void te_sli_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_sli.Text, out r_ret) )
            {
                e.Cancel = true;
                MessageBox.Show("请输入数字");
            }

           int deltaX=   GetDeltaX();

            this.te_zonghe2.Invoke(new Action(()=> {
                this.te_zonghe2.Text = GetSliCDeltaX(r_ret, deltaX).ToString();
            }));

        }

        private void te_nnum_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_nnum.Text, out r_ret))
            {
                e.Cancel = true;
                MessageBox.Show("请输入数字");
            }

            if (r_ret <=0)
            {
                MessageBox.Show(string.Format("增加接收线数（n）出现了异常 "));
                return;
            }
            this.Nvalue = r_ret;
            GetAllpoints();
        }

        private void te_Rnum_EditValueChanged(object sender, EventArgs e)
        {
         
        }

        private void te_Rnum_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_Rnum.Text, out r_ret))
            {
                e.Cancel = true;
                MessageBox.Show("请输入数字");
            }
            this.Rvalue = r_ret;
            GetAllpoints();
        }

        private void te_Enum_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_Enum.Text, out r_ret))
            {
                e.Cancel = true;
                MessageBox.Show("请输入数字");
            }
            this.EValue = r_ret;
            GetAllpoints();
        }

        private void te_ShotsCell_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_ShotsCell.Text, out r_ret))
            {
                e.Cancel = true;
                MessageBox.Show("请输入数字");
            }
            this.ShotsCell = r_ret;
            GetAllpoints();
        }


        // 获得一个临时的节点
        private void testSeries()
        {
            /*
            this.chartControl1.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint("11", 100));
            this.chartControl1.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint("12", 101));
            this.chartControl1.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint("13", 102));
            this.chartControl1.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint("14", 103));
            this.chartControl1.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint("15", 10));
            this.chartControl1.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint("16", 120));
            */
        }

        private void GetAllpoints()
        {
            int n_num = 10;
            if (!Int32.TryParse(this.te_nnum.Text, out n_num))
            {
                //MessageBox.Show("");
                //Console.WriteLine("没有指定增加接收线数（N）");
                //return;
            }

            this.chartControl1.Series[0].Points.Clear();

            //投入采集道数（E）
            for (int i = 0; i < n_num; i++)
            {
                 double s_value =  this.GetS值(i);
                this.chartControl1.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint(i, s_value));
            }

        }

        private void CCForm_Load(object sender, EventArgs e)
        {
            this.testSeries();
        }

        private void te_zonghe1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_zonghe1.Text, out r_ret))
            {
                //e.Cancel = true;
                // MessageBox.Show("请输入数字");
            }
            this.XmaxX2CDeltaX = r_ret;
            GetAllpoints();
        }

        private void te_zonghe2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int r_ret = 0;
            if (!Int32.TryParse(te_zonghe2.Text, out r_ret))
            {
                e.Cancel = true;
                //  MessageBox.Show("请输入数字");
            }
            SliCDeltaX = r_ret;
            GetAllpoints();
        }
    }
}
