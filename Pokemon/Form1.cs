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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Comenzar_Click(object sender, EventArgs e)
        {
            listBoxAtaques.Items.Clear();

            var charizard = new Charizard();

            labelNombre.Text = charizard.nombre;
            labelTipo.Text = charizard.tipo.ToString();
            labelTipo2.Text = charizard.tipo2.ToString();
            textBoxVida.Text = charizard.estadisticas.vida.ToString();
            textBoxAtaque.Text = charizard.estadisticas.ataque.ToString();
            textBoxDefensa.Text = charizard.estadisticas.defensa.ToString();
            textBoxVelocidad.Text = charizard.estadisticas.velocidad.ToString();

            foreach (var ataque in charizard.ataques)
            {
                listBoxAtaques.Items.Add(ataque.Key + " - " + ataque.Value);
            }

        }
    }
}
