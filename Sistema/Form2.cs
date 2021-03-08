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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Panel pn = Painel_SubMenu_Cadastro;
            if(pn.Visible == false)
            {
                pn.Visible = true;
            }
            else
            {
                pn.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Panel pn3 = Painel_SubMenuSub3;
            if (pn3.Visible == false)
            {
                pn3.Visible = true;
            }
            else
            {
                pn3.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Panel pn2 = Painel_SubMenuSub2;
            if (pn2.Visible == false)
            {
                pn2.Visible = true;
            }
            else
            {
                pn2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel pn1 = Painel_SubMenuSub;
            if (pn1.Visible == false)
            {
                pn1.Visible = true;
            }
            else
            {
                pn1.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente Cad_Cliente = new Cadastro_Cliente();
            Cad_Cliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_Produto Cad_Produto = new Cadastro_Produto();
            Cad_Produto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro_Funcionario Cad_Funcionario = new Cadastro_Funcionario();
            Cad_Funcionario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Panel pn = Painel_SubMenuLoja;
            if (pn.Visible == false)
            {
                pn.Visible = true;
            }
            else
            {
                pn.Visible = false;
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Tela_Venda t_venda = new Tela_Venda();
            t_venda.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Visualizar_Cliente V_Cliente = new Visualizar_Cliente();
            V_Cliente.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
