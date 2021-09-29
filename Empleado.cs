using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2___Guía4_MM200149
{
    class Empleado:Persona
    {
        string tipoempleo;
        public string TipoEmpleo
        {
            get { return tipoempleo; }
            set { tipoempleo = value; }
        }

    }
}
