namespace BiblioLivri.View
{
    partial class FrmConsultaCliente
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(766, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Items.AddRange(new object[] {
            "Cidade",
            "CPF",
            "Nome",
            "Sobrenome",
            "Todos"});
            this.cmbCriterio.Location = new System.Drawing.Point(6, 17);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterio.TabIndex = 16;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(133, 19);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(627, 20);
            this.txtCriterio.TabIndex = 15;
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(6, 45);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(835, 415);
            this.dtgClientes.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPesquisar);
            this.groupBox4.Controls.Add(this.cmbCriterio);
            this.groupBox4.Controls.Add(this.txtCriterio);
            this.groupBox4.Controls.Add(this.dtgClientes);
            this.groupBox4.Location = new System.Drawing.Point(1, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(847, 466);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Todos os clientes:";
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 490);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes cadastrados";
            this.Load += new System.EventHandler(this.FrmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}