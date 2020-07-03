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
        public AddM_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            IMemberManager imm = ManagerFactory.getMememberManager("");
            member.Name = MemberName.Text.Trim();
            member.Fatherid = imm.getFatherId(FatherName.Text.Trim());
            //member.Birth = Birth.Value.ToString();
            imm.addMember(member);
        }

        private void AddM_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
