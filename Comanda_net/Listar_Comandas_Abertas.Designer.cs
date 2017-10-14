namespace Comanda_net
{
    partial class Listar_Comandas_Abertas
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandanetdatabaseDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comanda_net_databaseDataSet2 = new Comanda_net.Comanda_net_databaseDataSet2();
            this.tCOMANDABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comandanetdatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tCOMANDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_COMANDATableAdapter = new Comanda_net.Comanda_net_databaseDataSet2TableAdapters.T_COMANDATableAdapter();
            this.tCOMANDABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandanetdatabaseDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMANDABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandanetdatabaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMANDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMANDABindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.DataSource = this.comandanetdatabaseDataSet2BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(564, 294);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Comanda";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Abertura";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fechamento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // comandanetdatabaseDataSet2BindingSource1
            // 
            this.comandanetdatabaseDataSet2BindingSource1.DataSource = this.comanda_net_databaseDataSet2;
            this.comandanetdatabaseDataSet2BindingSource1.Position = 0;
            // 
            // comanda_net_databaseDataSet2
            // 
            this.comanda_net_databaseDataSet2.DataSetName = "Comanda_net_databaseDataSet2";
            this.comanda_net_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCOMANDABindingSource1
            // 
            this.tCOMANDABindingSource1.DataMember = "T_COMANDA";
            this.tCOMANDABindingSource1.DataSource = this.comandanetdatabaseDataSet2BindingSource;
            // 
            // comandanetdatabaseDataSet2BindingSource
            // 
            this.comandanetdatabaseDataSet2BindingSource.DataSource = this.comanda_net_databaseDataSet2;
            this.comandanetdatabaseDataSet2BindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tCOMANDABindingSource
            // 
            this.tCOMANDABindingSource.DataMember = "T_COMANDA";
            this.tCOMANDABindingSource.DataSource = this.comandanetdatabaseDataSet2BindingSource;
            // 
            // t_COMANDATableAdapter
            // 
            this.t_COMANDATableAdapter.ClearBeforeFill = true;
            // 
            // tCOMANDABindingSource2
            // 
            this.tCOMANDABindingSource2.DataMember = "T_COMANDA";
            this.tCOMANDABindingSource2.DataSource = this.comandanetdatabaseDataSet2BindingSource;
            // 
            // Listar_Comandas_Abertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Listar_Comandas_Abertas";
            this.Text = "jm";
            this.Load += new System.EventHandler(this.Listar_Comandas_Abertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandanetdatabaseDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMANDABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandanetdatabaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMANDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMANDABindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource comandanetdatabaseDataSet2BindingSource;
        private Comanda_net_databaseDataSet2 comanda_net_databaseDataSet2;
        private System.Windows.Forms.BindingSource tCOMANDABindingSource;
        private Comanda_net_databaseDataSet2TableAdapters.T_COMANDATableAdapter t_COMANDATableAdapter;
        private System.Windows.Forms.BindingSource comandanetdatabaseDataSet2BindingSource1;
        private System.Windows.Forms.BindingSource tCOMANDABindingSource1;
        private System.Windows.Forms.BindingSource tCOMANDABindingSource2;
    }
}