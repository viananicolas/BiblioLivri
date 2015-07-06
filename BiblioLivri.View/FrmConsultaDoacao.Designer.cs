namespace BiblioLivri.View
{
    partial class FrmConsultaDoacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgItensDoados = new System.Windows.Forms.DataGridView();
            this.ItemNumDoacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumCopia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDataDoacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgDoacoes = new System.Windows.Forms.DataGridView();
            this.DoNumDoacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoNumClienteDoador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensDoados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgItensDoados);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 159);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes da doação:";
            // 
            // dtgItensDoados
            // 
            this.dtgItensDoados.AllowUserToAddRows = false;
            this.dtgItensDoados.AllowUserToDeleteRows = false;
            this.dtgItensDoados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensDoados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumDoacao,
            this.ItemNumCopia,
            this.ItemDataDoacao});
            this.dtgItensDoados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgItensDoados.Location = new System.Drawing.Point(6, 19);
            this.dtgItensDoados.Name = "dtgItensDoados";
            this.dtgItensDoados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgItensDoados.Size = new System.Drawing.Size(436, 134);
            this.dtgItensDoados.TabIndex = 9;
            // 
            // ItemNumDoacao
            // 
            this.ItemNumDoacao.DataPropertyName = "ItemNumDoacao";
            this.ItemNumDoacao.HeaderText = "Nº Doação";
            this.ItemNumDoacao.Name = "ItemNumDoacao";
            this.ItemNumDoacao.ReadOnly = true;
            // 
            // ItemNumCopia
            // 
            this.ItemNumCopia.DataPropertyName = "ItemNumCopia";
            this.ItemNumCopia.HeaderText = "Nº Cópia";
            this.ItemNumCopia.Name = "ItemNumCopia";
            this.ItemNumCopia.ReadOnly = true;
            // 
            // ItemDataDoacao
            // 
            this.ItemDataDoacao.DataPropertyName = "ItemDataDoacao";
            this.ItemDataDoacao.HeaderText = "Data da doação";
            this.ItemDataDoacao.Name = "ItemDataDoacao";
            this.ItemDataDoacao.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgDoacoes);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.cmbPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 192);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doações realizadas:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtgDoacoes
            // 
            this.dtgDoacoes.AllowUserToAddRows = false;
            this.dtgDoacoes.AllowUserToDeleteRows = false;
            this.dtgDoacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoNumDoacao,
            this.DoNumClienteDoador});
            this.dtgDoacoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgDoacoes.Location = new System.Drawing.Point(5, 53);
            this.dtgDoacoes.Name = "dtgDoacoes";
            this.dtgDoacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDoacoes.Size = new System.Drawing.Size(436, 133);
            this.dtgDoacoes.TabIndex = 1;
            this.dtgDoacoes.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgDoacoes_CellBeginEdit);
            this.dtgDoacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDoacoes_CellContentClick);
            this.dtgDoacoes.SelectionChanged += new System.EventHandler(this.dtgDoacoes_SelectionChanged);
            // 
            // DoNumDoacao
            // 
            this.DoNumDoacao.DataPropertyName = "DoNumDoacao";
            this.DoNumDoacao.HeaderText = "Nº Doação";
            this.DoNumDoacao.Name = "DoNumDoacao";
            this.DoNumDoacao.ReadOnly = true;
            // 
            // DoNumClienteDoador
            // 
            this.DoNumClienteDoador.DataPropertyName = "DoNumClienteDoador";
            this.DoNumClienteDoador.HeaderText = "Nº Cartão Cliente Doador";
            this.DoNumClienteDoador.Name = "DoNumClienteDoador";
            this.DoNumClienteDoador.ReadOnly = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(108, 27);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(233, 20);
            this.txtPesquisa.TabIndex = 27;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(347, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "ID Cliente",
            "ID Livro",
            "Todos"});
            this.cmbPesquisa.Location = new System.Drawing.Point(5, 27);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(97, 21);
            this.cmbPesquisa.TabIndex = 28;
            // 
            // FrmConsultaDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaDoacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Doações";
            this.Load += new System.EventHandler(this.FrmConsultaDoacao_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensDoados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgItensDoados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgDoacoes;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumDoacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumCopia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDataDoacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoNumDoacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoNumClienteDoador;
    }
}