using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek.Vue
{
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            FrmAbsences frmAbsences = new FrmAbsences();
            frmAbsences.ShowDialog();
        }
    }
}
