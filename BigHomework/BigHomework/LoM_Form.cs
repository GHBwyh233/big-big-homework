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
    public partial class LoM_Form : Form
    {
        public LoM_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            int id = int.Parse(Memberid.Text);
            string fatherName = null;
            string mapName = null;
            string partnerName = null;
            Member member = iqm.queryMember(id);
            if (member == null)
            {
                MessageBox.Show("该成员不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MemberName.Text = member.Name;
            Sex.Text = member.Sex.ToString();
            Birth.Text = member.Birth;
            BirthPlace.Text = member.BirthPlace;
            Generation.Text = member.Generation;
            fatherName = iqm.getFatherName(member.Fatherid);
            mapName = iqm.getMapName(id);
            partnerName = iqm.getPartnerName(id);
            if (fatherName != null)
            {
                FatherName.Text = fatherName;
            }
            else 
            {
                FatherName.Text = "无";
            }
            if (mapName != null)
            {
                MapName.Text = mapName;
            }
            else
            {
                MapName.Text = "无";
            }
            if (partnerName != null) 
            {
                PartnerName.Text = partnerName;
            }
            else
            {
                PartnerName.Text = "无";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
