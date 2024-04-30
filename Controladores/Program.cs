using jromres._4EvProg.Dtos;
using jromres._4EvProg.Servicios;
using System.Net.Http.Headers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jromres._4EvProg.Controladores
{
    internal class Program
    {
        /// <summary>
        /// Listas declaradas de forma estatica para poder acceder a ellas desde cualquier parte del codigo
        /// </summary>
        public static List<ConsultasDto> listaConsultas = new List<ConsultasDto> ();

        //uso de Dictionary para poder buscar la fecha y mostrar la lista de consultas
        public static Dictionary<DateTime,ConsultasDto> fechaDictionary = new Dictionary<DateTime, ConsultasDto>();
        public static Dictionary<string, ConsultasDto> dniClienteDictionary = new Dictionary<string, ConsultasDto>();
        public static Dictionary<string, ConsultasDto> especialidadClienteDictionary = new Dictionary<string, ConsultasDto>();

        /// <summary>
        /// Metodo principal de la aplicion
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Constructores de clases e interfaces
            MenuInterfaz mi = new MenuImplementacion();
            RegistroInterfaz ri = new RegistroImplementacion();


            try
            {


                //Creacion de ficheros
                string fecha = DateTime.Today.ToString("ddMMyyyy");
                string texto = "citas.txt";
                string combinacion = "C:\\Users\\Profesor\\source\\repos\\jromres.4EvProg\\";
                string rutaFicheroGeneral = string.Concat(combinacion, fecha, texto);

                //Variables de flujo
                int seleccionPrincipal;
                bool cerrarMenu = false;

                // METODOS ESTATICOS QUE MUESTRAN EL ESTADO ACTUAL DE LOS FICHEROS AL MOMENTO DE ABRIR LA APP Y EL CONTENIDO
                Utilidades.GestorFicheros.accesoAFicheros(rutaFicheroGeneral);

                while (!cerrarMenu)
                {

                    seleccionPrincipal = mi.menuPrincipal();
                    switch (seleccionPrincipal)
                    {
                        case 0:
                            using (StreamWriter sw = new StreamWriter(rutaFicheroGeneral))
                            {
                                foreach (ConsultasDto consultas in listaConsultas)
                                {

                                    sw.WriteLine(consultas.DniCompleto + ";" + consultas.NombreCompleto
                                        + ";" + consultas.Especialidad + ";" + consultas.FechaCita + ";" + consultas.Asistencia);


                                }
                            }

                            cerrarMenu = true;
                            break;
                        case 1:
                            ri.registroLlegada();
                            break;
                        case 2:
                            mi.seleccionConsultas();

                            break;
                        default:
                            Console.WriteLine("Seleccione opcion valida");
                            break;

                    }
                }


            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
