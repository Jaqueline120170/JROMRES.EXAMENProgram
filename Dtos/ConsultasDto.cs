using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres._4EvProg.Dtos
{
    internal class ConsultasDto
    {
        ///Propiedades del objeto consultasdto valores por defecto para prueba
        string dniCompleto = "12345678Z";
        int numDni = 11111;
        char letraDni;
        string nombre= "ALFONSO";
        string apellidoPrimero = "FERNANDEZ";
        string apellidoSegundo= "GARCIA";
        string nombreCompleto = "ALFONSO FERNANDEZ GARCIA";
        string especialidad="PSICOLOGIA";
        DateTime fechaCita = DateTime.Now;
        bool asistencia = false;

        ///contructores de referencia para dar de alta una nueva biblioteca
        public ConsultasDto(string dniCompleto, DateTime fechaCita)
        {
            this.dniCompleto = dniCompleto;
            this.fechaCita = fechaCita;
        }

        public ConsultasDto(string dniCompleto, string nombreCompleto, string especialidad, DateTime fechaCita, bool asistencia)
        {
            this.dniCompleto = dniCompleto;
            this.nombreCompleto = nombreCompleto;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.asistencia = asistencia;
        }


        public ConsultasDto(int numDni, char letraDni, string nombre, string apellidoPrimero, string apellidoSegundo, string nombreCompleto, DateTime fechaCita, bool asistencia)
        {
            string[] dniArreglo = dniCompleto.Split("");
            this.dniCompleto = numDni.ToString() + letraDni;
            this.nombre = nombre;
            this.nombreCompleto = nombreCompleto;
            string[] arregloNombre = nombreCompleto.Split(" ");
            this.nombre = arregloNombre[0];
            this.apellidoPrimero = arregloNombre[1];
            this.apellidoSegundo = arregloNombre[2];
            this.fechaCita = fechaCita;
            this.asistencia = asistencia;
        }

        //Métodos de acceso getters y setters

        public string DniCompleto { get => dniCompleto; set => dniCompleto = value; }
        public int NumDni { get => numDni; set => numDni = value; }
        public char LetraDni { get => letraDni; set => letraDni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPrimero { get => apellidoPrimero; set => apellidoPrimero = value; }
        public string ApellidoSegundo { get => apellidoSegundo; set => apellidoSegundo = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool Asistencia { get => asistencia; set => asistencia = value; }

       
        /// <summary>
        /// 
        /// metodo tstring para mostrar
        /// </summary>
        /// <returns>nombre y fecha</returns>
        public string ToString()
        {
            string consulta =
                $"Nombre: {NombreCompleto} \n" +
                $"Hora: {fechaCita.Hour}\n" +
                $"------------------------------";

            return consulta;
        }




    }
}
