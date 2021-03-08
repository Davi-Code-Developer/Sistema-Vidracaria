
namespace Sistema
{
    partial class Cadastro_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Painel_Fundo = new System.Windows.Forms.Panel();
            this.Painel_Cad_Cliente = new System.Windows.Forms.Panel();
            this.bntCadastro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Painel_Fundo.SuspendLayout();
            this.Painel_Cad_Cliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_Fundo
            // 
            this.Painel_Fundo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Painel_Fundo.Controls.Add(this.Painel_Cad_Cliente);
            this.Painel_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Fundo.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Painel_Fundo.Location = new System.Drawing.Point(0, 0);
            this.Painel_Fundo.Name = "Painel_Fundo";
            this.Painel_Fundo.Size = new System.Drawing.Size(800, 450);
            this.Painel_Fundo.TabIndex = 2;
            // 
            // Painel_Cad_Cliente
            // 
            this.Painel_Cad_Cliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Painel_Cad_Cliente.Controls.Add(this.bntCadastro);
            this.Painel_Cad_Cliente.Controls.Add(this.panel1);
            this.Painel_Cad_Cliente.Location = new System.Drawing.Point(46, 43);
            this.Painel_Cad_Cliente.Name = "Painel_Cad_Cliente";
            this.Painel_Cad_Cliente.Size = new System.Drawing.Size(652, 404);
            this.Painel_Cad_Cliente.TabIndex = 0;
            // 
            // bntCadastro
            // 
            this.bntCadastro.Font = new System.Drawing.Font("Dungeon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastro.Location = new System.Drawing.Point(511, 370);
            this.bntCadastro.Name = "bntCadastro";
            this.bntCadastro.Size = new System.Drawing.Size(138, 31);
            this.bntCadastro.TabIndex = 16;
            this.bntCadastro.Text = "Cadastrar";
            this.bntCadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 371);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo de produto:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Espelho",
            "Acessorio"});
            this.comboBox1.Location = new System.Drawing.Point(27, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 31);
            this.comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo do vidro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Altura:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 31);
            this.textBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Espessura:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 31);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(29, 151);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(210, 31);
            this.TxtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade no estoque:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(27, 213);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(210, 31);
            this.TxtEmail.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Verde",
            "Incolor",
            "Fumê"});
            this.comboBox2.Location = new System.Drawing.Point(357, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 31);
            this.comboBox2.TabIndex = 17;
            // 
            // Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Painel_Fundo);
            this.Name = "Cadastro_Produto";
            this.Text = "Cadastro_Produto";
            this.Painel_Fundo.ResumeLayout(false);
            this.Painel_Cad_Cliente.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Fundo;
        private System.Windows.Forms.Panel Painel_Cad_Cliente;
        private System.Windows.Forms.Button bntCadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}