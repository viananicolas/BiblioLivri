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
            this.txtAno = new System.Windows.Forms.TextBox();
            this.chkEmprestado = new System.Windows.Forms.CheckBox();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCopia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLivro
            // 
            this.cmbLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLivro.Enabled = false;
            this.cmbLivro.FormattingEnabled = true;
            this.cmbLivro.Location = new System.Drawing.Point(58, 19);
            this.cmbLivro.Name = "cmbLivro";
            this.cmbLivro.Size = new System.Drawing.Size(343, 21);
            this.cmbLivro.TabIndex = 0;
            this.cmbLivro.SelectedValueChanged += new System.EventHandler(this.cmbLivro_SelectedValueChanged);
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Enabled = false;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(58, 46);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(343, 21);
            this.cmbIdioma.TabIndex = 1;
            // 
            // txtAno
            // 
            this.txtAno.Enabled = false;
            this.txtAno.Location = new System.Drawing.Point(58, 74);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 3;
            // 
            // chkEmprestado
            // 
            this.chkEmprestado.AutoSize = true;
            this.chkEmprestado.Enabled = false;
            this.chkEmprestado.Location = new System.Drawing.Point(319, 76);
            this.chkEmprestado.Name = "chkEmprestado";
            this.chkEmprestado.Size = new System.Drawing.Size(82, 17);
            this.chkEmprestado.TabIndex = 4;
            this.chkEmprestado.Text = "Emprestado";
            this.chkEmprestado.UseVisualStyleBackColor = true;
            // 
            // txtEdicao
            // 
            this.txtEdicao.Enabled = false;
            this.txtEdicao.Location = new System.Drawing.Point(213, 74);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(100, 20);
            this.txtEdicao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Idioma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edição:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(168, 19);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Salvar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número cópia:";
            // 
            // txtNumCopia
            // 
            this.txtNumCopia.Enabled = false;
            this.txtNumCopia.Location = new System.Drawing.Point(485, 74);
            this.txtNumCopia.Name = "txtNumCopia";
            this.txtNumCopia.Size = new System.Drawing.Size(100, 20);
            this.txtNumCopia.TabIndex = 11;
            this.txtNumCopia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumCopia_KeyDown);
            this.txtNumCopia.Leave += new System.EventHandler(this.txtNumCopia_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLivro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbIdioma);
            this.groupBox1.Controls.Add(this.txtNumCopia);
            this.groupBox1.Controls.Add(this.txtAno);
            this.groupBox1.Controls.Add(this.chkEmprestado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEdicao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 111);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 56);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCopiaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 194);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCopiaLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cópias";
            this.Load += new System.EventHandler(this.FrmCopiaLivro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLivro;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.CheckBox chkEmprestado;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumCopia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}