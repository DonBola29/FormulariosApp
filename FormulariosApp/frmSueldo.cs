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
    public partial class frmSueldo : Form
    {
        public frmSueldo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //validaciones
            if(this.txtNombre.Text.Length == 0)
            {
               MessageBox.Show("Por favor debes ingresar el nombre...");
                this.txtNombre.Focus(); //ubica el cursor en un control
                return; //abandonar
            }

            //sumar los ingresos 
            double horasTrabjadas = double.Parse( this.txtHorasTrab.Text);
            double valorHora = double.Parse(this.txtValorHora.Text);
            double bono = double.Parse(this.txtBono.Text);
            double toting = horasTrabjadas * valorHora + bono;

            //mostrar el total de ingresos em el cuadro de texto
            this.txtTotalIng.Text = toting.ToString();

            //sumar egresos
            double asoTrab = double.Parse(this.txtAsoTrab.Text);
            double bar = double.Parse(this.txtBar.Text);
            double cuentaxPagar = double.Parse(this.txtCuentaxPagar.Text);
            double totEgre = asoTrab * bar + cuentaxPagar;

            //mostrar el total de egresos em el cuadro de texto
            this.txtTotalEgresos.Text = totEgre.ToString();

            //mostrar mensaje de liquido a recibir
           double LiquidoRecibir = totIng - totEgre;
            IblResultado.Text = "Estimado" + this.txtNombre.Text + ", tu sueldo es: " + LiquidoRecibir;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar el formlario actual
        }
    }
}


