using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {
            //variables
            int numero = Convert.ToInt32(this.numero.Value);

            if (numero == 0)
            {
                this.resultado_parimpar.Text = "Nulo";
            }

            else if (numero % 2 == 0)
            {
                this.resultado_parimpar.Text = "Par";
            }

            else
            {
                this.resultado_parimpar.Text = "Impar";
            }
        }

        private void resultado_parimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
