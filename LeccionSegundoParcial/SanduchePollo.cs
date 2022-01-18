using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeccionSegundoParcial
{
    public class SanduchePollo : SanduBuilder
    {

        public SanduchePollo()
        {
            _descripcion = "Sanduche de Pollo";
        }
        public override Agregado BuildAgregado()
        {
            return new Pollo();
        }

        public override Pan BuildPan()
        {
            return new ALaPiedra();
        }

        public override Salsa BuildSalsa()
        {
            return new Cesar();
        }
      
}
}