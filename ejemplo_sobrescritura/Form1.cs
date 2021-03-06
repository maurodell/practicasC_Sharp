using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ejemplo_sobrescritura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuadrado _c = new Cuadrado(int.Parse(Interaction.InputBox("Ingrese un número: ")));
            MessageBox.Show("El resultado es: " + _c.Area()) ;
        }

        abstract class Forma
        {
            abstract public int Area();
        }
        class Cuadrado : Forma
        {
            int lado = 0;
            public Cuadrado(int n) { lado = n; }

            public override int Area()
            {
                return lado * lado;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Impuesto imp = new ImpuestoComun();
            Impuesto impEspecial = new ImpuestoEspecial();

            imp.Importe = decimal.Parse(Interaction.InputBox("Ingrese el importe: "));
            MessageBox.Show("TOTAL A PAGAR\n"+
                            "Con impuesto común del 10%  $"+imp.TotalAPagar().ToString());
            MessageBox.Show("TOTAL A PAGAR\n"+
                            "Con impuesto especial del 20%  $"+impEspecial.TotalAPagar().ToString());
        }

        public void CalcularDescuento(Producto precio)
        {
            precio.Precio = decimal.Parse(Interaction.InputBox("Igrese le precio del producto: "));
            MessageBox.Show("El precio sin descuento es:  $"+precio.Precio+"\n"+
                            "El precio con descuento es:  $"+precio.PrecioConDescuento().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
           CalcularDescuento(new ProductoNacional());

            CalcularDescuento(new ProductoImportado());
        }
    }
}
