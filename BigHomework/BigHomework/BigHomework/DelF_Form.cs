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
            imm.deleteMap(int.Parse(Mapid.Text));
        }
    }
}
