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
    public partial class UPU2_Form : Form
    {
        public UPU2_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IAccountManager iam = ManagerFactory.getAccountManager("AccountManagerImpl");
            int perLevel = 3;
            string username = Username.Text;
            if (iam.hasUser(username))
            {
                MessageBox.Show("账号不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (FamCtr.Checked)
            {
                perLevel = 2;
            }
            iam.modifyUserPerLevel(username, perLevel);
            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
