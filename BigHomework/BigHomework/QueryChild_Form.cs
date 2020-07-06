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
    public partial class QueryChild_Form : Form
    {
        public QueryChild_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            int id = int.Parse(Memberid.Text);
            int index;
            Member m = iqm.queryMember(id);
            if (m == null)
            {
                MessageBox.Show("该成员不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Member member = new Member();
            int[] childid = iqm.getRelativeId(4,id);
            dgv.Rows.Clear();
            if (m.Sex == '女')
            {
                MessageBox.Show("该成员为女性成员，后代不在其族谱表中！请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 0; i < childid.Length; i++)
            {
                if (childid[i] == 0)
                {
                    continue;
                }
                member = iqm.queryMember(childid[i]);
                index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = member.Name;
                dgv.Rows[index].Cells[1].Value = member.Sex;
                dgv.Rows[index].Cells[2].Value = member.Generation;
                dgv.Rows[index].Cells[3].Value = member.Birth;
                dgv.Rows[index].Cells[4].Value = member.BirthPlace;
                if (member.Sex == '男')
                {
                    dgv.Rows[index].Cells[5].Value = "父子";
                }
                else
                {
                    dgv.Rows[index].Cells[5].Value = "父女";
                }
                
            }
        }
    }
}
