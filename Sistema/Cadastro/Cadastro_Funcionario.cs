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
    public partial class Cadastro_Funcionario : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Cadastro_Funcionario()
        {
            InitializeComponent();
        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {
            if (TxtNome.TextLength == 0 || TxtEmail.TextLength == 0 ||
                TxtTelefone.TextLength == 0 || TxtCPF.TextLength == 0)
            {
                MessageBox.Show("Alguma das caixas de texto esta vazia!");
            }
            else
            {
                try
                {
                    conexao = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                    strSQL = "INSERT INTO FUNCIONARIO " +
                        "(NOME,EMAIL,TELEFONE,CPF,DATANASC,SEXO) VALUES" +
                        "(@NOME,@EMAIL,@TELEFONE,@CPF,@DATANASC,@SEXO);";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@NOME", TxtNome.Text);
                    comando.Parameters.AddWithValue("@EMAIL", TxtEmail.Text);
                    comando.Parameters.AddWithValue("@TELEFONE", TxtTelefone.Text);
                    comando.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                    comando.Parameters.AddWithValue("@DATANASC", TxtData.Text);
                    comando.Parameters.AddWithValue("@SEXO", CheckOp());
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
                    MessageBox.Show("Cliente cadastrado com sucesso");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
