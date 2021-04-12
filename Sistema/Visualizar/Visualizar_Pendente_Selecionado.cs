using MySql.Data.MySqlClient;
using Sistema.Cadastro;
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

namespace Sistema.Visualizar
{
    public partial class Visualizar_Pendente_Selecionado : Form
    {
        public string URL;
        private string strConn = "Server=localhost;Database=sistema;Uid=root;Pwd=1234;";
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";
        public Visualizar_Pendente_Selecionado(string url)
        {
            InitializeComponent();
            URL = url;
        }

        public int ReceberCliente()
        {
            FileInfo fileInfo = new FileInfo(URL);
            string nomearquivo = fileInfo.Name;
            var id = nomearquivo.Split(' ');
            return int.Parse(id[0]);
        }
        public string ReceberData()
        {
            FileInfo fileInfo = new FileInfo(URL);
            string nomearquivo = fileInfo.Name;
            var data = nomearquivo.Split(' ');
            return data[1];
        }

        private void Visualizar_Pendente_Selecionado_Load(object sender, EventArgs e)
        {
            ListarDados2();
            ListarDados();
            CarregarProdutos();
            ListaProduto.DataSource = lista.ToArray();

            Color color = new Color();
            color = Color.FromArgb(0, 0, 0);
            ListaProduto.ForeColor = color;

            ListaProduto.BorderStyle = BorderStyle.None;
            ListaProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ListaProduto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListaProduto.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ListaProduto.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ListaProduto.BackgroundColor = Color.White;

            ListaProduto.EnableHeadersVisualStyles = false;
            ListaProduto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ListaProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ListaProduto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void ListarDados()
        {
            int ID = ReceberCliente();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");

                string selectQuery = "SELECT * FROM CLIENTE WHERE CLIENTE_ID = " + ID + ";";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LabelCliente.Text = reader.GetString("nome");
                    LabelTelefone.Text = reader.GetString("telefone");
                    LabelRua.Text = reader.GetString("rua") + ", " + reader.GetString("numero");
                    LabelEndereco.Text = reader.GetString("cidade") + ", " + reader.GetString("bairro");
                    LabelData.Text = ReceberData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarDados2()
        {
            FileInfo fileInfo = new FileInfo(URL);
            string nomearquivo = fileInfo.Name;
            var nome = nomearquivo.Split(' ');
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");

                string selectQuery = "SELECT * FROM PEDIDO WHERE NOMEARQUIVO LIKE '%" + nome[3] + "';";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LabelIDPedido.Text = reader.GetString("pedido_id");
                    LabelVendedor.Text = reader.GetString("vendedor");
                    LabelTotal.Text = reader.GetString("total") +" R$";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        List<Produto> lista = new List<Produto>();
        private void CarregarProdutos()
        {
            using (StreamReader sr = new StreamReader(URL))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    var temp = linha.Split(',');
                    string produto = temp[0];
                    double valor = double.Parse(temp[1]);
                    string espessura = temp[2];
                    string comprimento = temp[3];
                    string altura = temp[4];
                    string tipo = temp[5];
                    string estilo = temp[6];
                    lista.Add(new Produto(produto,comprimento,valor,espessura,altura,tipo,estilo));
                }
            }

        }
    }
}
