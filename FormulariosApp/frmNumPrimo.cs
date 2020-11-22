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
    public partial class frmNumPrimo : Form
    {
        public frmNumPrimo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar el valor de sus horas");
                this.txtNumero.Focus();
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            if (this.txtNumero.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar un numero");
                this.txtNumero.Focus();
                return;
            }
            int numero = int.Parse(this.txtNumero.Text);
            if (this.txtNumero.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar un numero");
                this.txtNumero.Focus();
                return;
            }
            int Numero = int.Parse(this.txtNumero.Text);
            comprobacion(numero);
            return;
        }
        void comprobacion(int numero)
        {
            int a = 0;
            for (int i = 1; i <= numero; i++)
            {
                if ((numero % i) == 0)
                    a = a + 1;
            }
            if (a > 2)
                this.lbresultado.Text = "El numero no es Primo";
            else
                this.lbresultado.Text = "El numero es Primo";
        }
    }
}
