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
    public partial class QueryAllM_Form : Form
    {
        public QueryAllM_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            int mapid = int.Parse(Mapid.Text);
            int index;
            string fatherName = null;
            string partnerName = null;
            List<Member> list = iqm.getMemberList(mapid);
            dgv.Rows.Clear();
            if (list == null)
            {
                MessageBox.Show("该族谱还没有添加成员！");
                return;
            }
            
            foreach (Member member in list)
            {
                index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = member.Id;
                dgv.Rows[index].Cells[1].Value = member.Name;
                dgv.Rows[index].Cells[2].Value = member.Sex;
                dgv.Rows[index].Cells[3].Value = member.Generation;
                dgv.Rows[index].Cells[4].Value = member.Birth;
                dgv.Rows[index].Cells[5].Value = member.BirthPlace;
                dgv.Rows[index].Cells[6].Value = member.Idcard;
                fatherName = iqm.getFatherName(member.Fatherid);
                if (fatherName == null)
                {
                    dgv.Rows[index].Cells[7].Value = "无";
                }
                else
                {
                    dgv.Rows[index].Cells[7].Value = fatherName;
                }
                partnerName = iqm.getPartnerName(member.Id);
                if (partnerName == null)
                {
                    dgv.Rows[index].Cells[8].Value = "无";
                }
                else
                {
                    dgv.Rows[index].Cells[8].Value = partnerName;
                }
            }
        }
    }
}
