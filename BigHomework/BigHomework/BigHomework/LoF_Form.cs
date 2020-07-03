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
    public partial class LoF_Form : Form
    {
        public LoF_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
            int id = int.Parse(Mapid.Text);
            Map map = iqm.queryMap(id);
            if (map == null)
            {
                MessageBox.Show("族谱不存在！");
                return;
            }
            MapName.Text = map.Name;
            Surname.Text = map.Surname;
            Generation.Text = map.Generation;
            Introduce.Text = map.Introduce;
            Precepts.Text = map.Precepts;
        }
    }
}
