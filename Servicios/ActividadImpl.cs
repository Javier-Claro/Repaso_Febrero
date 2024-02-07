using Repaso_Febrero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Febrero.Servicios
{
    /// <summary>
    /// Clase que contien los metodos relacionados con los clientes
    /// 070224 - mjcb
    /// </summary>
    internal class ActividadImpl : ActividadIntfz
    {
        List<ActividadDto> ListaActividad = new List<ActividadDto>();


        /// <summary>
        /// Metodo que crea una actividad y la añade a la lista:
        /// 070224 - mjcb
        /// </summary>
        /// <param name="listaCliente"></param>
        /// <returns></returns>
        public List<ActividadDto> anyadirActividad(List<ActividadDto> listaActividad)
        {
            ActividadDto actividad = new ActividadDto();
            actividad = crearNuevaActividad();

            listaActividad.Add(actividad);

            return listaActividad;
        }

        private ActividadDto crearNuevaActividad()
        {
            ActividadDto nuevaActividad = new ActividadDto();

            Console.Write("\n\tIntroduzca el nombre de la Actividad: ");
            nuevaActividad.NombreAct = Console.ReadLine();

            Console.Write("\n\tIntroduzca el dia de inicio de la Actividad: ");
            string dia = Console.ReadLine();

            Console.Write("\n\tIntroduzca el mes de inicio de la Actividad: ");
            string mes = Console.ReadLine();

            Console.Write("\n\tIntroduzca el año de inicio de la Actividad: ");
            string anyo = Console.ReadLine();

            string fechaInicioString = dia + "/" + mes + "/" + anyo;
            nuevaActividad.FechaInicio = Convert.ToDateTime(fechaInicioString);

            nuevaActividad.FechaFinal = DateTime.Today;

            TimeSpan dias = nuevaActividad.FechaFinal - nuevaActividad.FechaInicio;

            int minTranscurridos = dias.Minutes;

            nuevaActividad.DuracionAct = minTranscurridos;

            return nuevaActividad;
        }
    }
}
