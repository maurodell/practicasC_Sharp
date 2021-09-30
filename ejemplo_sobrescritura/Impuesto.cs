using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_sobrescritura
{
    abstract class Impuesto//creo la clase abstract
    {
        public static decimal Imp;//se genera un atributo static para poder implementar los metodos y no perder el value
        public decimal Importe {
            get => Imp;
            set
            {
                Imp = value;
            }
                 }//atributo Importe
        virtual public decimal ImpuestoEnPesos() { return this.Importe * 0.10m; }//metodo virtual que retorna el importe *0.10
        abstract public decimal TotalAPagar();//metodo abstracto vacío
    }
    class ImpuestoComun : Impuesto
    {
        override public decimal TotalAPagar()//hereda el metodo vacio y lo sobrescribe
        {
            return Importe + ImpuestoEnPesos();//suma el atributo y el lo que devuelve el metodo.
        }
    }
    class ImpuestoEspecial : Impuesto
    {
        override public decimal ImpuestoEnPesos()//se hace override, sobrescribiendo el metodo abstracto
        {
            return this.Importe * 0.20m;//se retorna el importe de la clase base
        }
        private decimal TasaAdicional()
        {
            return this.Importe * 0.01m;
        }
        public override decimal TotalAPagar()
        {
            return Importe + ImpuestoEnPesos() + TasaAdicional();
        }
    }
}
