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
    public partial class AddP_Form : Form
    {
        private string username;
        public AddP_Form()
        {
            InitializeComponent();
        }
        public AddP_Form(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private void AddP_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMemberManager imm = ManagerFactory.getMememberManager("");
            Partner partner = new Partner();
            imm.addPartner(partner);
        }
    }
}
