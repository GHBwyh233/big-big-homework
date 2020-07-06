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
    public partial class DelM_Form : Form
    {
        public DelM_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMemberManager imm = ManagerFactory.getMememberManager("MemberMangerImpl");
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            string name = MemberName.Text.Trim();
            Member member = iqm.queryMember(name);
            if (member == null)
            {
                MessageBox.Show("该成员不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            imm.deletePartner(MemberName.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
