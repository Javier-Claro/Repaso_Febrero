using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Febrero.Servicios
{
    /// <summary>
    /// Clase que contiene el metodo que implementa el menu
    /// 070224 - mjcb
    /// </summary>
    internal class MenuImpl : MenuIntfz
    {
        /// <summary>
        /// Metodo que implementa el menu
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.WriteLine("\n\t---------------------------------------------");
            Console.WriteLine("\n\t0. Cerrar menu");
            Console.WriteLine("\n\t1. Crear nueva Actividad");
            Console.WriteLine("\n\t2. Mostrar Actividad");
            Console.WriteLine("\n\t3. Borrar Actividad");
            Console.WriteLine("\n\t---------------------------------------------");
            Console.Write("\n\tSeleccione una opcion: ");


            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }
    }
}
