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
            Member m = iqm.getAncestor(member.Mapid);
            if (member == null)
            {
                MessageBox.Show("该成员不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (member.Id == m.Id)
            {
                MessageBox.Show("该成员为该族谱祖先，不能删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            imm.deleteMember(MemberName.Text.Trim());
            MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
