using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PokémonFuego : Pokémon
    {
        public PokémonFuego(string nombre, Tipo tipo, Tipo tipo2, Estadisticas estadisticas, Dictionary<string, int> ataques, Debilidades debilidades) : base(nombre, tipo, tipo2, estadisticas, ataques, debilidades)
        {
        }
    }
    public class Charizard : PokémonFuego
    {

        public Charizard() : base("Charizard", Tipo.Fuego, Tipo.Volador, estadisticasAleatorias(), new Dictionary<string, int>(), new Debilidades())
        {
            this.debilidades.debilidades.Add(Tipo.Agua);
            this.debilidades.debilidades.Add(Tipo.Tierra);
            this.debilidades.debilidades.Add(Tipo.Roca);

            this.ataques.Add("Llamarada", 80);
            this.ataques.Add("Furia Ígnea", 100);
            this.ataques.Add("Inferno Ardiente", 150);
            this.ataques.Add("Ala Cortante", 90);
        }
        public override string ToString()
        {
            return this.nombre;
        }
        private static Estadisticas estadisticasAleatorias()
        {
            Random random = new Random();
            int vida = random.Next(78, 301);
            int ataque = random.Next(84, 301);
            int defensa = random.Next(78, 301);
            int velocidad = random.Next(100, 301);
            int vidamax = vida;

            return new Estadisticas { vida = vida, vidaMax = vidamax, ataque = ataque, defensa = defensa, velocidad = velocidad };
        }
    }
}
