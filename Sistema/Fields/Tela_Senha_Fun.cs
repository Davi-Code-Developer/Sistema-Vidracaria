using Sistema.Visualizar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Fields
{
    public partial class Tela_Senha_Fun : Form
    {
        public Tela_Senha_Fun()
        {
            InitializeComponent();
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "misael")
            {
                Visualizar_Funcionario V_Funcionario = new Visualizar_Funcionario();
                V_Funcionario.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Entrada não autorizada!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
