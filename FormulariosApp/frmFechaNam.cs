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
    public partial class frmFechaNam : Form
    {
        public frmFechaNam()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
       
        }

        private void lbFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int edadAnios = DateTime.Today.Year - dtpFecha.Value.Year;
            txtEdadAn.Text = Convert.ToString(edadAnios + " años de edad");

            int edadDias = (DateTime.Today.Year - dtpFecha.Value.Year) * 365;
            edadDias += (DateTime.Today.Month - dtpFecha.Value.Month) * 30;
            edadDias += 1;
            edadDias += DateTime.Today.Day - dtpFecha.Value.Day;
            txtEdadDias.Text = Convert.ToString(edadDias + " días de edad");
        }
    }
}
