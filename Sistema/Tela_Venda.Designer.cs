
namespace Sistema
{
    partial class Tela_Venda
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
            this.Painel_Cad_Cliente = new System.Windows.Forms.Panel();
            this.bntTeste = new System.Windows.Forms.Button();
            this.bntCadastro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtMaterial = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.CheckTemperado = new System.Windows.Forms.CheckBox();
            this.CheckJateado = new System.Windows.Forms.CheckBox();
            this.bntAtivacao = new System.Windows.Forms.Button();
            this.ComboProduto = new System.Windows.Forms.ComboBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.LabelComprimento = new System.Windows.Forms.Label();
            this.ComboAltura = new System.Windows.Forms.ComboBox();
            this.LabelAltura = new System.Windows.Forms.Label();
            this.ComboEspessura = new System.Windows.Forms.ComboBox();
            this.LabelEspessura = new System.Windows.Forms.Label();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.LabelTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntApagar = new System.Windows.Forms.Button();
            this.Painel_Lista = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntFinalizar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.Painel_Fundo = new System.Windows.Forms.Panel();
            this.Painel_Cad_Cliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Painel_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Painel_Fundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_Cad_Cliente
            // 
            this.Painel_Cad_Cliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Painel_Cad_Cliente.Controls.Add(this.bntTeste);
            this.Painel_Cad_Cliente.Controls.Add(this.bntCadastro);
            this.Painel_Cad_Cliente.Controls.Add(this.panel1);
            this.Painel_Cad_Cliente.Location = new System.Drawing.Point(12, 12);
            this.Painel_Cad_Cliente.Name = "Painel_Cad_Cliente";
            this.Painel_Cad_Cliente.Size = new System.Drawing.Size(1326, 363);
            this.Painel_Cad_Cliente.TabIndex = 0;
            // 
            // bntTeste
            // 
            this.bntTeste.Location = new System.Drawing.Point(1075, 308);
            this.bntTeste.Name = "bntTeste";
            this.bntTeste.Size = new System.Drawing.Size(89, 23);
            this.bntTeste.TabIndex = 19;
            this.bntTeste.Text = "Testar";
            this.bntTeste.UseVisualStyleBackColor = true;
            this.bntTeste.Click += new System.EventHandler(this.bntTeste_Click);
            // 
            // bntCadastro
            // 
            this.bntCadastro.Location = new System.Drawing.Point(1213, 308);
            this.bntCadastro.Name = "bntCadastro";
            this.bntCadastro.Size = new System.Drawing.Size(107, 23);
            this.bntCadastro.TabIndex = 16;
            this.bntCadastro.Text = "Adicionar a cesta";
            this.bntCadastro.UseVisualStyleBackColor = true;
            this.bntCadastro.Click += new System.EventHandler(this.bntCadastro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TxtMaterial);
            this.panel1.Controls.Add(this.TxtAltura);
            this.panel1.Controls.Add(this.CheckTemperado);
            this.panel1.Controls.Add(this.CheckJateado);
            this.panel1.Controls.Add(this.bntAtivacao);
            this.panel1.Controls.Add(this.ComboProduto);
            this.panel1.Controls.Add(this.txtComprimento);
            this.panel1.Controls.Add(this.LabelComprimento);
            this.panel1.Controls.Add(this.ComboAltura);
            this.panel1.Controls.Add(this.LabelAltura);
            this.panel1.Controls.Add(this.ComboEspessura);
            this.panel1.Controls.Add(this.LabelEspessura);
            this.panel1.Controls.Add(this.ComboTipo);
            this.panel1.Controls.Add(this.LabelTipo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 302);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.Location = new System.Drawing.Point(8, 138);
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.Size = new System.Drawing.Size(150, 20);
            this.TxtMaterial.TabIndex = 31;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(250, 53);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(125, 20);
            this.TxtAltura.TabIndex = 29;
            this.TxtAltura.Visible = false;
            // 
            // CheckTemperado
            // 
            this.CheckTemperado.AutoSize = true;
            this.CheckTemperado.Location = new System.Drawing.Point(445, 166);
            this.CheckTemperado.Name = "CheckTemperado";
            this.CheckTemperado.Size = new System.Drawing.Size(80, 17);
            this.CheckTemperado.TabIndex = 27;
            this.CheckTemperado.Text = "Temperado";
            this.CheckTemperado.UseVisualStyleBackColor = true;
            // 
            // CheckJateado
            // 
            this.CheckJateado.AutoSize = true;
            this.CheckJateado.Location = new System.Drawing.Point(445, 142);
            this.CheckJateado.Name = "CheckJateado";
            this.CheckJateado.Size = new System.Drawing.Size(64, 17);
            this.CheckJateado.TabIndex = 26;
            this.CheckJateado.Text = "Jateado";
            this.CheckJateado.UseVisualStyleBackColor = true;
            // 
            // bntAtivacao
            // 
            this.bntAtivacao.Location = new System.Drawing.Point(164, 50);
            this.bntAtivacao.Name = "bntAtivacao";
            this.bntAtivacao.Size = new System.Drawing.Size(50, 23);
            this.bntAtivacao.TabIndex = 25;
            this.bntAtivacao.Text = "button1";
            this.bntAtivacao.UseVisualStyleBackColor = true;
            this.bntAtivacao.Visible = false;
            this.bntAtivacao.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboProduto
            // 
            this.ComboProduto.FormattingEnabled = true;
            this.ComboProduto.Items.AddRange(new object[] {
            "Box",
            "Porta",
            "Vidro",
            "Janela"});
            this.ComboProduto.Location = new System.Drawing.Point(8, 52);
            this.ComboProduto.Name = "ComboProduto";
            this.ComboProduto.Size = new System.Drawing.Size(150, 21);
            this.ComboProduto.TabIndex = 24;
            this.ComboProduto.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(250, 138);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(125, 20);
            this.txtComprimento.TabIndex = 23;
            // 
            // LabelComprimento
            // 
            this.LabelComprimento.AutoSize = true;
            this.LabelComprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComprimento.Location = new System.Drawing.Point(246, 100);
            this.LabelComprimento.Name = "LabelComprimento";
            this.LabelComprimento.Size = new System.Drawing.Size(129, 24);
            this.LabelComprimento.TabIndex = 19;
            this.LabelComprimento.Text = "Comprimento:";
            // 
            // ComboAltura
            // 
            this.ComboAltura.FormattingEnabled = true;
            this.ComboAltura.Items.AddRange(new object[] {
            "1.10 m",
            "1.80 m",
            "2.10 m"});
            this.ComboAltura.Location = new System.Drawing.Point(250, 52);
            this.ComboAltura.Name = "ComboAltura";
            this.ComboAltura.Size = new System.Drawing.Size(125, 21);
            this.ComboAltura.TabIndex = 18;
            // 
            // LabelAltura
            // 
            this.LabelAltura.AutoSize = true;
            this.LabelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAltura.Location = new System.Drawing.Point(246, 10);
            this.LabelAltura.Name = "LabelAltura";
            this.LabelAltura.Size = new System.Drawing.Size(63, 24);
            this.LabelAltura.TabIndex = 17;
            this.LabelAltura.Text = "Altura:";
            // 
            // ComboEspessura
            // 
            this.ComboEspessura.FormattingEnabled = true;
            this.ComboEspessura.Items.AddRange(new object[] {
            "2 mm",
            "3 mm",
            "4 mm",
            "5 mm",
            "6 mm",
            "8 mm",
            "10 mm"});
            this.ComboEspessura.Location = new System.Drawing.Point(8, 255);
            this.ComboEspessura.Name = "ComboEspessura";
            this.ComboEspessura.Size = new System.Drawing.Size(77, 21);
            this.ComboEspessura.TabIndex = 11;
            // 
            // LabelEspessura
            // 
            this.LabelEspessura.AutoSize = true;
            this.LabelEspessura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEspessura.Location = new System.Drawing.Point(4, 209);
            this.LabelEspessura.Name = "LabelEspessura";
            this.LabelEspessura.Size = new System.Drawing.Size(104, 24);
            this.LabelEspessura.TabIndex = 10;
            this.LabelEspessura.Text = "Espessura:";
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Incolor",
            "Fumê",
            "Verde"});
            this.ComboTipo.Location = new System.Drawing.Point(8, 138);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(139, 21);
            this.ComboTipo.TabIndex = 9;
            // 
            // LabelTipo
            // 
            this.LabelTipo.AutoSize = true;
            this.LabelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTipo.Location = new System.Drawing.Point(4, 100);
            this.LabelTipo.Name = "LabelTipo";
            this.LabelTipo.Size = new System.Drawing.Size(53, 24);
            this.LabelTipo.TabIndex = 8;
            this.LabelTipo.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntApagar
            // 
            this.bntApagar.Location = new System.Drawing.Point(1136, 657);
            this.bntApagar.Name = "bntApagar";
            this.bntApagar.Size = new System.Drawing.Size(89, 23);
            this.bntApagar.TabIndex = 17;
            this.bntApagar.Text = "Apagar produto";
            this.bntApagar.UseVisualStyleBackColor = true;
            // 
            // Painel_Lista
            // 
            this.Painel_Lista.BackColor = System.Drawing.SystemColors.Window;
            this.Painel_Lista.Controls.Add(this.dataGridView1);
            this.Painel_Lista.Location = new System.Drawing.Point(12, 381);
            this.Painel_Lista.Name = "Painel_Lista";
            this.Painel_Lista.Size = new System.Drawing.Size(1326, 270);
            this.Painel_Lista.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1326, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // bntFinalizar
            // 
            this.bntFinalizar.Location = new System.Drawing.Point(1231, 657);
            this.bntFinalizar.Name = "bntFinalizar";
            this.bntFinalizar.Size = new System.Drawing.Size(107, 23);
            this.bntFinalizar.TabIndex = 17;
            this.bntFinalizar.Text = "Finalizar compra";
            this.bntFinalizar.UseVisualStyleBackColor = true;
            this.bntFinalizar.Click += new System.EventHandler(this.bntFinalizar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(1041, 657);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(89, 23);
            this.bntCancelar.TabIndex = 18;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // Painel_Fundo
            // 
            this.Painel_Fundo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Painel_Fundo.Controls.Add(this.bntCancelar);
            this.Painel_Fundo.Controls.Add(this.bntApagar);
            this.Painel_Fundo.Controls.Add(this.bntFinalizar);
            this.Painel_Fundo.Controls.Add(this.Painel_Lista);
            this.Painel_Fundo.Controls.Add(this.Painel_Cad_Cliente);
            this.Painel_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Fundo.Location = new System.Drawing.Point(0, 0);
            this.Painel_Fundo.Name = "Painel_Fundo";
            this.Painel_Fundo.Size = new System.Drawing.Size(1350, 729);
            this.Painel_Fundo.TabIndex = 1;
            // 
            // Tela_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Painel_Fundo);
            this.Name = "Tela_Venda";
            this.Text = "Tela_Venda";
            this.Painel_Cad_Cliente.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Painel_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Painel_Fundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Painel_Cad_Cliente;
        private System.Windows.Forms.Button bntApagar;
        private System.Windows.Forms.Button bntCadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntFinalizar;
        private System.Windows.Forms.Panel Painel_Lista;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Panel Painel_Fundo;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.Label LabelTipo;
        private System.Windows.Forms.ComboBox ComboEspessura;
        private System.Windows.Forms.Label LabelEspessura;
        private System.Windows.Forms.Label LabelComprimento;
        private System.Windows.Forms.ComboBox ComboAltura;
        private System.Windows.Forms.Label LabelAltura;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.ComboBox ComboProduto;
        private System.Windows.Forms.Button bntTeste;
        private System.Windows.Forms.Button bntAtivacao;
        private System.Windows.Forms.CheckBox CheckTemperado;
        private System.Windows.Forms.CheckBox CheckJateado;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtMaterial;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}