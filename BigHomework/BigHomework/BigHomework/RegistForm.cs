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
                MessageBox.Show("确认密码跟密码不一样！");
            }
            IAccountManager iam = ManagerFactory.getAccountManager("AccountManagerImpl");
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            User user = new User();
            Member member = iqm.queryMember(RealName.Text.Trim());
            user.Memberid = member.Id;
            user.Mapid = member.Mapid;
            user.Username = Username.Text;
            user.Pwd = Pwd.Text;
            user.Tele = Tele.Text;
            user.Email = Email.Text;
            user.PerLevel = 3;
            iam.addUser(user);
        }
    }
}
