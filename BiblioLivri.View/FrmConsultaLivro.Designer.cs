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
            "Titulo"});
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
            // 
            // dtgLivros
            // 
            this.dtgLivros.AllowUserToAddRows = false;
            this.dtgLivros.AllowUserToDeleteRows = false;
            this.dtgLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dtgCopiaLivro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgCopiaLivro.Location = new System.Drawing.Point(12, 19);
            this.dtgCopiaLivro.Name = "dtgCopiaLivro";
            this.dtgCopiaLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCopiaLivro.Size = new System.Drawing.Size(804, 174);
            this.dtgCopiaLivro.TabIndex = 4;
            // 
            // FrmConsultaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmConsultaLivro";
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
    }
}