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

        private Int32 Rvalue { get; set; }
        //2*Xmax/△X	
        private Int32 XmaxX2CDeltaX { get; set; }
        //SLI/△X	
        private Int32 SliCDeltaX { get; set; }
        private Int32 ShotsCell { get; set; }


        private Int32 GetXmaxX2CDeltaX(int Xmax, int DeltaX)
        {
            this.XmaxX2CDeltaX = Xmax * 2 / DeltaX;
            return XmaxX2CDeltaX;
        }

        private Int32 GetSliCDeltaX(int Sli, int DeltaX)
        {
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
                MessageBox.Show(string.Format("获得M值的时候出现了异常 : {0} ", err.Message));
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
    }
}
