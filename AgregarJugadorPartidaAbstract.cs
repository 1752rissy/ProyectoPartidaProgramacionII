using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJuego
{
    public  class AgregarJugadorPartidaAbstract
    {
        public static List<IPartida> lstPartida = new List<IPartida>();
        public static void AñadiraJugdoresAUnaPartida(IPartida jugador)
        {
            lstPartida.Add(jugador);
        }

    }
}
