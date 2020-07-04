using System;
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
    public partial class NormalForm : Form
    {
        private string username;
        public NormalForm()
        {
            InitializeComponent();
        }
        public NormalForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LocatingForm flc = new LocatingForm();
            flc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddP_Form af1 = new AddP_Form(username);
            af1.ShowDialog();
        }

        private void NormalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
