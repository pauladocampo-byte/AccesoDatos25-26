
namespace Actividad2
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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertarAlumno = new System.Windows.Forms.Button();
            this.txtListaAlumnos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrarListaActualizada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(158, 69);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(158, 141);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // btnInsertarAlumno
            // 
            this.btnInsertarAlumno.Location = new System.Drawing.Point(132, 311);
            this.btnInsertarAlumno.Name = "btnInsertarAlumno";
            this.btnInsertarAlumno.Size = new System.Drawing.Size(91, 23);
            this.btnInsertarAlumno.TabIndex = 6;
            this.btnInsertarAlumno.Text = "Insertar alumno";
            this.btnInsertarAlumno.UseVisualStyleBackColor = true;
            this.btnInsertarAlumno.Click += new System.EventHandler(this.btnInsertarAlumno_Click);
            // 
            // txtListaAlumnos
            // 
            this.txtListaAlumnos.Location = new System.Drawing.Point(415, 65);
            this.txtListaAlumnos.Multiline = true;
            this.txtListaAlumnos.Name = "txtListaAlumnos";
            this.txtListaAlumnos.Size = new System.Drawing.Size(281, 206);
            this.txtListaAlumnos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lista alumnos";
            // 
            // btnMostrarListaActualizada
            // 
            this.btnMostrarListaActualizada.Location = new System.Drawing.Point(498, 311);
            this.btnMostrarListaActualizada.Name = "btnMostrarListaActualizada";
            this.btnMostrarListaActualizada.Size = new System.Drawing.Size(132, 23);
            this.btnMostrarListaActualizada.TabIndex = 9;
            this.btnMostrarListaActualizada.Text = "Mostrar lista actualizada";
            this.btnMostrarListaActualizada.UseVisualStyleBackColor = true;
            this.btnMostrarListaActualizada.Click += new System.EventHandler(this.btnMostrarListaActualizada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertarAlumno;
        private System.Windows.Forms.TextBox txtListaAlumnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarListaActualizada;
    }
}

