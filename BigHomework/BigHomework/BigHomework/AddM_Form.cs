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
    public partial class AddM_Form : Form
    {
        private int id;//管理员id
        public AddM_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            IMemberManager imm = ManagerFactory.getMememberManager("MemberMangerImpl");
            StringBuilder sb = new StringBuilder();
            member.Name = MemberName.Text.Trim();
            member.Fatherid = imm.getFatherId(FatherName.Text.Trim());
            sb.Append(Birth.Value.Year.ToString());
            sb.Append("-");
            sb.Append(Birth.Value.Month.ToString());
            sb.Append("-");
            sb.Append(Birth.Value.Day.ToString());
            member.Birth = sb.ToString();
            member.BirthPlace = BirthPlace.Text;
            member.Generation = Generation.Text.Trim();
            member.Idcard = Idcard.Text;
            if (Male.Checked)
            {
                member.Sex = '男';
            }
            else
            {
                member.Sex = '女';
            }
            member.Mapid = imm.getMapid(id);
            imm.addMember(member);
        }

        private void AddM_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
