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
    public partial class Visualizar_Funcionario : Form
    {
        private string strConn = "Server=localhost;Database=sistema;Uid=root;Pwd=1234;";
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";
        public Visualizar_Funcionario()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void Visualizar_Funcionario_Load(object sender, EventArgs e)
        {
            ToolTip dicas = new ToolTip();
            dicas.SetToolTip(bntExcluir, "Excluir");
            dicas.SetToolTip(bntAtualizar, "Editar dados");
            dicas.SetToolTip(bntAdicionar, "Cadastrar");
            Color color = new Color();
            color = Color.FromArgb(0, 0, 0);
            ListaFuncionario.ForeColor = color;
            ListaFuncionario.DataSource = GetListaFuncionarios();
            ListaGrid();

            ListaFuncionario.BorderStyle = BorderStyle.None;
            ListaFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ListaFuncionario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListaFuncionario.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ListaFuncionario.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ListaFuncionario.BackgroundColor = Color.White;

            ListaFuncionario.EnableHeadersVisualStyles = false;
            ListaFuncionario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ListaFuncionario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ListaFuncionario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private DataTable GetListaFuncionarios()
        {
            DataTable dtListaFuncionarios = new DataTable();
            return dtListaFuncionarios;
        }
        public void ListaGrid()
        {
            strSQL = "SELECT FUNCIONARIO_ID AS ID,NOME,EMAIL,TELEFONE,CPF FROM FUNCIONARIO;";
            objConnect = new MySqlConnection(strConn);
            objCommand = new MySqlCommand(strSQL, objConnect);
            try
            {
                MySqlDataAdapter objDA = new MySqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objDA.Fill(dt);
                ListaFuncionario.DataSource = dt;
                ListaFuncionario.AutoResizeColumns();
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

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            string ID = ListaFuncionario.SelectedCells[0].Value.ToString();
            if (ID == null)
            {
                MessageBox.Show("Alguma das caixas de texto esta vazia!");
            }
            else
            {
                try
                {
                    objConnect = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                    strSQL = "DELETE FROM FUNCIONARIO WHERE FUNCIONARIO_ID = @ID;";
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

        private void bntAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            Cadastro_Funcionario cadastro_Funcionario = new Cadastro_Funcionario();
            cadastro_Funcionario.ShowDialog();
        }

        private void bntAtualizar_Click_1(object sender, EventArgs e)
        {
            string id = ListaFuncionario.SelectedCells[0].Value.ToString();
            int ID = int.Parse(id);
            Tela_Atualizar_Funcionario tf = new Tela_Atualizar_Funcionario(ID);
            tf.ShowDialog();
            ListaGrid();
        }
    }
}
