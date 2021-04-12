using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema.Fields
{
    public partial class Tela_Atualizar_Funcionario : Form
    {
        public int ID;
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";
        public Tela_Atualizar_Funcionario(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Tela_Atualizar_Funcionario_Load(object sender, EventArgs e)
        {
            CarregarDados(ID);
        }
        public void CarregarDados(int ID)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");

                string selectQuery = "SELECT * FROM FUNCIONARIO WHERE FUNCIONARIO_ID = " + ID + ";";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TxtNome.Text = reader.GetString("nome");
                    TxtEmail.Text = reader.GetString("email");
                    TxtTelefone.Text = reader.GetString("telefone");
                    TxtCPF.Text = reader.GetString("cpf");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objConnect = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                strSQL = "UPDATE FUNCIONARIO SET NOME = @NOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE, CPF = @CPF WHERE FUNCIONARIO_ID = @ID;";
                objCommand = new MySqlCommand(strSQL, objConnect);
                objCommand.Parameters.AddWithValue("@ID", ID);
                objCommand.Parameters.AddWithValue("@NOME", TxtNome.Text);
                objCommand.Parameters.AddWithValue("@EMAIL", TxtEmail.Text);
                objCommand.Parameters.AddWithValue("@TELEFONE", TxtTelefone.Text);
                objCommand.Parameters.AddWithValue("@CPF", TxtCPF.Text);
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
    }
}
