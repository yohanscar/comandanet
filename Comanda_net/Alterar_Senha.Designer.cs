namespace Comanda_net
{
    partial class Alterar_Senha
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenhaAtual = new System.Windows.Forms.TextBox();
            this.textNovaSenha = new System.Windows.Forms.TextBox();
            this.textConfirmeNova = new System.Windows.Forms.TextBox();
            this.BtConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha Atual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nova Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirme Nova";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(105, 13);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(100, 20);
            this.textUsuario.TabIndex = 4;
            // 
            // textSenhaAtual
            // 
            this.textSenhaAtual.Location = new System.Drawing.Point(105, 37);
            this.textSenhaAtual.Name = "textSenhaAtual";
            this.textSenhaAtual.Size = new System.Drawing.Size(100, 20);
            this.textSenhaAtual.TabIndex = 5;
            this.textSenhaAtual.UseSystemPasswordChar = true;
            // 
            // textNovaSenha
            // 
            this.textNovaSenha.Location = new System.Drawing.Point(105, 63);
            this.textNovaSenha.Name = "textNovaSenha";
            this.textNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.textNovaSenha.TabIndex = 6;
            this.textNovaSenha.UseSystemPasswordChar = true;
            // 
            // textConfirmeNova
            // 
            this.textConfirmeNova.Location = new System.Drawing.Point(105, 89);
            this.textConfirmeNova.Name = "textConfirmeNova";
            this.textConfirmeNova.Size = new System.Drawing.Size(100, 20);
            this.textConfirmeNova.TabIndex = 7;
            this.textConfirmeNova.UseSystemPasswordChar = true;
            // 
            // BtConfirmar
            // 
            this.BtConfirmar.Location = new System.Drawing.Point(105, 115);
            this.BtConfirmar.Name = "BtConfirmar";
            this.BtConfirmar.Size = new System.Drawing.Size(100, 41);
            this.BtConfirmar.TabIndex = 8;
            this.BtConfirmar.Text = "Confirmar";
            this.BtConfirmar.UseVisualStyleBackColor = true;
            this.BtConfirmar.Click += new System.EventHandler(this.BtConfirmar_Click);
            // 
            // Alterar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 170);
            this.Controls.Add(this.BtConfirmar);
            this.Controls.Add(this.textConfirmeNova);
            this.Controls.Add(this.textNovaSenha);
            this.Controls.Add(this.textSenhaAtual);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alterar_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenhaAtual;
        private System.Windows.Forms.TextBox textNovaSenha;
        private System.Windows.Forms.TextBox textConfirmeNova;
        private System.Windows.Forms.Button BtConfirmar;
    }
}