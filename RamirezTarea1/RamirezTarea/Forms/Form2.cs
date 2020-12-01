using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamirezTarea.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            double r = RamirezTareaSerie.Serie.CalcularSerie(i, n);
            textBox3.Text = r.ToString();
        }
    }
}
