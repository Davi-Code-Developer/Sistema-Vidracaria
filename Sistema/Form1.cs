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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            string usario = TextBox_User.Text;
            string senha = TextBox_Pass.Text;

            string user = "adm";
            string pass = "adm";

            if(usario == user && senha == pass)
            {
                Form2 telaPrincipall = new Form2();
                telaPrincipall.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreto!");
            }
        }
    }
}
