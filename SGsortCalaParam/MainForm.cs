using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SGsortCalaParam.working;
using DevExpress.XtraTab;
using System.IO;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace SGsortCalaParam
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        working.NepCalaTable active_nepCalaTable = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void bt_chongfupailiemaizhijisuan_Click(object sender, EventArgs e)
        {
            shunpaoxian _l_spx = new shunpaoxian();
            _l_spx.Dock = DockStyle.Fill;
            _l_spx.TopLevel = false;
            this.xtraTabControl1.SelectedTabPage.Controls.Add(_l_spx);
            _l_spx.BringToFront();
            _l_spx.Show();
        }

        private void bt_zhuangbei_touru_Click(object sender, EventArgs e)
        {
            CCForm cc = new CCForm();
            cc.Dock = DockStyle.Fill;
            cc.TopLevel = false;
            this.xtraTabControl1.SelectedTabPage.Controls.Add(cc);
            cc.BringToFront();
            cc.Show();
        }

        private void sb_newwork_Click(object sender, EventArgs e)
        {
            XtraTabPage xinka = new XtraTabPage();
            xinka.Name = "xin";
            xinka.Text = "新工作区";
            NepCalaTable xintab = new NepCalaTable();
            xintab.Dock = DockStyle.Fill;
            xinka.Controls.Add(xintab);
            this.xtraTabControl1.TabPages.Add(xinka);
            this.xtraTabControl1.SelectedTabPage = xinka;
            this.active_nepCalaTable = xintab;
        }

        public  string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs EArg = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            Console.WriteLine(this.xtraTabControl1.ShowHeaderFocus.ToString());
            this.xtraTabControl1.TabPages.RemoveAt(this.xtraTabControl1.SelectedTabPageIndex);
        }

        private void textEdit1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void textEdit1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_DoubleClick(object sender, EventArgs e)
        {
            if (this.textEdit1.Enabled)
            {
                this.textEdit1.Enabled = false;
                this.xtraTabControl1.SelectedTabPage.Text = this.textEdit1.Text;
            }
            else
            {
                this.textEdit1.Enabled = true;
            }
        }

        private void sb_rename_Click(object sender, EventArgs e)
        {
            if (this.textEdit1.Enabled)
            {
                this.textEdit1.Enabled = false;
                this.xtraTabControl1.SelectedTabPage.Text = this.textEdit1.Text;
            }
            else
            {
                this.textEdit1.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            XtraTabPage xinka =
    this.xtraTabControl1.TabPages[this.xtraTabControl1.SelectedTabPageIndex];
            //Console.WriteLine( xinka.Controls[0]);
            try
            { this.active_nepCalaTable = xinka.Controls[0] as NepCalaTable; }
            catch (Exception err)
            {
                MessageBox.Show("出现了错误： " + err.Message);
            }
        }

        private void sb_extend_Click(object sender, EventArgs e)
        {
            XtraTabPage xinka =
this.xtraTabControl1.TabPages[this.xtraTabControl1.SelectedTabPageIndex];
            SaveFileDialog sflg = new SaveFileDialog();
            sflg.Filter = "Excel(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
            if (sflg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            //this.gridView1.ExportToXls(sflg.FileName);
            //NPOI.xs book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            NPOI.SS.UserModel.IWorkbook book = null;
            if (sflg.FilterIndex == 1)
            {
                book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            }
            else
            {
                book = new NPOI.XSSF.UserModel.XSSFWorkbook();
            }

            NPOI.SS.UserModel.ISheet sheet = book.CreateSheet(xinka.Text);

            // 添加表头
            NPOI.SS.UserModel.IRow row = sheet.CreateRow(0);
            int index = 0;
            GridView ac = this.active_nepCalaTable.GC;
            int count = ac.Columns.Count;
            for (int i = 0;i < count ; i++)
            {
                string Caption = ac.Columns[i].Caption;
                NPOI.SS.UserModel.ICell cell = row.CreateCell(index);
                cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell.SetCellValue(Caption);
                index++;
            }
            /*
            foreach (GridColumn item in this.gridView1.Columns)
            {
                if (item.Visible)
                {
                    NPOI.SS.UserModel.ICell cell = row.CreateCell(index);
                    cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                    cell.SetCellValue(item.Caption);
                    index++;
                }
            }*/

            // 添加数据

            DataTable dt = this.active_nepCalaTable.DDT;
            for (int j = 0; j< dt.Rows.Count; j++)
            {
                index = 0;
                row = sheet.CreateRow(j + 1);
                for (int k = 0; k < count; k++)
                {
                    NPOI.SS.UserModel.ICell cell = row.CreateCell(index);
                    cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                    //cell.SetCellValue(this.gridView1.GetRowCellValue(i, item).ToString());
                    cell.SetCellValue(dt.Rows[j][k].ToString());
                    index++;
                }
            }

            NPOI.SS.UserModel.IRow r1 = sheet.GetRow(0);
            // 第一排
            NPOI.SS.UserModel.ICell cell1 = r1.CreateCell(12);
            cell1.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell1.SetCellValue("激发点距");
            NPOI.SS.UserModel.ICell cell11 = r1.CreateCell(13);
            cell11.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell11.SetCellValue(this.active_nepCalaTable.jifa_dianju.Text);

            // 第二排
            r1 = sheet.GetRow(1);
            NPOI.SS.UserModel.ICell cell2 = r1.CreateCell(12);
            cell2.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell2.SetCellValue("接收点距");
            NPOI.SS.UserModel.ICell cell21 = r1.CreateCell(13);
            cell21.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell21.SetCellValue(this.active_nepCalaTable.jieshou_dianju.Text);



            // 第三排
            r1 = sheet.GetRow(2);
            NPOI.SS.UserModel.ICell cell3 = r1.CreateCell(12);
            cell3.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell3.SetCellValue("接收点数");
            NPOI.SS.UserModel.ICell cell31 = r1.CreateCell(13);
            cell31.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell31.SetCellValue(this.active_nepCalaTable.jieshou_dianshu.Text);



            // 第四排
            r1 = sheet.GetRow(3);
            NPOI.SS.UserModel.ICell cell4 = r1.CreateCell(12);
            cell4.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell4.SetCellValue("激发线距");
            NPOI.SS.UserModel.ICell cell41 = r1.CreateCell(13);
            cell41.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell41.SetCellValue(this.active_nepCalaTable.jifa_xianju.Text);




            // 第五排
            r1 = sheet.GetRow(4);
            NPOI.SS.UserModel.ICell cell5 = r1.CreateCell(12);
            cell5.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell5.SetCellValue("接受线距");
            NPOI.SS.UserModel.ICell cell51 = r1.CreateCell(13);
            cell51.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell51.SetCellValue(this.active_nepCalaTable.jieshou_xianju.Text);

            // 第六排
            r1 = sheet.GetRow(5);
            NPOI.SS.UserModel.ICell cell6 = r1.CreateCell(12);
            cell6.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell6.SetCellValue("纵向滚动距离");
            NPOI.SS.UserModel.ICell cell61 = r1.CreateCell(13);
            cell61.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell61.SetCellValue(this.active_nepCalaTable.muban_zong.Text);

            // 第7排
            r1 = sheet.GetRow(6);
            NPOI.SS.UserModel.ICell cell7 = r1.CreateCell(12);
            cell7.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell7.SetCellValue("模板炮");
            NPOI.SS.UserModel.ICell cell71 = r1.CreateCell(13);
            cell71.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell71.SetCellValue(this.active_nepCalaTable.mobanpao.Text);


            // 第8排
            r1 = sheet.GetRow(7);
            NPOI.SS.UserModel.ICell cell8 = r1.CreateCell(12);
            cell8.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell8.SetCellValue("接收线数");
            NPOI.SS.UserModel.ICell cell81 = r1.CreateCell(13);
            cell81.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell81.SetCellValue(this.active_nepCalaTable.jieshou_xianshu.Text);



            // 第9排
            r1 = sheet.GetRow(8);
            NPOI.SS.UserModel.ICell cell9 = r1.CreateCell(12);
            cell9.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell9.SetCellValue("横向滚动距离");
            NPOI.SS.UserModel.ICell cell91 = r1.CreateCell(13);
            cell91.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell91.SetCellValue(this.active_nepCalaTable.muban_heng.Text);



            // 第10排
            r1 = sheet.GetRow(9);
            NPOI.SS.UserModel.ICell cell10 = r1.CreateCell(12);
            cell10.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell10.SetCellValue("布设接受线数");
            NPOI.SS.UserModel.ICell cell101 = r1.CreateCell(13);
            cell101.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell101.SetCellValue(this.active_nepCalaTable.bushe_jieshouxianshu.Text);



            // 第11排
            r1 = sheet.GetRow(10);
            NPOI.SS.UserModel.ICell cell1_1 = r1.CreateCell(12);
            cell1_1.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell1_1.SetCellValue("布设激发线数");
            NPOI.SS.UserModel.ICell cell111 = r1.CreateCell(13);
            cell111.SetCellType(NPOI.SS.UserModel.CellType.String);
            cell111.SetCellValue(this.active_nepCalaTable.bushe_jifaxianshu.Text);




            /*
            for (int i = 0; i < this.gridView1.DataRowCount; i++)
            {
                index = 0;
                row = sheet.CreateRow(i + 1);
                foreach (GridColumn item in this.gridView1.Columns)
                {
                    if (item.Visible)
                    {
                        NPOI.SS.UserModel.ICell cell = row.CreateCell(index);
                        cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                        cell.SetCellValue(this.gridView1.GetRowCellValue(i, item).ToString());
                        index++;
                    }
                }
            }*/
            // 写入 
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            book.Write(ms);
            book = null;

            using (FileStream fs = new FileStream(sflg.FileName, FileMode.Create, FileAccess.Write))
            {
                byte[] data = ms.ToArray();
                fs.Write(data, 0, data.Length);
                fs.Flush();
            }
            MessageBox.Show("保存成功了");
            ms.Close();
            ms.Dispose();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            XtraTabPage xinka =
                this.xtraTabControl1.TabPages[this.xtraTabControl1.SelectedTabPageIndex];
            //Console.WriteLine( xinka.Controls[0]);
            this.textEdit1.Text = xinka.Text;
            try
            { this.active_nepCalaTable = xinka.Controls[0] as NepCalaTable; }
            catch (Exception err)
            {
                MessageBox.Show("出现了错误： "+ err.Message);
            }
        }

        private void sb_import_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = null;

            OpenFileDialog sflg = new OpenFileDialog();
            sflg.Filter = "Excel(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
            if (sflg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            FileStream fs = new FileStream(sflg.FileName, FileMode.Open, FileAccess.Read);
            NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook(fs);
            int sheetCount = book.NumberOfSheets;
            for (int sheetIndex = 0; sheetIndex < sheetCount; sheetIndex++)
            {
                string st_name =   book.GetSheetName(sheetIndex);
                XtraTabPage xinka = new XtraTabPage();
                xinka.Name = "xin";
                xinka.Text = st_name;
                NepCalaTable xintab = new NepCalaTable();
                xintab.Dock = DockStyle.Fill;
                xinka.Controls.Add(xintab);
                this.xtraTabControl1.TabPages.Add(xinka);
                this.xtraTabControl1.SelectedTabPage = xinka;
                this.active_nepCalaTable = xintab;

                NPOI.SS.UserModel.ISheet sheet = book.GetSheetAt(sheetIndex);
                if (sheet == null) continue;

                NPOI.SS.UserModel.IRow row = sheet.GetRow(0);
                if (row == null) continue;

                int firstCellNum = row.FirstCellNum;
                int lastCellNum = row.LastCellNum;
                if (firstCellNum == lastCellNum) continue;

                dt = new DataTable(sheet.SheetName);
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
                lastCellNum = 10;
                for (int i = firstCellNum; i < lastCellNum; i++)
                {
                    dt.Columns.Add(row.GetCell(i).StringCellValue, typeof(string));
                }

                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    DataRow newRow = dt.Rows.Add();
                    for (int j = firstCellNum; j < lastCellNum; j++)
                    {
                        newRow[j] = sheet.GetRow(i).GetCell(j).StringCellValue;
                    }
                }
                NPOI.SS.UserModel.IRow row0 = sheet.GetRow(0);
                this.active_nepCalaTable.jifa_dianju.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(1);
                this.active_nepCalaTable.jieshou_dianju.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(2);
                this.active_nepCalaTable.jieshou_dianshu.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(3);
                this.active_nepCalaTable.jifa_xianju.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(4);
                this.active_nepCalaTable.jieshou_xianju.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(5);
                this.active_nepCalaTable.muban_zong.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(6);
                this.active_nepCalaTable.mobanpao.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(7);
                this.active_nepCalaTable.jieshou_xianshu.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(8);
                this.active_nepCalaTable.muban_heng.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(9);
                this.active_nepCalaTable.bushe_jieshouxianshu.Text = row0.GetCell(13).StringCellValue;
                row0 = sheet.GetRow(10);
                this.active_nepCalaTable.bushe_jifaxianshu.Text = row0.GetCell(13).StringCellValue;

                ds.Tables.Add(dt);
                this.active_nepCalaTable.DDT = dt;
            }
           
        }

        private void sb_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sflg = new SaveFileDialog();
            sflg.Filter = "Excel(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
            if (sflg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            int aa = 0;
            NPOI.SS.UserModel.IWorkbook book = null;
            if (sflg.FilterIndex == 1)
            {
                book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            }
            else
            {
                book = new NPOI.XSSF.UserModel.XSSFWorkbook();
            }
            foreach (XtraTabPage trp in this.xtraTabControl1.TabPages)
            {
                XtraTabPage xinka = trp;
                try
                {
                    this.active_nepCalaTable = xinka.Controls[0] as NepCalaTable;
                }
                catch (Exception err)
                {
                    MessageBox.Show("出现了错误： " + err.Message);
                }
                aa += 1;
                
                //this.gridView1.ExportToXls(sflg.FileName);
                //NPOI.xs book = new NPOI.HSSF.UserModel.HSSFWorkbook();
                //NPOI.SS.UserModel.ISheet sheet = book.CreateSheet(string.Format("test_{0}", aa));
                NPOI.SS.UserModel.ISheet sheet = book.CreateSheet(xinka.Text);
                // 添加表头
                NPOI.SS.UserModel.IRow row = sheet.CreateRow(0);
                int index = 0;
                GridView ac = this.active_nepCalaTable.GC;
                int count = ac.Columns.Count;
                for (int i = 0; i < count; i++)
                {
                    string Caption = ac.Columns[i].Caption;
                    NPOI.SS.UserModel.ICell cell = row.CreateCell(index);
                    cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                    cell.SetCellValue(Caption);
                    index++;
                }

                // 添加数据

                DataTable dt = this.active_nepCalaTable.DDT;
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    index = 0;
                    row = sheet.CreateRow(j + 1);
                    for (int k = 0; k < count; k++)
                    {
                        NPOI.SS.UserModel.ICell cell = row.CreateCell(index);
                        cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                        //cell.SetCellValue(this.gridView1.GetRowCellValue(i, item).ToString());
                        cell.SetCellValue(dt.Rows[j][k].ToString());
                        index++;
                    }
                }
                NPOI.SS.UserModel.IRow r1 = sheet.GetRow(0);
                // 第一排
                NPOI.SS.UserModel.ICell cell1 = r1.CreateCell(12);
                cell1.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell1.SetCellValue("激发点距");
                NPOI.SS.UserModel.ICell cell11 = r1.CreateCell(13);
                cell11.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell11.SetCellValue(this.active_nepCalaTable.jifa_dianju.Text);

                // 第二排
                r1 = sheet.GetRow(1);
                NPOI.SS.UserModel.ICell cell2 = r1.CreateCell(12);
                cell2.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell2.SetCellValue("接收点距");
                NPOI.SS.UserModel.ICell cell21 = r1.CreateCell(13);
                cell21.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell21.SetCellValue(this.active_nepCalaTable.jieshou_dianju.Text);



                // 第三排
                r1 = sheet.GetRow(2);
                NPOI.SS.UserModel.ICell cell3 = r1.CreateCell(12);
                cell3.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell3.SetCellValue("接收点数");
                NPOI.SS.UserModel.ICell cell31 = r1.CreateCell(13);
                cell31.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell31.SetCellValue(this.active_nepCalaTable.jieshou_dianshu.Text);



                // 第四排
                r1 = sheet.GetRow(3);
                NPOI.SS.UserModel.ICell cell4 = r1.CreateCell(12);
                cell4.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell4.SetCellValue("激发线距");
                NPOI.SS.UserModel.ICell cell41 = r1.CreateCell(13);
                cell41.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell41.SetCellValue(this.active_nepCalaTable.jifa_xianju.Text);




                // 第五排
                r1 = sheet.GetRow(4);
                NPOI.SS.UserModel.ICell cell5 = r1.CreateCell(12);
                cell5.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell5.SetCellValue("接受线距");
                NPOI.SS.UserModel.ICell cell51 = r1.CreateCell(13);
                cell51.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell51.SetCellValue(this.active_nepCalaTable.jieshou_xianju.Text);

                // 第六排
                r1 = sheet.GetRow(5);
                NPOI.SS.UserModel.ICell cell6 = r1.CreateCell(12);
                cell6.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell6.SetCellValue("纵向滚动距离");
                NPOI.SS.UserModel.ICell cell61 = r1.CreateCell(13);
                cell61.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell61.SetCellValue(this.active_nepCalaTable.muban_zong.Text);

                // 第7排
                r1 = sheet.GetRow(6);
                NPOI.SS.UserModel.ICell cell7 = r1.CreateCell(12);
                cell7.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell7.SetCellValue("模板炮");
                NPOI.SS.UserModel.ICell cell71 = r1.CreateCell(13);
                cell71.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell71.SetCellValue(this.active_nepCalaTable.mobanpao.Text);


                // 第8排
                r1 = sheet.GetRow(7);
                NPOI.SS.UserModel.ICell cell8 = r1.CreateCell(12);
                cell8.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell8.SetCellValue("接收线数");
                NPOI.SS.UserModel.ICell cell81 = r1.CreateCell(13);
                cell81.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell81.SetCellValue(this.active_nepCalaTable.jieshou_xianshu.Text);



                // 第9排
                r1 = sheet.GetRow(8);
                NPOI.SS.UserModel.ICell cell9 = r1.CreateCell(12);
                cell9.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell9.SetCellValue("横向滚动距离");
                NPOI.SS.UserModel.ICell cell91 = r1.CreateCell(13);
                cell91.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell91.SetCellValue(this.active_nepCalaTable.muban_heng.Text);



                // 第10排
                r1 = sheet.GetRow(9);
                NPOI.SS.UserModel.ICell cell10 = r1.CreateCell(12);
                cell10.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell10.SetCellValue("布设接受线数");
                NPOI.SS.UserModel.ICell cell101 = r1.CreateCell(13);
                cell101.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell101.SetCellValue(this.active_nepCalaTable.bushe_jieshouxianshu.Text);



                // 第11排
                r1 = sheet.GetRow(10);
                NPOI.SS.UserModel.ICell cell1_1 = r1.CreateCell(12);
                cell1_1.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell1_1.SetCellValue("布设激发线数");
                NPOI.SS.UserModel.ICell cell111 = r1.CreateCell(13);
                cell111.SetCellType(NPOI.SS.UserModel.CellType.String);
                cell111.SetCellValue(this.active_nepCalaTable.bushe_jifaxianshu.Text);


                // 写入 
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                book.Write(ms);
                //book = null;

                using (FileStream fs = new FileStream(sflg.FileName, FileMode.Create, FileAccess.Write))
                {
                    byte[] data = ms.ToArray();
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                }
               
                ms.Close();
                ms.Dispose();
            }
            book = null;
            MessageBox.Show("保存成功了");
        }
    }
}