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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //尝试按照权限登录系统
            if (Program.status == 1)
            {
                RootForm rootForm = new RootForm();
                this.Close();
                rootForm.Show();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //注册账号
            RegistForm registForm = new RegistForm();
            registForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //用户忘记密码，尝试找回
            FindPwdForm findPwdForm = new FindPwdForm();
            findPwdForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
