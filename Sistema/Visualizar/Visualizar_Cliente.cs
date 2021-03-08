using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Visualizar_Cliente : Form
    {
        public Visualizar_Cliente()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bnt_Excluir_Click(object sender, EventArgs e)
        {
            
        }

        private void bnt_Opcoes_Click(object sender, EventArgs e)
        {
            Panel pn = Painel_SubOpcoes;
            if (pn.Visible == false)
            {
                pn.Visible = true;
            }
            else
            {
                pn.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
