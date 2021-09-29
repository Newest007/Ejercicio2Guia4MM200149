using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2___Guía4_MM200149
{
    class Estudiante: Persona
    {

        protected string numcarnet;
        public string NumCarnet
        {
            get { return numcarnet; }
            set { numcarnet = value; }
        }

        protected string nvlestudios;
        public string NlvEstudios
        {
            get { return nvlestudios; }
            set { nvlestudios = value; }
        }


    }

    class Universitario:Estudiante
    {
        protected string nombreuniversidad;
        
        public string NombreUniversidad
        {
            get { return nombreuniversidad; }
            set { nombreuniversidad = value; }
        }

        protected string carrera;
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }



    }


}
