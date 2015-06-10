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
    public partial class FrmConsultaEditora : Form
    {
        public FrmConsultaEditora()
        {
            InitializeComponent();
        }

        private void FrmConsultaEditora_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
            dtgEditoras.DataSource = oProxy.SelecionaTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                var oProxy = new CEditora.CEditoraClient();
                dtgEditoras.DataSource = oProxy.SelecionaTodosCriterio(txtPesquisa.Text, cmbPesquisa.SelectedIndex);
            }
        }
    }
}