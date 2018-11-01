namespace BitmonGráfico
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListaBits = new System.Windows.Forms.ComboBox();
            this.BotonJugador1Agregar = new System.Windows.Forms.Button();
            this.BotonJugador2Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliga un Bitmon para su equipo!";
            // 
            // ListaBits
            // 
            this.ListaBits.FormattingEnabled = true;
            this.ListaBits.Location = new System.Drawing.Point(37, 56);
            this.ListaBits.Name = "ListaBits";
            this.ListaBits.Size = new System.Drawing.Size(725, 21);
            this.ListaBits.TabIndex = 1;
            this.ListaBits.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BotonJugador1Agregar
            // 
            this.BotonJugador1Agregar.Location = new System.Drawing.Point(214, 152);
            this.BotonJugador1Agregar.Name = "BotonJugador1Agregar";
            this.BotonJugador1Agregar.Size = new System.Drawing.Size(101, 55);
            this.BotonJugador1Agregar.TabIndex = 2;
            this.BotonJugador1Agregar.Text = "Agregar a Equipo \nde "+Form1.nombre1;
            this.BotonJugador1Agregar.UseVisualStyleBackColor = true;
            this.BotonJugador1Agregar.Click += new System.EventHandler(this.BotonJugador1Agregar_Click);
            // 
            // BotonJugador2Agregar
            // 
            this.BotonJugador2Agregar.Location = new System.Drawing.Point(478, 152);
            this.BotonJugador2Agregar.Name = "BotonJugador2Agregar";
            this.BotonJugador2Agregar.Size = new System.Drawing.Size(101, 55);
            this.BotonJugador2Agregar.TabIndex = 3;
            this.BotonJugador2Agregar.Text = "Agregar a Equipo \nde "+Form1.nombre2;
            this.BotonJugador2Agregar.UseVisualStyleBackColor = true;
            this.BotonJugador2Agregar.Click += new System.EventHandler(this.BotonJugador2Agregar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonJugador2Agregar);
            this.Controls.Add(this.BotonJugador1Agregar);
            this.Controls.Add(this.ListaBits);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListaBits;
        private System.Windows.Forms.Button BotonJugador1Agregar;
        private System.Windows.Forms.Button BotonJugador2Agregar;
    }
}