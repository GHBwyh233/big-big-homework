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
    public partial class QueryRela_Form : Form
    {
        public QueryRela_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            int id = int.Parse(Memberid.Text);
            int index;
            Member member = new Member();
            Member m = null;
            m = iqm.queryMember(id);
            if (m == null)
            {
                MessageBox.Show("该成员不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int[] fatherid = iqm.getRelativeId(1,id);
            int[] brotherid = iqm.getRelativeId(2, id);
            Partner mother = iqm.getMother(id);
            int[] systerid = iqm.getRelativeId(3, id);
            dgv.Rows.Clear();
            for (int i = 0; i < fatherid.Length; i++)
            {
                if (fatherid[i] == 0)
                {
                    continue;
                }
                index = dgv.Rows.Add();
                member = iqm.queryMember(fatherid[i]);
                dgv.Rows[index].Cells[0].Value = member.Name;
                dgv.Rows[index].Cells[1].Value = member.Sex;
                dgv.Rows[index].Cells[2].Value = member.Generation;
                dgv.Rows[index].Cells[3].Value = member.Birth;
                dgv.Rows[index].Cells[4].Value = "父子";
                dgv.Rows[index].Cells[5].Value = member.Idcard;
            }
            if(mother!=null)
            { 
                index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = mother.Name;
                dgv.Rows[index].Cells[1].Value = mother.Sex;
                dgv.Rows[index].Cells[2].Value = "无";
                dgv.Rows[index].Cells[3].Value = "无";
                dgv.Rows[index].Cells[4].Value = "母子";
                dgv.Rows[index].Cells[5].Value = "无";
            }
            for (int i = 0; i < brotherid.Length; i++)
            {
                if (brotherid[i] == 0)
                {
                    continue;
                }
                index = dgv.Rows.Add();
                member = iqm.queryMember(brotherid[i]);
                dgv.Rows[index].Cells[0].Value = member.Name;
                dgv.Rows[index].Cells[1].Value = member.Sex;
                dgv.Rows[index].Cells[2].Value = member.Generation;
                dgv.Rows[index].Cells[3].Value = member.Birth;
                dgv.Rows[index].Cells[4].Value = "兄弟姐妹";
                dgv.Rows[index].Cells[5].Value = member.Idcard;
            }
            for (int i = 0; i < systerid.Length; i++)
            {
                if (systerid[i] == 0)
                {
                    continue;
                }
                member = iqm.queryMember(systerid[i]);
                index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = member.Name;
                dgv.Rows[index].Cells[1].Value = member.Sex;
                dgv.Rows[index].Cells[2].Value = member.Generation;
                dgv.Rows[index].Cells[3].Value = member.Birth;
                dgv.Rows[index].Cells[4].Value = "兄弟姐妹";
                dgv.Rows[index].Cells[5].Value = member.Idcard;
            }
        }
    }
}
