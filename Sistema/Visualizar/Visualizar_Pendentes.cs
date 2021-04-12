using MySql.Data.MySqlClient;
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
    public partial class Visualizar_Pendentes : Form
    {
        public Visualizar_Pendentes()
        {
            InitializeComponent();
        }
        public string pedido;
        public string cliente;
        public string arquivo;
        public string data;
        public string vendedor;
        public double total;
        MySqlConnection conexao;
        MySqlCommand comando;
        private string strConn = "Server=localhost;Database=sistema;Uid=root;Pwd=1234;";
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string URL = ListaPendentes.SelectedCells[0].Value.ToString();
            Visualizar_Pendente_Selecionado vps = new Visualizar_Pendente_Selecionado(URL);
            vps.ShowDialog();
        }

        private void Visualizar_Pendentes_Load(object sender, EventArgs e)
        {
            Color color = new Color();
            color = Color.FromArgb(0, 0, 0);
            ListaPendentes.ForeColor = color;
            ListaPendentes.DataSource = GetListaPedidos();
            ListaGrid();

            ListaPendentes.BorderStyle = BorderStyle.None;
            ListaPendentes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ListaPendentes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListaPendentes.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ListaPendentes.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ListaPendentes.BackgroundColor = Color.White;

            ListaPendentes.EnableHeadersVisualStyles = false;
            ListaPendentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ListaPendentes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ListaPendentes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private DataTable GetListaPedidos()
        {
            DataTable dtListaPedidos = new DataTable();
            return dtListaPedidos;
        }

        public void ListaGrid()
        {
            strSQL = "SELECT NOMEARQUIVO AS 'LOCALIZAÇÃO',PEDIDO_ID AS 'ID PRODUTO', CLIENTE_ID_FK AS 'ID CLIENTE',DATACAD 'DATA DA COMPRA', VENDEDOR AS VENDEDOR, TOTAL FROM PEDIDO;";
            objConnect = new MySqlConnection(strConn);
            objCommand = new MySqlCommand(strSQL, objConnect);
            try
            {
                MySqlDataAdapter objDA = new MySqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objDA.Fill(dt);
                ListaPendentes.DataSource = dt;
                //ListaPendentes.AutoResizeColumns();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objConnect = null;
                objCommand = null;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string URL = ListaPendentes.SelectedCells[0].Value.ToString();
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
                    pedido = reader.GetString("PEDIDO_ID");
                    cliente = reader.GetString("CLIENTE_ID_FK");
                    arquivo = reader.GetString("NOMEARQUIVO");
                    data = reader.GetString("DATACAD");
                    vendedor = reader.GetString("VENDEDOR");
                    total = reader.GetDouble("TOTAL");
                }
                TransferirPedido(pedido,cliente,arquivo,data,vendedor,total);
                ApagarPedido();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void TransferirPedido(string pedido,string cliente,string arquivo,string data,string vendedor,double total)
        {
            DateTime today = DateTime.Today;
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                strSQL = "INSERT INTO HISTORICO " +
                        "(PEDIDO_ID, CLIENTE_ID_FK, NOMEARQUIVO, DATACAD,VENDEDOR,TOTAL,DATAFINAL) VALUES" +
                        "(@PEDIDO_ID, @CLIENTE_ID_FK, @NOMEARQUIVO, @DATACAD,@VENDEDOR,@TOTAL,@DATAFINAL);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@PEDIDO_ID", pedido);
                comando.Parameters.AddWithValue("@CLIENTE_ID_FK", cliente);
                comando.Parameters.AddWithValue("@NOMEARQUIVO", arquivo);
                comando.Parameters.AddWithValue("@DATACAD", data);
                comando.Parameters.AddWithValue("@VENDEDOR",vendedor);
                comando.Parameters.AddWithValue("@TOTAL", total);
                comando.Parameters.AddWithValue("@DATAFINAL", today.ToString("dd/MM/yyyy"));
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ERRO!");
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
                MessageBox.Show("Pedido finalizado com sucesso!");
            }
        }
        public void ApagarPedido()
        {
            string URL = ListaPendentes.SelectedCells[0].Value.ToString();
            FileInfo fileInfo = new FileInfo(URL);
            string nomearquivo = fileInfo.Name;
            var nome = nomearquivo.Split(' ');
            try
            {
                objConnect = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                strSQL = "DELETE FROM PEDIDO WHERE NOMEARQUIVO LIKE '%" + nome[3] + "';";
                objCommand = new MySqlCommand(strSQL, objConnect);
                objConnect.Open();
                objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Pedido não deletado!");
            }
            finally
            {
                objConnect.Close();
                objConnect = null;
                objCommand = null;
                ListaGrid();
            }
        }
    }
}
