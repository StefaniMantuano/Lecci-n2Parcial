using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeccionSegundoParcial
{
    public class SanducheAtun : SanduBuilder
    {
        public SanducheAtun()
        {
            _descripcion = "Sanduche de atún";
        }
        public override Agregado BuildAgregado()
        {
            return new Pescado();
        }

        public override Pan BuildPan()
        {
            return new AlMolde();
        }

        public override Salsa BuildSalsa()
        {
            return new Aguacate();
        }
    }
}
