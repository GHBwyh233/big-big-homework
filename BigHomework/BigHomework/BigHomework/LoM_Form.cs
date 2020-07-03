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
    public partial class LoM_Form : Form
    {
        public LoM_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IQueryManager iqm = ManagerFactory.getQueryManager("");
            int id = 1;
            Member user = iqm.queryMember(id);
        }
    }
}
