namespace gestionCompagnieVoyage
{
    partial class Vehicules_liste
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
            this.btnAfficher_vehicules = new System.Windows.Forms.Button();
            this.dGV_Vehicule = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Vehicule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(201, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informations Véhicules";
            // 
            // btnAfficher_vehicules
            // 
            this.btnAfficher_vehicules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficher_vehicules.Location = new System.Drawing.Point(241, 323);
            this.btnAfficher_vehicules.Name = "btnAfficher_vehicules";
            this.btnAfficher_vehicules.Size = new System.Drawing.Size(98, 35);
            this.btnAfficher_vehicules.TabIndex = 6;
            this.btnAfficher_vehicules.Text = "Afficher";
            this.btnAfficher_vehicules.UseVisualStyleBackColor = true;
            this.btnAfficher_vehicules.Click += new System.EventHandler(this.btnAfficher_vehicules_Click);
            // 
            // dGV_Vehicule
            // 
            this.dGV_Vehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Vehicule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column1});
            this.dGV_Vehicule.Location = new System.Drawing.Point(76, 120);
            this.dGV_Vehicule.Name = "dGV_Vehicule";
            this.dGV_Vehicule.Size = new System.Drawing.Size(444, 150);
            this.dGV_Vehicule.TabIndex = 8;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Immatricule";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Marque";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Type Vehicule";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date Mise Service";
            this.Column1.Name = "Column1";
            // 
            // Vehicules_liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 383);
            this.Controls.Add(this.dGV_Vehicule);
            this.Controls.Add(this.btnAfficher_vehicules);
            this.Controls.Add(this.label1);
            this.Name = "Vehicules_liste";
            this.Text = "Vehicules_liste";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Vehicule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAfficher_vehicules;
        private System.Windows.Forms.DataGridView dGV_Vehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}