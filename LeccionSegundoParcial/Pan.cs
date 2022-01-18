using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeccionSegundoParcial
{
    public abstract class Pan
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }

    public class AlMolde : Pan
    {
        public AlMolde()
        {
            _descripcion = "Pan de molde";
        }
    }

    public class ALaPiedra : Pan
    {
        public ALaPiedra()
        {
            _descripcion = "Pan caliente del horno ";
        }
    }

    public class Integral : Pan
    {
        public Integral()
        {
            _descripcion = "Pan integral";
        }
    }

}

