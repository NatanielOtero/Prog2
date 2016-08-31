using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteFacturacion
{
    public partial class Form1 : Form
    {
        private int Numero1;
        private int Numero2;
        private int Numero3;
        private int resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lvlNumero1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            
            Numero1 = int.Parse(this.txtBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            Numero2 = int.Parse(this.txtBox2.Text);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            resultado = Numero1 + Numero2 + Numero3;
            MessageBox.Show("El resultado es  " + resultado );
        }

        private void lvlNumero3_Click(object sender, EventArgs e)
        {

        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {
            Numero3 = int.Parse(this.txtBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float promedio;
            promedio = (Numero1+Numero2+Numero3)/3;
            MessageBox.Show("El promedio es " + promedio);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double Precio = (double)resultado + ((double)resultado * 0.21);
            MessageBox.Show("El precio es " + Precio);
        }
    }
}
