namespace BiblioLivri.View
{
    partial class FrmEmprestimo
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
            System.Windows.Forms.Label empNumCartaoLabel;
            System.Windows.Forms.Label empISBNLabel;
            System.Windows.Forms.Label empDataDevolucaoLabel;
            this.dtpDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbLivros = new System.Windows.Forms.ComboBox();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lsBLivrosSelecionados = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            empNumCartaoLabel = new System.Windows.Forms.Label();
            empISBNLabel = new System.Windows.Forms.Label();
            empDataDevolucaoLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // empNumCartaoLabel
            // 
            empNumCartaoLabel.AutoSize = true;
            empNumCartaoLabel.Location = new System.Drawing.Point(4, 12);
            empNumCartaoLabel.Name = "empNumCartaoLabel";
            empNumCartaoLabel.Size = new System.Drawing.Size(42, 13);
            empNumCartaoLabel.TabIndex = 2;
            empNumCartaoLabel.Text = "Cliente:";
            // 
            // empISBNLabel
            // 
            empISBNLabel.AutoSize = true;
            empISBNLabel.Location = new System.Drawing.Point(335, 12);
            empISBNLabel.Name = "empISBNLabel";
            empISBNLabel.Size = new System.Drawing.Size(33, 13);
            empISBNLabel.TabIndex = 4;
            empISBNLabel.Text = "Livro:";
            // 
            // empDataDevolucaoLabel
            // 
            empDataDevolucaoLabel.AutoSize = true;
            empDataDevolucaoLabel.Location = new System.Drawing.Point(7, 39);
            empDataDevolucaoLabel.Name = "empDataDevolucaoLabel";
            empDataDevolucaoLabel.Size = new System.Drawing.Size(112, 13);
            empDataDevolucaoLabel.TabIndex = 6;
            empDataDevolucaoLabel.Text = "Emp Data Devolucao:";
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.Location = new System.Drawing.Point(125, 35);
            this.dtpDataDevolucao.Name = "dtpDataDevolucao";
            this.dtpDataDevolucao.Size = new System.Drawing.Size(250, 20);
            this.dtpDataDevolucao.TabIndex = 7;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(52, 9);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(277, 21);
            this.cmbCliente.TabIndex = 8;
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectedValueChanged);
            // 
            // cmbLivros
            // 
            this.cmbLivros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLivros.FormattingEnabled = true;
            this.cmbLivros.Location = new System.Drawing.Point(374, 9);
            this.cmbLivros.Name = "cmbLivros";
            this.cmbLivros.Size = new System.Drawing.Size(291, 21);
            this.cmbLivros.TabIndex = 9;
            this.cmbLivros.SelectedValueChanged += new System.EventHandler(this.cmbLivros_SelectedValueChanged);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(382, 37);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(75, 23);
            this.btnEmprestar.TabIndex = 12;
            this.btnEmprestar.Text = "Emprestar:";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(671, 7);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lsBLivrosSelecionados
            // 
            this.lsBLivrosSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsBLivrosSelecionados.FormattingEnabled = true;
            this.lsBLivrosSelecionados.Location = new System.Drawing.Point(6, 19);
            this.lsBLivrosSelecionados.Name = "lsBLivrosSelecionados";
            this.lsBLivrosSelecionados.Size = new System.Drawing.Size(354, 43);
            this.lsBLivrosSelecionados.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsBLivrosSelecionados);
            this.groupBox3.Location = new System.Drawing.Point(475, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 78);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Livros selecionados:";
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 129);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.cmbLivros);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(empDataDevolucaoLabel);
            this.Controls.Add(this.dtpDataDevolucao);
            this.Controls.Add(empISBNLabel);
            this.Controls.Add(empNumCartaoLabel);
            this.Name = "FrmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar empréstimo";
            this.Load += new System.EventHandler(this.FrmEmprestimo_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDataDevolucao;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbLivros;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ListBox lsBLivrosSelecionados;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}