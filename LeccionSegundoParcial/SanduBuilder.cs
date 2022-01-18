using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeccionSegundoParcial
{
    public abstract class SanduBuilder   
    {

        protected string _descripcion;
        public abstract Pan BuildPan();
        public abstract Salsa BuildSalsa();
        public abstract Agregado BuildAgregado();

        public override string ToString()
        {
            return _descripcion;
        }
        public Sanduches BuildSanduche()
        {
            Pan pan = BuildPan();
            Salsa salsa = BuildSalsa();
            Agregado agregado = BuildAgregado();

            return new Sanduches(pan, salsa, agregado, _descripcion);
        }
    
        public void Escoger()
    {
        int persona;
        Console.WriteLine("Elija su preferencia : \nChancho----1 \nPollo-----2\nAtún----3");
        persona = int.Parse(Console.ReadLine());

        if (persona == 1)
        {
            Console.WriteLine("Ha escogido Sanduche de chancho");
            SanducheChancho sachancho = new SanducheChancho();
            

        }

        else if (persona == 2)
        {
            Console.WriteLine("Ha escogido Sanduche de Pollo");
            SanduchePollo sapollo = new SanduchePollo();
            
        }


        else if (persona == 3)
        {
            Console.WriteLine("Ha escogido Sanduche de Atún");
            SanducheAtun satun = new SanducheAtun();
            
        }

    }


}
}