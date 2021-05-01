using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJuego
{
    class Mago : AgregarJugadorPartidaAbstract, IPartida, IMagia
    {
        public Mago()
        {
            AñadiraJugdoresAUnaPartida(this);
        }
        public int UsarArma()
        {
            return 4;
        }

        public int UsarDefensaPersonal()
        {
            return 2;
        }

        public int UsarMagia()
        {
            return 10;
        }

        public int UsarTelepatia()
        {
            return 10;
        }
    }
}
