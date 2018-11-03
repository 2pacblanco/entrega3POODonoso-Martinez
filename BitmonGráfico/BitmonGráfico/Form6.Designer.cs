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
            this.Atacar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listStatsAtaques = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listAtaques
            // 
            this.listAtaques.FormattingEnabled = true;
            this.listAtaques.Location = new System.Drawing.Point(47, 73);
            this.listAtaques.Name = "listAtaques";
            this.listAtaques.Size = new System.Drawing.Size(121, 147);
            this.listAtaques.TabIndex = 0;
            this.listAtaques.SelectedIndexChanged += new System.EventHandler(this.listAtaques_SelectedIndexChanged);
            // 
            // Atacar
            // 
            this.Atacar.Location = new System.Drawing.Point(213, 306);
            this.Atacar.Name = "Atacar";
            this.Atacar.Size = new System.Drawing.Size(75, 23);
            this.Atacar.TabIndex = 1;
            this.Atacar.Text = "Usar Ataque";
            this.Atacar.UseVisualStyleBackColor = true;
            this.Atacar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Solo seleccione el nonmbre del ataque, en la parte izquierda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listStatsAtaques
            // 
            this.listStatsAtaques.FormattingEnabled = true;
            this.listStatsAtaques.Location = new System.Drawing.Point(174, 73);
            this.listStatsAtaques.Name = "listStatsAtaques";
            this.listStatsAtaques.Size = new System.Drawing.Size(199, 147);
            this.listStatsAtaques.TabIndex = 3;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 421);
            this.Controls.Add(this.listStatsAtaques);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Atacar);
            this.Controls.Add(this.listAtaques);
            this.Name = "Form6";
            this.Text = "form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAtaques;
        private System.Windows.Forms.Button Atacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listStatsAtaques;
    }
}