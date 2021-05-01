using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJuego
{
    public class Elfo : AgregarJugadorPartidaAbstract, IPartida, IMagia
    {
        public Elfo()
        {
            AñadiraJugdoresAUnaPartida(this);
        }

        public int UsarArma()
        {
            return 10;
        }

        public int UsarDefensaPersonal()
        {
            return 8;
        }

        public int UsarMagia()
        {
            return 6;
        }

        public int UsarTelepatia()
        {
            return 9;
        }
    }
}
