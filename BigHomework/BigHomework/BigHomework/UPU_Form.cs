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
    public partial class UPU_Form : Form
    {
        public UPU_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            IAccountManager iam = ManagerFactory.getAccountManager("AccountManagerImpl");
            string username = Username.Text.Trim();
            User user = iqm.queryUser(username);
            //修改
            user.Tele = Tele.Text;
            user.Email = Email.Text;
            iam.modifyUser(username, user);
            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            User user = iqm.queryUser(Username.Text.Trim());
            //显示
            Tele.Text = user.Tele;
            Email.Text = user.Email;
        }
    }
}
