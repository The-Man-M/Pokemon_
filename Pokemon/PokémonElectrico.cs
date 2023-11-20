using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PokémonElectrico : Pokémon
    {
        public PokémonElectrico(string nombre, Tipo tipo, Tipo tipo2, Estadisticas estadisticas, Dictionary<string, int> ataques, Debilidades debilidades) : base(nombre, tipo, tipo2, estadisticas, ataques, debilidades)
        {
        }
    }
    public class Pikachu : PokémonElectrico
    {
        public Pikachu() : base("Pikachu", Tipo.Electrico, Tipo.Ninguno, estadisticasAleatorias(), new Dictionary<string, int>(), new Debilidades())
        {
            this.debilidades.debilidades.Add(Tipo.Agua);
            this.debilidades.debilidades.Add(Tipo.Tierra);
            this.debilidades.debilidades.Add(Tipo.Roca);

            this.ataques.Add("Impactrueno", 70);
            this.ataques.Add("Onda Trueno", 85);
            this.ataques.Add("Rayo", 110);
            this.ataques.Add("Ataque Rápido", 60);
        }
        public override string ToString()
        {
            return this.nombre;
        }
        private static Estadisticas estadisticasAleatorias()
        {
            Random random = new Random();
            int vida = random.Next(35, 301);
            int ataque = random.Next(55, 301);
            int defensa = random.Next(40, 301);
            int velocidad = random.Next(90, 301);

            int vidamax = vida;

            return new Estadisticas { vida = vida, vidaMax = vidamax, ataque = ataque, defensa = defensa, velocidad = velocidad };
        }
    }
}
