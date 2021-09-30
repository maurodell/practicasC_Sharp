using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_sobrescritura
{
    abstract public class Producto
    {
        public decimal Precio { get; set; }
        abstract public decimal PrecioConDescuento();
    }
    public class ProductoNacional : Producto
    {
        public override decimal PrecioConDescuento()
        {
            return this.Precio * 0.90m;
        }
    }
    public class ProductoImportado : Producto
    {
        public override decimal PrecioConDescuento()
        {
            return this.Precio * 0.80m;
        }
    }
}
