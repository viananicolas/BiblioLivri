using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioLivri.View
{
    public partial class FrmFilme : Form
    {
        public FrmFilme()
        {
            InitializeComponent();
        }

        private void FrmFilme_Load(object sender, EventArgs e)
        {
            CFilme.TBFilme fsf = new CFilme.TBFilme();
        }
    }
}
