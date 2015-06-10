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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtgDoacoes = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.groupBox2.Size = new System.Drawing.Size(842, 159);
            this.groupBox2.TabIndex = 25;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 192);
            this.groupBox1.TabIndex = 24;
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
            // FrmConsultaDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaDoacao";
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
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dtgDoacoes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}