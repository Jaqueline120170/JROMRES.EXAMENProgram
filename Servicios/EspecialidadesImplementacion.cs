using jromres._4EvProg.Controladores;
using jromres._4EvProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres._4EvProg.Servicios
{
    internal class EspecialidadesImplementacion : EspecialidadesInterfaz
    {
        public void mostrarListasPsicologia()
        {
            try
            {

                Console.WriteLine("Introduzca la fecha de la consulta que desea ver en formato (dd-MM-YYYY)");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());
                bool fechaEncontrada = false;

                foreach (ConsultasDto consulta in Program.listaConsultas)
                {
                    if (Program.fechaDictionary.Equals(fecha))
                    {
                        fechaEncontrada = true;
                        Console.WriteLine(Program.listaConsultas.ToString());
                    }
                }
                if (!fechaEncontrada)
                {
                    Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada");
                }
                Utilidades.util.guardarIdDictionary();

            }
            catch (Exception) { throw; }

        }
        public void mostrarListasTraumatologia()
        {
            try
            {

                Console.WriteLine("Introduzca la fecha de la consulta que desea ver en formato (dd-MM-YYYY)");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());
                bool fechaEncontrada = false;

                foreach (ConsultasDto consulta in Program.listaConsultas)
                {
                    if (Program.fechaDictionary.Equals(fecha))
                    {
                        fechaEncontrada = true;
                        Console.WriteLine(Program.listaConsultas.ToString());
                    }
                }
                if (!fechaEncontrada)
                {
                    Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada");
                }
                Utilidades.util.guardarIdDictionary();

            }
            catch (Exception) { throw; }

        }
        public void mostrarListasFisioterapia()
        {
            try
            {

                Console.WriteLine("Introduzca la fecha de la consulta que desea ver en formato (dd-MM-YYYY)");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());
                bool fechaEncontrada = false;

                foreach (ConsultasDto consulta in Program.listaConsultas)
                {
                    if (Program.fechaDictionary.Equals(fecha))
                    {
                        fechaEncontrada = true;
                        Console.WriteLine(Program.listaConsultas.ToString());
                    }
                }
                if (!fechaEncontrada)
                {
                    Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada");
                }
                Utilidades.util.guardarIdDictionary();

            }
            catch (Exception) { throw; }

        }
    }
}
