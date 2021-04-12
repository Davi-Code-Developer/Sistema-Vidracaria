using MySql.Data.MySqlClient;
using Sistema.Visualizar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Cadastro
{
    public partial class Cadastrar_Pedido : Form
    {
        private string strConn = "Server=localhost;Database=sistema;Uid=root;Pwd=1234;";
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";
        MySqlConnection conexao;
        MySqlCommand comando;
        public Cadastrar_Pedido()
        {
            InitializeComponent();
        }

        private void Cadastrar_Pedido_Load(object sender, EventArgs e)
        {
            ListarFuncionario();
            ToolTip dicas = new ToolTip();
            //  dicas.SetToolTip(Visualizar, "Visualizar carrinho");

            Color color = new Color();
            color = Color.FromArgb(0, 0, 0);
            //ListaCarrinho.DataSource = GetListaCarrinho();
            ListaCarrinho.ForeColor = Color.White;
            ListaCarrinho.BorderStyle = BorderStyle.None;
            ListaCarrinho.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 173, 181);
            ListaCarrinho.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 173, 181);
            ListaCarrinho.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListaCarrinho.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            ListaCarrinho.DefaultCellStyle.SelectionForeColor = Color.White;
            ListaCarrinho.BackgroundColor = Color.FromArgb(0, 173, 181);

            ListaCarrinho.EnableHeadersVisualStyles = false;
            ListaCarrinho.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ListaCarrinho.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ListaCarrinho.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void ListarFuncionario()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");

                string selectQuery = "SELECT * FROM FUNCIONARIO;";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ComboVendedor.Items.Add(reader.GetString("nome"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void regra()
        {
            string op = ComboProduto.Text;
            if (op == "Box")
            {
                ReturnDefault();
                ComboEspessura.SelectedIndex = 5;
                ComboEspessura.Enabled = false;
                ComboAltura.SelectedIndex = 1;
                ComboAltura.Enabled = false;
                CheckTemperado.Checked = true;
                CheckTemperado.Enabled = false;
            }
            if (op == "Porta")
            {
                ReturnDefault();
                ComboEspessura.Items.Clear();
                ComboEspessura.Items.Insert(0, "8 mm");
                ComboEspessura.Items.Insert(1, "10 mm");
                ComboAltura.SelectedIndex = 2;
                ComboAltura.Enabled = false;
            }
            if (op == "Vidro")
            {
                ReturnDefault();
                ComboEspessura.Items.Clear();
                ComboEspessura.Items.Insert(0, "2 mm");
                ComboEspessura.Items.Insert(1, "3 mm");
                ComboEspessura.Items.Insert(2, "4 mm");
                ComboEspessura.Items.Insert(3, "5 mm");
                ComboEspessura.Items.Insert(4, "6 mm");
                ComboTipo.Items.Clear();
                ComboAltura.Items.Clear();
                ComboTipo.Items.Insert(0, "Incolor");
                ComboTipo.Items.Insert(1, "Fumê");
                ComboTipo.Items.Insert(2, "Fantasia");
                CheckJateado.Enabled = true;
                CheckTemperado.Visible = false;
            }
            if (op == "Janela")
            {
                ReturnDefault();
                ComboEspessura.SelectedIndex = 5;
                ComboAltura.Items.Clear();
                ComboEspessura.Enabled = false;
                CheckTemperado.Checked = true;
                CheckTemperado.Enabled = false;
                CheckJateado.Enabled = false;
                CheckTemperado.Enabled = false;
            }
            if (op == "Persiana")
            {
                ReturnDefault();
                ComboTipo.Items.Clear();
                ComboTipo.Items.Insert(0, "Vertical");
                ComboTipo.Items.Insert(1, "Horizontal");
                ComboAltura.Items.Clear();
                ComboEspessura.Visible = false;
                CheckJateado.Visible = false;
                CheckTemperado.Visible = false;
                LabelEspessura.Visible = false;
            }
        }
        private void ReturnDefault()
        {
            CheckJateado.Visible = true;
            CheckTemperado.Visible = true;
            CheckJateado.Enabled = true;
            CheckTemperado.Enabled = true;

            ComboAltura.Enabled = true;
            ComboAltura.Visible = true;
            ComboEspessura.Enabled = true;
            ComboEspessura.Visible = true;
            ComboTipo.Enabled = true;
            ComboTipo.Visible = true;

            ComboTipo.Text = "";
            ComboAltura.Text = "";
            ComboEspessura.Text = "";
            CheckJateado.Checked = false;
            CheckTemperado.Checked = false;

            LabelTipo.Text = "Tipo";
            LabelEspessura.Visible = true;

            ComboEspessura.Items.Clear();
            ComboEspessura.Items.Insert(0, "2 mm");
            ComboEspessura.Items.Insert(1, "3 mm");
            ComboEspessura.Items.Insert(2, "4 mm");
            ComboEspessura.Items.Insert(3, "5 mm");
            ComboEspessura.Items.Insert(4, "6 mm");
            ComboEspessura.Items.Insert(5, "8 mm");
            ComboEspessura.Items.Insert(6, "10 mm");

            ComboTipo.Items.Clear();
            ComboTipo.Items.Insert(0, "Incolor");
            ComboTipo.Items.Insert(1, "Fumê");
            ComboTipo.Items.Insert(2, "Verde");

            ComboAltura.Items.Clear();
            ComboAltura.Items.Insert(0, "1.10 m");
            ComboAltura.Items.Insert(1, "1.80 m");
            ComboAltura.Items.Insert(2, "2.10 m");

            txtComprimento.Visible = true;
            LabelComprimento.Visible = true;
        }
        private void ComboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            regra();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Carrinho_panel.Visible = false;
        }
        List<Produto> listaProdutos = new List<Produto>();
        double total;
        public void adicionarAoCarrinho()
        {
            string produto = ComboProduto.Text;
            string comprimento = txtComprimento.Text;
            double valor = double.Parse(TxtValor.Text);
            string espessura = ComboEspessura.Text;
            string altura = ComboAltura.Text;
            string tipo = ComboTipo.Text;
            string estilo = opc();
            listaProdutos.Add(new Produto(produto, comprimento, valor, espessura, altura, tipo, estilo));
            List<Item> temp = new List<Item>();
            foreach(Produto p in listaProdutos)
            {
                temp.Add(new Item(p.ProdutoNome, p.Valor));
            }
            ListaCarrinho.DataSource = temp.ToArray();
            total = total + double.Parse(TxtValor.Text);
            TotalLabel.Text = "R$ " + total.ToString();
            TotalLabel2.Text = "R$ " + total.ToString();
        }
        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            adicionarAoCarrinho();
            LimparCampos();

            if (Carrinho_panel.Visible == false)
            {
                Carrinho_panel.Visible = true;
            }
        }
        public void LimparCampos()
        {
            ComboProduto.Text = "";
            txtComprimento.Text = "";
            TxtValor.Text = "";
            ComboEspessura.Text = "";
            ComboAltura.Text = "";
            ComboTipo.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string vendedor = ComboVendedor.Text;
            Tela_Finalizar_Compra tf = new Tela_Finalizar_Compra(listaProdutos,vendedor,total);
            tf.ShowDialog();
            Dispose();
        }
        public string opc()
        {
            if (CheckJateado.Checked == true)
            {
                return "Jateado";
            }
            if (CheckTemperado.Checked == true)
            {
                return "Temperado";
            }
            if (CheckTemperado.Checked == true && CheckJateado.Checked == true)
            {
                return "Jateado/Temperado";
            }
            else
            {
                return "";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Carrinho_panel.Visible == false)
            {
                Carrinho_panel.Visible = true;
            }
            else
            {
                Carrinho_panel.Visible = false;
            }
        }
  
       
    }
}

