using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJuego
{
    public class Guerrero : AgregarJugadorPartidaAbstract, IPartida
    {
        public Guerrero()
        {
            AñadiraJugdoresAUnaPartida(this);
        }
        public int UsarArma()
        {
            return 8;
        }

        public int UsarDefensaPersonal()
        {
            return 10;
        }
    }
}
