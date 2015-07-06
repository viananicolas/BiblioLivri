﻿using System;
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
    public partial class FrmGenero : Form
    {
        public FrmGenero()
        {
            InitializeComponent();
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
          
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
            CGenero.TBGenero oGenero = new CGenero.TBGenero();
            oGenero.GeDescricao = txtDescricao.Text;
            oProxy.Incluir(oGenero);
            txtDescricao.Text = "";
        }
    }
}
