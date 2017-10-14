namespace Comanda_net
{
    partial class Listar_Cliente
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
            this.cODCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATANASCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comanda_net_databaseCliente = new Comanda_net.Comanda_net_databaseCliente();
            this.t_CLIENTETableAdapter = new Comanda_net.Comanda_net_databaseClienteTableAdapters.T_CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseCliente)).BeginInit();
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
            this.cODCLIENTEDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.tELEFONEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.dATANASCIMENTODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tCLIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(762, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // cODCLIENTEDataGridViewTextBoxColumn
            // 
            this.cODCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "COD_CLIENTE";
            this.cODCLIENTEDataGridViewTextBoxColumn.HeaderText = "COD_CLIENTE";
            this.cODCLIENTEDataGridViewTextBoxColumn.Name = "cODCLIENTEDataGridViewTextBoxColumn";
            this.cODCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
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
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            this.uFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONEDataGridViewTextBoxColumn
            // 
            this.tELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.Name = "tELEFONEDataGridViewTextBoxColumn";
            this.tELEFONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATANASCIMENTODataGridViewTextBoxColumn
            // 
            this.dATANASCIMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_NASCIMENTO";
            this.dATANASCIMENTODataGridViewTextBoxColumn.HeaderText = "DATA_NASCIMENTO";
            this.dATANASCIMENTODataGridViewTextBoxColumn.Name = "dATANASCIMENTODataGridViewTextBoxColumn";
            this.dATANASCIMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCLIENTEBindingSource
            // 
            this.tCLIENTEBindingSource.DataMember = "T_CLIENTE";
            this.tCLIENTEBindingSource.DataSource = this.comanda_net_databaseCliente;
            // 
            // comanda_net_databaseCliente
            // 
            this.comanda_net_databaseCliente.DataSetName = "Comanda_net_databaseCliente";
            this.comanda_net_databaseCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_CLIENTETableAdapter
            // 
            this.t_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // Listar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 413);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Clientes";
            this.Load += new System.EventHandler(this.Listar_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Comanda_net_databaseCliente comanda_net_databaseCliente;
        private System.Windows.Forms.BindingSource tCLIENTEBindingSource;
        private Comanda_net_databaseClienteTableAdapters.T_CLIENTETableAdapter t_CLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATANASCIMENTODataGridViewTextBoxColumn;
    }
}