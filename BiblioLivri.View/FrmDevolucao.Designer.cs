namespace BiblioLivri.View
{
    partial class FrmDevolucao
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
            this.txtCopiaLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLivros = new System.Windows.Forms.ListView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCopiaLivro
            // 
            this.txtCopiaLivro.Location = new System.Drawing.Point(103, 13);
            this.txtCopiaLivro.Name = "txtCopiaLivro";
            this.txtCopiaLivro.Size = new System.Drawing.Size(184, 20);
            this.txtCopiaLivro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número da cópia:";
            // 
            // lstLivros
            // 
            this.lstLivros.Location = new System.Drawing.Point(7, 40);
            this.lstLivros.Name = "lstLivros";
            this.lstLivros.Size = new System.Drawing.Size(361, 133);
            this.lstLivros.TabIndex = 2;
            this.lstLivros.UseCompatibleStateImageBehavior = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(293, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(7, 179);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDevolver);
            this.groupBox1.Controls.Add(this.txtCopiaLivro);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.lstLivros);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livros a serem devolvidos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 227);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.FrmDevolucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCopiaLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstLivros;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}