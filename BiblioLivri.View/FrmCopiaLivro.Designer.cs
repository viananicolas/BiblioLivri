namespace BiblioLivri.View
{
    partial class FrmCopiaLivro
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
            this.cmbLivro = new System.Windows.Forms.ComboBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.dtgCopiaLivro = new System.Windows.Forms.DataGridView();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.chkEmprestado = new System.Windows.Forms.CheckBox();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCopiaLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLivro
            // 
            this.cmbLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLivro.FormattingEnabled = true;
            this.cmbLivro.Location = new System.Drawing.Point(60, 12);
            this.cmbLivro.Name = "cmbLivro";
            this.cmbLivro.Size = new System.Drawing.Size(343, 21);
            this.cmbLivro.TabIndex = 0;
            this.cmbLivro.SelectedValueChanged += new System.EventHandler(this.cmbLivro_SelectedValueChanged);
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(60, 39);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(343, 21);
            this.cmbIdioma.TabIndex = 1;
            // 
            // dtgCopiaLivro
            // 
            this.dtgCopiaLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCopiaLivro.Location = new System.Drawing.Point(12, 120);
            this.dtgCopiaLivro.Name = "dtgCopiaLivro";
            this.dtgCopiaLivro.Size = new System.Drawing.Size(593, 150);
            this.dtgCopiaLivro.TabIndex = 2;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(60, 67);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 3;
            // 
            // chkEmprestado
            // 
            this.chkEmprestado.AutoSize = true;
            this.chkEmprestado.Location = new System.Drawing.Point(321, 69);
            this.chkEmprestado.Name = "chkEmprestado";
            this.chkEmprestado.Size = new System.Drawing.Size(82, 17);
            this.chkEmprestado.TabIndex = 4;
            this.chkEmprestado.Text = "Emprestado";
            this.chkEmprestado.UseVisualStyleBackColor = true;
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(215, 67);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(100, 20);
            this.txtEdicao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Idioma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edição:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 93);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // FrmCopiaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 278);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdicao);
            this.Controls.Add(this.chkEmprestado);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.dtgCopiaLivro);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.cmbLivro);
            this.Name = "FrmCopiaLivro";
            this.Text = "FrmCopiaLivro";
            this.Load += new System.EventHandler(this.FrmCopiaLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCopiaLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLivro;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.DataGridView dtgCopiaLivro;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.CheckBox chkEmprestado;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserir;
    }
}