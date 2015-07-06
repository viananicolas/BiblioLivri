namespace BiblioLivri.View
{
    partial class FrmConsultaAutor
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dtgAutores = new System.Windows.Forms.DataGridView();
            this.id_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuNacionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmbPesquisa);
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Controls.Add(this.dtgAutores);
            this.groupBox2.Location = new System.Drawing.Point(0, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 348);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autores:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Sobrenome",
            "Nacionalidade",
            "Todos"});
            this.cmbPesquisa.Location = new System.Drawing.Point(16, 19);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(97, 21);
            this.cmbPesquisa.TabIndex = 8;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(119, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(258, 20);
            this.txtPesquisa.TabIndex = 3;
            // 
            // dtgAutores
            // 
            this.dtgAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_autor,
            this.AuNome,
            this.AuSobrenome,
            this.AuNacionalidade});
            this.dtgAutores.Location = new System.Drawing.Point(16, 46);
            this.dtgAutores.Name = "dtgAutores";
            this.dtgAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAutores.Size = new System.Drawing.Size(471, 296);
            this.dtgAutores.TabIndex = 2;
            // 
            // id_autor
            // 
            this.id_autor.DataPropertyName = "id_autor";
            this.id_autor.HeaderText = "ID Autor";
            this.id_autor.Name = "id_autor";
            this.id_autor.ReadOnly = true;
            // 
            // AuNome
            // 
            this.AuNome.DataPropertyName = "AuNome";
            this.AuNome.HeaderText = "Nome";
            this.AuNome.Name = "AuNome";
            this.AuNome.ReadOnly = true;
            // 
            // AuSobrenome
            // 
            this.AuSobrenome.DataPropertyName = "AuSobrenome";
            this.AuSobrenome.HeaderText = "Sobrenome";
            this.AuSobrenome.Name = "AuSobrenome";
            this.AuSobrenome.ReadOnly = true;
            // 
            // AuNacionalidade
            // 
            this.AuNacionalidade.DataPropertyName = "AuNacionalidade";
            this.AuNacionalidade.HeaderText = "Nacionalidade";
            this.AuNacionalidade.Name = "AuNacionalidade";
            this.AuNacionalidade.ReadOnly = true;
            // 
            // FrmConsultaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 372);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de autores";
            this.Load += new System.EventHandler(this.FrmConsultaAutor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dtgAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuSobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuNacionalidade;
    }
}