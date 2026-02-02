
namespace ProyectoPokemon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPokemon = new System.Windows.Forms.ListBox();
            this.btnMostrarNombrePokemon = new System.Windows.Forms.Button();
            this.btnGetPokemonKilos = new System.Windows.Forms.Button();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPokemon
            // 
            this.lstPokemon.FormattingEnabled = true;
            this.lstPokemon.Location = new System.Drawing.Point(185, 30);
            this.lstPokemon.Name = "lstPokemon";
            this.lstPokemon.Size = new System.Drawing.Size(494, 394);
            this.lstPokemon.TabIndex = 0;
            // 
            // btnMostrarNombrePokemon
            // 
            this.btnMostrarNombrePokemon.Location = new System.Drawing.Point(44, 468);
            this.btnMostrarNombrePokemon.Name = "btnMostrarNombrePokemon";
            this.btnMostrarNombrePokemon.Size = new System.Drawing.Size(101, 44);
            this.btnMostrarNombrePokemon.TabIndex = 1;
            this.btnMostrarNombrePokemon.Text = "Mostrar nombre Pokemon";
            this.btnMostrarNombrePokemon.UseVisualStyleBackColor = true;
            this.btnMostrarNombrePokemon.Click += new System.EventHandler(this.btnMostrarNombrePokemon_Click);
            // 
            // btnGetPokemonKilos
            // 
            this.btnGetPokemonKilos.Location = new System.Drawing.Point(351, 447);
            this.btnGetPokemonKilos.Name = "btnGetPokemonKilos";
            this.btnGetPokemonKilos.Size = new System.Drawing.Size(101, 87);
            this.btnGetPokemonKilos.TabIndex = 2;
            this.btnGetPokemonKilos.Text = "Mostrar los Pokémon que tengan menos de X kilos";
            this.btnGetPokemonKilos.UseVisualStyleBackColor = true;
            this.btnGetPokemonKilos.Click += new System.EventHandler(this.btnGetPokemonKilos_Click);
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(234, 476);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(100, 20);
            this.txtKilos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kilos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKilos);
            this.Controls.Add(this.btnGetPokemonKilos);
            this.Controls.Add(this.btnMostrarNombrePokemon);
            this.Controls.Add(this.lstPokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPokemon;
        private System.Windows.Forms.Button btnMostrarNombrePokemon;
        private System.Windows.Forms.Button btnGetPokemonKilos;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label label1;
    }
}

