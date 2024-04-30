using jromres._4EvProg.Controladores;
using jromres._4EvProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jromres._4EvProg.Utilidades
{
    internal class util
    {
        public static void guardarIdDictionary()
        {
            foreach (ConsultasDto consulta in Program.listaConsultas)
            {
                if (!Program.dniClienteDictionary.ContainsKey(consulta.DniCompleto))
                {
                    Program.dniClienteDictionary.Add(consulta.DniCompleto, consulta);
                }
            }
            foreach (ConsultasDto consulta1 in Program.listaConsultas)
            {
                if (!Program.fechaDictionary.ContainsKey(consulta1.FechaCita))
                {
                    Program.fechaDictionary.Add(consulta1.FechaCita, consulta1);

                }
            }
            foreach (ConsultasDto consulta1 in Program.listaConsultas)
            {
                if (!Program.especialidadClienteDictionary.ContainsKey(consulta1.Especialidad))
                {
                    Program.especialidadClienteDictionary.Add(consulta1.Especialidad, consulta1);

                }
            }

        }
    }
}
