using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Bitmon
    {
        public int vida, stamina, defensa, ataque;
        public string nombre, tipo, estadolucha, estadosalud;
        public List<Poder> poderes;

        public Bitmon(int vida, int stamina, int defensa, int ataque, string nombre, string tipo, string estadolucha, List<Poder> poderes, string estadosalud)
        {
            this.vida = vida;
            this.stamina = stamina;
            this.defensa = defensa;
            this.ataque = ataque;
            this.nombre = nombre;
            this.tipo = tipo;
            this.estadolucha = estadolucha;
            this.poderes = poderes;
            this.estadosalud = estadosalud;
        }
    }
}
