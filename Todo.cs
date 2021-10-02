using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2___Guía4_MM200149
{
    class Ingenieria : Universitario
    {

        protected string nombreproyecto;
        public string NombreProyecto
        {
            get { return nombreproyecto; }
            set { nombreproyecto = value; }
        }

        protected string totalhoras;
        public string TotalHoras
        {
            get { return totalhoras; }
            set { totalhoras = value; }
        }

        protected string horascompletadas;
        public string HorasCompletadas
        {
            get { return horascompletadas; }
            set { horascompletadas = value; }
        }


    }

    class Universitario: Estudiante
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

        protected string materiasincritas;
        public string MateriasIncritas
        {
            get { return materiasincritas; }
            set { materiasincritas = value; }
        }

        protected double nota1;
        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        protected double nota2;
        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        protected double nota3;
        public double Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

        protected double cum;
        public double Cum
        {
            get { return cum; }
            set { cum = value; }
        }

        protected double promedio;
        public double Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }


    }


    class Estudiante : Persona
    {

        protected string numcarnet;
        public string NumCarnet
        {
            get { return numcarnet; }
            set { numcarnet = value; }
        }

        protected string nvlestudios;
        public string NivelEstudios
        {
            get { return nvlestudios; }
            set { nvlestudios = value; }
        }


    }


    class Persona
    {

        protected string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        protected string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


    }


}