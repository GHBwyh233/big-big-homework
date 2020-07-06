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
            try
            {
                Member member = new Member();
                Member m = new Member();
                IMemberManager imm = ManagerFactory.getMememberManager("MemberMangerImpl");
                IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
                m = iqm.queryMember(FatherName.Text.Trim());
                if (m == null)
                {
                    MessageBox.Show("您输入的成员父亲在族谱中不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                StringBuilder sb = new StringBuilder();
                member.Name = MemberName.Text.Trim();
                member.Fatherid = imm.getFatherId(FatherName.Text.Trim());
                member = iqm.queryMember(member.Fatherid);
                sb.Append(Year.GetItemText(Year.Items[0]));
                sb.Append("/");
                sb.Append(Month.GetItemText(Month.Items[0]));
                sb.Append("/");
                sb.Append(Day.GetItemText(Day.Items[0]));
                //MessageBox.Show(sb.ToString());
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            MessageBox.Show("添加成功！");
        }

        private void AddM_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
