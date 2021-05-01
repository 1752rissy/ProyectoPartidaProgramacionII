using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJuego
{
    class Program
    {

        static void Main(string[] args)
        {
            //tecnica de inyeccion de dependencias.
            /*
             inyeccion : inyectar en algun lugar una dependencia donde?
            2 tipos de inyeccion: inyectar en el constructor, inyectar en los metodos.
             */

            //Console.WriteLine("puntaje guerrero arma :" + guerrero.UsarArma());
            //guerrero.UsarDefensaPersonal();
            Elfo elfo = new Elfo();
            Mago mago = new Mago();
            Guerrero guerrero = new Guerrero();

          //  lstPartida = new List<IPartida>(); //lista de objetos que implementan IPartida
            List<IMagia> lstMagia = new List<IMagia>();

            //AñadiraJugdoresAUnaPartida(elfo);
            //AñadiraJugdoresAUnaPartida(guerrero);
            //AñadiraJugdoresAUnaPartida(mago);


            lstMagia.Add(mago); 
            lstMagia.Add(elfo);
            //TECNICA OPEN CLOSE
            foreach (IPartida partida in AgregarJugadorPartidaAbstract.lstPartida)
            {
                Console.WriteLine("el jugador : "+partida.GetType()+" tiene nivel de arma :"+ partida.UsarArma());
                Console.WriteLine("el jugador : " + partida.GetType() + " tiene nivel de defensa personal :" + partida.UsarDefensaPersonal());
            }

            foreach(IMagia magia in lstMagia )
            {
                Console.WriteLine("el jugador : " + magia.GetType() + " tiene nivel de magia :" + magia.UsarMagia());
                Console.WriteLine("el jugador : " + magia.GetType() + " tiene nivel de telepatia :" + magia.UsarTelepatia());
            }

            Console.ReadLine();

        }


        //public static void AñadiraJugdoresAUnaPartida(IPartida jugador)
        //{
        //    lstPartida.Add(jugador);
        //}

    }
}
