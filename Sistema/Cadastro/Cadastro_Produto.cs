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
    public partial class Cadastro_Produto : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {
            if (TxtNome.TextLength == 0 || 
                TxtValor.TextLength == 0 ||
                TxtQuantidade.TextLength == 0)
            {
                MessageBox.Show("Nome, valor e quantidade não podem estar vazios!");
            }
            else
            {
                try
                {
                    DateTime today = DateTime.Today;
                    conexao = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                    strSQL = "INSERT INTO PRODUTO " +
                            "(NOME,MATERIAL,MEDIDA,VALOR,QUANTIDADE,DATACAD) VALUES" +
                            "(@NOME,@MATERIAL,@MEDIDA,@VALOR,@QUANTIDADE,@DATACAD);";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@NOME", TxtNome.Text);
                    comando.Parameters.AddWithValue("@MATERIAL", TxtMaterial.Text);
                    comando.Parameters.AddWithValue("@MEDIDA", TxtMedida.Text);
                    comando.Parameters.AddWithValue("@VALOR", float.Parse(TxtValor.Text));
                    comando.Parameters.AddWithValue("@QUANTIDADE", int.Parse(TxtQuantidade.Text));
                    comando.Parameters.AddWithValue("@DATACAD", today.ToString("dd/MM/yyyy"));
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Produto não cadastrado!");
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                    MessageBox.Show("Produto cadastrado com sucesso");
                    LimparCampos();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void LimparCampos()
        {
            TxtNome.Text = "";
            TxtMedida.Text = "";
            TxtMaterial.Text = "";
            TxtQuantidade.Text = "";
            TxtValor.Text = "";
        }

        private void Cadastro_Produto_Load(object sender, EventArgs e)
        {
        }

        private void TxtMedida_Enter(object sender, EventArgs e)
        {
            if (TxtMedida.Text == "25 cm")
            {
                TxtMedida.Text = "";
                TxtMedida.ForeColor = Color.Black;
            }
        }

        private void TxtMedida_Leave(object sender, EventArgs e)
        {
            if (TxtMedida.Text == "")
            {
                TxtMedida.Text = "25 cm";
                TxtMedida.ForeColor = Color.Gray;
            }
        }

        private void TxtMedida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
