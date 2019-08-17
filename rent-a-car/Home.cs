using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentAcar
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //this.Exit();
        }

        private void button_AdaugaMeniu_Click(object sender, EventArgs e)
        {
            adauga_masina formAdauga = new adauga_masina();
            formAdauga.Show();
        }

        private void button_lista_Click(object sender, EventArgs e)
        {
            lista_masini formLista = new lista_masini();
            formLista.Show();
        }

        private void button_Modifica_Click(object sender, EventArgs e)
        {
            Modifica formModifica = new Modifica();
            formModifica.Show();
        }
    }
}
