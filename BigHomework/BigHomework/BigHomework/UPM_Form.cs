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
    public partial class UPM_Form : Form
    {
        public UPM_Form()
        {
            InitializeComponent();
        }

        private void UPM_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            IMemberManager imm = ManagerFactory.getMememberManager("MemberMangerImpl");
            int memberid = int.Parse(Memberid.Text);
            Member member = iqm.queryMember(memberid);
            //修改
            member.Name = MemberName.Text;
            member.Generation = Generation.Text;
            member.Birth = Birth.Text;
            member.BirthPlace = BirthPlace.Text;
            member.Idcard = Idcard.Text;
            if (Male.Checked)
            {
                member.Sex = '男';
            }
            else
            {
                member.Sex = '女';
            }
            imm.modifyMember(1,member);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            int memberid = int.Parse(Memberid.Text);
            Member member = iqm.queryMember(memberid);
            MemberName.Text = member.Name;
            Generation.Text = member.Generation;
            Birth.Text = member.Birth;
            BirthPlace.Text = member.BirthPlace;
            Idcard.Text = member.Idcard;
            if (member.Sex == '男')
            {
                Male.Checked = true;
                Female.Checked = false;
            }
            else
            {
                Female.Checked = true;
                Male.Checked = false;
            }

        }
    }
}
