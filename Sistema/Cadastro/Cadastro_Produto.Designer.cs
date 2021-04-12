
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bntCadastro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Painel_Cad_Cliente = new System.Windows.Forms.Panel();
            this.TxtMedida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.MaskedTextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Painel_Fundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Painel_Cad_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_Fundo
            // 
            this.Painel_Fundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(109)))));
            this.Painel_Fundo.Controls.Add(this.pictureBox3);
            this.Painel_Fundo.Controls.Add(this.button1);
            this.Painel_Fundo.Controls.Add(this.bntCadastro);
            this.Painel_Fundo.Controls.Add(this.label8);
            this.Painel_Fundo.Controls.Add(this.Painel_Cad_Cliente);
            this.Painel_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Fundo.Location = new System.Drawing.Point(0, 0);
            this.Painel_Fundo.Name = "Painel_Fundo";
            this.Painel_Fundo.Size = new System.Drawing.Size(475, 260);
            this.Painel_Fundo.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Sistema.Properties.Resources.IconProduto;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(10, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(312, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntCadastro
            // 
            this.bntCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.bntCadastro.FlatAppearance.BorderSize = 0;
            this.bntCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.bntCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.bntCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastro.ForeColor = System.Drawing.Color.Black;
            this.bntCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCadastro.Location = new System.Drawing.Point(391, 224);
            this.bntCadastro.Name = "bntCadastro";
            this.bntCadastro.Size = new System.Drawing.Size(80, 24);
            this.bntCadastro.TabIndex = 5;
            this.bntCadastro.Text = "Cadastrar";
            this.bntCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntCadastro.UseVisualStyleBackColor = false;
            this.bntCadastro.Click += new System.EventHandler(this.bntCadastro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(43, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "CADASTRO DE PRODUTO";
            // 
            // Painel_Cad_Cliente
            // 
            this.Painel_Cad_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.Painel_Cad_Cliente.Controls.Add(this.TxtMedida);
            this.Painel_Cad_Cliente.Controls.Add(this.label4);
            this.Painel_Cad_Cliente.Controls.Add(this.TxtMaterial);
            this.Painel_Cad_Cliente.Controls.Add(this.label2);
            this.Painel_Cad_Cliente.Controls.Add(this.TxtQuantidade);
            this.Painel_Cad_Cliente.Controls.Add(this.TxtValor);
            this.Painel_Cad_Cliente.Controls.Add(this.TxtNome);
            this.Painel_Cad_Cliente.Controls.Add(this.label9);
            this.Painel_Cad_Cliente.Controls.Add(this.label1);
            this.Painel_Cad_Cliente.Controls.Add(this.label3);
            this.Painel_Cad_Cliente.Location = new System.Drawing.Point(3, 37);
            this.Painel_Cad_Cliente.Name = "Painel_Cad_Cliente";
            this.Painel_Cad_Cliente.Size = new System.Drawing.Size(469, 172);
            this.Painel_Cad_Cliente.TabIndex = 0;
            // 
            // TxtMedida
            // 
            this.TxtMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMedida.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtMedida.Location = new System.Drawing.Point(72, 128);
            this.TxtMedida.Name = "TxtMedida";
            this.TxtMedida.Size = new System.Drawing.Size(123, 22);
            this.TxtMedida.TabIndex = 28;
            this.TxtMedida.Text = "25 cm";
            this.TxtMedida.TextChanged += new System.EventHandler(this.TxtMedida_TextChanged);
            this.TxtMedida.Enter += new System.EventHandler(this.TxtMedida_Enter);
            this.TxtMedida.Leave += new System.EventHandler(this.TxtMedida_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Medida:";
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaterial.Location = new System.Drawing.Point(72, 75);
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.Size = new System.Drawing.Size(190, 22);
            this.TxtMaterial.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Material:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantidade.Location = new System.Drawing.Point(341, 129);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(105, 22);
            this.TxtQuantidade.TabIndex = 3;
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.Location = new System.Drawing.Point(341, 75);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(105, 22);
            this.TxtValor.TabIndex = 2;
            this.TxtValor.ValidatingType = typeof(System.DateTime);
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(72, 23);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(374, 22);
            this.TxtNome.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade:";
            // 
            // Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 260);
            this.Controls.Add(this.Painel_Fundo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Produto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cadastro_Produto_Load);
            this.Painel_Fundo.ResumeLayout(false);
            this.Painel_Fundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Painel_Cad_Cliente.ResumeLayout(false);
            this.Painel_Cad_Cliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Fundo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntCadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel Painel_Cad_Cliente;
        private System.Windows.Forms.MaskedTextBox TxtValor;
        public System.Windows.Forms.TextBox TxtQuantidade;
        public System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtMaterial;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}