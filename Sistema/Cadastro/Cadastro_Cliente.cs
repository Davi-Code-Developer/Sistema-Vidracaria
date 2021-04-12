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

namespace Sistema
{
    public partial class Cadastro_Cliente : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void Painel_Cad_Cliente_Paint(object sender, PaintEventArgs e)
        {

        }
        private string CheckOp()
        {
            if (RadioMasculino.Checked == true)
            {
                return "Masculino";
            }
            else
            {
                return "Feminino";
            }
        }

        private void bntCadastro_Click_1(object sender, EventArgs e)
        {
            if (TxtNome.TextLength == 0 ||
                TxtCPF.TextLength == 0 ||
                TxtEmail.TextLength == 0 ||
                TxtTelefone.TextLength == 0 ||
                TxtBairro.TextLength == 0 ||
                TxtCidade.TextLength == 0 ||
                TxtNumero.TextLength == 0 ||
                TxtRua.TextLength == 0)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                try
                {
                    conexao = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                    strSQL = "INSERT INTO CLIENTE " +
                            "(NOME,CPF,SEXO,EMAIL,TELEFONE,CIDADE,BAIRRO,RUA,NUMERO) VALUES" +
                            "(@NOME,@CPF,@SEXO,@EMAIL,@TELEFONE,@CIDADE,@BAIRRO,@RUA,@NUMERO);";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@NOME", TxtNome.Text);
                    comando.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                    comando.Parameters.AddWithValue("@SEXO", CheckOp());
                    comando.Parameters.AddWithValue("@EMAIL", TxtEmail.Text);
                    comando.Parameters.AddWithValue("@TELEFONE", TxtTelefone.Text);
                    comando.Parameters.AddWithValue("@CIDADE", TxtCidade.Text);
                    comando.Parameters.AddWithValue("@BAIRRO", TxtBairro.Text);
                    comando.Parameters.AddWithValue("@RUA", TxtRua.Text);
                    comando.Parameters.AddWithValue("@NUMERO", TxtNumero.Text);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Usuario não cadastrado!");
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                    MessageBox.Show("Cliente cadastrado com sucesso");
                }
            }
        }

        private void TxtCPF_Enter(object sender, EventArgs e)
        {
            if (TxtCPF.Text == "000.000.000-00")
            {
                TxtCPF.Text = "";
                TxtCPF.ForeColor = Color.Black;
            }
        }

        private void TxtCPF_Leave(object sender, EventArgs e)
        {
            if (TxtCPF.Text == "")
            {
                TxtCPF.Text = "000.000.000-00";
                TxtCPF.ForeColor = Color.Gray;
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "email@email.com")
            {
                TxtEmail.Text = "";
                TxtEmail.ForeColor = Color.Black;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "")
            {
                TxtEmail.Text = "email@email.com";
                TxtEmail.ForeColor = Color.Gray;
            }
        }

        private void TxtTelefone_Enter(object sender, EventArgs e)
        {
            if (TxtTelefone.Text == "(75) 99999-9999")
            {
                TxtTelefone.Text = "";
                TxtTelefone.ForeColor = Color.Black;
            }
        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            if (TxtTelefone.Text == "")
            {
                TxtTelefone.Text = "75999999999";
                TxtTelefone.ForeColor = Color.Gray;
            }
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
