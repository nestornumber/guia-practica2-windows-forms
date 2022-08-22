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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void ejerciciodescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {
            //variables
            int numero1 = Convert.ToInt32(this.numero1.Value);
            int numero2 = Convert.ToInt32(this.numero2.Value);
            int numero3 = Convert.ToInt32(this.numero3.Value);

            //calculos
            if (numero1 > numero2)
            {
                if (numero1 > numero3)
                {
                    this.resultado_mayormenor.Text = "El mayor numero es el " + numero1;
                }
            }

            else
            {
                if (numero2 > numero3)
                {
                    this.resultado_mayormenor.Text = "El mayor numero es el " + numero2;
                }

                else
                {
                    this.resultado_mayormenor.Text = "El mayor numero es el " +numero3;
                }
            }
        }

        private void resultado_mayormenor_Click(object sender, EventArgs e)
        {

        }
    }
}
