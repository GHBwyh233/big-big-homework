using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace BigHomework
{
    public partial class FindPwdForm : Form
    {
        private IAccountManager iam = ManagerFactory.getAccountManager("AccountManagerImpl");
        public FindPwdForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            if (!iam.hasUser(username))
            {
                MessageBox.Show("用户不存在！请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            label1.Visible = false;
            Username.Visible = false;
            btn1.Visible = false;

            label2.Visible = true;
            Email.Visible = true;
            btn2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string email = Email.Text;
            if (!iam.verifyUser(username, email))
            {
                MessageBox.Show("邮箱验证失败！请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            label2.Visible = false;
            Email.Visible = false;
            btn2.Visible = false;

            label3.Visible = true;
            label4.Visible = true;
            Pwd1.Visible = true;
            Pwd2.Visible = true;
            btn3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string pwd1 = Pwd1.Text;
            string pwd2 = Pwd2.Text;
            if (!pwd1.Equals(pwd2))
            {
                MessageBox.Show("确认密码与密码不一致！请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Pwd2.Text = "";
                return;
            }
            iam.modifyUserPassword(username,pwd1);
            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
