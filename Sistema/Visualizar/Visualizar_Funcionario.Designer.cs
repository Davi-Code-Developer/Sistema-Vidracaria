
namespace Sistema.Visualizar
{
    partial class Visualizar_Funcionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_Funcionario));
            this.Painel_Fundo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bntAtualizar = new System.Windows.Forms.Button();
            this.bntAdicionar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.ListaFuncionario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Painel_Fundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // Painel_Fundo
            // 
            this.Painel_Fundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(109)))));
            this.Painel_Fundo.Controls.Add(this.pictureBox3);
            this.Painel_Fundo.Controls.Add(this.bntAtualizar);
            this.Painel_Fundo.Controls.Add(this.bntAdicionar);
            this.Painel_Fundo.Controls.Add(this.bntExcluir);
            this.Painel_Fundo.Controls.Add(this.ListaFuncionario);
            this.Painel_Fundo.Controls.Add(this.button1);
            this.Painel_Fundo.Controls.Add(this.TxtNome);
            this.Painel_Fundo.Controls.Add(this.label1);
            this.Painel_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Fundo.ForeColor = System.Drawing.Color.White;
            this.Painel_Fundo.Location = new System.Drawing.Point(0, 0);
            this.Painel_Fundo.Name = "Painel_Fundo";
            this.Painel_Fundo.Size = new System.Drawing.Size(884, 400);
            this.Painel_Fundo.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Sistema.Properties.Resources.IconFuncio1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(258, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // bntAtualizar
            // 
            this.bntAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.bntAtualizar.BackgroundImage = global::Sistema.Properties.Resources.Icon_Update2;
            this.bntAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntAtualizar.FlatAppearance.BorderSize = 0;
            this.bntAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAtualizar.ForeColor = System.Drawing.Color.Black;
            this.bntAtualizar.Location = new System.Drawing.Point(85, 40);
            this.bntAtualizar.Name = "bntAtualizar";
            this.bntAtualizar.Size = new System.Drawing.Size(28, 27);
            this.bntAtualizar.TabIndex = 55;
            this.bntAtualizar.UseVisualStyleBackColor = false;
            this.bntAtualizar.Click += new System.EventHandler(this.bntAtualizar_Click_1);
            // 
            // bntAdicionar
            // 
            this.bntAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.bntAdicionar.BackgroundImage = global::Sistema.Properties.Resources.Icon_More2;
            this.bntAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntAdicionar.FlatAppearance.BorderSize = 0;
            this.bntAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAdicionar.ForeColor = System.Drawing.Color.Black;
            this.bntAdicionar.Location = new System.Drawing.Point(119, 40);
            this.bntAdicionar.Name = "bntAdicionar";
            this.bntAdicionar.Size = new System.Drawing.Size(28, 27);
            this.bntAdicionar.TabIndex = 54;
            this.bntAdicionar.UseVisualStyleBackColor = false;
            this.bntAdicionar.Click += new System.EventHandler(this.bntAdicionar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.BackColor = System.Drawing.Color.Transparent;
            this.bntExcluir.BackgroundImage = global::Sistema.Properties.Resources.IconX1;
            this.bntExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntExcluir.FlatAppearance.BorderSize = 0;
            this.bntExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExcluir.ForeColor = System.Drawing.Color.Black;
            this.bntExcluir.Location = new System.Drawing.Point(51, 40);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(28, 27);
            this.bntExcluir.TabIndex = 53;
            this.bntExcluir.UseVisualStyleBackColor = false;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // ListaFuncionario
            // 
            this.ListaFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListaFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.ListaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaFuncionario.Location = new System.Drawing.Point(3, 68);
            this.ListaFuncionario.Name = "ListaFuncionario";
            this.ListaFuncionario.Size = new System.Drawing.Size(878, 326);
            this.ListaFuncionario.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(844, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(667, 34);
            this.TxtNome.Multiline = true;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(205, 28);
            this.TxtNome.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "LISTA DE FUNCIONARÁRIOS";
            // 
            // Visualizar_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 400);
            this.Controls.Add(this.Painel_Fundo);
            this.Name = "Visualizar_Funcionario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Visualizar_Funcionario_Load);
            this.Painel_Fundo.ResumeLayout(false);
            this.Painel_Fundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Fundo;
        private System.Windows.Forms.DataGridView ListaFuncionario;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntAtualizar;
        private System.Windows.Forms.Button bntAdicionar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}