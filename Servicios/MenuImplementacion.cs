using jromres._4EvProg.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres._4EvProg.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        EspecialidadesInterfaz es = new EspecialidadesImplementacion();
        ImprimirInterfaz im = new ImprimirImplementacion();
        public int menuPrincipal()
        {
            try
            {


                int opcionPrincipal;
                Console.WriteLine("----------------");
                Console.WriteLine("CENTRO MEDICO");
                Console.WriteLine("----------------");
                Console.WriteLine("0. Cerrar Menu");
                Console.WriteLine("1. Registrar llegada");
                Console.WriteLine("2. Listado Consultas");
                Console.WriteLine("Seleccione una opcion");
                opcionPrincipal = Convert.ToInt32(Console.ReadLine());
                return opcionPrincipal;
            }
            catch (Exception) { throw; }
        }

        private int menuConsultas()
        {
            try
            {


                int opcionConsultas;
                Console.WriteLine("----------------");
                Console.WriteLine("Listado Consultas");
                Console.WriteLine("----------------");
                Console.WriteLine("0. Volver");
                Console.WriteLine("1. Mostrar Consultas");
                Console.WriteLine("2. Imprimir Consltas");
                Console.WriteLine("Seleccione una opcion");
                opcionConsultas = Convert.ToInt32(Console.ReadLine());
                return opcionConsultas;
            }
            catch (Exception) { throw; }

        }
        public void seleccionConsultas()
        {
            try
            {


                int seleccionConsulta = menuConsultas();
                switch (seleccionConsulta)
                {
                    case 0:
                        break;
                    case 1:
                        mostrarMenuEspecialidades();
                        break;
                    case 2:
                        im.imprimirConsultasDelDiaAsistida();
                        break;
                    default:
                        Console.WriteLine("Introduzca una opcion valida");
                        break;
                }
            }
            catch (Exception) { throw; }
        }
        private int mostrarMenuEspecialidades()
        {
            try
            {


                int opcionEspecialidades;
                Console.WriteLine("------------------------");
                Console.WriteLine("Listado Especialidades");
                Console.WriteLine("------------------------");
                Console.WriteLine("0. Volver");
                Console.WriteLine("1. Psicologia");
                Console.WriteLine("2. Traumatologia");
                Console.WriteLine("3. Fisioterapia");
                Console.WriteLine("Seleccione la opcion de especialidad que desea mostrar");
                opcionEspecialidades = Convert.ToInt32(Console.ReadLine());
                return opcionEspecialidades;
            }
            catch (Exception) { throw; }
        }

        public void seleccionEspecialidades()
        {
            try
            {


                if (Program.listaConsultas.Count > 0)
                {
                    int seleccionEspecialidades = mostrarMenuEspecialidades();
                    switch (seleccionEspecialidades)
                    {
                        case 0:
                            break;
                        case 1:
                            es.mostrarListasPsicologia();

                            break;
                        case 2:
                            es.mostrarListasTraumatologia();
                            break;
                        case 3:
                            es.mostrarListasFisioterapia();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Debes de añadir como inimo alguna consulta");
                }
            }
            catch (Exception) { throw; }

        }
        private int mostrarMenuEspecialidadesImprimir()
        {
            try
            {


                int opcionEspecialidades;
                Console.WriteLine("------------------------");
                Console.WriteLine("Listado Especialidades para Imprimir");
                Console.WriteLine("------------------------");
                Console.WriteLine("0. Volver");
                Console.WriteLine("1. Psicologia");
                Console.WriteLine("2. Traumatologia");
                Console.WriteLine("3. Fisioterapia");
                Console.WriteLine("Seleccione la opcion de especialidad que desea mostrar");
                opcionEspecialidades = Convert.ToInt32(Console.ReadLine());
                return opcionEspecialidades;
            }
            catch (Exception) { throw; }
        }
        public void seleccionEspecialidadesImprimir()
        {
            try
            {


                if (Program.listaConsultas.Count > 0)
                {
                    int seleccionEspecialidades = mostrarMenuEspecialidadesImprimir();
                    switch (seleccionEspecialidades)
                    {
                        case 0:
                            break;
                        case 1:
                            

                            break;
                        case 2:
                         
                            break;
                        case 3:
                            
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Debes de añadir como inimo alguna consulta");
                }
            }
            catch (Exception) { throw; }

        }
    }
}
