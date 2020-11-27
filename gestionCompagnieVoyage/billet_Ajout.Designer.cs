namespace gestionCompagnieVoyage
{
    partial class billet_Ajout
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
            this.comboID_Voyage = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateDelivrance = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.nobreBillet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboID_Voyage
            // 
            this.comboID_Voyage.FormattingEnabled = true;
            this.comboID_Voyage.Location = new System.Drawing.Point(256, 295);
            this.comboID_Voyage.Name = "comboID_Voyage";
            this.comboID_Voyage.Size = new System.Drawing.Size(201, 21);
            this.comboID_Voyage.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Id Voyage";
            // 
            // dateDelivrance
            // 
            this.dateDelivrance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDelivrance.Location = new System.Drawing.Point(255, 250);
            this.dateDelivrance.Name = "dateDelivrance";
            this.dateDelivrance.Size = new System.Drawing.Size(202, 20);
            this.dateDelivrance.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Date Delivrance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Nombre Billet";
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Ajouter.Location = new System.Drawing.Point(545, 199);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(94, 34);
            this.Ajouter.TabIndex = 97;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // nobreBillet
            // 
            this.nobreBillet.Location = new System.Drawing.Point(255, 209);
            this.nobreBillet.Name = "nobreBillet";
            this.nobreBillet.Size = new System.Drawing.Size(202, 20);
            this.nobreBillet.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(318, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 95;
            this.label1.Text = "Ajout Billet";
            // 
            // billet_Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboID_Voyage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateDelivrance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.nobreBillet);
            this.Controls.Add(this.label1);
            this.Name = "billet_Ajout";
            this.Text = "billet_Ajout";
            this.Load += new System.EventHandler(this.billet_Ajout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboID_Voyage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateDelivrance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox nobreBillet;
        private System.Windows.Forms.Label label1;
    }
}