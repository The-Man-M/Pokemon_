namespace Pokemon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Comenzar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.textBoxVida = new System.Windows.Forms.TextBox();
            this.textBoxAtaque = new System.Windows.Forms.TextBox();
            this.textBoxDefensa = new System.Windows.Forms.TextBox();
            this.textBoxVelocidad = new System.Windows.Forms.TextBox();
            this.listBoxAtaques = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTipo2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Comenzar
            // 
            this.Comenzar.Location = new System.Drawing.Point(650, 30);
            this.Comenzar.Name = "Comenzar";
            this.Comenzar.Size = new System.Drawing.Size(75, 23);
            this.Comenzar.TabIndex = 0;
            this.Comenzar.Text = "button1";
            this.Comenzar.UseVisualStyleBackColor = true;
            this.Comenzar.Click += new System.EventHandler(this.Comenzar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(76, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(35, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "label1";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(76, 35);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(35, 13);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "label1";
            // 
            // textBoxVida
            // 
            this.textBoxVida.Location = new System.Drawing.Point(79, 62);
            this.textBoxVida.Name = "textBoxVida";
            this.textBoxVida.Size = new System.Drawing.Size(404, 20);
            this.textBoxVida.TabIndex = 3;
            // 
            // textBoxAtaque
            // 
            this.textBoxAtaque.Location = new System.Drawing.Point(79, 103);
            this.textBoxAtaque.Name = "textBoxAtaque";
            this.textBoxAtaque.Size = new System.Drawing.Size(404, 20);
            this.textBoxAtaque.TabIndex = 4;
            // 
            // textBoxDefensa
            // 
            this.textBoxDefensa.Location = new System.Drawing.Point(79, 141);
            this.textBoxDefensa.Name = "textBoxDefensa";
            this.textBoxDefensa.Size = new System.Drawing.Size(401, 20);
            this.textBoxDefensa.TabIndex = 5;
            // 
            // textBoxVelocidad
            // 
            this.textBoxVelocidad.Location = new System.Drawing.Point(79, 181);
            this.textBoxVelocidad.Name = "textBoxVelocidad";
            this.textBoxVelocidad.Size = new System.Drawing.Size(401, 20);
            this.textBoxVelocidad.TabIndex = 6;
            // 
            // listBoxAtaques
            // 
            this.listBoxAtaques.FormattingEnabled = true;
            this.listBoxAtaques.Location = new System.Drawing.Point(97, 221);
            this.listBoxAtaques.Name = "listBoxAtaques";
            this.listBoxAtaques.Size = new System.Drawing.Size(401, 173);
            this.listBoxAtaques.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo:";
            // 
            // labelTipo2
            // 
            this.labelTipo2.AutoSize = true;
            this.labelTipo2.Location = new System.Drawing.Point(157, 35);
            this.labelTipo2.Name = "labelTipo2";
            this.labelTipo2.Size = new System.Drawing.Size(35, 13);
            this.labelTipo2.TabIndex = 10;
            this.labelTipo2.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ataque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Defensa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Defensa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Habilidades:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTipo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAtaques);
            this.Controls.Add(this.textBoxVelocidad);
            this.Controls.Add(this.textBoxDefensa);
            this.Controls.Add(this.textBoxAtaque);
            this.Controls.Add(this.textBoxVida);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.Comenzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Comenzar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox textBoxVida;
        private System.Windows.Forms.TextBox textBoxAtaque;
        private System.Windows.Forms.TextBox textBoxDefensa;
        private System.Windows.Forms.TextBox textBoxVelocidad;
        private System.Windows.Forms.ListBox listBoxAtaques;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTipo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}