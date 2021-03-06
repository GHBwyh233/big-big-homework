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
using Model;

namespace BigHomework
{
    public partial class QueryA_Form : Form
    {
        public QueryA_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            int mapid = int.Parse(Mapid.Text);
            Map map = iqm.queryMap(mapid);
            if (map == null)
            {
                MessageBox.Show("该族谱不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Member member = iqm.getAncestor(mapid);
            if (member == null)
            {
                MessageBox.Show("该族谱中还没有成员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AName.Text = member.Name;
            Birth.Text = member.Birth;
            BirthPlace.Text = member.BirthPlace;
            Generation.Text = member.Generation;
            Idcard.Text = member.Idcard;
            if (member.Sex == '男')
            {
                Male.Checked = true;
            }
            else
            {
                Female.Checked = true;
            }
        }
    }
}
