using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_pa_las_11
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciamos al formulario
            frmtest frm = new frmtest();
            frm.MdiParent = this; //definir formulario padre
            frm.Show(); // mostrar formulario
        }

        private void ordenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOrden fmr = new frmOrden();

            fmr.MdiParent = this;
            fmr.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
