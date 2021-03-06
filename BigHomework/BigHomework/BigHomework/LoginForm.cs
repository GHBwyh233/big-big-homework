﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


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
            IAccountManager iam = ManagerFactory.getAccountManager("AccountManagerImpl");
            string username = Account.Text.Trim();
            string pwd = Password.Text;
            int level;
            if (iam.isLogin(username, pwd))
            {
                level = iam.getPerLevel(username);
                
                //尝试按照权限登录系统
                if (level == 1)
                {
                    //MessageBox.Show(level.ToString());
                    RootForm rootForm = new RootForm();
                    this.Hide();
                    rootForm.ShowDialog();

                    
                }
                else if (level == 3)
                {
                    NormalForm normalForm = new NormalForm(username);
                    this.Hide();
                    normalForm.Show();
                }
                else
                {
                    FamCtrForm famCtrForm = new FamCtrForm();
                    this.Hide();
                    famCtrForm.Show();
                }
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
