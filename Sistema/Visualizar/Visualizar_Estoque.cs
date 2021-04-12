using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema.Fields;

namespace Sistema.Visualizar
{
    public partial class Visualizar_Estoque : Form
    {
        private string strConn = "Server=localhost;Database=sistema;Uid=root;Pwd=1234;";
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";
        public Visualizar_Estoque()
        {
            InitializeComponent();
        }

        private void ListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ListaGrid()
        {
            strSQL = "SELECT PRODUTO_ID AS ID,NOME,MATERIAL,MEDIDA,VALOR,QUANTIDADE,DATACAD AS 'CADASTRADO EM' FROM PRODUTO;";
            objConnect = new MySqlConnection(strConn);
            objCommand = new MySqlCommand(strSQL, objConnect);
            try
            {
                MySqlDataAdapter objDA = new MySqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objDA.Fill(dt);
                ListaProdutos.DataSource = dt;
                ListaProdutos.AutoResizeColumns();
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

        private void Visualizar_Estoque_Load(object sender, EventArgs e)
        {
            ToolTip dicas = new ToolTip();
            dicas.SetToolTip(bntExcluir, "Excluir");
            dicas.SetToolTip(bntAtualizar, "Editar dados");
            dicas.SetToolTip(bntCadastrar, "Cadastrar");
            Color color = new Color();
            color = Color.FromArgb(0, 0, 0);
            ListaProdutos.ForeColor = color;
            ListaProdutos.DataSource = GetListaProdutos();
            ListaGrid();

            ListaProdutos.BorderStyle = BorderStyle.None;
            ListaProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ListaProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListaProdutos.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ListaProdutos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ListaProdutos.BackgroundColor = Color.White;

            ListaProdutos.EnableHeadersVisualStyles = false;
            ListaProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ListaProdutos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ListaProdutos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private DataTable GetListaProdutos()
        {
            DataTable dtListaClientes = new DataTable();
            return dtListaClientes;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = ListaProdutos.SelectedCells[0].Value.ToString();
            int ID = int.Parse(id);
            Tela_Atualizar_Produto ta = new Tela_Atualizar_Produto(ID);
            ta.ShowDialog();
            ListaGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID = ListaProdutos.SelectedCells[0].Value.ToString();
            if (ID == null)
            {
                MessageBox.Show("Alguma das caixas de texto esta vazia!");
            }
            else
            {
                try
                {
                    objConnect = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                    strSQL = "DELETE FROM PRODUTO WHERE PRODUTO_ID = @ID;";
                    objCommand = new MySqlCommand(strSQL, objConnect);
                    objCommand.Parameters.AddWithValue("@ID", ID);
                    objConnect.Open();
                    objCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Produto não deletado!");
                }
                finally
                {
                    objConnect.Close();
                    objConnect = null;
                    objCommand = null;
                    MessageBox.Show("Produto deletado com sucesso");
                    ListaGrid();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro_Produto CP = new Cadastro_Produto();
            CP.ShowDialog();
            ListaGrid();
        }
    }
}
