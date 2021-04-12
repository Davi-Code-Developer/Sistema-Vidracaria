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

namespace Sistema.Fields
{
    public partial class Tela_Atualizar_Produto : Form
    {
        public int ID;
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";
        public Tela_Atualizar_Produto(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objConnect = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                strSQL = "UPDATE PRODUTO SET NOME = @NOME, MATERIAL = @MATERIAL, MEDIDA = @MEDIDA, VALOR = @VALOR, QUANTIDADE = @QUANTIDADE WHERE PRODUTO_ID = @ID;";
                objCommand = new MySqlCommand(strSQL, objConnect);
                objCommand.Parameters.AddWithValue("@ID", ID);
                objCommand.Parameters.AddWithValue("@NOME", TxtNome.Text);
                objCommand.Parameters.AddWithValue("@MATERIAL", TxtMaterial.Text);
                objCommand.Parameters.AddWithValue("@MEDIDA", TxtMedida.Text);
                objCommand.Parameters.AddWithValue("@VALOR", TxtValor.Text);
                objCommand.Parameters.AddWithValue("@QUANTIDADE", TxtQuantidade.Text);
                objConnect.Open();
                objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Produto não atualizado!");
            }
            finally
            {
                objConnect.Close();
                objConnect = null;
                objCommand = null;
                MessageBox.Show("Produto atualizado com sucesso");
            }
            Dispose();
        }
        public void CarregarDados(int ID)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");

                string selectQuery = "SELECT * FROM PRODUTO WHERE PRODUTO_ID = " + ID + ";";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TxtNome.Text = reader.GetString("nome");
                    TxtMaterial.Text = reader.GetString("material");
                    TxtMedida.Text = reader.GetString("medida");
                    TxtValor.Text = reader.GetString("valor");
                    TxtQuantidade.Text = reader.GetString("quantidade");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tela_Atualizar_Produto_Load(object sender, EventArgs e)
        {
            CarregarDados(ID);
        }
    }
}
