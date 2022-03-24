using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garcia_Bernardo_PRG_III__A__Ex_1
{
    class Juego
    {
        public string nombreJuego { get; set; }
        public int capacidadMax { get; set; }

        public Juego(string nombre, int capacidad)
        {
            nombreJuego = nombre;
            capacidadMax = capacidad;
        }

        public Juego()
        {
        }
    }
}
