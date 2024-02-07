using Repaso_Febrero.Dtos;
using Repaso_Febrero.Servicios;

namespace RepasoFebrero.Controladores {

    /// <summary>
    /// Clase principal por la que iniciara la aplicacion
    /// 070224 - mjcb
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo main por donde inicia la app
        /// 070224 - mjcb
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            MenuIntfz mi = new MenuImpl();
            ActividadIntfz ci = new ActividadImpl();
            List<ActividadDto> listaActividad = new List<ActividadDto>();

        }
    }
}
