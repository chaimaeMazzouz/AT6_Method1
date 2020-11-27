namespace gestionCompagnieVoyage
{
    partial class voyage_Ajout
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textNbre_Voyageurs = new System.Windows.Forms.TextBox();
            this.textVille_Depart = new System.Windows.Forms.TextBox();
            this.textVille_Arrive = new System.Windows.Forms.TextBox();
            this.textDuree = new System.Windows.Forms.TextBox();
            this.textPlace_libre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textTarif = new System.Windows.Forms.TextBox();
            this.comboID_chauffeur = new System.Windows.Forms.ComboBox();
            this.comboImmatricule = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(502, 281);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 26;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // textNbre_Voyageurs
            // 
            this.textNbre_Voyageurs.Location = new System.Drawing.Point(164, 281);
            this.textNbre_Voyageurs.Name = "textNbre_Voyageurs";
            this.textNbre_Voyageurs.Size = new System.Drawing.Size(194, 20);
            this.textNbre_Voyageurs.TabIndex = 24;
            // 
            // textVille_Depart
            // 
            this.textVille_Depart.Location = new System.Drawing.Point(164, 161);
            this.textVille_Depart.Name = "textVille_Depart";
            this.textVille_Depart.Size = new System.Drawing.Size(194, 20);
            this.textVille_Depart.TabIndex = 22;
            // 
            // textVille_Arrive
            // 
            this.textVille_Arrive.Location = new System.Drawing.Point(164, 200);
            this.textVille_Arrive.Name = "textVille_Arrive";
            this.textVille_Arrive.Size = new System.Drawing.Size(194, 20);
            this.textVille_Arrive.TabIndex = 23;
            // 
            // textDuree
            // 
            this.textDuree.Location = new System.Drawing.Point(164, 239);
            this.textDuree.Name = "textDuree";
            this.textDuree.Size = new System.Drawing.Size(194, 20);
            this.textDuree.TabIndex = 21;
            // 
            // textPlace_libre
            // 
            this.textPlace_libre.Location = new System.Drawing.Point(578, 122);
            this.textPlace_libre.Name = "textPlace_libre";
            this.textPlace_libre.Size = new System.Drawing.Size(194, 20);
            this.textPlace_libre.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nbre_Voyageurs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Duree";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ville_Arrive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ville_Depart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date_Voyage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(322, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ajout voyage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Place_libre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tarif";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "ID_chauffeur";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Immatricule";
            // 
            // textTarif
            // 
            this.textTarif.Location = new System.Drawing.Point(578, 162);
            this.textTarif.Name = "textTarif";
            this.textTarif.Size = new System.Drawing.Size(194, 20);
            this.textTarif.TabIndex = 32;
            // 
            // comboID_chauffeur
            // 
            this.comboID_chauffeur.FormattingEnabled = true;
            this.comboID_chauffeur.Location = new System.Drawing.Point(578, 199);
            this.comboID_chauffeur.Name = "comboID_chauffeur";
            this.comboID_chauffeur.Size = new System.Drawing.Size(194, 21);
            this.comboID_chauffeur.TabIndex = 33;
            // 
            // comboImmatricule
            // 
            this.comboImmatricule.FormattingEnabled = true;
            this.comboImmatricule.Location = new System.Drawing.Point(578, 231);
            this.comboImmatricule.Name = "comboImmatricule";
            this.comboImmatricule.Size = new System.Drawing.Size(194, 21);
            this.comboImmatricule.TabIndex = 34;
            // 
            // voyage_Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.comboImmatricule);
            this.Controls.Add(this.comboID_chauffeur);
            this.Controls.Add(this.textTarif);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textNbre_Voyageurs);
            this.Controls.Add(this.textVille_Depart);
            this.Controls.Add(this.textVille_Arrive);
            this.Controls.Add(this.textDuree);
            this.Controls.Add(this.textPlace_libre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "voyage_Ajout";
            this.Text = "voyage_Ajout";
            this.Load += new System.EventHandler(this.voyage_Ajout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textNbre_Voyageurs;
        private System.Windows.Forms.TextBox textVille_Depart;
        private System.Windows.Forms.TextBox textVille_Arrive;
        private System.Windows.Forms.TextBox textDuree;
        private System.Windows.Forms.TextBox textPlace_libre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textTarif;
        private System.Windows.Forms.ComboBox comboID_chauffeur;
        private System.Windows.Forms.ComboBox comboImmatricule;
    }
}