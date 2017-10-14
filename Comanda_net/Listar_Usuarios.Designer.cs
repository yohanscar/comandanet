namespace Comanda_net
{
    partial class Listar_Usuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDUSUARIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFILGERENCIADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFILRECEPCAODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFILBARMANDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFILCAIXADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comanda_net_databaseUsuarios = new Comanda_net.Comanda_net_databaseUsuarios();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerfilGerencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recepcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerfilRecepcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerfilCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFILGERENCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFILRECEPCAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFILBARMANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFILCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listar_UsuariosToolStrip = new System.Windows.Forms.ToolStrip();
            this.listar_UsuariosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.t_USUARIOTableAdapter = new Comanda_net.Comanda_net_databaseUsuariosTableAdapters.T_USUARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseUsuarios)).BeginInit();
            this.listar_UsuariosToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUSUARIODataGridViewTextBoxColumn1,
            this.nOMEDataGridViewTextBoxColumn1,
            this.rGDataGridViewTextBoxColumn1,
            this.eMAILDataGridViewTextBoxColumn1,
            this.tELEFONEDataGridViewTextBoxColumn1,
            this.pERFILGERENCIADataGridViewTextBoxColumn1,
            this.pERFILRECEPCAODataGridViewTextBoxColumn1,
            this.pERFILBARMANDataGridViewTextBoxColumn1,
            this.pERFILCAIXADataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.tUSUARIOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(943, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDUSUARIODataGridViewTextBoxColumn1
            // 
            this.iDUSUARIODataGridViewTextBoxColumn1.DataPropertyName = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn1.HeaderText = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn1.Name = "iDUSUARIODataGridViewTextBoxColumn1";
            this.iDUSUARIODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn1
            // 
            this.nOMEDataGridViewTextBoxColumn1.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn1.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn1.Name = "nOMEDataGridViewTextBoxColumn1";
            this.nOMEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rGDataGridViewTextBoxColumn1
            // 
            this.rGDataGridViewTextBoxColumn1.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn1.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn1.Name = "rGDataGridViewTextBoxColumn1";
            this.rGDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn1
            // 
            this.eMAILDataGridViewTextBoxColumn1.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn1.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn1.Name = "eMAILDataGridViewTextBoxColumn1";
            this.eMAILDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tELEFONEDataGridViewTextBoxColumn1
            // 
            this.tELEFONEDataGridViewTextBoxColumn1.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn1.HeaderText = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn1.Name = "tELEFONEDataGridViewTextBoxColumn1";
            this.tELEFONEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pERFILGERENCIADataGridViewTextBoxColumn1
            // 
            this.pERFILGERENCIADataGridViewTextBoxColumn1.DataPropertyName = "PERFIL_GERENCIA";
            this.pERFILGERENCIADataGridViewTextBoxColumn1.HeaderText = "PERFIL_GERENCIA";
            this.pERFILGERENCIADataGridViewTextBoxColumn1.Name = "pERFILGERENCIADataGridViewTextBoxColumn1";
            this.pERFILGERENCIADataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pERFILRECEPCAODataGridViewTextBoxColumn1
            // 
            this.pERFILRECEPCAODataGridViewTextBoxColumn1.DataPropertyName = "PERFIL_RECEPCAO";
            this.pERFILRECEPCAODataGridViewTextBoxColumn1.HeaderText = "PERFIL_RECEPCAO";
            this.pERFILRECEPCAODataGridViewTextBoxColumn1.Name = "pERFILRECEPCAODataGridViewTextBoxColumn1";
            this.pERFILRECEPCAODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pERFILBARMANDataGridViewTextBoxColumn1
            // 
            this.pERFILBARMANDataGridViewTextBoxColumn1.DataPropertyName = "PERFIL_BARMAN";
            this.pERFILBARMANDataGridViewTextBoxColumn1.HeaderText = "PERFIL_BARMAN";
            this.pERFILBARMANDataGridViewTextBoxColumn1.Name = "pERFILBARMANDataGridViewTextBoxColumn1";
            this.pERFILBARMANDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pERFILCAIXADataGridViewTextBoxColumn1
            // 
            this.pERFILCAIXADataGridViewTextBoxColumn1.DataPropertyName = "PERFIL_CAIXA";
            this.pERFILCAIXADataGridViewTextBoxColumn1.HeaderText = "PERFIL_CAIXA";
            this.pERFILCAIXADataGridViewTextBoxColumn1.Name = "pERFILCAIXADataGridViewTextBoxColumn1";
            this.pERFILCAIXADataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tUSUARIOBindingSource
            // 
            this.tUSUARIOBindingSource.DataMember = "T_USUARIO";
            this.tUSUARIOBindingSource.DataSource = this.comanda_net_databaseUsuarios;
            // 
            // comanda_net_databaseUsuarios
            // 
            this.comanda_net_databaseUsuarios.DataSetName = "Comanda_net_databaseUsuarios";
            this.comanda_net_databaseUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdUsuario
            // 
            this.IdUsuario.Frozen = true;
            this.IdUsuario.HeaderText = "ID Usuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.Frozen = true;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // RG
            // 
            this.RG.Frozen = true;
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.Frozen = true;
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Telefone
            // 
            this.Telefone.Frozen = true;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 70;
            // 
            // PerfilGerencia
            // 
            this.PerfilGerencia.Frozen = true;
            this.PerfilGerencia.HeaderText = "Gerencia";
            this.PerfilGerencia.Name = "PerfilGerencia";
            this.PerfilGerencia.ReadOnly = true;
            this.PerfilGerencia.Width = 65;
            // 
            // Recepcao
            // 
            this.Recepcao.Frozen = true;
            this.Recepcao.HeaderText = "Recepcão";
            this.Recepcao.Name = "Recepcao";
            this.Recepcao.ReadOnly = true;
            this.Recepcao.Width = 65;
            // 
            // PerfilRecepcao
            // 
            this.PerfilRecepcao.Frozen = true;
            this.PerfilRecepcao.HeaderText = "Barman";
            this.PerfilRecepcao.Name = "PerfilRecepcao";
            this.PerfilRecepcao.ReadOnly = true;
            this.PerfilRecepcao.Width = 65;
            // 
            // PerfilCaixa
            // 
            this.PerfilCaixa.Frozen = true;
            this.PerfilCaixa.HeaderText = "Caixa";
            this.PerfilCaixa.Name = "PerfilCaixa";
            this.PerfilCaixa.ReadOnly = true;
            this.PerfilCaixa.Width = 65;
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            this.iDUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONEDataGridViewTextBoxColumn
            // 
            this.tELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.Name = "tELEFONEDataGridViewTextBoxColumn";
            this.tELEFONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pERFILGERENCIADataGridViewTextBoxColumn
            // 
            this.pERFILGERENCIADataGridViewTextBoxColumn.DataPropertyName = "PERFIL_GERENCIA";
            this.pERFILGERENCIADataGridViewTextBoxColumn.HeaderText = "PERFIL_GERENCIA";
            this.pERFILGERENCIADataGridViewTextBoxColumn.Name = "pERFILGERENCIADataGridViewTextBoxColumn";
            this.pERFILGERENCIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pERFILRECEPCAODataGridViewTextBoxColumn
            // 
            this.pERFILRECEPCAODataGridViewTextBoxColumn.DataPropertyName = "PERFIL_RECEPCAO";
            this.pERFILRECEPCAODataGridViewTextBoxColumn.HeaderText = "PERFIL_RECEPCAO";
            this.pERFILRECEPCAODataGridViewTextBoxColumn.Name = "pERFILRECEPCAODataGridViewTextBoxColumn";
            this.pERFILRECEPCAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pERFILBARMANDataGridViewTextBoxColumn
            // 
            this.pERFILBARMANDataGridViewTextBoxColumn.DataPropertyName = "PERFIL_BARMAN";
            this.pERFILBARMANDataGridViewTextBoxColumn.HeaderText = "PERFIL_BARMAN";
            this.pERFILBARMANDataGridViewTextBoxColumn.Name = "pERFILBARMANDataGridViewTextBoxColumn";
            this.pERFILBARMANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pERFILCAIXADataGridViewTextBoxColumn
            // 
            this.pERFILCAIXADataGridViewTextBoxColumn.DataPropertyName = "PERFIL_CAIXA";
            this.pERFILCAIXADataGridViewTextBoxColumn.HeaderText = "PERFIL_CAIXA";
            this.pERFILCAIXADataGridViewTextBoxColumn.Name = "pERFILCAIXADataGridViewTextBoxColumn";
            this.pERFILCAIXADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listar_UsuariosToolStrip
            // 
            this.listar_UsuariosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listar_UsuariosToolStripButton});
            this.listar_UsuariosToolStrip.Location = new System.Drawing.Point(0, 0);
            this.listar_UsuariosToolStrip.Name = "listar_UsuariosToolStrip";
            this.listar_UsuariosToolStrip.Size = new System.Drawing.Size(964, 25);
            this.listar_UsuariosToolStrip.TabIndex = 1;
            this.listar_UsuariosToolStrip.Text = "listar_UsuariosToolStrip";
            this.listar_UsuariosToolStrip.Visible = false;
            // 
            // listar_UsuariosToolStripButton
            // 
            this.listar_UsuariosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.listar_UsuariosToolStripButton.Name = "listar_UsuariosToolStripButton";
            this.listar_UsuariosToolStripButton.Size = new System.Drawing.Size(89, 22);
            this.listar_UsuariosToolStripButton.Text = "Listar_Usuarios";
            this.listar_UsuariosToolStripButton.Visible = false;
            this.listar_UsuariosToolStripButton.Click += new System.EventHandler(this.listar_UsuariosToolStripButton_Click);
            // 
            // t_USUARIOTableAdapter
            // 
            this.t_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // Listar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 422);
            this.Controls.Add(this.listar_UsuariosToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listar_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Usuarios";
            this.Load += new System.EventHandler(this.Listar_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseUsuarios)).EndInit();
            this.listar_UsuariosToolStrip.ResumeLayout(false);
            this.listar_UsuariosToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerfilGerencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recepcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerfilRecepcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerfilCaixa;
        private Comanda_net_databaseUsuarios comanda_net_databaseUsuarios;
        private System.Windows.Forms.BindingSource tUSUARIOBindingSource;
        private Comanda_net_databaseUsuariosTableAdapters.T_USUARIOTableAdapter t_USUARIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFILGERENCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFILRECEPCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFILBARMANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFILCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip listar_UsuariosToolStrip;
        private System.Windows.Forms.ToolStripButton listar_UsuariosToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFILGERENCIADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFILRECEPCAODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFILBARMANDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFILCAIXADataGridViewTextBoxColumn1;
    }
}