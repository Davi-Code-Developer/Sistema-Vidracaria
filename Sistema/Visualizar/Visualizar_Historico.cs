using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Visualizar
{
    public partial class Visualizar_Historico : Form
    {
        public Visualizar_Historico()
        {
            InitializeComponent();
        }
        private string strConn = "Server=localhost;Database=sistema;Uid=root;Pwd=1234;";
        MySqlCommand objCommand = null;
        MySqlConnection objConnect = null;
        string strSQL = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void ListaGrid()
        {
            strSQL = "SELECT NOMEARQUIVO AS 'LOCALIZAÇÃO',PEDIDO_ID AS 'ID PEDIDO', CLIENTE_ID_FK AS 'ID CLIENTE',DATACAD 'DATA DA COMPRA', VENDEDOR AS VENDEDOR, TOTAL, DATAFINAL AS 'DATA DE FINALIZAÇÃO' FROM HISTORICO;";
            objConnect = new MySqlConnection(strConn);
            objCommand = new MySqlCommand(strSQL, objConnect);
            try
            {
                MySqlDataAdapter objDA = new MySqlDataAdapter(objCommand);
                DataTable dt = new DataTable();
                objDA.Fill(dt);
                ListaPendentes.DataSource = dt;
                ListaPendentes.AutoResizeColumns();
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

        private void Visualizar_Historico_Load(object sender, EventArgs e)
        {
            Color color = new Color();
            color = Color.FromArgb(0, 0, 0);
            ListaPendentes.ForeColor = color;
            ListaGrid();

            ListaPendentes.BorderStyle = BorderStyle.None;
            ListaPendentes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ListaPendentes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListaPendentes.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ListaPendentes.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ListaPendentes.BackgroundColor = Color.White;

            ListaPendentes.EnableHeadersVisualStyles = false;
            ListaPendentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ListaPendentes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ListaPendentes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
