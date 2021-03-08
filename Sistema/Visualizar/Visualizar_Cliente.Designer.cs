
namespace Sistema
{
    partial class Visualizar_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_Cliente));
            this.Painel_Fundo = new System.Windows.Forms.Panel();
            this.Painel_Opcoes = new System.Windows.Forms.Panel();
            this.Painel_SubOpcoes = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.bnt_Opcoes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnt_Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Painel_Fundo.SuspendLayout();
            this.Painel_Opcoes.SuspendLayout();
            this.Painel_SubOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Painel_Fundo
            // 
            this.Painel_Fundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(109)))));
            this.Painel_Fundo.Controls.Add(this.Painel_Opcoes);
            this.Painel_Fundo.Controls.Add(this.button1);
            this.Painel_Fundo.Controls.Add(this.TxtNome);
            this.Painel_Fundo.Controls.Add(this.dataGridView1);
            this.Painel_Fundo.Controls.Add(this.bnt_Voltar);
            this.Painel_Fundo.Controls.Add(this.label1);
            this.Painel_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Fundo.ForeColor = System.Drawing.Color.White;
            this.Painel_Fundo.Location = new System.Drawing.Point(0, 0);
            this.Painel_Fundo.Name = "Painel_Fundo";
            this.Painel_Fundo.Size = new System.Drawing.Size(884, 561);
            this.Painel_Fundo.TabIndex = 1;
            // 
            // Painel_Opcoes
            // 
            this.Painel_Opcoes.BackColor = System.Drawing.Color.Transparent;
            this.Painel_Opcoes.Controls.Add(this.Painel_SubOpcoes);
            this.Painel_Opcoes.Controls.Add(this.bnt_Opcoes);
            this.Painel_Opcoes.ForeColor = System.Drawing.Color.White;
            this.Painel_Opcoes.Location = new System.Drawing.Point(19, 80);
            this.Painel_Opcoes.Margin = new System.Windows.Forms.Padding(0, 25, 40, 0);
            this.Painel_Opcoes.Name = "Painel_Opcoes";
            this.Painel_Opcoes.Size = new System.Drawing.Size(156, 89);
            this.Painel_Opcoes.TabIndex = 43;
            // 
            // Painel_SubOpcoes
            // 
            this.Painel_SubOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.Painel_SubOpcoes.Controls.Add(this.button2);
            this.Painel_SubOpcoes.Controls.Add(this.button12);
            this.Painel_SubOpcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Painel_SubOpcoes.ForeColor = System.Drawing.Color.Transparent;
            this.Painel_SubOpcoes.Location = new System.Drawing.Point(0, 31);
            this.Painel_SubOpcoes.Name = "Painel_SubOpcoes";
            this.Painel_SubOpcoes.Size = new System.Drawing.Size(156, 58);
            this.Painel_SubOpcoes.TabIndex = 5;
            this.Painel_SubOpcoes.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 29);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(156, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "      Atualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(156, 29);
            this.button12.TabIndex = 1;
            this.button12.Text = "       Excluir";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // bnt_Opcoes
            // 
            this.bnt_Opcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.bnt_Opcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnt_Opcoes.FlatAppearance.BorderSize = 0;
            this.bnt_Opcoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.bnt_Opcoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.bnt_Opcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Opcoes.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Opcoes.ForeColor = System.Drawing.Color.White;
            this.bnt_Opcoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Opcoes.Location = new System.Drawing.Point(0, 0);
            this.bnt_Opcoes.Name = "bnt_Opcoes";
            this.bnt_Opcoes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bnt_Opcoes.Size = new System.Drawing.Size(156, 31);
            this.bnt_Opcoes.TabIndex = 6;
            this.bnt_Opcoes.Text = "Opções";
            this.bnt_Opcoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_Opcoes.UseVisualStyleBackColor = false;
            this.bnt_Opcoes.Click += new System.EventHandler(this.bnt_Opcoes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(844, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(667, 80);
            this.TxtNome.Multiline = true;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(205, 28);
            this.TxtNome.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Email,
            this.Telefone,
            this.Sexo,
            this.Cidade});
            this.dataGridView1.Location = new System.Drawing.Point(3, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 352);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 35.92814F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.FillWeight = 112.8144F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Email
            // 
            this.Email.FillWeight = 112.8144F;
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // Telefone
            // 
            this.Telefone.FillWeight = 112.8144F;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Sexo
            // 
            this.Sexo.FillWeight = 112.8144F;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Cidade
            // 
            this.Cidade.FillWeight = 112.8144F;
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // bnt_Voltar
            // 
            this.bnt_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnt_Voltar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bnt_Voltar.FlatAppearance.BorderSize = 0;
            this.bnt_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.bnt_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.bnt_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Voltar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Voltar.ForeColor = System.Drawing.Color.Black;
            this.bnt_Voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_Voltar.Location = new System.Drawing.Point(795, 526);
            this.bnt_Voltar.Name = "bnt_Voltar";
            this.bnt_Voltar.Size = new System.Drawing.Size(77, 23);
            this.bnt_Voltar.TabIndex = 37;
            this.bnt_Voltar.Text = "Salvar";
            this.bnt_Voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_Voltar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 27);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lista de clientes";
            // 
            // Visualizar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Painel_Fundo);
            this.MaximizeBox = false;
            this.Name = "Visualizar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar_Cliente";
            this.Painel_Fundo.ResumeLayout(false);
            this.Painel_Fundo.PerformLayout();
            this.Painel_Opcoes.ResumeLayout(false);
            this.Painel_SubOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Fundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_Voltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        public System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Painel_Opcoes;
        private System.Windows.Forms.Panel Painel_SubOpcoes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button bnt_Opcoes;
    }
}