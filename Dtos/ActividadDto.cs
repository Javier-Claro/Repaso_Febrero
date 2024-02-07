using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Febrero.Dtos
{
    /// <summary>
    /// Clase que contiene la entidad Cliente
    /// 070224 - mjcb
    /// </summary>
    internal class ActividadDto
    {
        //Atributos:
        string nombreAct = "aaaaaaa";
        DateTime fechaInicio;
        DateTime fechaFinal;
        long duracionAct;

        //Getter y Setters:
        public string NombreAct { get => nombreAct; set => nombreAct = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public long DuracionAct { get => duracionAct; set => duracionAct = value; }

        //Constructores:
        public ActividadDto(string nombreAct, DateTime fechaInicio, DateTime fechaFinal, long duracionAct)
        {
            this.nombreAct = nombreAct;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.duracionAct = duracionAct;
        }

        public ActividadDto() { }

        /// <summary>
        /// Metodo para escribir por pantalla los atributos definidos del objeto
        /// 070224 - mjcb
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            string clienteString = "\n\tNombre Actividad: " + this.NombreAct +
                                   ".\n\tFecha Inicio: " + this.FechaInicio +
                                   ".\n\tFecha Finalizacion: " + this.FechaFinal +
                                   ".\n\tDuracion: " + this.DuracionAct + "min.";
            return clienteString;
        }
    }
}
