using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeccionSegundoParcial
{
    public abstract class Agregado
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }


    public class Pollo : Agregado
    {
        public Pollo()
        {
            _descripcion = "Pollo hornado";
        }
    }

    public class Chancho : Agregado
    {
        public Chancho()
        {
            _descripcion = "Chancho hornado";
        }
    }


    public class Pescado : Agregado
    {
        public Pescado()
        {
            _descripcion = "lómitos de atún en aceite de girasol ";
        }
    }

}

