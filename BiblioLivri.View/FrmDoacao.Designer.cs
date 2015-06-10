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
            this.cmbLivros = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            empISBNLabel = new System.Windows.Forms.Label();
            empNumCartaoLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
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
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnDoar
            // 
            this.btnDoar.Location = new System.Drawing.Point(387, 40);
            this.btnDoar.Name = "btnDoar";
            this.btnDoar.Size = new System.Drawing.Size(75, 23);
            this.btnDoar.TabIndex = 24;
            this.btnDoar.Text = "Doar:";
            this.btnDoar.UseVisualStyleBackColor = true;
            this.btnDoar.Click += new System.EventHandler(this.btnDoar_Click);
            // 
            // cmbLivros
            // 
            this.cmbLivros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLivros.FormattingEnabled = true;
            this.cmbLivros.Location = new System.Drawing.Point(379, 12);
            this.cmbLivros.Name = "cmbLivros";
            this.cmbLivros.Size = new System.Drawing.Size(291, 21);
            this.cmbLivros.TabIndex = 21;
            this.cmbLivros.SelectedValueChanged += new System.EventHandler(this.cmbLivros_SelectedValueChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(57, 12);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(277, 21);
            this.cmbCliente.TabIndex = 20;
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectedValueChanged);
            // 
            // FrmDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 490);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnDoar);
            this.Controls.Add(this.cmbLivros);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(empISBNLabel);
            this.Controls.Add(empNumCartaoLabel);
            this.Name = "FrmDoacao";
            this.Text = "Doações";
            this.Load += new System.EventHandler(this.FrmDoacao_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lsBLivrosSelecionados;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnDoar;
        private System.Windows.Forms.ComboBox cmbLivros;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}