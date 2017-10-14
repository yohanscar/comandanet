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
    public partial class Selecionar_Comanda : Form
    {
      //  Detalhar_Comanda instancia;

        public Selecionar_Comanda(NL_Comanda parm)
        {
            InitializeComponent();

        }

        public void Selecionar_Comandas(NL_Comanda parm)
        {
            InitializeComponent();
           // textBox1.Text = Convert.ToString(parm.NumeroComanda);            
        }

        public String getText()
        {
           return textBox1.Text;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
