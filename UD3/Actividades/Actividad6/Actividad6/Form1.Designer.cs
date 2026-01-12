namespace Actividad6
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
            this.btnMostrarListaActualizada = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtListaAlumnos = new System.Windows.Forms.TextBox();
            this.btnInsertarAlumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.btnActualizarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            
            // ===== LISTBOX CON Items.Add() =====
            this.lstAlumnosItemsAdd = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeleccionarItemsAdd = new System.Windows.Forms.Button();
            this.btnCargarItemsAdd = new System.Windows.Forms.Button();
            
            // ===== LISTBOX CON DataSource =====
            this.lstAlumnosDataSource = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSeleccionarDataSource = new System.Windows.Forms.Button();
            this.btnCargarDataSource = new System.Windows.Forms.Button();
            
            // ===== LABELS EXPLICATIVOS =====
            this.lblExplicacionItemsAdd = new System.Windows.Forms.Label();
            this.lblExplicacionDataSource = new System.Windows.Forms.Label();
            
            this.SuspendLayout();
            
            // 
            // btnMostrarListaActualizada
            // 
            this.btnMostrarListaActualizada.Location = new System.Drawing.Point(950, 344);
            this.btnMostrarListaActualizada.Name = "btnMostrarListaActualizada";
            this.btnMostrarListaActualizada.Size = new System.Drawing.Size(132, 23);
            this.btnMostrarListaActualizada.TabIndex = 19;
            this.btnMostrarListaActualizada.Text = "Actualizar Lista Texto";
            this.btnMostrarListaActualizada.UseVisualStyleBackColor = true;
            this.btnMostrarListaActualizada.Click += new System.EventHandler(this.btnMostrarListaActualizada_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(950, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lista alumnos (Texto)";
            // 
            // txtListaAlumnos
            // 
            this.txtListaAlumnos.Location = new System.Drawing.Point(850, 98);
            this.txtListaAlumnos.Multiline = true;
            this.txtListaAlumnos.Name = "txtListaAlumnos";
            this.txtListaAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaAlumnos.Size = new System.Drawing.Size(281, 206);
            this.txtListaAlumnos.TabIndex = 17;
            this.txtListaAlumnos.ReadOnly = true;
            // 
            // btnInsertarAlumno
            // 
            this.btnInsertarAlumno.Location = new System.Drawing.Point(98, 250);
            this.btnInsertarAlumno.Name = "btnInsertarAlumno";
            this.btnInsertarAlumno.Size = new System.Drawing.Size(80, 30);
            this.btnInsertarAlumno.TabIndex = 16;
            this.btnInsertarAlumno.Text = "Insertar";
            this.btnInsertarAlumno.UseVisualStyleBackColor = true;
            this.btnInsertarAlumno.Click += new System.EventHandler(this.btnInsertarAlumno_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "DNI";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(166, 174);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(200, 20);
            this.txtApellidos.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 139);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(166, 102);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 10;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(184, 250);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(80, 30);
            this.btnBuscarAlumno.TabIndex = 20;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // btnActualizarAlumno
            // 
            this.btnActualizarAlumno.Location = new System.Drawing.Point(270, 250);
            this.btnActualizarAlumno.Name = "btnActualizarAlumno";
            this.btnActualizarAlumno.Size = new System.Drawing.Size(80, 30);
            this.btnActualizarAlumno.TabIndex = 21;
            this.btnActualizarAlumno.Text = "Actualizar";
            this.btnActualizarAlumno.UseVisualStyleBackColor = true;
            this.btnActualizarAlumno.Click += new System.EventHandler(this.btnActualizarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(98, 290);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(80, 30);
            this.btnEliminarAlumno.TabIndex = 22;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(184, 290);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // ===== LISTBOX CON Items.Add() =====
            // 
            // lblExplicacionItemsAdd
            // 
            this.lblExplicacionItemsAdd.AutoSize = true;
            this.lblExplicacionItemsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExplicacionItemsAdd.ForeColor = System.Drawing.Color.Blue;
            this.lblExplicacionItemsAdd.Location = new System.Drawing.Point(400, 50);
            this.lblExplicacionItemsAdd.Name = "lblExplicacionItemsAdd";
            this.lblExplicacionItemsAdd.Size = new System.Drawing.Size(200, 13);
            this.lblExplicacionItemsAdd.TabIndex = 30;
            this.lblExplicacionItemsAdd.Text = "?? MÉTODO 1: Items.Add() - Manual";
            // 
            // lstAlumnosItemsAdd
            // 
            this.lstAlumnosItemsAdd.FormattingEnabled = true;
            this.lstAlumnosItemsAdd.Location = new System.Drawing.Point(400, 98);
            this.lstAlumnosItemsAdd.Name = "lstAlumnosItemsAdd";
            this.lstAlumnosItemsAdd.Size = new System.Drawing.Size(200, 206);
            this.lstAlumnosItemsAdd.TabIndex = 24;
            this.lstAlumnosItemsAdd.SelectedIndexChanged += new System.EventHandler(this.lstAlumnosItemsAdd_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Items.Add - 0 elementos";
            // 
            // btnSeleccionarItemsAdd
            // 
            this.btnSeleccionarItemsAdd.Location = new System.Drawing.Point(400, 320);
            this.btnSeleccionarItemsAdd.Name = "btnSeleccionarItemsAdd";
            this.btnSeleccionarItemsAdd.Size = new System.Drawing.Size(90, 30);
            this.btnSeleccionarItemsAdd.TabIndex = 26;
            this.btnSeleccionarItemsAdd.Text = "Seleccionar";
            this.btnSeleccionarItemsAdd.UseVisualStyleBackColor = true;
            this.btnSeleccionarItemsAdd.Click += new System.EventHandler(this.btnSeleccionarItemsAdd_Click);
            // 
            // btnCargarItemsAdd
            // 
            this.btnCargarItemsAdd.Location = new System.Drawing.Point(510, 320);
            this.btnCargarItemsAdd.Name = "btnCargarItemsAdd";
            this.btnCargarItemsAdd.Size = new System.Drawing.Size(90, 30);
            this.btnCargarItemsAdd.TabIndex = 27;
            this.btnCargarItemsAdd.Text = "?? Recargar";
            this.btnCargarItemsAdd.UseVisualStyleBackColor = true;
            this.btnCargarItemsAdd.Click += new System.EventHandler(this.btnCargarItemsAdd_Click);

            // ===== LISTBOX CON DataSource =====
            // 
            // lblExplicacionDataSource
            // 
            this.lblExplicacionDataSource.AutoSize = true;
            this.lblExplicacionDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExplicacionDataSource.ForeColor = System.Drawing.Color.Green;
            this.lblExplicacionDataSource.Location = new System.Drawing.Point(620, 50);
            this.lblExplicacionDataSource.Name = "lblExplicacionDataSource";
            this.lblExplicacionDataSource.Size = new System.Drawing.Size(220, 13);
            this.lblExplicacionDataSource.TabIndex = 31;
            this.lblExplicacionDataSource.Text = "? MÉTODO 2: DataSource - Automático";
            // 
            // lstAlumnosDataSource
            // 
            this.lstAlumnosDataSource.FormattingEnabled = true;
            this.lstAlumnosDataSource.Location = new System.Drawing.Point(620, 98);
            this.lstAlumnosDataSource.Name = "lstAlumnosDataSource";
            this.lstAlumnosDataSource.Size = new System.Drawing.Size(200, 206);
            this.lstAlumnosDataSource.TabIndex = 28;
            this.lstAlumnosDataSource.SelectedIndexChanged += new System.EventHandler(this.lstAlumnosDataSource_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "DataSource - 0 elementos";
            // 
            // btnSeleccionarDataSource
            // 
            this.btnSeleccionarDataSource.Location = new System.Drawing.Point(620, 320);
            this.btnSeleccionarDataSource.Name = "btnSeleccionarDataSource";
            this.btnSeleccionarDataSource.Size = new System.Drawing.Size(90, 30);
            this.btnSeleccionarDataSource.TabIndex = 32;
            this.btnSeleccionarDataSource.Text = "Seleccionar";
            this.btnSeleccionarDataSource.UseVisualStyleBackColor = true;
            this.btnSeleccionarDataSource.Click += new System.EventHandler(this.btnSeleccionarDataSource_Click);
            // 
            // btnCargarDataSource
            // 
            this.btnCargarDataSource.Location = new System.Drawing.Point(730, 320);
            this.btnCargarDataSource.Name = "btnCargarDataSource";
            this.btnCargarDataSource.Size = new System.Drawing.Size(90, 30);
            this.btnCargarDataSource.TabIndex = 33;
            this.btnCargarDataSource.Text = "? Recargar";
            this.btnCargarDataSource.UseVisualStyleBackColor = true;
            this.btnCargarDataSource.Click += new System.EventHandler(this.btnCargarDataSource_Click);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.btnCargarDataSource);
            this.Controls.Add(this.btnSeleccionarDataSource);
            this.Controls.Add(this.lblExplicacionDataSource);
            this.Controls.Add(this.lblExplicacionItemsAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstAlumnosDataSource);
            this.Controls.Add(this.btnCargarItemsAdd);
            this.Controls.Add(this.btnSeleccionarItemsAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstAlumnosItemsAdd);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnActualizarAlumno);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.btnMostrarListaActualizada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtListaAlumnos);
            this.Controls.Add(this.btnInsertarAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Name = "Form1";
            this.Text = "Actividad 6 - ?? Items.Add() vs ? DataSource - Comparación Práctica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarListaActualizada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtListaAlumnos;
        private System.Windows.Forms.Button btnInsertarAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Button btnActualizarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnLimpiar;
        
        // MÉTODO 1: Items.Add()
        private System.Windows.Forms.ListBox lstAlumnosItemsAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeleccionarItemsAdd;
        private System.Windows.Forms.Button btnCargarItemsAdd;
        private System.Windows.Forms.Label lblExplicacionItemsAdd;
        
        // MÉTODO 2: DataSource
        private System.Windows.Forms.ListBox lstAlumnosDataSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSeleccionarDataSource;
        private System.Windows.Forms.Button btnCargarDataSource;
        private System.Windows.Forms.Label lblExplicacionDataSource;
    }
}