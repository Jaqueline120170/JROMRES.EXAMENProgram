using jromres._4EvProg.Controladores;
using jromres._4EvProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres._4EvProg.Servicios
{
    internal class RegistroImplementacion : RegistroInterfaz
    {

        public void registroLlegada()
        {
            try
            {

                Console.WriteLine("----------------");
                Console.WriteLine("REGISTRAR LLEGADA");
                Console.WriteLine("----------------");
                Console.WriteLine("Ingrese los numeros del DNI ( verificar que sean 8 digitos)");
                int dniPacienteRegistro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la letra del DNI ");
                char letraPaciente = Convert.ToChar(Console.ReadLine().ToUpper());
                var dniCl = verificarDni(dniPacienteRegistro, letraPaciente);
                string dniCompleto = string.Concat(dniPacienteRegistro, letraPaciente);
                bool dniEncontrado = false;
                foreach (ConsultasDto buscarDni in Program.listaConsultas)
                {
                    if (buscarDni.DniCompleto.Equals(dniCompleto))
                    {
                        dniEncontrado = true;
                        DateTime fechaLlegada = DateTime.Now;
                        ConsultasDto registro = new ConsultasDto(dniCompleto, fechaLlegada);
                        Program.listaConsultas.Add(registro);
                        Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.\r\n");
                    }
                }
                if (!dniEncontrado)
                {
                    Console.WriteLine("No dispone de cita previa  hoy");
                }
                Utilidades.util.guardarIdDictionary();

               
                
            }
            catch (Exception) { throw; }
        }

        private int verificarDni(int dniCliente, char letraCliente)
        {
            try
            {
                int dniVerificar = -1;

                int[] resto = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
                char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

                int divisor = 23;
                int operacion = dniCliente % divisor;

                int posicionResto = resto[operacion];

                if (letraCliente == letras[posicionResto])
                {

                    Console.WriteLine("DNI válido");
                    dniVerificar = dniCliente; // Asigna el DNI verificado a la variable de retorno
                }
                else
                {
                    Console.WriteLine("La letra ingresada no coincide con la letra calculada.");
                }
                return dniVerificar;
            }
            catch (Exception) { throw; }
        }

    }
}
