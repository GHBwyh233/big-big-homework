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
    public partial class DelF_Form : Form
    {
        public DelF_Form()
        {
            InitializeComponent();
        }

        private void DelF_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                IMapManager imm = ManagerFactory.getMapManager("MapManagerImpl");
                IQueryManager iqm = ManagerFactory.getQueryManager("QUeryManagerImpl");
                int mapid = int.Parse(Mapid.Text);
                Map map = iqm.queryMap(mapid);
                if (map == null)
                {
                    MessageBox.Show("该族谱不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                imm.deleteMap(mapid);
            MessageBox.Show("删除成功！");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
