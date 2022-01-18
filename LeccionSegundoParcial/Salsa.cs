using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeccionSegundoParcial
{
    public abstract class Salsa
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }


    public class Aguacate : Salsa
    {
        public Aguacate()
        {
            _descripcion = "Salsa de aguacate";
        }
    }

    public class Cesar : Salsa
    {
        public Cesar()
        {
            _descripcion = "Salsa Cesar";
        }
    }

    public class CebollaAguacate : Salsa
    {
        public CebollaAguacate()
        {
            _descripcion = "Salsa con cebolla y aguacate";
        }
    }


    public class Pesto : Salsa
    {
        public Pesto()
        {
            _descripcion = "Salsa de pesto";
        }
    }

}