using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SGsortCalaParam
{
    public partial class LoginFrom : DevExpress.XtraEditors.XtraForm
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                MessageBox.Show("请填写用户名");
                return;
            }

            if (password.Text == "")
            {
                MessageBox.Show("请填写密码");
                return;
            }

            if (userName.Text == "admin" && password.Text == "cjzx123")
            {
                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("用户名和密码好像不太正确");
            }

        }
        
    }
}