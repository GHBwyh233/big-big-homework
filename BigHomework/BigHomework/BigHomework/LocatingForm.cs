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
    public partial class LocatingForm : Form
    {
        public LocatingForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoM_Form lm = new LoM_Form();
            lm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoF_Form lf = new LoF_Form();
            lf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
