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
    public partial class RegistForm : Form
    {
        public RegistForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Pwd.Text.Equals(Pwd1.Text))
            {
                MessageBox.Show("确认密码跟密码不一致", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            IAccountManager iam = ManagerFactory.getAccountManager("AccountManagerImpl");
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            User user = new User();
            Member member = new Member();
            if (iam.hasUser(Username.Text.Trim()))
            {
                MessageBox.Show("用户名已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            member = iqm.queryMember(RealName.Text.Trim());
            if (member == null)
            {
                MessageBox.Show("您输入的成员姓名在族谱中不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            user.Memberid = member.Id;
            user.Mapid = member.Mapid;
            user.Username = Username.Text;
            user.Pwd = Pwd.Text;
            user.Tele = Tele.Text;
            user.Email = Email.Text;
            user.PerLevel = 3;
            iam.addUser(user);
            MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
