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
    public partial class FindPwdForm : Form
    {
        private IAccountManager iam = ManagerFactory.getAccountManager("");
        public FindPwdForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iam.hasUser("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iam.verifyUser("","");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iam.modifyUserPassword("", "");
        }
    }
}
