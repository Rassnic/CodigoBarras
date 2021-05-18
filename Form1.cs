using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETIQUETADO_ARTICULOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirEtiqueta();
        }


        public void ImprimirEtiqueta() {

            reportViewer verReporte = new reportViewer();
            verReporte.imprimirEtiquetaA(txtArticulo.Text);
            verReporte.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevo nuevo = new frmNuevo();
            this.Hide();
            nuevo.Show();
        }
    }
}
