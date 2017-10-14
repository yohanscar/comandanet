namespace Comanda_net
{
    partial class Inteface_principal
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalharComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoDeConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comanda_net_databaseDataSet = new Comanda_net.Comanda_net_databaseDataSet();
            this.t_USUARIOSTableAdapter = new Comanda_net.Comanda_net_databaseDataSetTableAdapters.T_USUARIOSTableAdapter();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tUSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(602, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Comanda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Produtos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(726, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(0, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1008, 53);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(353, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = "Abrir Consumo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clienteToolStripMenuItem,
            this.consumoToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.consultarUsuáriosToolStripMenuItem,
            this.listarUsuariosToolStripMenuItem,
            this.listarUsuariosToolStripMenuItem1,
            this.alterarUsuariosToolStripMenuItem,
            this.cadastrarUsuárioToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "Login";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem2.Text = "Login";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // consultarUsuáriosToolStripMenuItem
            // 
            this.consultarUsuáriosToolStripMenuItem.Name = "consultarUsuáriosToolStripMenuItem";
            this.consultarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.consultarUsuáriosToolStripMenuItem.Text = "Logout";
            this.consultarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuáriosToolStripMenuItem_Click);
            // 
            // listarUsuariosToolStripMenuItem
            // 
            this.listarUsuariosToolStripMenuItem.Name = "listarUsuariosToolStripMenuItem";
            this.listarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listarUsuariosToolStripMenuItem.Text = "Alterar Senha";
            this.listarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listarUsuariosToolStripMenuItem_Click);
            // 
            // listarUsuariosToolStripMenuItem1
            // 
            this.listarUsuariosToolStripMenuItem1.Name = "listarUsuariosToolStripMenuItem1";
            this.listarUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.listarUsuariosToolStripMenuItem1.Text = "Listar Usuários";
            this.listarUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.listarUsuariosToolStripMenuItem1_Click);
            // 
            // alterarUsuariosToolStripMenuItem
            // 
            this.alterarUsuariosToolStripMenuItem.Name = "alterarUsuariosToolStripMenuItem";
            this.alterarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.alterarUsuariosToolStripMenuItem.Text = "Alterar Usuários";
            this.alterarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.alterarUsuariosToolStripMenuItem_Click);
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem,
            this.excluirClienteToolStripMenuItem,
            this.pesquisarClienteToolStripMenuItem,
            this.listarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.consultarClienteToolStripMenuItem.Text = "Alterar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // excluirClienteToolStripMenuItem
            // 
            this.excluirClienteToolStripMenuItem.Name = "excluirClienteToolStripMenuItem";
            this.excluirClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.excluirClienteToolStripMenuItem.Text = "Excluir Cliente";
            this.excluirClienteToolStripMenuItem.Click += new System.EventHandler(this.excluirClienteToolStripMenuItem_Click);
            // 
            // pesquisarClienteToolStripMenuItem
            // 
            this.pesquisarClienteToolStripMenuItem.Name = "pesquisarClienteToolStripMenuItem";
            this.pesquisarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pesquisarClienteToolStripMenuItem.Text = "Pesquisar Cliente";
            this.pesquisarClienteToolStripMenuItem.Click += new System.EventHandler(this.pesquisarClienteToolStripMenuItem_Click);
            // 
            // listarClienteToolStripMenuItem
            // 
            this.listarClienteToolStripMenuItem.Name = "listarClienteToolStripMenuItem";
            this.listarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listarClienteToolStripMenuItem.Text = "Listar Clientes";
            this.listarClienteToolStripMenuItem.Click += new System.EventHandler(this.listarClienteToolStripMenuItem_Click);
            // 
            // consumoToolStripMenuItem
            // 
            this.consumoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumirToolStripMenuItem,
            this.detalharComandaToolStripMenuItem,
            this.cadastrarComandaToolStripMenuItem,
            this.historicoDeConsumoToolStripMenuItem});
            this.consumoToolStripMenuItem.Name = "consumoToolStripMenuItem";
            this.consumoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consumoToolStripMenuItem.Text = "Consumo";
            // 
            // consumirToolStripMenuItem
            // 
            this.consumirToolStripMenuItem.Name = "consumirToolStripMenuItem";
            this.consumirToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.consumirToolStripMenuItem.Text = "Abrir Consumo";
            this.consumirToolStripMenuItem.Click += new System.EventHandler(this.consumirToolStripMenuItem_Click);
            // 
            // detalharComandaToolStripMenuItem
            // 
            this.detalharComandaToolStripMenuItem.Name = "detalharComandaToolStripMenuItem";
            this.detalharComandaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.detalharComandaToolStripMenuItem.Text = "Detalhar Comanda";
            this.detalharComandaToolStripMenuItem.Click += new System.EventHandler(this.detalharComandaToolStripMenuItem_Click);
            // 
            // cadastrarComandaToolStripMenuItem
            // 
            this.cadastrarComandaToolStripMenuItem.Name = "cadastrarComandaToolStripMenuItem";
            this.cadastrarComandaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cadastrarComandaToolStripMenuItem.Text = "Cadastrar Comanda";
            this.cadastrarComandaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarComandaToolStripMenuItem_Click);
            // 
            // historicoDeConsumoToolStripMenuItem
            // 
            this.historicoDeConsumoToolStripMenuItem.Name = "historicoDeConsumoToolStripMenuItem";
            this.historicoDeConsumoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.historicoDeConsumoToolStripMenuItem.Text = "Historico de Consumo";
            this.historicoDeConsumoToolStripMenuItem.Click += new System.EventHandler(this.historicoDeConsumoToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutosToolStripMenuItem,
            this.consultarProdutosToolStripMenuItem,
            this.listarProdutosToolStripMenuItem,
            this.pesquisarProdutosToolStripMenuItem,
            this.excluirProdutoToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            this.cadastrarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastrarProdutosToolStripMenuItem.Text = "Cadastrar Produtos";
            this.cadastrarProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutosToolStripMenuItem_Click);
            // 
            // consultarProdutosToolStripMenuItem
            // 
            this.consultarProdutosToolStripMenuItem.Name = "consultarProdutosToolStripMenuItem";
            this.consultarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.consultarProdutosToolStripMenuItem.Text = "Alterar Produtos";
            this.consultarProdutosToolStripMenuItem.Click += new System.EventHandler(this.consultarProdutosToolStripMenuItem_Click);
            // 
            // listarProdutosToolStripMenuItem
            // 
            this.listarProdutosToolStripMenuItem.Name = "listarProdutosToolStripMenuItem";
            this.listarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.listarProdutosToolStripMenuItem.Text = "Listar Produtos";
            this.listarProdutosToolStripMenuItem.Click += new System.EventHandler(this.listarProdutosToolStripMenuItem_Click);
            // 
            // pesquisarProdutosToolStripMenuItem
            // 
            this.pesquisarProdutosToolStripMenuItem.Name = "pesquisarProdutosToolStripMenuItem";
            this.pesquisarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pesquisarProdutosToolStripMenuItem.Text = "Pesquisar Produtos";
            this.pesquisarProdutosToolStripMenuItem.Click += new System.EventHandler(this.pesquisarProdutosToolStripMenuItem_Click);
            // 
            // excluirProdutoToolStripMenuItem
            // 
            this.excluirProdutoToolStripMenuItem.Name = "excluirProdutoToolStripMenuItem";
            this.excluirProdutoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.excluirProdutoToolStripMenuItem.Text = "Excluir Produto";
            this.excluirProdutoToolStripMenuItem.Click += new System.EventHandler(this.excluirProdutoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // tUSUARIOSBindingSource
            // 
            this.tUSUARIOSBindingSource.DataMember = "T_USUARIOS";
            this.tUSUARIOSBindingSource.DataSource = this.comanda_net_databaseDataSet;
            // 
            // comanda_net_databaseDataSet
            // 
            this.comanda_net_databaseDataSet.DataSetName = "Comanda_net_databaseDataSet";
            this.comanda_net_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_USUARIOSTableAdapter
            // 
            this.t_USUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // Inteface_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inteface_principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ComandaNet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tUSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarProdutosToolStripMenuItem;
        private Comanda_net_databaseDataSet comanda_net_databaseDataSet;
        private System.Windows.Forms.BindingSource tUSUARIOSBindingSource;
        private Comanda_net_databaseDataSetTableAdapters.T_USUARIOSTableAdapter t_USUARIOSTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem listarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalharComandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarComandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirProdutoToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoDeConsumoToolStripMenuItem;
    }
}

