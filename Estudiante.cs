﻿using System;
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

        protected string materiasincritas;
        public string MateriasIncritas
        {
            get { return materiasincritas; }
            set { materiasincritas = value; }
        }

        protected double notas;
        public double Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        protected double cum;
        public double Cum
        {
            get { return cum; }
            set { cum = value; }
        }


    }

    class Ingenieria:Universitario
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



}
