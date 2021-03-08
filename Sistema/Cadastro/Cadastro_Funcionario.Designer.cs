
namespace Sistema
{
    partial class Cadastro_Funcionario
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDataNascimento = new System.Windows.Forms.TextBox();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxSexo = new System.Windows.Forms.ComboBox();
            this.Painel_Fundo.SuspendLayout();
            this.Painel_Cad_Cliente.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.Painel_Fundo.TabIndex = 1;
            // 
            // Painel_Cad_Cliente
            // 
            this.Painel_Cad_Cliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Painel_Cad_Cliente.Controls.Add(this.bntCadastro);
            this.Painel_Cad_Cliente.Controls.Add(this.panel2);
            this.Painel_Cad_Cliente.Controls.Add(this.panel1);
            this.Painel_Cad_Cliente.Location = new System.Drawing.Point(127, 84);
            this.Painel_Cad_Cliente.Name = "Painel_Cad_Cliente";
            this.Painel_Cad_Cliente.Size = new System.Drawing.Size(571, 363);
            this.Painel_Cad_Cliente.TabIndex = 0;
            // 
            // bntCadastro
            // 
            this.bntCadastro.Font = new System.Drawing.Font("Dungeon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastro.Location = new System.Drawing.Point(430, 332);
            this.bntCadastro.Name = "bntCadastro";
            this.bntCadastro.Size = new System.Drawing.Size(138, 31);
            this.bntCadastro.TabIndex = 16;
            this.bntCadastro.Text = "Cadastrar";
            this.bntCadastro.UseVisualStyleBackColor = true;
            this.bntCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.BoxSexo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxtDataNascimento);
            this.panel2.Controls.Add(this.TxtCPF);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 159);
            this.panel2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(281, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data de nascimento: (ANO,MES,DIA)";
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Location = new System.Drawing.Point(285, 39);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(241, 31);
            this.TxtDataNascimento.TabIndex = 13;
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(36, 39);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(207, 31);
            this.TxtCPF.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(38, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPF:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtTelefone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 161);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(36, 42);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(210, 31);
            this.TxtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(288, 41);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(100, 31);
            this.TxtTelefone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(36, 112);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(210, 31);
            this.TxtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(38, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sexo:";
            // 
            // BoxSexo
            // 
            this.BoxSexo.FormattingEnabled = true;
            this.BoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.BoxSexo.Location = new System.Drawing.Point(36, 116);
            this.BoxSexo.Name = "BoxSexo";
            this.BoxSexo.Size = new System.Drawing.Size(207, 31);
            this.BoxSexo.TabIndex = 16;
            // 
            // Cadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Painel_Fundo);
            this.Name = "Cadastro_Funcionario";
            this.Text = "Form3";
            this.Painel_Fundo.ResumeLayout(false);
            this.Painel_Cad_Cliente.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Fundo;
        private System.Windows.Forms.Panel Painel_Cad_Cliente;
        private System.Windows.Forms.Button bntCadastro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDataNascimento;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.ComboBox BoxSexo;
        private System.Windows.Forms.Label label4;
    }
}