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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            //variables
            float productoPrecio = Convert.ToSingle(this.productoPrecio.Value);
            float productoCantidad = Convert.ToSingle(this.productoCantidad.Value);
            float productoPagar = 0;

            productoPagar = productoPrecio * productoCantidad;

            this.productoPagar.Text = productoPagar.ToString();


        }

        private void ejerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
