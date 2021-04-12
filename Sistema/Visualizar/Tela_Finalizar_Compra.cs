using MySql.Data.MySqlClient;
using Sistema.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Visualizar
{
    public partial class Tela_Finalizar_Compra : Form
    {
        string strSQL = "";
        MySqlConnection conexao;
        MySqlCommand comando;
        List<Produto> listaProdutos;
        public string vendedor;
        public double total;
        public Tela_Finalizar_Compra(List<Produto> listaProduto, string vende,double valor)
        {
            listaProdutos = new List<Produto>(listaProduto);
            InitializeComponent();
            vendedor = vende;
            total = valor;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Visible == false)
            {
                label1.Visible = true;
                label2.Visible = true;
                ComboCliente.Visible = true;
                button3.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                ComboCliente.Visible = false;
                button3.Visible = true;
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente2 cadastro_Cliente = new Cadastro_Cliente2();
            cadastro_Cliente.ShowDialog();
            ComboCliente.Items.Clear();
            listarCliente();
        }

        private void Tela_Finalizar_Compra_Load(object sender, EventArgs e)
        {
            listarCliente();
        }
        private void listarCliente()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");

                string selectQuery = "SELECT * FROM CLIENTE;";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ComboCliente.Items.Add(reader.GetString("nome")+" ID:" + reader.GetString("cliente_id"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(ComboCliente.Text != "")
            {
                var temp = ComboCliente.Text.Split(':');
                int id = int.Parse(temp[1]);
                DateTime today = DateTime.Today;
                try
                {
                    conexao = new MySqlConnection("Server=localhost;Database=sistema;Uid=root;Pwd=1234;");
                    strSQL = "INSERT INTO PEDIDO " +
                            "(CLIENTE_ID_FK,NOMEARQUIVO,DATACAD,VENDEDOR,TOTAL) VALUES" +
                            "(@CLIENTE,@ARQUIVO,@DATACAD,@VENDEDOR,@TOTAL);";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@CLIENTE", id);
                    comando.Parameters.AddWithValue("@ARQUIVO", criarArquivo(id));
                    comando.Parameters.AddWithValue("@DATACAD", today.ToString("dd/MM/yyyy"));
                    comando.Parameters.AddWithValue("@VENDEDOR", vendedor);
                    comando.Parameters.AddWithValue("@TOTAL", total);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Pedido não cadastrado!");
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                    MessageBox.Show("Pedido cadastrado com sucesso");
                }
                Tela_Finalizar_Compra_SIM compra_SIM = new Tela_Finalizar_Compra_SIM();
                compra_SIM.ShowDialog();
                Dispose();
            }
            else
            {
                MessageBox.Show("Selecione um cliente!");
            }

        }
        public string criarArquivo(int id)
        {
            Random randNum = new Random();
            
            DateTime today = DateTime.Today;
            string data = today.ToString("dd/MM/yyyy").Replace('/','-');
            string url = @"C:\Pedido\" + id + " " + data + " - "+ randNum.Next(1,999)+".txt";
            try
            {
                StreamWriter name = new StreamWriter(url);
                foreach (Produto product in listaProdutos)
                {
                    name.WriteLine(product.ToString());
                }

                name.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return url;
        }
    }
}
