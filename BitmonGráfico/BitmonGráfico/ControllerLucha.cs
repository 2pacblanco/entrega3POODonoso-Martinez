using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

//remplazando clase lucha

namespace BitmonGráfico
{
    public class ControllerLucha
    {
        int contadorJugador = 1;
        public List<Bitmon> allbitmons;
        public Lucha lucha = new Lucha(1);

        public ControllerLucha()
        {
            allbitmons = new List<Bitmon>();
            Poder Ember = new Poder(10, 1, "Fuego", null, "Ember");
            Poder FireFang = new Poder(11, 2, "Fuego", null, "Fire Fang");
            Poder FireSpin = new Poder(14, 3, "Fuego", null, "Fire Spin");
            Poder Flamethrower = new Poder(15, 5, "Fuego", "Confusion", "Flamethrower");
            Poder Iceshard = new Poder(12, 3, "Hielo", null, "Ice Shard");
            Poder FrostBreath = new Poder(10, 2, "Hielo", null, "Frost Breath");
            Poder PowderSnow = new Poder(6, 1, "Hielo", null, "Powder Snow");
            Poder Hypothemia = new Poder(0, 1, "Hielo", "Sueño", "Hypothemia");
            Poder WaterGun = new Poder(5, 2, "Agua", null, "Water Gun");
            Poder PoisonGun = new Poder(5, 4, "Agua", "Veneno", "Poison Gun");
            Poder Bubble = new Poder(12, 4, "Agua", null, "Bubble");
            Poder Waterfall = new Poder(16, 5, "Agua", null, "Waterfall");
            Poder ThunderShock = new Poder(5, 2, "Electro", null, "Thunder Shock");
            Poder Spark = new Poder(6, 5, "Electro", "Paralisis", "Spark");
            Poder ChargeBeam = new Poder(8, 4, "Electro", null, "Charge Beam");
            Poder VoltSwitch = new Poder(20, 6, "Electro", null, "Volt Switch");

            List<Poder> charmonpow = new List<Poder>();
            charmonpow.Add(ThunderShock);
            charmonpow.Add(Spark);
            charmonpow.Add(Ember);
            charmonpow.Add(Flamethrower);

            Bitmon Charmon = new Bitmon(500, 15, 128, 108, "Charmon", "Fuego", null, charmonpow, null);

            List<Poder> bitpow = new List<Poder>();
            bitpow.Add(Ember);
            bitpow.Add(FireFang);
            bitpow.Add(FireSpin);
            bitpow.Add(Flamethrower);

            Bitmon Bitmeleon = new Bitmon(800, 20, 160, 140, "Bitmeleon", "Fuego", null, bitpow, null);

            List<Poder> pikapow = new List<Poder>();
            pikapow.Add(ChargeBeam);
            pikapow.Add(VoltSwitch);
            pikapow.Add(FireFang);
            pikapow.Add(FireSpin);

            Bitmon Pikamon = new Bitmon(400, 17, 124, 108, "Pikamon", "Electro", null, pikapow, null);

            List<Poder> qwertypow = new List<Poder>();
            qwertypow.Add(ThunderShock);
            qwertypow.Add(Spark);
            qwertypow.Add(ChargeBeam);
            qwertypow.Add(VoltSwitch);

            Bitmon Qwertymon = new Bitmon(700, 22, 200, 154, "Qwertymon", "Electro", null, qwertypow, null);

            List<Poder> squipow = new List<Poder>();
            squipow.Add(FrostBreath);
            squipow.Add(PowderSnow);
            squipow.Add(Bubble);
            squipow.Add(Waterfall);

            Bitmon Squimon = new Bitmon(500, 13, 112, 142, "Squimon", "Agua", null, squipow, null);

            List<Poder> worpow = new List<Poder>();
            worpow.Add(WaterGun);
            worpow.Add(PoisonGun);
            worpow.Add(Bubble);
            worpow.Add(Waterfall);

            Bitmon Worbito = new Bitmon(600, 19, 144, 176, "Worbito", "Agua", null, worpow, null);

            List<Poder> icepow = new List<Poder>();
            icepow.Add(PoisonGun);
            icepow.Add(Iceshard);
            icepow.Add(Hypothemia);
            icepow.Add(WaterGun);

            Bitmon Icemon = new Bitmon(500, 12, 128, 110, "Icemon", "Hielo", null, icepow, null);

            List<Poder> dragpow = new List<Poder>();
            dragpow.Add(Iceshard);
            dragpow.Add(FrostBreath);
            dragpow.Add(PowderSnow);
            dragpow.Add(Hypothemia);

            Bitmon Dragonice = new Bitmon(800, 20, 170, 152, "Dragonice", "Hielo", null, dragpow, null);

            List<Poder> tiripow = new List<Poder>();
            tiripow.Add(Flamethrower);
            tiripow.Add(Hypothemia);
            tiripow.Add(PoisonGun);
            tiripow.Add(Spark);

            Bitmon Tirimon = new Bitmon(600, 17, 132, 136, "Tirimon", "Normal", null, tiripow, null);

            List<Poder> naidopow = new List<Poder>();
            naidopow.Add(FireSpin);
            naidopow.Add(Iceshard);
            naidopow.Add(Waterfall);
            naidopow.Add(VoltSwitch);

            Bitmon Naidormon = new Bitmon(1000, 16, 142, 128, "Naidormon", "Normal", null, naidopow, null);

            allbitmons.Add(Charmon);
            allbitmons.Add(Bitmeleon);
            allbitmons.Add(Pikamon);
            allbitmons.Add(Qwertymon);
            allbitmons.Add(Squimon);
            allbitmons.Add(Worbito);
            allbitmons.Add(Icemon);
            allbitmons.Add(Dragonice);
            allbitmons.Add(Tirimon);
            allbitmons.Add(Naidormon);

            // ver como implementar bien el metodo turno

        }

        public void OnagregarJugardor(string nombre)
        {
            if (contadorJugador == 1)
            {
                Jugador jg1 = new Jugador(nombre, contadorJugador); //revisar como ponerle equipo al jugador al momento de instanciarlo
                contadorJugador += 1;
                lucha.participantes[0] = jg1;
                

            }
            if (contadorJugador == 2)
            {
                Jugador jg2 = new Jugador(nombre, contadorJugador);
                lucha.participantes[1] = jg2;
                
            }
        }

        public void AddEquipos(List<Bitmon> nombres, int jugador)
        {
            if (jugador == 1)
            {
                lucha.participantes[0].equipo = nombres;
            }
            if (jugador == 2)
            {
                lucha.participantes[1].equipo = nombres;
            }
        }

        public string GetNombre(string nom)
        {
            return nom;
        }

        public void AddActivo(string act1,string act2)
        {
            foreach(Bitmon b in lucha.participantes[0].equipo)
            {
                if(act1 == b.nombre)
                {
                    b.estadolucha = "activo";
                }
            }
            foreach(Bitmon b in lucha.participantes[1].equipo)
            {
                if(act2 == b.nombre)
                {
                    b.estadolucha = "activo";
                }
            }
        }

        public Bitmon GetActivo(string nombre_jug)
        {
            foreach(Jugador j in lucha.participantes)
            {
                if(nombre_jug == j.nombre)
                {
                    foreach(Bitmon b in j.equipo)
                    {
                        if (b.estadolucha == "activo")
                        {
                            return b;
                        }
                    }
                }
            }
            return null;
        }

        public void Descansar(string nombre_jug)
        {
            Bitmon act = GetActivo(nombre_jug);

            act.vida = act.vida + 40;
            act.stamina = act.stamina + 10;

            foreach(Jugador j in lucha.participantes)
            {
                if(j.nombre == nombre_jug)
                {
                    foreach(Bitmon b in j.equipo)
                    {
                        if(b.nombre == act.nombre)
                        {
                            b.vida = act.vida;
                            b.stamina = act.stamina;
                        }
                    }
                }
            }
        }
       
        

        public void Neutro1()
        {       
            foreach(Bitmon b in lucha.participantes[0].equipo)
            {
                if (b.estadolucha == "activo")
                {
                    b.estadolucha = null;
                }
            }           
        }

        public void Neutro2()
        {
            foreach(Bitmon b in lucha.participantes[1].equipo)
            {
                if(b.estadolucha == "activo")
                {
                    b.estadolucha = null;
                }
            }
        }

        public void Cambiar1(string nombre_bit)
        {
           foreach(Bitmon b in lucha.participantes[0].equipo)
           {
                if(b.nombre == nombre_bit)
                {
                    b.estadolucha = "activo";
                }
           }
        }

        public void Cambiar2(string nombre_bit)
        {
            foreach (Bitmon b in lucha.participantes[1].equipo)
            {
                if (b.nombre == nombre_bit)
                {
                    b.estadolucha = "activo";
                }
            }
        }

        public void Rendirse(string nombre_jug)
        {
            foreach(Jugador j in lucha.participantes)
            {
                if(j.nombre == nombre_jug)
                {
                    foreach(Bitmon b in j.equipo)
                    {
                        b.vida = 0;
                    }
                }
            }
        }

        public bool Verify(int turno)
        {
            if (turno == 1)
            {
                foreach(Bitmon b in lucha.participantes[1].equipo)
                {
                    if(b.vida > 0)
                    {
                        return true;
                    }
                }
                return false;
            }

            if (turno == 2)
            {
                foreach (Bitmon b in lucha.participantes[0].equipo)
                {
                    if (b.vida > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            else { return true; }
        }

        public Bitmon Ataca(Bitmon atacado, Poder pow, string nombre_jug)
        {
            Bitmon act = GetActivo(nombre_jug);

            double defensareal = atacado.defensa * (0.3);//esto nos pareció necesario para hacer un poco más rápido y fluido el juego
            double ataquereal = pow.danio + act.ataque;
            //reduccion de vida
            if (pow.tipo == "Normal")
            {
                atacado.vida = atacado.vida - Convert.ToInt32(ataquereal - defensareal);
                
            }
            if (pow.tipo == "Electro")
            {
                if (atacado.tipo == "Agua")//aumentaremos 30%+ el ataque y la defensa la redujiremos 30%-
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal * 1.3 - defensareal * 0.7);
                    
                }
                if (atacado.tipo == "Hielo")//ataque 30%- y defensa 30%+
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal * 0.7 - defensareal * 1.3);
                    
                }
                if (atacado.tipo == "Normal" || atacado.tipo == "Fuego" || atacado.tipo == "Electro")
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal - defensareal);
                    
                }
            }
            if (pow.tipo == "Agua")
            {
                if (atacado.tipo == "Fuego")//aumentaremos 30%+ el ataque y la defensa la redujiremos 30%-
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal * 1.3 - defensareal * 0.7);
                    
                }
                if (atacado.tipo == "Electro")//ataque 30%- y defensa 30%+
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal * 0.7 - defensareal * 1.3);
                    
                }
                if (atacado.tipo == "Normal" || atacado.tipo == "Agua" || atacado.tipo == "Hielo")
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal - defensareal);
                    
                }
            }
            if (pow.tipo == "Hielo")
            {
                if (atacado.tipo == "Electro")//aumentaremos 30%+ el ataque y la defensa la redujiremos 30%-
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal * 1.3 - defensareal * 0.7);
                    
                }
                if (atacado.tipo == "Fuego")//ataque 30%- y defensa 30%+
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal * 0.7 - defensareal * 1.3);
                    
                }
                if (atacado.tipo == "Normal" || atacado.tipo == "Agua" || atacado.tipo == "Hielo")
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal - defensareal);
                   
                }
            }
            if (pow.tipo == "Fuego")
            {
                if (atacado.tipo == "Hielo")//aumentaremos 30%+ el ataque y la defensa la redujiremos 30%-
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal * 1.3 - defensareal * 0.7);
                    
                }
                if (atacado.tipo == "Agua")//ataque 30%- y defensa 30%+
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal * 0.7 - defensareal * 1.3);
                    
                }
                if (atacado.tipo == "Normal" || atacado.tipo == "Fuego" || atacado.tipo == "Electro")
                {
                    atacado.vida = atacado.vida - Convert.ToInt32(ataquereal - defensareal);
                    
                }
            }

            //reduccion stamina
            act.stamina = act.stamina - pow.costo;

            atacado.estadosalud = pow.ulti;

            if (atacado.vida <= 0)
            {
                atacado.vida = 0;
                atacado.estadolucha = "activo";   
            }

            return atacado;

        }


    }
}
