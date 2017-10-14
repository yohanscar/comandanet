namespace Comanda_net
{
    partial class Abrir_Consumo
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
            this.label1 = new System.Windows.Forms.Label();
            this.comandanetdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comanda_net_databaseDataSet = new Comanda_net.Comanda_net_databaseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textRG = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tCOMANDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comanda_net_databaseDataSet1 = new Comanda_net.Comanda_net_databaseDataSet1();
            this.t_COMANDATableAdapter = new Comanda_net.Comanda_net_databaseDataSet1TableAdapters.T_COMANDATableAdapter();
            this.textCamandaNum = new System.Windows.Forms.TextBox();
            this.bt_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comandanetdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMANDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Comanda";
            // 
            // comandanetdatabaseDataSetBindingSource
            // 
            this.comandanetdatabaseDataSetBindingSource.DataSource = this.comanda_net_databaseDataSet;
            this.comandanetdatabaseDataSetBindingSource.Position = 0;
            // 
            // comanda_net_databaseDataSet
            // 
            this.comanda_net_databaseDataSet.DataSetName = "Comanda_net_databaseDataSet";
            this.comanda_net_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(132, 75);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(140, 20);
            this.textNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG";
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(132, 45);
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(140, 20);
            this.textRG.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tCOMANDABindingSource
            // 
            this.tCOMANDABindingSource.DataMember = "T_COMANDA";
            this.tCOMANDABindingSource.DataSource = this.comanda_net_databaseDataSet1;
            // 
            // comanda_net_databaseDataSet1
            // 
            this.comanda_net_databaseDataSet1.DataSetName = "Comanda_net_databaseDataSet1";
            this.comanda_net_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_COMANDATableAdapter
            // 
            this.t_COMANDATableAdapter.ClearBeforeFill = true;
            // 
            // textCamandaNum
            // 
            this.textCamandaNum.Location = new System.Drawing.Point(132, 17);
            this.textCamandaNum.Name = "textCamandaNum";
            this.textCamandaNum.Size = new System.Drawing.Size(140, 20);
            this.textCamandaNum.TabIndex = 1;
            // 
            // bt_Buscar
            // 
            this.bt_Buscar.Location = new System.Drawing.Point(278, 43);
            this.bt_Buscar.Name = "bt_Buscar";
            this.bt_Buscar.Size = new System.Drawing.Size(55, 23);
            this.bt_Buscar.TabIndex = 7;
            this.bt_Buscar.Text = "Buscar";
            this.bt_Buscar.UseVisualStyleBackColor = true;
            this.bt_Buscar.Click += new System.EventHandler(this.bt_Buscar_Click);
            // 
            // Abrir_Consumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 112);
            this.Controls.Add(this.bt_Buscar);
            this.Controls.Add(this.textCamandaNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Abrir_Consumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Consumo";
            this.Load += new System.EventHandler(this.Abrir_Consumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comandanetdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOMANDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comanda_net_databaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource comandanetdatabaseDataSetBindingSource;
        private Comanda_net_databaseDataSet comanda_net_databaseDataSet;
        private Comanda_net_databaseDataSet1 comanda_net_databaseDataSet1;
        private System.Windows.Forms.BindingSource tCOMANDABindingSource;
        private Comanda_net_databaseDataSet1TableAdapters.T_COMANDATableAdapter t_COMANDATableAdapter;
        private System.Windows.Forms.TextBox textCamandaNum;
        private System.Windows.Forms.Button bt_Buscar;
    }
}