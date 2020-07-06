using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigHomework
{
    public partial class RootForm : Form
    {
        private LoginForm loginForm = null;
        public RootForm()
        {
            InitializeComponent();
        }
        public RootForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //更新用户对应的权限
            UPU2_Form U2 = new UPU2_Form();
            U2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //查询账号信息界面，新弹出窗体，可执行修改功能
            LoU_Form LU = new LoU_Form();
            LU.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UPU_Form U1 = new UPU_Form();
            U1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RootForm_Load(object sender, EventArgs e)
        {

        }

        private void RootForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }
    }
}
