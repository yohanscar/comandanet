namespace Comanda_net
{
    partial class Detalhar_Comanda
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_comanda = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFechamento = new System.Windows.Forms.TextBox();
            this.textAbertura = new System.Windows.Forms.TextBox();
            this.dataGridItens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Rem = new System.Windows.Forms.Button();
            this.textCodProduto = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.FILLER = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comanda Nº";
            // 
            // textBox_comanda
            // 
            this.textBox_comanda.Location = new System.Drawing.Point(99, 16);
            this.textBox_comanda.Name = "textBox_comanda";
            this.textBox_comanda.Size = new System.Drawing.Size(141, 20);
            this.textBox_comanda.TabIndex = 1;
            this.textBox_comanda.TextChanged += new System.EventHandler(this.textBox_comanda_TextChanged);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(246, 14);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 2;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(99, 53);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(208, 20);
            this.textCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Abertura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fechamento";
            // 
            // textFechamento
            // 
            this.textFechamento.Location = new System.Drawing.Point(385, 53);
            this.textFechamento.Name = "textFechamento";
            this.textFechamento.Size = new System.Drawing.Size(133, 20);
            this.textFechamento.TabIndex = 8;
            // 
            // textAbertura
            // 
            this.textAbertura.Location = new System.Drawing.Point(385, 16);
            this.textAbertura.Name = "textAbertura";
            this.textAbertura.Size = new System.Drawing.Size(133, 20);
            this.textAbertura.TabIndex = 9;
            // 
            // dataGridItens
            // 
            this.dataGridItens.AllowUserToAddRows = false;
            this.dataGridItens.AllowUserToDeleteRows = false;
            this.dataGridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Quantidade,
            this.Column3,
            this.Column4});
            this.dataGridItens.Location = new System.Drawing.Point(12, 108);
            this.dataGridItens.Name = "dataGridItens";
            this.dataGridItens.ReadOnly = true;
            this.dataGridItens.Size = new System.Drawing.Size(506, 188);
            this.dataGridItens.TabIndex = 10;
            this.dataGridItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "_CodProduto";
            this.Column1.HeaderText = "Codigo Iten";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "_DescProduto";
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "_QtdeProduto";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "_VlUnitario";
            this.Column3.HeaderText = "Valor Unitario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "_SubTotal";
            this.Column4.HeaderText = "Sub. Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Location = new System.Drawing.Point(403, 302);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(115, 23);
            this.bt_Fechar.TabIndex = 11;
            this.bt_Fechar.Text = "Fechar Consumo";
            this.bt_Fechar.UseVisualStyleBackColor = true;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(147, 302);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(115, 23);
            this.bt_Add.TabIndex = 12;
            this.bt_Add.Text = "Adicionar Iten";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Rem
            // 
            this.bt_Rem.Location = new System.Drawing.Point(274, 302);
            this.bt_Rem.Name = "bt_Rem";
            this.bt_Rem.Size = new System.Drawing.Size(115, 23);
            this.bt_Rem.TabIndex = 13;
            this.bt_Rem.Text = "Remover Iten";
            this.bt_Rem.UseVisualStyleBackColor = true;
            this.bt_Rem.Click += new System.EventHandler(this.bt_Rem_Click);
            // 
            // textCodProduto
            // 
            this.textCodProduto.Location = new System.Drawing.Point(12, 304);
            this.textCodProduto.Name = "textCodProduto";
            this.textCodProduto.Size = new System.Drawing.Size(129, 20);
            this.textCodProduto.TabIndex = 14;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(179, 80);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(208, 25);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "TOTAL CONSUMO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "R$";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.Location = new System.Drawing.Point(422, 80);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(52, 25);
            this.labelValorTotal.TabIndex = 17;
            this.labelValorTotal.Text = "  00";
            // 
            // FILLER
            // 
            this.FILLER.AutoSize = true;
            this.FILLER.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FILLER.Location = new System.Drawing.Point(469, 81);
            this.FILLER.Name = "FILLER";
            this.FILLER.Size = new System.Drawing.Size(36, 18);
            this.FILLER.TabIndex = 18;
            this.FILLER.Text = ", 00";
            // 
            // Detalhar_Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 333);
            this.Controls.Add(this.FILLER);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textCodProduto);
            this.Controls.Add(this.bt_Rem);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Fechar);
            this.Controls.Add(this.dataGridItens);
            this.Controls.Add(this.textAbertura);
            this.Controls.Add(this.textFechamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.textBox_comanda);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Detalhar_Comanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhar Comanda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFechamento;
        private System.Windows.Forms.TextBox textAbertura;
        private System.Windows.Forms.DataGridView dataGridItens;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Rem;
        public System.Windows.Forms.TextBox textBox_comanda;
        private System.Windows.Forms.TextBox textCodProduto;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label FILLER;
    }
}