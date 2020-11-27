namespace gestionCompagnieVoyage
{
    partial class Nombre_de_lignes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNbChauffeurs = new System.Windows.Forms.TextBox();
            this.textNbVehicules = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNbVoyages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNbBillets = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(49, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Statistique base de données";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre de Chauffeurs";
            // 
            // txtNbChauffeurs
            // 
            this.txtNbChauffeurs.Location = new System.Drawing.Point(195, 88);
            this.txtNbChauffeurs.Name = "txtNbChauffeurs";
            this.txtNbChauffeurs.Size = new System.Drawing.Size(52, 20);
            this.txtNbChauffeurs.TabIndex = 2;
            // 
            // textNbVehicules
            // 
            this.textNbVehicules.Location = new System.Drawing.Point(195, 130);
            this.textNbVehicules.Name = "textNbVehicules";
            this.textNbVehicules.Size = new System.Drawing.Size(52, 20);
            this.textNbVehicules.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre de Véhicules";
            // 
            // textNbVoyages
            // 
            this.textNbVoyages.Location = new System.Drawing.Point(195, 172);
            this.textNbVoyages.Name = "textNbVoyages";
            this.textNbVoyages.Size = new System.Drawing.Size(52, 20);
            this.textNbVoyages.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre de Voyages";
            // 
            // textNbBillets
            // 
            this.textNbBillets.Location = new System.Drawing.Point(195, 225);
            this.textNbBillets.Name = "textNbBillets";
            this.textNbBillets.Size = new System.Drawing.Size(52, 20);
            this.textNbBillets.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre de Billets";
            // 
            // Nombre_de_lignes
            // 
            this.ClientSize = new System.Drawing.Size(394, 305);
            this.Controls.Add(this.textNbBillets);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNbVoyages);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNbVehicules);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNbChauffeurs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Nombre_de_lignes";
            this.Load += new System.EventHandler(this.Nombre_de_lignes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNbChauffeurs;
        private System.Windows.Forms.TextBox textNbVehicules;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNbVoyages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNbBillets;
        private System.Windows.Forms.Label label7;
    }
}