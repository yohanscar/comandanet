namespace Comanda_net
{
    partial class Listar_Produtos
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
            this.tPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comanda_net_databaseDataSet5 = new Comanda_net.Comanda_net_databaseDataSet5();
            this.tPRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comanda_net_databaseDataSet4 = new Comanda_net.Comanda_net_databaseDataSet4();
            this.t_PRODUTOSTableAdapter = new Comanda_net.Comanda_net_databaseDataSet4TableAdapters.T_PRODUTOSTableAdapter();
            this.t_PRODUTOTableAdapter = new Comanda_net.Comanda_net_databaseDataSet5TableAdapters.T_PRODUTOTableAdapter();
            this.cODPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLUNITARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTINCLUSAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTMANUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet4)).BeginInit();
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
            this.cODPRODUTODataGridViewTextBoxColumn,
            this.dESCPRODUTODataGridViewTextBoxColumn,
            this.vLUNITARIODataGridViewTextBoxColumn,
            this.dTINCLUSAODataGridViewTextBoxColumn,
            this.dTMANUTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tPRODUTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // tPRODUTOBindingSource
            // 
            this.tPRODUTOBindingSource.DataMember = "T_PRODUTO";
            this.tPRODUTOBindingSource.DataSource = this.comanda_net_databaseDataSet5;
            // 
            // comanda_net_databaseDataSet5
            // 
            this.comanda_net_databaseDataSet5.DataSetName = "Comanda_net_databaseDataSet5";
            this.comanda_net_databaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPRODUTOSBindingSource
            // 
            this.tPRODUTOSBindingSource.DataMember = "T_PRODUTOS";
            this.tPRODUTOSBindingSource.DataSource = this.comanda_net_databaseDataSet4;
            // 
            // comanda_net_databaseDataSet4
            // 
            this.comanda_net_databaseDataSet4.DataSetName = "Comanda_net_databaseDataSet4";
            this.comanda_net_databaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_PRODUTOSTableAdapter
            // 
            this.t_PRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // t_PRODUTOTableAdapter
            // 
            this.t_PRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // cODPRODUTODataGridViewTextBoxColumn
            // 
            this.cODPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.Name = "cODPRODUTODataGridViewTextBoxColumn";
            this.cODPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCPRODUTODataGridViewTextBoxColumn
            // 
            this.dESCPRODUTODataGridViewTextBoxColumn.DataPropertyName = "DESC_PRODUTO";
            this.dESCPRODUTODataGridViewTextBoxColumn.HeaderText = "DESC_PRODUTO";
            this.dESCPRODUTODataGridViewTextBoxColumn.Name = "dESCPRODUTODataGridViewTextBoxColumn";
            this.dESCPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCPRODUTODataGridViewTextBoxColumn.Width = 400;
            // 
            // vLUNITARIODataGridViewTextBoxColumn
            // 
            this.vLUNITARIODataGridViewTextBoxColumn.DataPropertyName = "VL_UNITARIO";
            this.vLUNITARIODataGridViewTextBoxColumn.HeaderText = "VL_UNITARIO";
            this.vLUNITARIODataGridViewTextBoxColumn.Name = "vLUNITARIODataGridViewTextBoxColumn";
            this.vLUNITARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTINCLUSAODataGridViewTextBoxColumn
            // 
            this.dTINCLUSAODataGridViewTextBoxColumn.DataPropertyName = "DT_INCLUSAO";
            this.dTINCLUSAODataGridViewTextBoxColumn.HeaderText = "DT_INCLUSAO";
            this.dTINCLUSAODataGridViewTextBoxColumn.Name = "dTINCLUSAODataGridViewTextBoxColumn";
            this.dTINCLUSAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTMANUTDataGridViewTextBoxColumn
            // 
            this.dTMANUTDataGridViewTextBoxColumn.DataPropertyName = "DT_MANUT";
            this.dTMANUTDataGridViewTextBoxColumn.HeaderText = "DT_MANUT";
            this.dTMANUTDataGridViewTextBoxColumn.Name = "dTMANUTDataGridViewTextBoxColumn";
            this.dTMANUTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Listar_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 515);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listar_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar_Produtos";
            this.Load += new System.EventHandler(this.Listar_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Comanda_net_databaseDataSet4 comanda_net_databaseDataSet4;
        private System.Windows.Forms.BindingSource tPRODUTOSBindingSource;
        private Comanda_net_databaseDataSet4TableAdapters.T_PRODUTOSTableAdapter t_PRODUTOSTableAdapter;
        private Comanda_net_databaseDataSet5 comanda_net_databaseDataSet5;
        private System.Windows.Forms.BindingSource tPRODUTOBindingSource;
        private Comanda_net_databaseDataSet5TableAdapters.T_PRODUTOTableAdapter t_PRODUTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vLUNITARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTINCLUSAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTMANUTDataGridViewTextBoxColumn;
    }
}