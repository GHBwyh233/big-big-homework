﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace BigHomework
{
    public partial class AddF_Form : Form
    {
        public AddF_Form()
        {
            InitializeComponent();
        }

        private void AddF_Form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMapManager imm = ManagerFactory.getMapManager("");
            Map map = new Map();
            imm.addMap(map);
        }
    }
}