using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenrenManage.comm
{
    class BaseCtrl
    {
        internal static Dictionary<string, XtraTabPage> xtab_map = new Dictionary<string, XtraTabPage>();
        internal static Dictionary<string, object> obj_map = new Dictionary<string, object>();
        public static void addSpaceLine(ref GridView temp_gridview)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < 10; i++)
            {
                temp_gridview.AddNewRow();
            }

        }

        public static object addtab2panel(object temp_oj, string name, string cap, XtraTabControl main)
        {
            try
            {
                // 1  如果已经存在就不放进去了
                if (xtab_map.ContainsKey(name))
                {
                    main.SelectedTabPage = xtab_map[name];
                    return obj_map[name];
                }

                // 2 把控件放进tab 容器中
                XtraTabPage xinka = new XtraTabPage();
                xinka.Name = name;
                xinka.Text = cap;

                UserControl tmp_uc = (temp_oj as UserControl);
                tmp_uc.Dock = DockStyle.Fill;
                xinka.Controls.Add(tmp_uc);

                main.TabPages.Add(xinka);
                main.SelectedTabPage = xinka;

                xtab_map.Add(name, xinka);
                obj_map.Add(name, temp_oj);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            return temp_oj;
        }

    }
}
