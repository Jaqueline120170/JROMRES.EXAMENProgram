using jromres._4EvProg.Controladores;
using jromres._4EvProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres._4EvProg.Servicios
{
    internal class ImprimirImplementacion : ImprimirInterfaz
    {

        public void imprimirConsultasDelDiaAsistida()
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime pedidaFecha;
            string[] arrayAsistencia;
            string ficheroConsultas = "C:\\Users\\Profesor\\source\\repos\\jromres.4EvProg\\ficheroConsultas";
            do
            {
                Console.WriteLine("ELIJA LA FECHA DE CONSULTA (dd-MM-yyyy)");
                pedidaFecha= Convert.ToDateTime(Console.ReadLine());
                arrayAsistencia = pedidaFecha.ToString().Split('-');
            } while (arrayAsistencia.Length <= 0);
            try
            {

                StreamWriter sw = new StreamWriter(ficheroConsultas, true);
                foreach (ConsultasDto consulta in Program.listaConsultas)
                {
                    if (consulta.FechaCita.Day == pedidaFecha.Day & consulta.FechaCita.Month == pedidaFecha.Month & consulta.FechaCita.Year == pedidaFecha.Year & consulta.Asistencia.Equals("true"))
                    {
                        if (consulta.Especialidad.Equals("PSICOLOGIA"))
                        {
                            sw.Write($"Nombre completo: {consulta.Nombre} {consulta.ApellidoPrimero}, Hora:{consulta.FechaCita.Hour}:{consulta.FechaCita.Minute}");
                        }
                        else if (consulta.Especialidad.Equals("TRAUMATOLOGIA"))
                        {
                            sw.Write($"Nombre completo: {consulta.Nombre} {consulta.ApellidoPrimero}, Hora: {consulta.FechaCita.Hour}:{consulta.FechaCita.Minute}");
                        }
                        else if (consulta.Especialidad.Equals("FISIOTERAPIA"))
                        {
                            sw.Write($"Nombre completo: {consulta.Nombre} {consulta.ApellidoPrimero}, Hora: {consulta.FechaCita.Hour}:{consulta.FechaCita.Minute}");
                        }
                        else
                        {
                            sw.Write("No hay datos disponibles para la especialidad y fecha y hgora disponibles");
                        }
                    }
                }
                sw.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ha habido un error en la app");
            }

        }

      
    }
}
