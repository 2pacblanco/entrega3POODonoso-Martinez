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
            this.label1 = new System.Windows.Forms.Label();
            this.BotonAtacar = new System.Windows.Forms.Button();
            this.labelATK1 = new System.Windows.Forms.Label();
            this.labelATK2 = new System.Windows.Forms.Label();
            this.labelATK3 = new System.Windows.Forms.Label();
            this.labelATK4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listAtaques
            // 
            this.listAtaques.FormattingEnabled = true;
            this.listAtaques.Location = new System.Drawing.Point(54, 74);
            this.listAtaques.Name = "listAtaques";
            this.listAtaques.Size = new System.Drawing.Size(145, 134);
            this.listAtaques.TabIndex = 0;
            this.listAtaques.SelectedIndexChanged += new System.EventHandler(this.listAtaques_SelectedIndexChanged);
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
            // BotonAtacar
            // 
            this.BotonAtacar.Location = new System.Drawing.Point(285, 305);
            this.BotonAtacar.Name = "BotonAtacar";
            this.BotonAtacar.Size = new System.Drawing.Size(75, 23);
            this.BotonAtacar.TabIndex = 1;
            this.BotonAtacar.Text = "Usar Ataque";
            this.BotonAtacar.UseVisualStyleBackColor = true;
            this.BotonAtacar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelATK1
            // 
            this.labelATK1.AutoSize = true;
            this.labelATK1.Location = new System.Drawing.Point(205, 74);
            this.labelATK1.Name = "labelATK1";
            this.labelATK1.Size = new System.Drawing.Size(71, 13);
            this.labelATK1.TabIndex = 3;
            this.labelATK1.Text = "stats ataque1";
            this.labelATK1.Click += new System.EventHandler(this.labelATK1_Click);
            // 
            // labelATK2
            // 
            this.labelATK2.AutoSize = true;
            this.labelATK2.Location = new System.Drawing.Point(205, 87);
            this.labelATK2.Name = "labelATK2";
            this.labelATK2.Size = new System.Drawing.Size(71, 13);
            this.labelATK2.TabIndex = 4;
            this.labelATK2.Text = "stats ataque2";
            // 
            // labelATK3
            // 
            this.labelATK3.AutoSize = true;
            this.labelATK3.Location = new System.Drawing.Point(205, 100);
            this.labelATK3.Name = "labelATK3";
            this.labelATK3.Size = new System.Drawing.Size(71, 13);
            this.labelATK3.TabIndex = 5;
            this.labelATK3.Text = "stats ataque3";
            // 
            // labelATK4
            // 
            this.labelATK4.AutoSize = true;
            this.labelATK4.Location = new System.Drawing.Point(205, 113);
            this.labelATK4.Name = "labelATK4";
            this.labelATK4.Size = new System.Drawing.Size(71, 13);
            this.labelATK4.TabIndex = 6;
            this.labelATK4.Text = "stats ataque4";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelATK4);
            this.Controls.Add(this.labelATK3);
            this.Controls.Add(this.labelATK2);
            this.Controls.Add(this.labelATK1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonAtacar;
        private System.Windows.Forms.Label labelATK1;
        private System.Windows.Forms.Label labelATK2;
        private System.Windows.Forms.Label labelATK3;
        private System.Windows.Forms.Label labelATK4;
    }
}