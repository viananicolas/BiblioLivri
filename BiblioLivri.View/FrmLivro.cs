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
            CarregaIdioma();
            CarregaLivros();
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

        private void CarregaLivros()
        {
            CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
            dtgLivros.DataSource = oProxy.SelecionaTodos();
        }

        private void CarregaEditora()
        {
            CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbEditora.Items.Add(item.EdNome);
            }
        }

        private void CarregaAutores()
        {
            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
           
            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbAutor.Items.Add(item.AuNome +" "+ item.AuSobrenome);
                cmbCoAutor.Items.Add(item.AuNome + " " + item.AuSobrenome);
            }
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
        private void CarregaIdioma()
        {
            foreach (var item in File.ReadLines(@"D:\Faculdade\3º Ano\Desenvolvimento de Sistemas Desktop\2º BI\BiblioLivri\BiblioLivri.View\Information\ListaIdioma.txt"))
            {
                cmbIdioma.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
            CLivro.TBLivro oLivro = new CLivro.TBLivro();
            oLivro.LiCapa = imgbytesize;
            oLivro.id_Autor = id_autor;
            oLivro.id_CoAutor = id_coautor;
            oLivro.id_Editora = id_editora;
            oLivro.id_Genero = id_genero;
            oLivro.LiAno = txtAno.Text;
            oLivro.LiCDU = txtCDU.Text;
            oLivro.LiIdioma = cmbIdioma.SelectedItem.ToString();
            oLivro.LiISBN = txtISBN.Text;
            oLivro.LiNumPaginas = txtNumPaginas.Text;
            oLivro.LiPais = cmbPais.SelectedItem.ToString();
            oLivro.LiTitulo = txtTitulo.Text;
            oProxy.Incluir(oLivro);
            CarregaLivros();
        }

        private void cmbAutor_SelectedValueChanged(object sender, EventArgs e)
        {
            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                if (cmbAutor.SelectedItem.ToString() == item.AuNome + " " + item.AuSobrenome)
                {
                    id_autor = item.id_Autor;
                }
            }
        }

        private void cmbCoAutor_SelectedValueChanged(object sender, EventArgs e)
        {
            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                if (cmbAutor.SelectedItem.ToString() == item.AuNome + " " + item.AuSobrenome)
                {
                    id_coautor = item.id_Autor;
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
                    id_editora = item.id_Editora;
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
    }
}
