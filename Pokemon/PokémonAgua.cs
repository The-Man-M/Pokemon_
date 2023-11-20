﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PokémonAgua : Pokémon
    {
        public PokémonAgua(string nombre, Tipo tipo, Tipo tipo2, Estadisticas estadisticas, Dictionary<string, int> ataques, Debilidades debilidades) : base(nombre, tipo, tipo2, estadisticas, ataques, debilidades)
        {
        }
    }
    public class Blastoise : PokémonAgua
    {
        public Blastoise() : base("Blastoise", Tipo.Agua, Tipo.Ninguno, estadisticasAleatorias(), new Dictionary<string, int>(), new Debilidades())
        {
            this.debilidades.debilidades.Add(Tipo.Agua);
            this.debilidades.debilidades.Add(Tipo.Tierra);
            this.debilidades.debilidades.Add(Tipo.Roca);

            this.ataques.Add("Hidrobomba", 120);
            this.ataques.Add("Ventisca", 110);
            this.ataques.Add("Tormenta Acuática", 130);
            this.ataques.Add("Pistola Agua", 85);
        }
        public override string ToString()
        {
            return this.nombre;
        }
        private static Estadisticas estadisticasAleatorias()
        {
            Random random = new Random();
            int vida = random.Next(79, 301);
            int ataque = random.Next(83, 301);
            int defensa = random.Next(100, 301);
            int velocidad = random.Next(78, 301);
            int vidamax = vida;

            return new Estadisticas { vida = vida, vidaMax = vidamax, ataque = ataque, defensa = defensa, velocidad = velocidad };
        }
    }
}
