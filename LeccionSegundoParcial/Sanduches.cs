using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeccionSegundoParcial
{
    public class Sanduches
    {
        Pan _pan;
        Salsa _salsa;
        Agregado _agregado;
        string _tipo;

        public override string ToString()
        {
            return $"{_tipo}, Pan: {_pan.Descripcion}, Salsa: {_salsa.Descripcion}, Agregado: {_agregado.Descripcion}";
        }


        public Sanduches(Pan pan, Salsa salsa, Agregado agregado, string tipo)
        {
            _pan = pan;
            _salsa = salsa;
            _agregado = agregado;
            _tipo = tipo;
        }
    }
}
