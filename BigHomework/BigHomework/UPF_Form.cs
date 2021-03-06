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
    public partial class UPF_Form : Form
    {
        public UPF_Form()
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
                MessageBox.Show("族谱不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //显示
            MapName.Text = map.Name;
            Surname.Text = map.Surname;
            Generation.Text = map.Generation;
            Precepts.Text = map.Precepts;
            Introduce.Text = map.Introduce;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            IMapManager imm = ManagerFactory.getMapManager("MapManagerImpl");
            int mapid = int.Parse(Mapid.Text);
            Map map = new Map();
            //修改
            map.Name = MapName.Text.Trim();
            map.Surname = Surname.Text.Trim();
            map.Generation = Generation.Text.Trim();
            map.Precepts = Precepts.Text.Trim();
            map.Introduce = Introduce.Text.Trim();
            imm.modifyMap(mapid, map);
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
