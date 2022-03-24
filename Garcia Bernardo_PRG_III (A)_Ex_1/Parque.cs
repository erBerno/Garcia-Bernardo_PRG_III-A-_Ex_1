using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garcia_Bernardo_PRG_III__A__Ex_1
{
    class Parque
    {
        public string nombreParque { get; }

        public Queue<Juego> colaJuegos { get; }

        public Parque(string nombre)
        {
            nombreParque = nombre;
            colaJuegos = new Queue<Juego>();
        }

        public Parque(string nombre, Queue<Juego> juegos)
        {
            nombreParque = nombre;
            colaJuegos = juegos;
        }

        public void AgregarJuego(string nombreJ, int capacidad)
        {
            colaJuegos.Enqueue(new Juego()
            {
                nombreJuego = nombreJ,
                capacidadMax = capacidad
            });
        }

        public void EliminarJuego()
        {
            colaJuegos.Dequeue();
        }

        
    }
}
