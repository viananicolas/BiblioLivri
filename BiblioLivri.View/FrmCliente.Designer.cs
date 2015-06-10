namespace BiblioLivri.View
{
    partial class FrmCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "País:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Complemento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtSobrenome);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 96);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(75, 69);
            this.txtCPF.Mask = "999-999-999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 8;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(280, 69);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(79, 20);
            this.txtID.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Nº Cartão";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(75, 42);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(386, 20);
            this.txtSobrenome.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(475, 200);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCEP);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.cmbPais);
            this.groupBox2.Controls.Add(this.cmbEstado);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 117);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(54, 62);
            this.txtCEP.Mask = "99999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 9;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(261, 88);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(179, 20);
            this.txtEndereco.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(181, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Endereço:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(261, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(98, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Número:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(261, 62);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(98, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(54, 88);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(54, 36);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(54, 13);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(386, 20);
            this.txtCidade.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTelefone);
            this.groupBox3.Controls.Add(this.txtCelular);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(492, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 84);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(64, 35);
            this.txtTelefone.Mask = "(99)99999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 16;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(64, 13);
            this.txtCelular.Mask = "(99)99999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 15;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(49, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Email:";
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
            this.dtgClientes.Size = new System.Drawing.Size(835, 166);
            this.dtgClientes.TabIndex = 13;
            this.dtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentClick);
            this.dtgClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExcluir);
            this.groupBox4.Controls.Add(this.btnAlterar);
            this.groupBox4.Controls.Add(this.btnPesquisar);
            this.groupBox4.Controls.Add(this.cmbCriterio);
            this.groupBox4.Controls.Add(this.txtCriterio);
            this.groupBox4.Controls.Add(this.dtgClientes);
            this.groupBox4.Location = new System.Drawing.Point(12, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(847, 217);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Todos os clientes:";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(766, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(685, 16);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(425, 17);
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
            this.cmbCriterio.Location = new System.Drawing.Point(298, 19);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterio.TabIndex = 16;
            this.cmbCriterio.SelectedIndexChanged += new System.EventHandler(this.cmbCriterio_SelectedIndexChanged);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(6, 19);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(286, 20);
            this.txtCriterio.TabIndex = 15;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 462);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtCEP;
    }
}