using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

//remplazando clase lucha

namespace BitmonGráfico
{
    class ControllerLucha
    {
        int contadorJugador = 1;
        public List<Jugador> participantes;
        public int idLucha, turno;
        public string estadoLucha;

        public ControllerLucha(List<Jugador> participantes, int idLucha, int turno, string estadoLucha)
        {
            this.participantes = participantes;
            this.idLucha = idLucha;
            this.turno = turno;
            this.estadoLucha = estadoLucha;

            // ver como implementar bien el metodo turno

        }
        public void OnagregarJugardor(string nombre)
        {
            if (contadorJugador == 1)
            {
                Jugador jg1 = new Jugador(null, null, nombre, contadorJugador); //revisar como ponerle equipo al jugador al momento de instanciarlo
                contadorJugador += 1;
                

            }
            if (contadorJugador == 2)
            {
                Jugador jg2 = new Jugador(null, null, nombre, contadorJugador);
                
            }
        }
        public string getNombre(string nom)
        {
            return nom;
        }
    }
}
