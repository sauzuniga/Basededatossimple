using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectobasedatos
{
    public partial class fmrmenu : Form
    {
        public fmrmenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrtest fmr = new fmrtest();
            fmr.MdiParent = this;
            fmr.Show();
        }

        private void fmrmenu_Load(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fms = new Form1();
            fms.MdiParent = this;
            fms.Show();
        }
    }
}
