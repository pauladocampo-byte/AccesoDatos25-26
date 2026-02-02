namespace Actividad3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbEquipos = new ListBox();
            label1 = new Label();
            lbFutbolistas = new ListBox();
            label2 = new Label();
            panel1 = new Panel();
            btnCancelarEquipo = new Button();
            lblInsertarActualizarEquipos = new Label();
            btnInsertarActualizarEquipo = new Button();
            txtCiudad = new TextBox();
            label5 = new Label();
            txtEstadio = new TextBox();
            label4 = new Label();
            txtPais = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            txtCodigo = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            btnCancelarFutbolista = new Button();
            label13 = new Label();
            cbEquipoSeleccionado = new ComboBox();
            lblInsertarActualizarFutbolistas = new Label();
            btnInsertarActualizarFutbolista = new Button();
            txtDorsalFutbolista = new TextBox();
            label8 = new Label();
            txtEdadFutbolista = new TextBox();
            label9 = new Label();
            txtPosicionFutbolista = new TextBox();
            label10 = new Label();
            txtNombreFutbolista = new TextBox();
            label11 = new Label();
            txtCodigoFutbolista = new TextBox();
            label12 = new Label();
            btnBorrarFutbolista = new Button();
            btnBorrarEquipo = new Button();
            btnEditarFutbolista = new Button();
            btnEditarEquipo = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbEquipos
            // 
            lbEquipos.FormattingEnabled = true;
            lbEquipos.ItemHeight = 25;
            lbEquipos.Location = new Point(58, 142);
            lbEquipos.Name = "lbEquipos";
            lbEquipos.Size = new Size(268, 304);
            lbEquipos.TabIndex = 0;
            lbEquipos.DoubleClick += lbEquipos_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 96);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 1;
            label1.Text = "Equipos";
            // 
            // lbFutbolistas
            // 
            lbFutbolistas.FormattingEnabled = true;
            lbFutbolistas.ItemHeight = 25;
            lbFutbolistas.Location = new Point(370, 142);
            lbFutbolistas.Name = "lbFutbolistas";
            lbFutbolistas.Size = new Size(255, 304);
            lbFutbolistas.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 96);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 3;
            label2.Text = "Futbolistas";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancelarEquipo);
            panel1.Controls.Add(lblInsertarActualizarEquipos);
            panel1.Controls.Add(btnInsertarActualizarEquipo);
            panel1.Controls.Add(txtCiudad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEstadio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPais);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(644, 73);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 500);
            panel1.TabIndex = 14;
            // 
            // btnCancelarEquipo
            // 
            btnCancelarEquipo.Location = new Point(19, 425);
            btnCancelarEquipo.Margin = new Padding(4);
            btnCancelarEquipo.Name = "btnCancelarEquipo";
            btnCancelarEquipo.Size = new Size(120, 50);
            btnCancelarEquipo.TabIndex = 10;
            btnCancelarEquipo.Text = "Cancelar";
            btnCancelarEquipo.UseVisualStyleBackColor = true;
            btnCancelarEquipo.Click += btnCancelarEquipo_Click;
            // 
            // lblInsertarActualizarEquipos
            // 
            lblInsertarActualizarEquipos.AutoSize = true;
            lblInsertarActualizarEquipos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInsertarActualizarEquipos.Location = new Point(75, 19);
            lblInsertarActualizarEquipos.Margin = new Padding(4, 0, 4, 0);
            lblInsertarActualizarEquipos.Name = "lblInsertarActualizarEquipos";
            lblInsertarActualizarEquipos.Size = new Size(218, 38);
            lblInsertarActualizarEquipos.TabIndex = 4;
            lblInsertarActualizarEquipos.Text = "Insertar equipo";
            // 
            // btnInsertarActualizarEquipo
            // 
            btnInsertarActualizarEquipo.Location = new Point(187, 425);
            btnInsertarActualizarEquipo.Margin = new Padding(4);
            btnInsertarActualizarEquipo.Name = "btnInsertarActualizarEquipo";
            btnInsertarActualizarEquipo.Size = new Size(162, 50);
            btnInsertarActualizarEquipo.TabIndex = 4;
            btnInsertarActualizarEquipo.Text = "Insertar equipo";
            btnInsertarActualizarEquipo.UseVisualStyleBackColor = true;
            btnInsertarActualizarEquipo.Click += btnInsertarActualizarEquipo_Click;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(125, 312);
            txtCiudad.Margin = new Padding(4);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(224, 31);
            txtCiudad.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 316);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 8;
            label5.Text = "Ciudad:";
            // 
            // txtEstadio
            // 
            txtEstadio.Location = new Point(125, 262);
            txtEstadio.Margin = new Padding(4);
            txtEstadio.Name = "txtEstadio";
            txtEstadio.Size = new Size(224, 31);
            txtEstadio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 266);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 6;
            label4.Text = "Estadio:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(125, 212);
            txtPais.Margin = new Padding(4);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(224, 31);
            txtPais.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 216);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 4;
            label3.Text = "País:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 162);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 31);
            txtNombre.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 166);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 2;
            label6.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(125, 112);
            txtCodigo.Margin = new Padding(4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(224, 31);
            txtCodigo.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 116);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 0;
            label7.Text = "Código:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCancelarFutbolista);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(cbEquipoSeleccionado);
            panel2.Controls.Add(lblInsertarActualizarFutbolistas);
            panel2.Controls.Add(btnInsertarActualizarFutbolista);
            panel2.Controls.Add(txtDorsalFutbolista);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtEdadFutbolista);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtPosicionFutbolista);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtNombreFutbolista);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtCodigoFutbolista);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(1136, 73);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 500);
            panel2.TabIndex = 15;
            // 
            // btnCancelarFutbolista
            // 
            btnCancelarFutbolista.Location = new Point(19, 425);
            btnCancelarFutbolista.Margin = new Padding(4);
            btnCancelarFutbolista.Name = "btnCancelarFutbolista";
            btnCancelarFutbolista.Size = new Size(120, 50);
            btnCancelarFutbolista.TabIndex = 12;
            btnCancelarFutbolista.Text = "Cancelar";
            btnCancelarFutbolista.UseVisualStyleBackColor = true;
            btnCancelarFutbolista.Click += btnCancelarFutbolista_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 366);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(72, 25);
            label13.TabIndex = 11;
            label13.Text = "Equipo:";
            // 
            // cbEquipoSeleccionado
            // 
            cbEquipoSeleccionado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEquipoSeleccionado.FormattingEnabled = true;
            cbEquipoSeleccionado.Location = new Point(125, 362);
            cbEquipoSeleccionado.Margin = new Padding(4);
            cbEquipoSeleccionado.Name = "cbEquipoSeleccionado";
            cbEquipoSeleccionado.Size = new Size(249, 33);
            cbEquipoSeleccionado.TabIndex = 10;
            // 
            // lblInsertarActualizarFutbolistas
            // 
            lblInsertarActualizarFutbolistas.AutoSize = true;
            lblInsertarActualizarFutbolistas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInsertarActualizarFutbolistas.Location = new Point(62, 19);
            lblInsertarActualizarFutbolistas.Margin = new Padding(4, 0, 4, 0);
            lblInsertarActualizarFutbolistas.Name = "lblInsertarActualizarFutbolistas";
            lblInsertarActualizarFutbolistas.Size = new Size(254, 38);
            lblInsertarActualizarFutbolistas.TabIndex = 4;
            lblInsertarActualizarFutbolistas.Text = "Insertar futbolista";
            // 
            // btnInsertarActualizarFutbolista
            // 
            btnInsertarActualizarFutbolista.Location = new Point(188, 425);
            btnInsertarActualizarFutbolista.Margin = new Padding(4);
            btnInsertarActualizarFutbolista.Name = "btnInsertarActualizarFutbolista";
            btnInsertarActualizarFutbolista.Size = new Size(188, 50);
            btnInsertarActualizarFutbolista.TabIndex = 4;
            btnInsertarActualizarFutbolista.Text = "Insertar futbolista";
            btnInsertarActualizarFutbolista.UseVisualStyleBackColor = true;
            btnInsertarActualizarFutbolista.Click += btnInsertarActualizarFutbolista_Click;
            // 
            // txtDorsalFutbolista
            // 
            txtDorsalFutbolista.Location = new Point(125, 312);
            txtDorsalFutbolista.Margin = new Padding(4);
            txtDorsalFutbolista.Name = "txtDorsalFutbolista";
            txtDorsalFutbolista.Size = new Size(124, 31);
            txtDorsalFutbolista.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 316);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 8;
            label8.Text = "Dorsal:";
            // 
            // txtEdadFutbolista
            // 
            txtEdadFutbolista.Location = new Point(125, 262);
            txtEdadFutbolista.Margin = new Padding(4);
            txtEdadFutbolista.Name = "txtEdadFutbolista";
            txtEdadFutbolista.Size = new Size(124, 31);
            txtEdadFutbolista.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 266);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 25);
            label9.TabIndex = 6;
            label9.Text = "Edad:";
            // 
            // txtPosicionFutbolista
            // 
            txtPosicionFutbolista.Location = new Point(125, 212);
            txtPosicionFutbolista.Margin = new Padding(4);
            txtPosicionFutbolista.Name = "txtPosicionFutbolista";
            txtPosicionFutbolista.Size = new Size(224, 31);
            txtPosicionFutbolista.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 216);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 4;
            label10.Text = "Posición:";
            // 
            // txtNombreFutbolista
            // 
            txtNombreFutbolista.Location = new Point(125, 162);
            txtNombreFutbolista.Margin = new Padding(4);
            txtNombreFutbolista.Name = "txtNombreFutbolista";
            txtNombreFutbolista.Size = new Size(224, 31);
            txtNombreFutbolista.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 166);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 2;
            label11.Text = "Nombre:";
            // 
            // txtCodigoFutbolista
            // 
            txtCodigoFutbolista.Location = new Point(125, 112);
            txtCodigoFutbolista.Margin = new Padding(4);
            txtCodigoFutbolista.Name = "txtCodigoFutbolista";
            txtCodigoFutbolista.Size = new Size(224, 31);
            txtCodigoFutbolista.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 116);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(75, 25);
            label12.TabIndex = 0;
            label12.Text = "Código:";
            // 
            // btnBorrarFutbolista
            // 
            btnBorrarFutbolista.Location = new Point(500, 462);
            btnBorrarFutbolista.Margin = new Padding(4);
            btnBorrarFutbolista.Name = "btnBorrarFutbolista";
            btnBorrarFutbolista.Size = new Size(125, 62);
            btnBorrarFutbolista.TabIndex = 19;
            btnBorrarFutbolista.Text = "Borrar futbolista";
            btnBorrarFutbolista.UseVisualStyleBackColor = true;
            btnBorrarFutbolista.Click += btnBorrarFutbolista_Click;
            // 
            // btnBorrarEquipo
            // 
            btnBorrarEquipo.Location = new Point(201, 462);
            btnBorrarEquipo.Margin = new Padding(4);
            btnBorrarEquipo.Name = "btnBorrarEquipo";
            btnBorrarEquipo.Size = new Size(125, 62);
            btnBorrarEquipo.TabIndex = 18;
            btnBorrarEquipo.Text = "Borrar equipo";
            btnBorrarEquipo.UseVisualStyleBackColor = true;
            btnBorrarEquipo.Click += btnBorrarEquipo_Click;
            // 
            // btnEditarFutbolista
            // 
            btnEditarFutbolista.Location = new Point(370, 462);
            btnEditarFutbolista.Margin = new Padding(4);
            btnEditarFutbolista.Name = "btnEditarFutbolista";
            btnEditarFutbolista.Size = new Size(125, 62);
            btnEditarFutbolista.TabIndex = 17;
            btnEditarFutbolista.Text = "Editar futbolista";
            btnEditarFutbolista.UseVisualStyleBackColor = true;
            btnEditarFutbolista.Click += btnEditarFutbolista_Click;
            // 
            // btnEditarEquipo
            // 
            btnEditarEquipo.Location = new Point(58, 462);
            btnEditarEquipo.Margin = new Padding(4);
            btnEditarEquipo.Name = "btnEditarEquipo";
            btnEditarEquipo.Size = new Size(125, 62);
            btnEditarEquipo.TabIndex = 16;
            btnEditarEquipo.Text = "Editar equipo";
            btnEditarEquipo.UseVisualStyleBackColor = true;
            btnEditarEquipo.Click += btnEditarEquipo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1612, 795);
            Controls.Add(btnBorrarFutbolista);
            Controls.Add(btnBorrarEquipo);
            Controls.Add(btnEditarFutbolista);
            Controls.Add(btnEditarEquipo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(lbFutbolistas);
            Controls.Add(label1);
            Controls.Add(lbEquipos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbEquipos;
        private Label label1;
        private ListBox lbFutbolistas;
        private Label label2;
        private Panel panel1;
        private Button btnCancelarEquipo;
        private Label lblInsertarActualizarEquipos;
        private Button btnInsertarActualizarEquipo;
        private TextBox txtCiudad;
        private Label label5;
        private TextBox txtEstadio;
        private Label label4;
        private TextBox txtPais;
        private Label label3;
        private TextBox txtNombre;
        private Label label6;
        private TextBox txtCodigo;
        private Label label7;
        private Panel panel2;
        private Button btnCancelarFutbolista;
        private Label label13;
        private ComboBox cbEquipoSeleccionado;
        private Label lblInsertarActualizarFutbolistas;
        private Button btnInsertarActualizarFutbolista;
        private TextBox txtDorsalFutbolista;
        private Label label8;
        private TextBox txtEdadFutbolista;
        private Label label9;
        private TextBox txtPosicionFutbolista;
        private Label label10;
        private TextBox txtNombreFutbolista;
        private Label label11;
        private TextBox txtCodigoFutbolista;
        private Label label12;
        private Button btnBorrarFutbolista;
        private Button btnBorrarEquipo;
        private Button btnEditarFutbolista;
        private Button btnEditarEquipo;
    }
}
