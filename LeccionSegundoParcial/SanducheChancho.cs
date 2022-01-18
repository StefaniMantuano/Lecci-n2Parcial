using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeccionSegundoParcial
{
    public class SanducheChancho : SanduBuilder
    {
        public SanducheChancho()
        {
            _descripcion = "Sanduche de Chancho";
        }
        public override Agregado BuildAgregado()
        {
            return new Chancho();
        }

        public override Pan BuildPan()
        {
            return new AlMolde();
        }

        public override Salsa BuildSalsa()
        {
            return new Pesto();
        }
    }
}
