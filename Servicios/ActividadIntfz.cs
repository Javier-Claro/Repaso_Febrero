using Repaso_Febrero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Febrero.Servicios
{
    internal class ActividadIntfz
    {

        public List<ActividadDto> anyadirActividad(List<ActividadDto> listaActividad);

        private ActividadDto crearNuevaActividad;
    }
}
