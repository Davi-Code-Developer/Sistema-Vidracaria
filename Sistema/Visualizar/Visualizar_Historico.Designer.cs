﻿
namespace Sistema.Visualizar
{
    partial class Visualizar_Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_Historico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Painel_Fundo = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.ListaPendentes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Painel_Fundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // Painel_Fundo
            // 
            this.Painel_Fundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(109)))));
            this.Painel_Fundo.Controls.Add(this.button2);
            this.Painel_Fundo.Controls.Add(this.TxtNome);
            this.Painel_Fundo.Controls.Add(this.ListaPendentes);
            this.Painel_Fundo.Controls.Add(this.label1);
            this.Painel_Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Fundo.ForeColor = System.Drawing.Color.White;
            this.Painel_Fundo.Location = new System.Drawing.Point(0, 0);
            this.Painel_Fundo.Name = "Painel_Fundo";
            this.Painel_Fundo.Size = new System.Drawing.Size(884, 403);
            this.Painel_Fundo.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(844, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 54;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(667, 50);
            this.TxtNome.Multiline = true;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(205, 28);
            this.TxtNome.TabIndex = 53;
            // 
            // ListaPendentes
            // 
            this.ListaPendentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaPendentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListaPendentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.ListaPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaPendentes.DefaultCellStyle = dataGridViewCellStyle1;
            this.ListaPendentes.Location = new System.Drawing.Point(3, 95);
            this.ListaPendentes.Name = "ListaPendentes";
            this.ListaPendentes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.ListaPendentes.Size = new System.Drawing.Size(878, 304);
            this.ListaPendentes.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "HISTÓRICO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Visualizar_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 403);
            this.Controls.Add(this.Painel_Fundo);
            this.Name = "Visualizar_Historico";
            this.Text = "Visualizar_Historico";
            this.Load += new System.EventHandler(this.Visualizar_Historico_Load);
            this.Painel_Fundo.ResumeLayout(false);
            this.Painel_Fundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPendentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Fundo;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox TxtNome;
        public System.Windows.Forms.DataGridView ListaPendentes;
        private System.Windows.Forms.Label label1;
    }
}