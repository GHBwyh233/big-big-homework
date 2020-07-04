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
    public partial class LoU_Form : Form
    {
        public LoU_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            User user = iqm.queryUser(Username.Text.Trim());
            Username1.Text = iqm.getMemberName(user.Memberid);
            Tele.Text = user.Tele;
            Email.Text = user.Email;
            switch (user.PerLevel) 
            {
                case 1:
                    PerLevel.Text = "超级管理员";
                    break;
                case 2:
                    PerLevel.Text = "家族管理员";
                    break;
                case 3:
                    PerLevel.Text = "普通成员";
                    break;
            }
            MapName.Text = iqm.getMapName(user.Memberid);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
