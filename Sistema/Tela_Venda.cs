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
    public partial class Tela_Venda : Form
    {
        public Tela_Venda()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void ComboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bntTeste_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ComboProduto.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op = ComboProduto.Text;
            if (op == "Box")
            {
                ReturnDefault();
                ComboEspessura.SelectedIndex = 5;
                ComboEspessura.Enabled = false;
                ComboAltura.SelectedIndex = 1;
                ComboAltura.Enabled = false;
                CheckTemperado.Checked = true;
                CheckTemperado.Enabled = false;
            }
            if (op == "Porta")
            {
                ReturnDefault();
                ComboEspessura.Items.Clear();
                ComboEspessura.Items.Insert(0, "8 mm");
                ComboEspessura.Items.Insert(1, "10 mm");
                ComboAltura.SelectedIndex = 2;
                ComboAltura.Enabled = false;
            }
            if (op == "Vidro")
            {
                ReturnDefault();
                ComboEspessura.Items.Clear();
                ComboEspessura.Items.Insert(0, "2 mm");
                ComboEspessura.Items.Insert(1, "3 mm");
                ComboEspessura.Items.Insert(2, "4 mm");
                ComboEspessura.Items.Insert(3, "5 mm");
                ComboEspessura.Items.Insert(4, "6 mm");
                ComboTipo.Items.Clear();
                ComboTipo.Items.Insert(0, "Incolor");
                ComboTipo.Items.Insert(1, "Fumê");
                ComboTipo.Items.Insert(2, "Fantasia");
                ComboAltura.Visible = false;
                TxtAltura.Visible = true;
                CheckJateado.Enabled = true;
                CheckTemperado.Visible = false;
            }
            if (op == "Janela")
            {
                ReturnDefault();
                ComboEspessura.SelectedIndex = 5;
                ComboEspessura.Enabled = false;
                CheckTemperado.Checked = true;
                CheckTemperado.Enabled = false;
                ComboAltura.Visible = false;
                TxtAltura.Visible = true;
                CheckJateado.Enabled = false;
                CheckTemperado.Enabled = false;
            }
        }

        private void ReturnDefault()
        {
            CheckJateado.Visible = true;
            CheckTemperado.Visible = true;
            CheckJateado.Enabled = true;
            CheckTemperado.Enabled = true;

            ComboAltura.Enabled = true;
            ComboAltura.Visible = true;
            ComboEspessura.Enabled = true;
            ComboEspessura.Visible = true;
            ComboTipo.Enabled = true;
            ComboTipo.Visible = true;

            ComboTipo.Text = "";
            ComboAltura.Text = "";
            ComboEspessura.Text = "";
            CheckJateado.Checked = false;
            CheckTemperado.Checked = false;

            TxtMaterial.Visible = false;

            TxtAltura.Visible = false;
            LabelTipo.Text = "Tipo";
            LabelEspessura.Visible = true;

            ComboEspessura.Items.Clear();
            ComboEspessura.Items.Insert(0, "2 mm");
            ComboEspessura.Items.Insert(1, "3 mm");
            ComboEspessura.Items.Insert(2, "4 mm");
            ComboEspessura.Items.Insert(3, "5 mm");
            ComboEspessura.Items.Insert(4, "6 mm");
            ComboEspessura.Items.Insert(5, "8 mm");
            ComboEspessura.Items.Insert(6, "10 mm");

            ComboTipo.Items.Clear();
            ComboTipo.Items.Insert(0, "Incolor");
            ComboTipo.Items.Insert(1, "Fumê");
            ComboTipo.Items.Insert(2, "Verde");

            ComboAltura.Items.Clear();
            ComboAltura.Items.Insert(0, "1.10 m");
            ComboAltura.Items.Insert(1, "1.80 m");
            ComboAltura.Items.Insert(2, "2.10 m");

            txtComprimento.Visible = true;
            LabelComprimento.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
