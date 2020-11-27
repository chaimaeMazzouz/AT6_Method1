namespace gestionCompagnieVoyage
{
    partial class billet_suppression
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
            this.comboNombreBillet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateDelivrance = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idVoyage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboNombreBillet
            // 
            this.comboNombreBillet.FormattingEnabled = true;
            this.comboNombreBillet.Location = new System.Drawing.Point(244, 212);
            this.comboNombreBillet.Name = "comboNombreBillet";
            this.comboNombreBillet.Size = new System.Drawing.Size(201, 21);
            this.comboNombreBillet.TabIndex = 111;
            this.comboNombreBillet.SelectedIndexChanged += new System.EventHandler(this.comboNombreBillet_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 109;
            this.label10.Text = "Id Voyage";
            // 
            // dateDelivrance
            // 
            this.dateDelivrance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDelivrance.Location = new System.Drawing.Point(244, 250);
            this.dateDelivrance.Name = "dateDelivrance";
            this.dateDelivrance.Size = new System.Drawing.Size(202, 20);
            this.dateDelivrance.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "Date Delivrance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "Nombre Billet";
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Supprimer.Location = new System.Drawing.Point(507, 288);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(115, 34);
            this.Supprimer.TabIndex = 105;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(240, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 104;
            this.label1.Text = "Suprimer Billet";
            // 
            // idVoyage
            // 
            this.idVoyage.Location = new System.Drawing.Point(244, 302);
            this.idVoyage.Name = "idVoyage";
            this.idVoyage.Size = new System.Drawing.Size(202, 20);
            this.idVoyage.TabIndex = 112;
            // 
            // billet_suppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idVoyage);
            this.Controls.Add(this.comboNombreBillet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateDelivrance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.label1);
            this.Name = "billet_suppression";
            this.Text = "billet_suppression";
            this.Load += new System.EventHandler(this.billet_suppression_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboNombreBillet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateDelivrance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idVoyage;
    }
}