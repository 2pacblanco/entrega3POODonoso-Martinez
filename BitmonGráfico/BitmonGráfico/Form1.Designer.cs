namespace BitmonGráfico
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_NameP1 = new System.Windows.Forms.TextBox();
            this.tb_NameP2 = new System.Windows.Forms.TextBox();
            this.bt_ALuchar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitmon Stadium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ingrese el nombre de el jugador 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ingrese el nombre de el jugador 2";
            // 
            // tb_NameP1
            // 
            this.tb_NameP1.Location = new System.Drawing.Point(320, 164);
            this.tb_NameP1.Multiline = true;
            this.tb_NameP1.Name = "tb_NameP1";
            this.tb_NameP1.Size = new System.Drawing.Size(245, 17);
            this.tb_NameP1.TabIndex = 3;
            
            // 
            // tb_NameP2
            // 
            this.tb_NameP2.Location = new System.Drawing.Point(320, 226);
            this.tb_NameP2.Name = "tb_NameP2";
            this.tb_NameP2.Size = new System.Drawing.Size(245, 20);
            this.tb_NameP2.TabIndex = 4;
            // 
            // bt_ALuchar
            // 
            this.bt_ALuchar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ALuchar.Location = new System.Drawing.Point(595, 280);
            this.bt_ALuchar.Name = "bt_ALuchar";
            this.bt_ALuchar.Size = new System.Drawing.Size(141, 52);
            this.bt_ALuchar.TabIndex = 5;
            this.bt_ALuchar.Text = "A Luchar!!";
            this.bt_ALuchar.UseVisualStyleBackColor = true;
            this.bt_ALuchar.Click += new System.EventHandler(this.bt_ALuchar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(772, 354);
            this.Controls.Add(this.bt_ALuchar);
            this.Controls.Add(this.tb_NameP2);
            this.Controls.Add(this.tb_NameP1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_NameP1;
        private System.Windows.Forms.TextBox tb_NameP2;
        private System.Windows.Forms.Button bt_ALuchar;
    }
}

