using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Jugador
    {
        public List<Bitmon> bitmons;
        public List<Bitmon> equipo;
        public string nombre;
        public int id;

        public Jugador(string nombre, int id)
        {
            equipo = new List<Bitmon>();
            this.nombre = nombre;
            this.id = id;
        }
    }
}
