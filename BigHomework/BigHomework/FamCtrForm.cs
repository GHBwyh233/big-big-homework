﻿using System;
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
    public partial class FamCtrForm : Form
    {
        private LoginForm loginForm = null;
        public FamCtrForm()
        {
            InitializeComponent();
        }
        public FamCtrForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }
        private void FamCtrForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LocatingForm flc = new LocatingForm();
            flc.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddF_Form af1 = new AddF_Form();
            af1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddM_Form am1 = new AddM_Form();
            am1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelF_Form Df1 = new DelF_Form();
            Df1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DelM_Form Dm1 = new DelM_Form();
            Dm1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UPF_Form uf1 = new UPF_Form();
            uf1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UPM_Form um1 = new UPM_Form();
            um1.ShowDialog();
        }

        private void FamCtrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }
    }
}
