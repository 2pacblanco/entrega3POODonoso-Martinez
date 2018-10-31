using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Lucha
    {
        public List<Jugador> participantes;
        public int idLucha, turno;
        public string estadoLucha;

        public Lucha(int idLucha)
        {
            this.idLucha = idLucha;
            turno = 0;
            this.estadoLucha = "Activa";
            participantes = new List<Jugador>();
            participantes.Add(null);
            participantes.Add(null);
        }
    }
}
