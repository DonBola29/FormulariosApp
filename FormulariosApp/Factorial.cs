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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num, i;
            double result = 1;

            num = int.Parse(txtNumero.Text);
            for (i = 2; i <= num; i++)
            {
                result = result * i;
            }

            lblrespuesta.Text = "El factorial del numero es :  " + result;
        }

        private void Factorial_Load(object sender, EventArgs e)
        {

        }
    }
}
