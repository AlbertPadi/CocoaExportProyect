using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocoaExport.Extras
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void Ayudabutton_Click(object sender, EventArgs e)
        {
            
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para el uso del sistema es recomendable\ncrear una cuenta o comunicarse con un administrador\no el creador de este. De esta manera podra darle uso \na este");
        }

        private void orientacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa esta orientado y exclusivamente\nprogramado prara la exportacion de cacao\nde otro modo habra que hacer actualizaciones\npara acomodar este a mas operaciones");
        }
    }
}
