using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosApp
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            //abrir el formulario que calcula sueldo 
            frmSueldo frm1 = new frmSueldo();
            frm1.Show(); //mostrar el formulario
        }

        private void btnNumEnBinario_Click(object sender, EventArgs e)
        {
            //ABRIR EL FORMULARIO DE CALCULAR SUELDO
            frmBinario frm1 = new frmBinario();
            frm1.ShowDialog();//MOSTRAR EL FORMULARIO
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
