namespace BitmonGráfico
{
    partial class Form6
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
            this.listAtaques = new System.Windows.Forms.ListBox();
            this.BotonAtacar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listAtaques
            // 
            this.listAtaques.FormattingEnabled = true;
            this.listAtaques.Location = new System.Drawing.Point(236, 89);
            this.listAtaques.Name = "listAtaques";
            this.listAtaques.Size = new System.Drawing.Size(379, 186);
            this.listAtaques.TabIndex = 0;
            this.listAtaques.SelectedIndexChanged += new System.EventHandler(this.listAtaques_SelectedIndexChanged);
            // 
            // BotonAtacar
            // 
            this.BotonAtacar.Location = new System.Drawing.Point(236, 315);
            this.BotonAtacar.Name = "BotonAtacar";
            this.BotonAtacar.Size = new System.Drawing.Size(75, 23);
            this.BotonAtacar.TabIndex = 1;
            this.BotonAtacar.Text = "Usar Ataque";
            this.BotonAtacar.UseVisualStyleBackColor = true;
            this.BotonAtacar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el ataque y use el boton";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonAtacar);
            this.Controls.Add(this.listAtaques);
            this.Name = "Form6";
            this.Text = "form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAtaques;
        private System.Windows.Forms.Button BotonAtacar;
        private System.Windows.Forms.Label label1;
    }
}