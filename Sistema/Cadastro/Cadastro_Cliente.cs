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
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void Painel_Cad_Cliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(TxtNome.TextLength == 0 ||TxtEmail.TextLength == 0 ||
                TxtTelefone.TextLength == 0 || TxtBairro.TextLength == 0 ||
                TxtCidade.TextLength == 0 || TxtNumero.TextLength == 0 ||
                TxtRua.TextLength == 0)
            {
                MessageBox.Show("Alguma das caixas de texto esta vazia!");
            }
            else
            {
                try
                {
                    conexao = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                    strSQL = "INSERT INTO USUARIO " +
                        "(NOME,EMAIL,TELEFONE,CIDADE,BAIRRO,RUA,NUMERO) VALUES" +
                        "(@NOME,@EMAIL,@TELEFONE,@CIDADE,@BAIRRO,@RUA,@NUMERO);";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@NOME", TxtNome.Text);
                    comando.Parameters.AddWithValue("@EMAIL", TxtEmail.Text);
                    comando.Parameters.AddWithValue("@TELEFONE", TxtTelefone.Text);
                    comando.Parameters.AddWithValue("@CIDADE", TxtCidade.Text);
                    comando.Parameters.AddWithValue("@BAIRRO", TxtRua.Text);
                    comando.Parameters.AddWithValue("@RUA", TxtRua.Text);
                    comando.Parameters.AddWithValue("@NUMERO", TxtNumero.Text);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                    MessageBox.Show("CLiente cadastrado com sucesso");
                }
            }*/


        }

        private void bntCadastro_Click(object sender, EventArgs e)
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
                MessageBox.Show("Alguma das caixas de texto esta vazia!");
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
                    comando.Parameters.AddWithValue("@BAIRRO", TxtRua.Text);
                    comando.Parameters.AddWithValue("@RUA", TxtRua.Text);
                    comando.Parameters.AddWithValue("@NUMERO", TxtNumero.Text);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                    MessageBox.Show("CLiente cadastrado com sucesso");
                }
            }
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
    }
}
