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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            int b=0, num=0, j=0;
            string divisores = "";

            //los numeros que se analizaran son del 1 al 1000
            num = 1000;

            for (int i = 1; i <= num; i++)
            {
                b = 0;

                for (j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        b += j;
                        divisores += " " + j + " ";
                    }
                }
                if (b == i)
                    this.resultado_numerosperfectos.Text=  i + ", divisores: " + divisores;
                divisores = "";
            }
        }
    }
}
