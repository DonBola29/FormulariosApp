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
    public partial class Multiplicar : Form
    {
        public Multiplicar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int tabla = int.Parse(txtNumero.Text);
            int resultado;

            for (int i = 1; i <= 10; i++)
            {
                resultado = tabla * i;
                listBox1.Items.Add(tabla + " x " + i + "=" + resultado);
            }
        }
    }
}
