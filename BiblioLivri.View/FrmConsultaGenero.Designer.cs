namespace BiblioLivri.View
{
    partial class FrmConsultaGenero
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgGeneros = new System.Windows.Forms.DataGridView();
            this.id_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgGeneros);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gêneros:";
            // 
            // dtgGeneros
            // 
            this.dtgGeneros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_genero,
            this.GeDescricao});
            this.dtgGeneros.Location = new System.Drawing.Point(6, 19);
            this.dtgGeneros.Name = "dtgGeneros";
            this.dtgGeneros.Size = new System.Drawing.Size(411, 225);
            this.dtgGeneros.TabIndex = 6;
            // 
            // id_genero
            // 
            this.id_genero.DataPropertyName = "id_genero";
            this.id_genero.HeaderText = "ID Gênero";
            this.id_genero.Name = "id_genero";
            this.id_genero.ReadOnly = true;
            // 
            // GeDescricao
            // 
            this.GeDescricao.DataPropertyName = "GeDescricao";
            this.GeDescricao.HeaderText = "Descrição";
            this.GeDescricao.Name = "GeDescricao";
            this.GeDescricao.ReadOnly = true;
            this.GeDescricao.Width = 160;
            // 
            // FrmConsultaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 268);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de gêneros";
            this.Load += new System.EventHandler(this.FrmConsultaGenero_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgGeneros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeDescricao;
    }
}