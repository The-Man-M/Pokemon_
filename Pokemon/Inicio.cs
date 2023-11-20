using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Inicio : Form
    {
        List<Pokémon> pokémons = new List<Pokémon>();
        List<Pokémon> pokémons2 = new List<Pokémon>();

        public Entrenador entrenador1 = new Entrenador();
        public Entrenador entrenador2 = new Entrenador();

        bool listo1 = false;
        bool listo2 = false;

        public Inicio()
        {
            pokémons.Add(new Charizard());
            pokémons.Add(new Blastoise());
            pokémons.Add(new Pikachu());
            pokémons2.Add(new Charizard());
            pokémons2.Add(new Blastoise());
            pokémons2.Add(new Pikachu());

            InitializeComponent();

            btnComenzar.Visible = false;

            listBoxJugador1.DisplayMember = "nombre";
            listBoxJugador2.DisplayMember = "nombre";
            int i = 0;
            foreach (var pokemon in pokémons)
            {
                copiarEstadisticas(pokemon, pokémons2[i]);
                i++;
            }
            foreach (var poke in pokémons)
            {
                listBoxJugador1.Items.Add(poke);
            }
            foreach (var poke in pokémons2)
            {
                listBoxJugador2.Items.Add(poke);
            }
        }

        // boton comenzar 
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            JugadorN1 jg1 = new JugadorN1();
            foreach (var item in entrenador1.equipo)
            {
                jg1.listBoxEquipo1.Items.Add(item);
            }
            foreach (var item in entrenador2.equipo)
            {
                jg1.listBoxEquipo2.Items.Add(item);
            }
            jg1.ShowDialog();
            
        }

        private void btnPokemonElejido1_Click(object sender, EventArgs e)
        {
            var elejirPokemon = listBoxJugador1.SelectedItem;

            Pokémon pokemonElejido = (Pokémon)elejirPokemon;

            if (listBoxEquipo1.Items.Count < 3)
            {
                listBoxEquipo1.Items.Add(elejirPokemon);
                entrenador1.equipo.Add(pokemonElejido);
            }
            else
            {
                MessageBox.Show("Tu equipo Pokemon ya esta completo");
            }
        }

        private void btnPokemonElejido2_Click(object sender, EventArgs e)
        {
            var elejirPokemon = listBoxJugador2.SelectedItem;

            Pokémon pokemonElejido = (Pokémon)elejirPokemon;

            if (listBoxEquipo2.Items.Count < 3)
            {
                listBoxEquipo2.Items.Add(elejirPokemon);
                entrenador2.equipo.Add(pokemonElejido);
            }
            else
            {
                MessageBox.Show("Tu equipo Pokemon ya esta completo");
            }

        }

        private void listBoxJugador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pokémon pokémon = (Pokémon)listBoxJugador1.SelectedItem;
            lblNombre.Text = pokémon.nombre;
            lblTipo1.Text = pokémon.tipo.ToString();
            lblTipo2.Text = pokémon.tipo2.ToString();
            lblVida.Text = pokémon.estadisticas.vida.ToString();
            lblAtaque.Text = pokémon.estadisticas.ataque.ToString();
            lblDefensa.Text = pokémon.estadisticas.defensa.ToString();
            lblVelocidad.Text = pokémon.estadisticas.velocidad.ToString();

            listBoxAtaques.Items.Clear();
            foreach (var ataque in pokémon.ataques)
            {
                listBoxAtaques.Items.Add(ataque.Key + " - " + ataque.Value);
            }
        }

        private void listBoxJugador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pokémon pokémon = (Pokémon)listBoxJugador2.SelectedItem;
            lblNombre.Text = pokémon.nombre;
            lblTipo1.Text = pokémon.tipo.ToString();
            lblTipo2.Text = pokémon.tipo2.ToString();
            lblVida.Text = pokémon.estadisticas.vida.ToString();
            lblAtaque.Text = pokémon.estadisticas.ataque.ToString();
            lblDefensa.Text = pokémon.estadisticas.defensa.ToString();
            lblVelocidad.Text = pokémon.estadisticas.velocidad.ToString();

            listBoxAtaques.Items.Clear();
            foreach (var ataque in pokémon.ataques)
            {
                listBoxAtaques.Items.Add(ataque.Key + " - " + ataque.Value);
            }
        }

        private void btnListo1_Click(object sender, EventArgs e)
        {
            listo1 = true;

            if (listo1 == true && listo2 == true)
            {
                btnComenzar.Visible = true;
            }
        }

        private void btnListo2_Click(object sender, EventArgs e)
        {
            listo2 = true;

            if (listo1 == true && listo2 == true)
            {
                btnComenzar.Visible = true;
            }
        }
        private void copiarEstadisticas(Pokémon original, Pokémon copia)
        {

     
            copia.estadisticas.vida = original.estadisticas.vida;
            copia.estadisticas.vidaMax = original.estadisticas.vidaMax;
            copia.estadisticas.ataque = original.estadisticas.ataque;
            copia.estadisticas.defensa = original.estadisticas.defensa;
            copia.estadisticas.velocidad = original.estadisticas.velocidad;

        }
    }
}
