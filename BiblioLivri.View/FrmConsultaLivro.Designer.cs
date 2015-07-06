namespace BiblioLivri.View
{
    partial class FrmConsultaLivro
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtgLivros = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCopiaLivro = new System.Windows.Forms.DataGridView();
            this.CoEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoEmprestado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CoNumCopia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAquisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiCDU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLivros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCopiaLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPesquisa);
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.dtgLivros);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(822, 215);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Livros:";
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Autor",
            "ISBN",
            "Gênero",
            "Titulo",
            "Todos"});
            this.cmbPesquisa.Location = new System.Drawing.Point(10, 22);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(97, 21);
            this.cmbPesquisa.TabIndex = 43;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(113, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(622, 20);
            this.txtPesquisa.TabIndex = 42;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(741, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 44;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtgLivros
            // 
            this.dtgLivros.AllowUserToAddRows = false;
            this.dtgLivros.AllowUserToDeleteRows = false;
            this.dtgLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LiTitulo,
            this.LIISBN,
            this.LiCDU,
            this.LiPais,
            this.id_Autor,
            this.id_genero});
            this.dtgLivros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgLivros.Location = new System.Drawing.Point(12, 54);
            this.dtgLivros.Name = "dtgLivros";
            this.dtgLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLivros.Size = new System.Drawing.Size(804, 155);
            this.dtgLivros.TabIndex = 4;
            this.dtgLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLivros_CellContentClick);
            this.dtgLivros.SelectionChanged += new System.EventHandler(this.dtgLivros_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCopiaLivro);
            this.groupBox1.Location = new System.Drawing.Point(12, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 199);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cópias:";
            // 
            // dtgCopiaLivro
            // 
            this.dtgCopiaLivro.AllowUserToAddRows = false;
            this.dtgCopiaLivro.AllowUserToDeleteRows = false;
            this.dtgCopiaLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCopiaLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCopiaLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoEdicao,
            this.CoAno,
            this.CoEmprestado,
            this.CoNumCopia,
            this.CoIdioma,
            this.DataAquisicao});
            this.dtgCopiaLivro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgCopiaLivro.Location = new System.Drawing.Point(12, 19);
            this.dtgCopiaLivro.Name = "dtgCopiaLivro";
            this.dtgCopiaLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCopiaLivro.Size = new System.Drawing.Size(804, 174);
            this.dtgCopiaLivro.TabIndex = 4;
            // 
            // CoEdicao
            // 
            this.CoEdicao.DataPropertyName = "CoEdicao";
            this.CoEdicao.HeaderText = "Edição";
            this.CoEdicao.Name = "CoEdicao";
            this.CoEdicao.ReadOnly = true;
            // 
            // CoAno
            // 
            this.CoAno.DataPropertyName = "CoAno";
            this.CoAno.HeaderText = "Ano";
            this.CoAno.Name = "CoAno";
            this.CoAno.ReadOnly = true;
            // 
            // CoEmprestado
            // 
            this.CoEmprestado.DataPropertyName = "CoEmprestado";
            this.CoEmprestado.HeaderText = "Emprestado";
            this.CoEmprestado.Name = "CoEmprestado";
            this.CoEmprestado.ReadOnly = true;
            // 
            // CoNumCopia
            // 
            this.CoNumCopia.DataPropertyName = "CoNumCopia";
            this.CoNumCopia.HeaderText = "Nº Cópia";
            this.CoNumCopia.Name = "CoNumCopia";
            this.CoNumCopia.ReadOnly = true;
            // 
            // CoIdioma
            // 
            this.CoIdioma.DataPropertyName = "CoIdioma";
            this.CoIdioma.HeaderText = "Idioma";
            this.CoIdioma.Name = "CoIdioma";
            this.CoIdioma.ReadOnly = true;
            // 
            // DataAquisicao
            // 
            this.DataAquisicao.DataPropertyName = "DataAquisicao";
            this.DataAquisicao.HeaderText = "Data de Aquisição";
            this.DataAquisicao.Name = "DataAquisicao";
            this.DataAquisicao.ReadOnly = true;
            this.DataAquisicao.Width = 120;
            // 
            // LiTitulo
            // 
            this.LiTitulo.DataPropertyName = "LiTitulo";
            this.LiTitulo.HeaderText = "Titulo";
            this.LiTitulo.Name = "LiTitulo";
            this.LiTitulo.ReadOnly = true;
            // 
            // LIISBN
            // 
            this.LIISBN.DataPropertyName = "LiISBN";
            this.LIISBN.HeaderText = "ISBN";
            this.LIISBN.Name = "LIISBN";
            this.LIISBN.ReadOnly = true;
            // 
            // LiCDU
            // 
            this.LiCDU.DataPropertyName = "LiCDU";
            this.LiCDU.HeaderText = "CDU";
            this.LiCDU.Name = "LiCDU";
            this.LiCDU.ReadOnly = true;
            // 
            // LiPais
            // 
            this.LiPais.DataPropertyName = "LiPais";
            this.LiPais.HeaderText = "Pais";
            this.LiPais.Name = "LiPais";
            this.LiPais.ReadOnly = true;
            // 
            // id_Autor
            // 
            this.id_Autor.DataPropertyName = "id_Autor";
            this.id_Autor.HeaderText = "ID Autor";
            this.id_Autor.Name = "id_Autor";
            this.id_Autor.ReadOnly = true;
            // 
            // id_genero
            // 
            this.id_genero.DataPropertyName = "id_genero";
            this.id_genero.HeaderText = "ID Gênero";
            this.id_genero.Name = "id_genero";
            this.id_genero.ReadOnly = true;
            // 
            // FrmConsultaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de livros";
            this.Load += new System.EventHandler(this.FrmConsultaLivro_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLivros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCopiaLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgLivros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgCopiaLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoAno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CoEmprestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoNumCopia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAquisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiCDU;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_genero;
    }
}