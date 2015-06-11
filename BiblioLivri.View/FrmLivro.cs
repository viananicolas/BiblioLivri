using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace BiblioLivri.View
{
    public partial class FrmLivro : Form
    {
        public int id_autor;
        public int id_coautor;
        public int id_editora;
        private int id_genero;
        private bool inserir = true;
        public byte[] imgbytesize;

        public FrmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            CarregaAutores();
            CarregaEditora();
            CarregaPaises();
            CarregaGeneros();
        }

        private void CarregaGeneros()
        {
            CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbGenero.Items.Add(item.GeDescricao);
            }
        }

        

        private void CarregaEditora()
        {
            CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbEditora.Items.Add(item.EdNome);
            }
        }
        private void CarregaGeneros(int genero)
        {
            CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
            string nomegenero = null;
            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbGenero.Items.Add(item.GeDescricao);
                if (genero == item.id_genero)
                    nomegenero = item.GeDescricao;
            }
            cmbGenero.SelectedItem = nomegenero;
        }

            private void CarregaEditora(int editora)
        {
            CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
            string nomeeditora = null;
            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbEditora.Items.Add(item.EdNome);
                if (editora == item.id_editora)
                    nomeeditora = item.EdNome;
            }
            cmbEditora.SelectedItem = nomeeditora;
        }
        private void CarregaAutores()
        {
            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbAutor.Items.Add(item.AuNome + " " + item.AuSobrenome);

            }
        }
        private void CarregaAutores(int autor)
        {
            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
            string nomeautor = null;
            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbAutor.Items.Add(item.AuNome +" "+ item.AuSobrenome);
             
                if (autor == item.id_autor)
                    nomeautor = item.AuNome + " " + item.AuSobrenome;
                
            }
            cmbAutor.SelectedItem = nomeautor;
        }

        private void btnCapa_Click(object sender, EventArgs e)
        {
            OpenFileDialog findfile = new OpenFileDialog();
            string filelocation;
            findfile.Filter = "JPEG (*.jpg;*.jpeg;*.jpe;*.jif;*.jfif;*.jfi)|*.jpg;*.jpeg;*.jpe;*.jif;*.jfif;*.jfi| PNG (*.png)|*.png";
            if(findfile.ShowDialog()== DialogResult.OK)
            {
                filelocation = findfile.FileName;
                FileInfo imginfo = new FileInfo(filelocation);
                var imgsize = imginfo.Length;
                //  byte imgbytesize = Convert.ToInt32(imgsize);
                imgbytesize = new byte[Convert.ToInt32(imgsize)];
                FileStream fs = new FileStream(filelocation, FileMode.Open, FileAccess.Read, FileShare.Read);
                var bytesread = fs.Read(imgbytesize, 0, Convert.ToInt32(imgsize));
                fs.Close();
                pbCapa.ImageLocation = filelocation;
            }
        }
        private void CarregaPaises()
        {
            foreach (var item in File.ReadLines(@"D:\Faculdade\3º Ano\Desenvolvimento de Sistemas Desktop\2º BI\BiblioLivri\BiblioLivri.View\Information\ListaPaises.txt"))
            {
                cmbPais.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var oProxy = new CLivro.CLivroClient())
            {
                if (ValidaCampos())
                {
                    CLivro.TBLivro oLivro = new CLivro.TBLivro();
                    oLivro.LiCapa = imgbytesize;
                    oLivro.id_autor = id_autor;
                    oLivro.ID_Editora = id_editora;
                    oLivro.id_genero = id_genero;
                    oLivro.LiCDU = txtCDU.Text;
                    oLivro.LiPagina = txtNumPaginas.Text;
                    oLivro.LiISBN = txtISBN.Text;
                    oLivro.LiPais = cmbPais.SelectedItem.ToString();
                    oLivro.LiTitulo = txtTitulo.Text;
                    if (inserir)
                    {
                       /* if (oProxy.ValidaISBN(txtISBN.Text))
                        {
                            MessageBox.Show("ISBN já consta no Banco de Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        }*/
                       // else
                       // {
                            oProxy.Incluir(oLivro);
                            MessageBox.Show("Livro inserido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                       // }
                    }
                    else
                    {
                        oLivro.LiISBN = txtISBN.Text;
                        oProxy.Alterar(oLivro);
                        MessageBox.Show("Livro alterado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }
                  
                }

            }

        }

        private bool ValidaCampos()
        {
            var oProxy = new CLivro.CLivroClient();
            if (oProxy.ValidaISBN(txtISBN.Text)==false)
            {
                MessageBox.Show("ISBN já consta no Banco de Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void cmbAutor_SelectedValueChanged(object sender, EventArgs e)
        {
            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                if (cmbAutor.SelectedItem.ToString() == item.AuNome + " " + item.AuSobrenome)
                {
                    id_autor = item.id_autor;
                }
            }
        }

        private void cmbEditora_SelectedValueChanged(object sender, EventArgs e)
        {
            CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                if (cmbEditora.SelectedItem.ToString() == item.EdNome)
                {
                    id_editora = item.id_editora;
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
            foreach (var item in oProxy.SelecionaTodos())
            {
                if(cmbGenero.SelectedItem.ToString() == item.GeDescricao)
                {
                    id_genero = item.id_genero;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inserir = true;
            HabilitaCampos();
        }

        private void HabilitaCampos()
        {
            txtCDU.Enabled = true;
            // txtID.Enabled = true;
            txtISBN.Enabled = true;
            txtNumPaginas.Enabled = true;
            txtTitulo.Enabled = true;
            btnCapa.Enabled = true;
            cmbAutor.Enabled = true;
            cmbEditora.Enabled = true;
            cmbGenero.Enabled = true;
            cmbPais.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inserir = false;
            txtISBN.Enabled = true;
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            Editar();
            
        }

        private void Editar()
        {
            if (inserir==false)
           
            using (var oProxy = new CLivro.CLivroClient())
            {
                var oLivro = oProxy.SelecionaPK(txtISBN.Text);
                txtCDU.Text = oLivro.LiCDU;
                txtNumPaginas.Text = oLivro.LiPagina;
                txtTitulo.Text = oLivro.LiTitulo;
                var aProxy = new CAutor.CAutorClient();
                var oAutor = aProxy.SelecionaPK(oLivro.id_autor);
                var bProxy = new CEditora.CEditoraClient();
                var oEditora = bProxy.SelecionaPK(oLivro.ID_Editora);
                cmbAutor.Items.Clear();
                cmbEditora.Items.Clear();
                cmbGenero.Items.Clear();
                CarregaAutores(oLivro.id_autor);
                CarregaEditora(oLivro.ID_Editora);
                CarregaGeneros(oLivro.id_genero);
                cmbPais.SelectedItem = oLivro.LiPais;
                imgbytesize = oLivro.LiCapa;
                string strfn = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);
                fs.Write(imgbytesize, 0, imgbytesize.Length);
                fs.Flush();
                fs.Close();
                pbCapa.Image = Image.FromFile(strfn);
                HabilitaCampos();
                txtISBN.Enabled = false;
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
            {
                var oProxy = new CLivro.CLivroClient();
               
                var oLivro = oProxy.SelecionaPK(txtISBN.Text);
                oProxy.Excluir(oLivro);
            }
            MessageBox.Show("Livro excluído com sucesso", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void txtISBN_KeyDown(object sender, KeyEventArgs e)
        {
            Editar();
        }

        private void txtISBN_Leave(object sender, EventArgs e)
        {
            Editar();
        }

    }
}
