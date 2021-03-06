﻿namespace BiblioLivri.View
{
    partial class FrmConsultaEditora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.dtgEditoras = new System.Windows.Forms.DataGridView();
            this.id_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditoras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.dtgEditoras);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 185);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editora:";
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Cidade",
            "Todos"});
            this.cmbPesquisa.Location = new System.Drawing.Point(6, 19);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(97, 21);
            this.cmbPesquisa.TabIndex = 38;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(109, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(455, 20);
            this.txtPesquisa.TabIndex = 37;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(570, 17);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 39;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgEditoras
            // 
            this.dtgEditoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_editora,
            this.EdNome,
            this.EdCidade,
            this.EdEmail,
            this.EdTelefone});
            this.dtgEditoras.Location = new System.Drawing.Point(3, 45);
            this.dtgEditoras.Name = "dtgEditoras";
            this.dtgEditoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEditoras.Size = new System.Drawing.Size(642, 119);
            this.dtgEditoras.TabIndex = 2;
            // 
            // id_editora
            // 
            this.id_editora.DataPropertyName = "id_editora";
            this.id_editora.HeaderText = "ID Editora";
            this.id_editora.Name = "id_editora";
            this.id_editora.ReadOnly = true;
            // 
            // EdNome
            // 
            this.EdNome.DataPropertyName = "EdNome";
            this.EdNome.HeaderText = "Nome";
            this.EdNome.Name = "EdNome";
            this.EdNome.ReadOnly = true;
            // 
            // EdCidade
            // 
            this.EdCidade.DataPropertyName = "EdCidade";
            this.EdCidade.HeaderText = "Cidade";
            this.EdCidade.Name = "EdCidade";
            this.EdCidade.ReadOnly = true;
            // 
            // EdEmail
            // 
            this.EdEmail.DataPropertyName = "EdEmail";
            this.EdEmail.HeaderText = "Email";
            this.EdEmail.Name = "EdEmail";
            this.EdEmail.ReadOnly = true;
            // 
            // EdTelefone
            // 
            this.EdTelefone.DataPropertyName = "EdTelefone";
            this.EdTelefone.HeaderText = "Telefone";
            this.EdTelefone.Name = "EdTelefone";
            this.EdTelefone.ReadOnly = true;
            // 
            // FrmConsultaEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 207);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Editoras";
            this.Load += new System.EventHandler(this.FrmConsultaEditora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView dtgEditoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdTelefone;
    }
}