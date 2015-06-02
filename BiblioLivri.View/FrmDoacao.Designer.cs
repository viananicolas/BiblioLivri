namespace BiblioLivri.View
{
    partial class FrmDoacao
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
            System.Windows.Forms.Label empISBNLabel;
            System.Windows.Forms.Label empNumCartaoLabel;
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsBLivrosSelecionados = new System.Windows.Forms.ListBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnDoar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgItensDoados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtgDoacoes = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbLivros = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            empISBNLabel = new System.Windows.Forms.Label();
            empNumCartaoLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensDoados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // empISBNLabel
            // 
            empISBNLabel.AutoSize = true;
            empISBNLabel.Location = new System.Drawing.Point(340, 15);
            empISBNLabel.Name = "empISBNLabel";
            empISBNLabel.Size = new System.Drawing.Size(33, 13);
            empISBNLabel.TabIndex = 17;
            empISBNLabel.Text = "Livro:";
            // 
            // empNumCartaoLabel
            // 
            empNumCartaoLabel.AutoSize = true;
            empNumCartaoLabel.Location = new System.Drawing.Point(9, 15);
            empNumCartaoLabel.Name = "empNumCartaoLabel";
            empNumCartaoLabel.Size = new System.Drawing.Size(42, 13);
            empNumCartaoLabel.TabIndex = 16;
            empNumCartaoLabel.Text = "Cliente:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsBLivrosSelecionados);
            this.groupBox3.Location = new System.Drawing.Point(480, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 78);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Livros selecionados:";
            // 
            // lsBLivrosSelecionados
            // 
            this.lsBLivrosSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsBLivrosSelecionados.FormattingEnabled = true;
            this.lsBLivrosSelecionados.Location = new System.Drawing.Point(6, 19);
            this.lsBLivrosSelecionados.Name = "lsBLivrosSelecionados";
            this.lsBLivrosSelecionados.Size = new System.Drawing.Size(354, 56);
            this.lsBLivrosSelecionados.TabIndex = 14;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(676, 10);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 25;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnDoar
            // 
            this.btnDoar.Location = new System.Drawing.Point(387, 40);
            this.btnDoar.Name = "btnDoar";
            this.btnDoar.Size = new System.Drawing.Size(75, 23);
            this.btnDoar.TabIndex = 24;
            this.btnDoar.Text = "Doar:";
            this.btnDoar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgItensDoados);
            this.groupBox2.Location = new System.Drawing.Point(4, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 159);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes da doação:";
            // 
            // dtgItensDoados
            // 
            this.dtgItensDoados.AllowUserToAddRows = false;
            this.dtgItensDoados.AllowUserToDeleteRows = false;
            this.dtgItensDoados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensDoados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgItensDoados.Location = new System.Drawing.Point(6, 19);
            this.dtgItensDoados.Name = "dtgItensDoados";
            this.dtgItensDoados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgItensDoados.Size = new System.Drawing.Size(829, 134);
            this.dtgItensDoados.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.dtgDoacoes);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(4, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 192);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doações realizadas:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(753, 24);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dtgDoacoes
            // 
            this.dtgDoacoes.AllowUserToAddRows = false;
            this.dtgDoacoes.AllowUserToDeleteRows = false;
            this.dtgDoacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoacoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgDoacoes.Location = new System.Drawing.Point(5, 53);
            this.dtgDoacoes.Name = "dtgDoacoes";
            this.dtgDoacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDoacoes.Size = new System.Drawing.Size(829, 133);
            this.dtgDoacoes.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(672, 24);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(108, 27);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(233, 20);
            this.txtPesquisa.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID Cliente",
            "ID Livro"});
            this.comboBox1.Location = new System.Drawing.Point(5, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // cmbLivros
            // 
            this.cmbLivros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLivros.FormattingEnabled = true;
            this.cmbLivros.Location = new System.Drawing.Point(379, 12);
            this.cmbLivros.Name = "cmbLivros";
            this.cmbLivros.Size = new System.Drawing.Size(291, 21);
            this.cmbLivros.TabIndex = 21;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(57, 12);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(277, 21);
            this.cmbCliente.TabIndex = 20;
            // 
            // FrmDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 490);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnDoar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbLivros);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(empISBNLabel);
            this.Controls.Add(empNumCartaoLabel);
            this.Name = "FrmDoacao";
            this.Text = "Doações";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensDoados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lsBLivrosSelecionados;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnDoar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgItensDoados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgDoacoes;
        private System.Windows.Forms.ComboBox cmbLivros;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}