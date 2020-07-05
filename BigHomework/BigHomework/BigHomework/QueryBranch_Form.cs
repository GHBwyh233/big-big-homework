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
    public partial class QueryBranch_Form : Form
    {
        private IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
        
        private Member member = new Member();
        public QueryBranch_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int memberid = int.Parse(Memberid.Text);
            int num = 0;
            Member m = new Member();
            member = iqm.queryMember(memberid);
            if (member == null)
            {
                MessageBox.Show("该成员不存在！请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (member.Sex == '女')
            {
                MessageBox.Show("该成员为女性成员，没有后代分支！请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int[] childid = iqm.getRelativeId(4,memberid);
            addDgv(childid,++num);

        }
        private void addDgv(int[] childid,int num)
        {
            int flag = num;
            int index;
            bool flag1 = false;
            for (int i = 0; i < childid.Length; i++)
            {
                if (childid[i] == 0)
                {
                    continue;
                }
                member = iqm.queryMember(childid[i]);
                if (member == null)
                {
                    continue;
                }
                index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = member.Name;
                dgv.Rows[index].Cells[1].Value = member.Sex;
                dgv.Rows[index].Cells[2].Value = member.Generation;
                dgv.Rows[index].Cells[3].Value = iqm.getFatherName(member.Fatherid);
                dgv.Rows[index].Cells[4].Value = "第"+flag.ToString()+"代";
                if (member.Sex == '女')
                {
                    continue;
                }
                int[] childid1 = iqm.getRelativeId(4,member.Id);
                for (int j = 0; j < childid1.Length; j++)
                {
                    if (childid1[i] != 0)
                    {
                        flag1 = true;
                        break;
                    }
                }
                if (flag1)
                {
                    addDgv(childid1,flag+1);
                }
                flag1 = false;
            }
        }
    }
}
