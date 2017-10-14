using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComandaNetLibs;

namespace Comanda_net
{
    
    

    public partial class Inteface_principal : Form
    {        
        login                  tela_login;
        Cadastrar_Usuario      tela_cadastro_user;
        Detalhar_Comanda       telaDetalharComanda;
        Cadastra_cliente       telaCadastraCliente;
        Adicionar_Produto_base telaAdicinarProduto;
        Cadastrar_Usuario      telaCadastrarUsuario;
        Listar_Cliente         telaListarCliente;
        Alterar_Senha          telaAlterarSenha;
        Listar_Usuarios        telaListarUsuarios;
        Abrir_Consumo          telaAbrirConsumo;
        Cadastrar_Comanda      telaCadastrarComanda;
        About                  telaSobre;
        Listar_Produtos        telaListarProdutos;
        Alterar_Usuario        telaAlterarUsuario;
        Alterar_Cliente        telaAlterarCliente;
        Alterar_Produtos       telaAlterarProdutos;
        Excluir_Produto        telaExcluirProduto;
        Pesquisar_Produtos     telaPesquisarProduto;
        Excluir_Cliente        telaExcluirCliente;
        Pesquisar_Cliente      telaPesquisarCliente;
        Pesquisa_Historico     telaPesquisarHistorico;



        public Inteface_principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comanda_net_databaseDataSet.T_USUARIOS' table. You can move, or remove it, as needed.
            this.t_USUARIOSTableAdapter.Fill(this.comanda_net_databaseDataSet.T_USUARIOS);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tela_login == null)
              {
                  tela_login = new login();
                  tela_login.MdiParent = this;
                  tela_login.Show();
                  tela_login.Disposed += new EventHandler(tela_login_Disposed);
               }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            tela_cadastro_user = new Cadastrar_Usuario();
            tela_cadastro_user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (telaCadastraCliente == null)
            {
                telaCadastraCliente = new Cadastra_cliente();
                telaCadastraCliente.Show();
                telaCadastraCliente.MdiParent = this;
                telaCadastraCliente.Disposed += new EventHandler(telaCadastraCliente_Disposed);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (telaDetalharComanda == null)
            {
                telaDetalharComanda = new Detalhar_Comanda();
                telaDetalharComanda.Show();
                telaDetalharComanda.MdiParent = this;
                telaDetalharComanda.Disposed += new EventHandler(telaDetalharComanda_Disposed);
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (telaAdicinarProduto == null)
            {
                telaAdicinarProduto = new Adicionar_Produto_base();
                telaAdicinarProduto.Show();
                telaAdicinarProduto.MdiParent = this;
                telaAdicinarProduto.Disposed += new EventHandler(telaAdicionarProduto_Disposed);

            }
        }



        void tela_login_Disposed(object sender, EventArgs e)
        {
            tela_login = null;
        }

        void telaDetalharComanda_Disposed(object sender, EventArgs e)
        {
            telaDetalharComanda = null;
        }

        void telaCadastraCliente_Disposed(object sender, EventArgs e)
        {
            telaCadastraCliente = null;
        }

        void telaAdicionarProduto_Disposed(object sender, EventArgs e)
        {
            telaAdicinarProduto = null;
        }

        void telaCadastrarUsuario_Disposed(object sender, EventArgs e)
        {
            telaCadastrarUsuario = null;
        }

        void telaListarCliente_Disposed(object sender, EventArgs e)
        {
            telaListarCliente = null;
        }

        void telaAlterarSenha_Disposed(object sender, EventArgs e)
        {
            telaAlterarSenha = null;
        }

        void telaListarUsuarios_Disposed(object sender, EventArgs e)
        {
            telaListarUsuarios = null;
        }

        void telaAbrirConsumo_Disposed(object sender, EventArgs e)
        {
            telaAbrirConsumo = null;
        }

        void telaCadastrarComanda_Disposed(object sender, EventArgs e)
        {
            telaCadastrarComanda = null;
        }

        void telaSobre_Disposed(object sender, EventArgs e)
        {
            telaSobre = null;
        }

        void telaListarProdutos_Disposed(object sender, EventArgs e)
        {
            telaListarProdutos = null;
        }

        void telaAlterarCliente_Disposed(object sender, EventArgs e)
        {
            telaAlterarCliente = null;
        }

        void telaAlterarUsuario_Disposed(object sender, EventArgs e)
        {
            telaAlterarUsuario = null;
        }

        void telaAlterarProdutos_Disposed(object sender, EventArgs e)
        {
            telaAlterarProdutos = null;
        }

        void telaExcluirProduto_Disposed(object sender, EventArgs e)
        {
            telaExcluirProduto = null;
        }

        void telaPesquisarProduto_Disposed(object sender, EventArgs e)
        {
            telaPesquisarProduto = null;
        }

        void telaExcluirCliente_Disposed(object sender, EventArgs e)
        {
            telaExcluirCliente = null;
        }

        void telaPesquisarCliente_Disposed(object sender, EventArgs e)
        {
            telaPesquisarCliente = null;
        }

        void telaPesquisarHistorico_Disposed(object sender, EventArgs e)
        {
            telaPesquisarHistorico = null;
        }


        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaCadastraCliente == null)
            {
                telaCadastraCliente = new Cadastra_cliente();
                telaCadastraCliente.Show();
                telaCadastraCliente.MdiParent = this;
                telaCadastraCliente.Disposed += new EventHandler(telaCadastraCliente_Disposed);
            }

        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaCadastrarUsuario == null)
            {
                telaCadastrarUsuario = new Cadastrar_Usuario();
                telaCadastrarUsuario.Show();
                telaCadastrarUsuario.MdiParent = this;
                telaCadastrarUsuario.Disposed += new EventHandler(telaCadastrarUsuario_Disposed);
            }

        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaAdicinarProduto == null)
            {
                telaAdicinarProduto = new Adicionar_Produto_base();
                telaAdicinarProduto.Show();
                telaAdicinarProduto.MdiParent = this;
                telaAdicinarProduto.Disposed += new EventHandler(telaAdicionarProduto_Disposed);

            }
        }

        private void listarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaListarCliente == null)
            {
                telaListarCliente = new Listar_Cliente();
                telaListarCliente.Show();
                telaListarCliente.MdiParent = this;
                telaListarCliente.Disposed += new EventHandler(telaListarCliente_Disposed);
            }
        }

        private void listarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {               // ALTERAR SENHA
            if (telaAlterarSenha == null)
            {
                telaAlterarSenha = new Alterar_Senha();
                telaAlterarSenha.Show();
                telaAlterarSenha.MdiParent = this;
                telaAlterarSenha.Disposed += new EventHandler(telaAlterarSenha_Disposed);
            }
        }

        private void listarUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {              // LISTAR USUARIOS
            if (telaListarUsuarios == null)
            {
                telaListarUsuarios = new Listar_Usuarios();
                telaListarUsuarios.Show();
                telaListarUsuarios.MdiParent = this;
                telaListarUsuarios.Disposed += new EventHandler(telaListarUsuarios_Disposed);
            }
        }

        private void consumirToolStripMenuItem_Click(object sender, EventArgs e)
        {   // abrir consumo

            if (telaListarUsuarios == null)
            {
                telaAbrirConsumo = new Abrir_Consumo();
                telaAbrirConsumo.Show();
                telaAbrirConsumo.MdiParent = this;
                telaAbrirConsumo.Disposed += new EventHandler(telaAbrirConsumo_Disposed);
            }
        }

        private void cadastrarComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaCadastrarComanda == null)
            {
                telaCadastrarComanda = new Cadastrar_Comanda();
                telaCadastrarComanda.Show();
                telaCadastrarComanda.MdiParent = this;
                telaCadastrarComanda.Disposed += new EventHandler(telaAbrirConsumo_Disposed);
            }

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaSobre == null)
            {
                telaSobre = new About();
                telaSobre.Show();
                telaSobre.MdiParent = this;
                telaSobre.Disposed += new EventHandler(telaSobre_Disposed);
            }

        }

        private void listarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaListarProdutos == null)
            {
                telaListarProdutos = new Listar_Produtos();
                telaListarProdutos.Show();
                telaListarProdutos.MdiParent = this;
                telaListarProdutos.Disposed += new EventHandler(telaListarProdutos_Disposed);
            }
        }

        private void alterarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaAlterarUsuario == null)
            {
                telaAlterarUsuario = new Alterar_Usuario();
                telaAlterarUsuario.Show();
                telaAlterarUsuario.MdiParent = this;
                telaAlterarUsuario.Disposed += new EventHandler(telaAlterarUsuario_Disposed);
            }
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {    // ALTERAR CLIENTE

            if (telaAlterarCliente == null)
            {
                telaAlterarCliente = new Alterar_Cliente();
                telaAlterarCliente.Show();
                telaAlterarCliente.MdiParent = this;
                telaAlterarCliente.Disposed += new EventHandler(telaAlterarCliente_Disposed);
            }
        }

        private void detalharComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaDetalharComanda == null)
            {
                telaDetalharComanda = new Detalhar_Comanda();
                telaDetalharComanda.Show();
                telaDetalharComanda.MdiParent = this;
                telaDetalharComanda.Disposed += new EventHandler(telaDetalharComanda_Disposed);
            }
        }

        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {   // ALTERAR PRODUTOS
            if (telaAlterarProdutos == null)
            {
                telaAlterarProdutos = new Alterar_Produtos();
                telaAlterarProdutos.Show();
                telaAlterarProdutos.MdiParent = this;
                telaAlterarProdutos.Disposed += new EventHandler(telaAlterarProdutos_Disposed);
            }
        }

        private void excluirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaExcluirProduto == null)
            {
                telaExcluirProduto = new Excluir_Produto();
                telaExcluirProduto.Show();
                telaExcluirProduto.MdiParent = this;
                telaExcluirProduto.Disposed += new EventHandler(telaExcluirProduto_Disposed);
            }
        }

        private void pesquisarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaPesquisarProduto == null)
            {
                telaPesquisarProduto = new Pesquisar_Produtos();
                telaPesquisarProduto.Show();
                telaPesquisarProduto.MdiParent = this;
                telaPesquisarProduto.Disposed += new EventHandler(telaPesquisarProduto_Disposed);
            }

        }

        private void excluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaExcluirCliente == null)
            {
                telaExcluirCliente = new Excluir_Cliente();
                telaExcluirCliente.Show();
                telaExcluirCliente.MdiParent = this;
                telaExcluirCliente.Disposed += new EventHandler(telaExcluirCliente_Disposed);
            }
        }

        private void pesquisarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaPesquisarCliente == null)
            {
                telaPesquisarCliente = new Pesquisar_Cliente();
                telaPesquisarCliente.Show();
                telaPesquisarCliente.MdiParent = this;
                telaPesquisarCliente.Disposed += new EventHandler(telaPesquisarCliente_Disposed);
            }
        }



        
        private void consultarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {  //LOGOUT








        }

        private void button6_Click(object sender, EventArgs e)
        { //abrir consumo
            if (telaListarUsuarios == null)
            {
                telaAbrirConsumo = new Abrir_Consumo();
                telaAbrirConsumo.Show();
                telaAbrirConsumo.MdiParent = this;
                telaAbrirConsumo.Disposed += new EventHandler(telaAbrirConsumo_Disposed);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        { //login
            if (tela_login == null)
            {
                tela_login = new login();
                tela_login.MdiParent = this;
                tela_login.Show();
                tela_login.Disposed += new EventHandler(tela_login_Disposed);
            }
        }

        
        private void historicoDeConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (telaPesquisarHistorico == null)
            {
                telaPesquisarHistorico = new Pesquisa_Historico();
                telaPesquisarHistorico.MdiParent = this;
                telaPesquisarHistorico.Show();
                telaPesquisarHistorico.Disposed += new EventHandler(telaPesquisarHistorico_Disposed);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // BOTAO LOG OUT

            MessageBox.Show("LOGOUT EFETUADO COM SUCESSO!");

            if (telaSobre == null)
            {
                telaSobre = new About();
                telaSobre.Show();
                telaSobre.MdiParent = this;
                telaSobre.Disposed += new EventHandler(telaSobre_Disposed);
            }


        }

    }
}
