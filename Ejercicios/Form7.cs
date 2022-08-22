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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void sucesion_Click(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {
            int i, j = 0; float pi = 0; int n;

            n = Convert.ToInt32(this.numero.Value);

            for (i = 1; i <= n; i += 2)
            {
                if (i == 1 || j == 4)
                {
                    pi = pi + (4 / (float)i); j = 2;
                }

                else
                {
                    pi = pi - (4 / (float)i);
                    j = j + 2;
                }
            }
            this.resultado_numero.Text = pi.ToString();
        }
    }
}
