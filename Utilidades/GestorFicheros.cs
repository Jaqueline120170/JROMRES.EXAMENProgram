using jromres._4EvProg.Controladores;
using jromres._4EvProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres._4EvProg.Utilidades
{
    internal class GestorFicheros
    {
        public static void accesoAFicheros(string rutaFicheroGeneral)
        {
            if (File.Exists(rutaFicheroGeneral))
            {
                string[] contenidoFichero = File.ReadAllLines(rutaFicheroGeneral);
                foreach (string fichero in contenidoFichero)
                {
                    // Dentro del bucle, se divide cada línea en partes usando el carácter ';' como separador.
                    string[] lineasContenido = fichero.Split(";");


                    ConsultasDto consulta = new ConsultasDto(lineasContenido[0], lineasContenido[1], lineasContenido[2], DateTime.Parse(lineasContenido[3]), bool.Parse(lineasContenido[4]));
                    Program.listaConsultas.Add(consulta);
                }
                /*
                foreach( VehiculosDto vehiculo in Program.listaConsultas)
                {
                    Console.WriteLine("lista de consultas");
                    Console.WriteLine(ineasContenido[0], lineasContenido[1], lineasContenido[2], DateTime.Parse(lineasContenido[3]));
                }
                */
                string[] arregloConsultas = File.ReadAllLines(rutaFicheroGeneral);
                Console.WriteLine("Lista de consultas registradas");
                foreach (string line in arregloConsultas)
                {
                    Console.WriteLine(line);
                }


            }
            else
            {
                Console.WriteLine("No existen consultas registradas");
            }
        }
    }    
}
