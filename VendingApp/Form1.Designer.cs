
namespace VendingApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSideMenu.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(7)))));
            this.pnlSideMenu.Controls.Add(this.btnExportar);
            this.pnlSideMenu.Controls.Add(this.btnConsulta);
            this.pnlSideMenu.Controls.Add(this.btnNovaVenda);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(200, 450);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(11)))));
            this.pnlBackground.Controls.Add(this.dataGridView1);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(200, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(780, 450);
            this.pnlBackground.TabIndex = 1;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(13, 48);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(173, 47);
            this.btnNovaVenda.TabIndex = 0;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(14, 116);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(173, 47);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consultar Vendas";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(14, 364);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(173, 47);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvProduto,
            this.dgvQtd,
            this.dgvValUni,
            this.dgvValTotal,
            this.dgvData});
            this.dataGridView1.Location = new System.Drawing.Point(19, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Nome";
            this.dgvName.Name = "dgvName";
            this.dgvName.Width = 125;
            // 
            // dgvProduto
            // 
            this.dgvProduto.HeaderText = "Produto";
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Width = 125;
            // 
            // dgvQtd
            // 
            this.dgvQtd.HeaderText = "Quantidade";
            this.dgvQtd.Name = "dgvQtd";
            this.dgvQtd.Width = 125;
            // 
            // dgvValUni
            // 
            this.dgvValUni.HeaderText = "Valor Uni";
            this.dgvValUni.Name = "dgvValUni";
            // 
            // dgvValTotal
            // 
            this.dgvValTotal.HeaderText = "Valor Total";
            this.dgvValTotal.Name = "dgvValTotal";
            // 
            // dgvData
            // 
            this.dgvData.HeaderText = "DataCompra";
            this.dgvData.Name = "dgvData";
            this.dgvData.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "Form1";
            this.Text = "Tela Inicial";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvData;
    }
}

