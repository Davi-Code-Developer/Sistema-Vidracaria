using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Sistema.Fields
{
    public partial class Tela_Atualizar_Cliente : Form
    {
        public int ID;
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";
        public Tela_Atualizar_Cliente()
        {
            InitializeComponent();
        }
        public Tela_Atualizar_Cliente(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                objConnect = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                strSQL = "UPDATE CLIENTE SET NOME = @NOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE, CIDADE = @CIDADE, BAIRRO = @BAIRRO, RUA = @RUA, NUMERO = @NUMERO WHERE CLIENTE_ID = @ID;";
                objCommand = new MySqlCommand(strSQL, objConnect);
                objCommand.Parameters.AddWithValue("@ID", ID);
                objCommand.Parameters.AddWithValue("@NOME", TxtNome.Text);
                objCommand.Parameters.AddWithValue("@EMAIL", TxtEmail.Text);
                objCommand.Parameters.AddWithValue("@TELEFONE", TxtTelefone.Text);
                objCommand.Parameters.AddWithValue("@CIDADE", TxtCidade.Text);
                objCommand.Parameters.AddWithValue("@BAIRRO", TxtCidade.Text);
                objCommand.Parameters.AddWithValue("@RUA", TxtRua.Text);
                objCommand.Parameters.AddWithValue("@NUMERO", TxtNumero.Text);
                objConnect.Open();
                objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Usuario não atualizado!");
            }
            finally
            {
                objConnect.Close();
                objConnect = null;
                objCommand = null;
                MessageBox.Show("Cliente atualizado com sucesso");
            }
            Dispose();
        }

        private void Tela_Atualizar_Cliente_Load(object sender, EventArgs e)
        {
            CarregarDados(ID);
        }
        public void CarregarDados(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");

                string selectQuery = "SELECT * FROM CLIENTE WHERE CLIENTE_ID = "+ID+";";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TxtNome.Text = reader.GetString("nome");
                    TxtEmail.Text = reader.GetString("email");
                    TxtTelefone.Text = reader.GetString("telefone");
                    TxtCidade.Text = reader.GetString("cidade");
                    TxtBairro.Text = reader.GetString("bairro");
                    TxtRua.Text = reader.GetString("rua");
                    TxtNumero.Text = reader.GetString("numero");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
