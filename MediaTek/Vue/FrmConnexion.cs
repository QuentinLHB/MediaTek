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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            txtMdp.UseSystemPasswordChar = true;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            FrmPersonnel frmPersonnel =  new FrmPersonnel();
            frmPersonnel.ShowDialog();
        }
    }
}
