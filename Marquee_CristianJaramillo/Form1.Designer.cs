namespace Marquee_CristianJaramillo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Salir = new System.Windows.Forms.Button();
            this.Terminar = new System.Windows.Forms.Button();
            this.Reanudar = new System.Windows.Forms.Button();
            this.Pausa = new System.Windows.Forms.Button();
            this.Iniciar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Salir
            // 
            resources.ApplyResources(this.Salir, "Salir");
            this.Salir.Name = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Terminar
            // 
            resources.ApplyResources(this.Terminar, "Terminar");
            this.Terminar.Name = "Terminar";
            this.Terminar.UseVisualStyleBackColor = true;
            this.Terminar.Click += new System.EventHandler(this.Terminar_Click);
            // 
            // Reanudar
            // 
            resources.ApplyResources(this.Reanudar, "Reanudar");
            this.Reanudar.Name = "Reanudar";
            this.Reanudar.UseVisualStyleBackColor = true;
            this.Reanudar.Click += new System.EventHandler(this.Reanudar_Click);
            // 
            // Pausa
            // 
            resources.ApplyResources(this.Pausa, "Pausa");
            this.Pausa.Name = "Pausa";
            this.Pausa.UseVisualStyleBackColor = true;
            this.Pausa.Click += new System.EventHandler(this.Pausa_Click);
            // 
            // Iniciar
            // 
            resources.ApplyResources(this.Iniciar, "Iniciar");
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Terminar);
            this.Controls.Add(this.Reanudar);
            this.Controls.Add(this.Pausa);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Terminar;
        private System.Windows.Forms.Button Reanudar;
        private System.Windows.Forms.Button Pausa;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

