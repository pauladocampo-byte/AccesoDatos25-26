namespace Actividad7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ===== CONTROLES PRINCIPALES =====
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAlumnos = new System.Windows.Forms.TabPage();
            this.tabMatriculas = new System.Windows.Forms.TabPage();
            this.tabIntegridad = new System.Windows.Forms.TabPage();

            // ===== TAB ALUMNOS =====
            this.groupBoxAlumno = new System.Windows.Forms.GroupBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnInsertarAlumno = new System.Windows.Forms.Button();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.btnActualizarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnLimpiarAlumno = new System.Windows.Forms.Button();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.lblListaAlumnos = new System.Windows.Forms.Label();

            // ===== TAB MATRICULAS =====
            this.groupBoxMatricula = new System.Windows.Forms.GroupBox();
            this.lblDNIMatricula = new System.Windows.Forms.Label();
            this.txtDNIMatricula = new System.Windows.Forms.TextBox();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.cboAsignaturas = new System.Windows.Forms.ComboBox();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnActualizarNota = new System.Windows.Forms.Button();
            this.lstMatriculas = new System.Windows.Forms.ListBox();
            this.lblListaMatriculas = new System.Windows.Forms.Label();
            this.btnEliminarMatricula = new System.Windows.Forms.Button();

            // ===== TAB INTEGRIDAD REFERENCIAL =====
            this.lblIntegridad = new System.Windows.Forms.Label();
            this.btnProbarIntegridad = new System.Windows.Forms.Button();
            this.txtResultadoIntegridad = new System.Windows.Forms.TextBox();
            this.lblExplicacion = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // ===== CONFIGURAR TABCONTROL =====
            this.tabControl.Controls.Add(this.tabAlumnos);
            this.tabControl.Controls.Add(this.tabMatriculas);
            this.tabControl.Controls.Add(this.tabIntegridad);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 600);
            this.tabControl.TabIndex = 0;

            // ===== TAB ALUMNOS =====
            this.tabAlumnos.Controls.Add(this.groupBoxAlumno);
            this.tabAlumnos.Controls.Add(this.lstAlumnos);
            this.tabAlumnos.Controls.Add(this.lblListaAlumnos);
            this.tabAlumnos.Location = new System.Drawing.Point(4, 22);
            this.tabAlumnos.Name = "tabAlumnos";
            this.tabAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlumnos.Size = new System.Drawing.Size(992, 574);
            this.tabAlumnos.TabIndex = 0;
            this.tabAlumnos.Text = "?? Gestión Alumnos";
            this.tabAlumnos.UseVisualStyleBackColor = true;

            // ===== GRUPO ALUMNO =====
            this.groupBoxAlumno.Controls.Add(this.lblDNI);
            this.groupBoxAlumno.Controls.Add(this.txtDNI);
            this.groupBoxAlumno.Controls.Add(this.lblNombre);
            this.groupBoxAlumno.Controls.Add(this.txtNombre);
            this.groupBoxAlumno.Controls.Add(this.lblApellidos);
            this.groupBoxAlumno.Controls.Add(this.txtApellidos);
            this.groupBoxAlumno.Controls.Add(this.btnInsertarAlumno);
            this.groupBoxAlumno.Controls.Add(this.btnBuscarAlumno);
            this.groupBoxAlumno.Controls.Add(this.btnActualizarAlumno);
            this.groupBoxAlumno.Controls.Add(this.btnEliminarAlumno);
            this.groupBoxAlumno.Controls.Add(this.btnLimpiarAlumno);
            this.groupBoxAlumno.Location = new System.Drawing.Point(20, 20);
            this.groupBoxAlumno.Name = "groupBoxAlumno";
            this.groupBoxAlumno.Size = new System.Drawing.Size(450, 200);
            this.groupBoxAlumno.TabIndex = 0;
            this.groupBoxAlumno.TabStop = false;
            this.groupBoxAlumno.Text = "Datos del Alumno";

            // ===== CONTROLES ALUMNO =====
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(20, 30);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";

            this.txtDNI.Location = new System.Drawing.Point(80, 27);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 1;

            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";

            this.txtNombre.Location = new System.Drawing.Point(80, 57);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;

            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(20, 90);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellidos:";

            this.txtApellidos.Location = new System.Drawing.Point(80, 87);
            this.txtApellidos.MaxLength = 100;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(200, 20);
            this.txtApellidos.TabIndex = 5;

            // ===== BOTONES ALUMNO =====
            this.btnInsertarAlumno.Location = new System.Drawing.Point(20, 130);
            this.btnInsertarAlumno.Name = "btnInsertarAlumno";
            this.btnInsertarAlumno.Size = new System.Drawing.Size(75, 25);
            this.btnInsertarAlumno.TabIndex = 6;
            this.btnInsertarAlumno.Text = "Insertar";
            this.btnInsertarAlumno.UseVisualStyleBackColor = true;
            this.btnInsertarAlumno.Click += new System.EventHandler(this.btnInsertarAlumno_Click);

            this.btnBuscarAlumno.Location = new System.Drawing.Point(105, 130);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarAlumno.TabIndex = 7;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);

            this.btnActualizarAlumno.Location = new System.Drawing.Point(190, 130);
            this.btnActualizarAlumno.Name = "btnActualizarAlumno";
            this.btnActualizarAlumno.Size = new System.Drawing.Size(75, 25);
            this.btnActualizarAlumno.TabIndex = 8;
            this.btnActualizarAlumno.Text = "Actualizar";
            this.btnActualizarAlumno.UseVisualStyleBackColor = true;
            this.btnActualizarAlumno.Click += new System.EventHandler(this.btnActualizarAlumno_Click);

            this.btnEliminarAlumno.Location = new System.Drawing.Point(275, 130);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(75, 25);
            this.btnEliminarAlumno.TabIndex = 9;
            this.btnEliminarAlumno.Text = "??? Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);

            this.btnLimpiarAlumno.Location = new System.Drawing.Point(360, 130);
            this.btnLimpiarAlumno.Name = "btnLimpiarAlumno";
            this.btnLimpiarAlumno.Size = new System.Drawing.Size(75, 25);
            this.btnLimpiarAlumno.TabIndex = 10;
            this.btnLimpiarAlumno.Text = "Limpiar";
            this.btnLimpiarAlumno.UseVisualStyleBackColor = true;
            this.btnLimpiarAlumno.Click += new System.EventHandler(this.btnLimpiarAlumno_Click);

            // ===== LISTA ALUMNOS =====
            this.lblListaAlumnos.AutoSize = true;
            this.lblListaAlumnos.Location = new System.Drawing.Point(500, 20);
            this.lblListaAlumnos.Name = "lblListaAlumnos";
            this.lblListaAlumnos.Size = new System.Drawing.Size(150, 13);
            this.lblListaAlumnos.TabIndex = 11;
            this.lblListaAlumnos.Text = "Lista de Alumnos (0 registros)";

            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(500, 40);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(450, 500);
            this.lstAlumnos.TabIndex = 12;
            this.lstAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstAlumnos_SelectedIndexChanged);

            // ===== TAB MATRICULAS =====
            this.tabMatriculas.Controls.Add(this.groupBoxMatricula);
            this.tabMatriculas.Controls.Add(this.lstMatriculas);
            this.tabMatriculas.Controls.Add(this.lblListaMatriculas);
            this.tabMatriculas.Location = new System.Drawing.Point(4, 22);
            this.tabMatriculas.Name = "tabMatriculas";
            this.tabMatriculas.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatriculas.Size = new System.Drawing.Size(992, 574);
            this.tabMatriculas.TabIndex = 1;
            this.tabMatriculas.Text = "?? Matrículas";
            this.tabMatriculas.UseVisualStyleBackColor = true;

            // ===== GRUPO MATRICULA =====
            this.groupBoxMatricula.Controls.Add(this.lblDNIMatricula);
            this.groupBoxMatricula.Controls.Add(this.txtDNIMatricula);
            this.groupBoxMatricula.Controls.Add(this.lblAsignatura);
            this.groupBoxMatricula.Controls.Add(this.cboAsignaturas);
            this.groupBoxMatricula.Controls.Add(this.btnMatricular);
            this.groupBoxMatricula.Controls.Add(this.lblNota);
            this.groupBoxMatricula.Controls.Add(this.txtNota);
            this.groupBoxMatricula.Controls.Add(this.btnActualizarNota);
            this.groupBoxMatricula.Controls.Add(this.btnEliminarMatricula);
            this.groupBoxMatricula.Location = new System.Drawing.Point(20, 20);
            this.groupBoxMatricula.Name = "groupBoxMatricula";
            this.groupBoxMatricula.Size = new System.Drawing.Size(450, 180);
            this.groupBoxMatricula.TabIndex = 0;
            this.groupBoxMatricula.TabStop = false;
            this.groupBoxMatricula.Text = "Gestión de Matrículas";

            // ===== CONTROLES MATRICULA =====
            this.lblDNIMatricula.AutoSize = true;
            this.lblDNIMatricula.Location = new System.Drawing.Point(20, 30);
            this.lblDNIMatricula.Name = "lblDNIMatricula";
            this.lblDNIMatricula.Size = new System.Drawing.Size(68, 13);
            this.lblDNIMatricula.TabIndex = 0;
            this.lblDNIMatricula.Text = "DNI Alumno:";

            this.txtDNIMatricula.Location = new System.Drawing.Point(100, 27);
            this.txtDNIMatricula.MaxLength = 9;
            this.txtDNIMatricula.Name = "txtDNIMatricula";
            this.txtDNIMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtDNIMatricula.TabIndex = 1;

            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(20, 60);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(61, 13);
            this.lblAsignatura.TabIndex = 2;
            this.lblAsignatura.Text = "Asignatura:";

            this.cboAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignaturas.FormattingEnabled = true;
            this.cboAsignaturas.Location = new System.Drawing.Point(100, 57);
            this.cboAsignaturas.Name = "cboAsignaturas";
            this.cboAsignaturas.Size = new System.Drawing.Size(300, 21);
            this.cboAsignaturas.TabIndex = 3;

            this.btnMatricular.Location = new System.Drawing.Point(20, 90);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(100, 25);
            this.btnMatricular.TabIndex = 4;
            this.btnMatricular.Text = "?? Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);

            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(250, 30);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 13);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "Nota:";

            this.txtNota.Location = new System.Drawing.Point(290, 27);
            this.txtNota.MaxLength = 4;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(50, 20);
            this.txtNota.TabIndex = 6;

            this.btnActualizarNota.Location = new System.Drawing.Point(130, 90);
            this.btnActualizarNota.Name = "btnActualizarNota";
            this.btnActualizarNota.Size = new System.Drawing.Size(100, 25);
            this.btnActualizarNota.TabIndex = 7;
            this.btnActualizarNota.Text = "?? Actualizar Nota";
            this.btnActualizarNota.UseVisualStyleBackColor = true;
            this.btnActualizarNota.Click += new System.EventHandler(this.btnActualizarNota_Click);

            this.btnEliminarMatricula.Location = new System.Drawing.Point(240, 90);
            this.btnEliminarMatricula.Name = "btnEliminarMatricula";
            this.btnEliminarMatricula.Size = new System.Drawing.Size(100, 25);
            this.btnEliminarMatricula.TabIndex = 8;
            this.btnEliminarMatricula.Text = "??? Eliminar";
            this.btnEliminarMatricula.UseVisualStyleBackColor = true;
            this.btnEliminarMatricula.Click += new System.EventHandler(this.btnEliminarMatricula_Click);

            // ===== LISTA MATRICULAS =====
            this.lblListaMatriculas.AutoSize = true;
            this.lblListaMatriculas.Location = new System.Drawing.Point(500, 20);
            this.lblListaMatriculas.Name = "lblListaMatriculas";
            this.lblListaMatriculas.Size = new System.Drawing.Size(160, 13);
            this.lblListaMatriculas.TabIndex = 9;
            this.lblListaMatriculas.Text = "Lista de Matrículas (0 registros)";

            this.lstMatriculas.FormattingEnabled = true;
            this.lstMatriculas.Location = new System.Drawing.Point(500, 40);
            this.lstMatriculas.Name = "lstMatriculas";
            this.lstMatriculas.Size = new System.Drawing.Size(450, 500);
            this.lstMatriculas.TabIndex = 10;
            this.lstMatriculas.SelectedIndexChanged += new System.EventHandler(this.lstMatriculas_SelectedIndexChanged);

            // ===== TAB INTEGRIDAD REFERENCIAL =====
            this.tabIntegridad.Controls.Add(this.lblIntegridad);
            this.tabIntegridad.Controls.Add(this.btnProbarIntegridad);
            this.tabIntegridad.Controls.Add(this.txtResultadoIntegridad);
            this.tabIntegridad.Controls.Add(this.lblExplicacion);
            this.tabIntegridad.Location = new System.Drawing.Point(4, 22);
            this.tabIntegridad.Name = "tabIntegridad";
            this.tabIntegridad.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntegridad.Size = new System.Drawing.Size(992, 574);
            this.tabIntegridad.TabIndex = 2;
            this.tabIntegridad.Text = "?? Integridad Referencial";
            this.tabIntegridad.UseVisualStyleBackColor = true;

            // ===== CONTROLES INTEGRIDAD =====
            this.lblIntegridad.AutoSize = true;
            this.lblIntegridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIntegridad.Location = new System.Drawing.Point(20, 20);
            this.lblIntegridad.Name = "lblIntegridad";
            this.lblIntegridad.Size = new System.Drawing.Size(350, 20);
            this.lblIntegridad.TabIndex = 0;
            this.lblIntegridad.Text = "?? Demostración de Integridad Referencial";

            this.lblExplicacion.AutoSize = true;
            this.lblExplicacion.Location = new System.Drawing.Point(20, 60);
            this.lblExplicacion.Name = "lblExplicacion";
            this.lblExplicacion.Size = new System.Drawing.Size(800, 65);
            this.lblExplicacion.TabIndex = 1;
            this.lblExplicacion.Text = "La integridad referencial protege la consistencia de los datos:\n\n" +
                                      "• No se puede eliminar un alumno que tenga matrículas asociadas\n" +
                                      "• No se puede matricular un alumno que no existe\n" +
                                      "• No se puede matricular en una asignatura que no existe\n" +
                                      "• No se puede matricular dos veces en la misma asignatura";

            this.btnProbarIntegridad.Location = new System.Drawing.Point(20, 150);
            this.btnProbarIntegridad.Name = "btnProbarIntegridad";
            this.btnProbarIntegridad.Size = new System.Drawing.Size(200, 30);
            this.btnProbarIntegridad.TabIndex = 2;
            this.btnProbarIntegridad.Text = "?? Probar Integridad Referencial";
            this.btnProbarIntegridad.UseVisualStyleBackColor = true;
            this.btnProbarIntegridad.Click += new System.EventHandler(this.btnProbarIntegridad_Click);

            this.txtResultadoIntegridad.Location = new System.Drawing.Point(20, 200);
            this.txtResultadoIntegridad.Multiline = true;
            this.txtResultadoIntegridad.Name = "txtResultadoIntegridad";
            this.txtResultadoIntegridad.ReadOnly = true;
            this.txtResultadoIntegridad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultadoIntegridad.Size = new System.Drawing.Size(950, 350);
            this.txtResultadoIntegridad.TabIndex = 3;

            // ===== CONFIGURACIÓN PRINCIPAL DEL FORMULARIO =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 624);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "?? Actividad 7 - Tablas Relacionadas e Integridad Referencial";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabControl.ResumeLayout(false);
            this.tabAlumnos.ResumeLayout(false);
            this.tabAlumnos.PerformLayout();
            this.groupBoxAlumno.ResumeLayout(false);
            this.groupBoxAlumno.PerformLayout();
            this.tabMatriculas.ResumeLayout(false);
            this.tabMatriculas.PerformLayout();
            this.groupBoxMatricula.ResumeLayout(false);
            this.groupBoxMatricula.PerformLayout();
            this.tabIntegridad.ResumeLayout(false);
            this.tabIntegridad.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // ===== CONTROLES DECLARADOS =====
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAlumnos;
        private System.Windows.Forms.TabPage tabMatriculas;
        private System.Windows.Forms.TabPage tabIntegridad;

        // TAB ALUMNOS
        private System.Windows.Forms.GroupBox groupBoxAlumno;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnInsertarAlumno;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Button btnActualizarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnLimpiarAlumno;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Label lblListaAlumnos;

        // TAB MATRICULAS
        private System.Windows.Forms.GroupBox groupBoxMatricula;
        private System.Windows.Forms.Label lblDNIMatricula;
        private System.Windows.Forms.TextBox txtDNIMatricula;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.ComboBox cboAsignaturas;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnActualizarNota;
        private System.Windows.Forms.Button btnEliminarMatricula;
        private System.Windows.Forms.ListBox lstMatriculas;
        private System.Windows.Forms.Label lblListaMatriculas;

        // TAB INTEGRIDAD
        private System.Windows.Forms.Label lblIntegridad;
        private System.Windows.Forms.Button btnProbarIntegridad;
        private System.Windows.Forms.TextBox txtResultadoIntegridad;
        private System.Windows.Forms.Label lblExplicacion;
    }
}