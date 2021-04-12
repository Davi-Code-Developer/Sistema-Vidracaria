using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema.Fields;

namespace Sistema
{
    public partial class Visualizar_Cliente : Form
    {
        private string strConn = "Server=localhost;Database=sistema;Uid=root;Pwd=1234;";
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";
        public Visualizar_Cliente()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bnt_Excluir_Click(object sender, EventArgs e)
        {

        }

        private void bnt_Opcoes_Click(object sender, EventArgs e)
        {
        }

        private void Visualizar_Cliente_Load(object sender, EventArgs e)
        {
            ToolTip dicas = new ToolTip();
            dicas.SetToolTip(bntExcluir, "Excluir cliente");
            dicas.SetToolTip(bntAtualizar, "Editar dados");
            dicas.SetToolTip(bntCadastro, "Cadastrar cliente");


            Color color = new Color();
            color = Color.FromArgb(0,0,0);
            ListaClientes.ForeColor = color;
            ListaClientes.DataSource = GetListaClientes();
            ListaGrid();

            ListaClientes.BorderStyle = BorderStyle.None;
            ListaClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ListaClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListaClientes.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ListaClientes.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ListaClientes.BackgroundColor = Color.White;

            ListaClientes.EnableHeadersVisualStyles = false;
            ListaClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ListaClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ListaClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        private DataTable GetListaClientes()
        {
            DataTable dtListaClientes = new DataTable();
            return dtListaClientes;
        }

        public void ListaGrid()
        {
            strSQL = "SELECT CLIENTE_ID AS ID,NOME,EMAIL,TELEFONE,CIDADE FROM CLIENTE;";
            objConnect = new MySqlConnection(strConn);
            objCommand = new MySqlCommand(strSQL, objConnect);
            try
            {
                MySqlDataAdapter objDA = new MySqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objDA.Fill(dt);
                ListaClientes.DataSource = dt;
                ListaClientes.AutoResizeColumns();                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objConnect = null;
                objCommand = null;
            }
        }

        private void bnt_Voltar_Click(object sender, EventArgs e)
        {
            ListaGrid();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void BntAtualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void ListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ListaClientes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListaClientes_MouseLeave(object sender, EventArgs e)
        {
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            string ID = ListaClientes.SelectedCells[0].Value.ToString();
            if (ID == null)
            {
                MessageBox.Show("Alguma das caixas de texto esta vazia!");
            }
            else
            {
                try
                {
                    objConnect = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                    strSQL = "DELETE FROM CLIENTE WHERE CLIENTE_ID = @ID;";
                    objCommand = new MySqlCommand(strSQL, objConnect);
                    objCommand.Parameters.AddWithValue("@ID", ID);
                    objConnect.Open();
                    objCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Usuario não deletado!");
                }
                finally
                {
                    objConnect.Close();
                    objConnect = null;
                    objCommand = null;
                    MessageBox.Show("Cliente deletado com sucesso");
                    ListaGrid();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = ListaClientes.SelectedCells[0].Value.ToString();
            int ID = int.Parse(id);
            Tela_Atualizar_Cliente tac = new Tela_Atualizar_Cliente(ID);
            tac.ShowDialog();
            ListaGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente cadastro_Cliente = new Cadastro_Cliente();
            cadastro_Cliente.ShowDialog();
        }
    }  
}

