using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int precio2 = int.Parse(precio.Text);

            precio2 = precio2 * 19 / 100;

            int total2 = precio2;

            total.Text = total2.ToString();

            int precio3 = int.Parse(precio.Text);
            precio3 = precio3 + precio2;

            preciototal.Text = precio3.ToString();
        }
    }
}
