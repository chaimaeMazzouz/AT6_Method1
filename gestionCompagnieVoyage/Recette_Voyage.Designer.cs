namespace gestionCompagnieVoyage
{
    partial class Recette_Voyage
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
            this.Recette = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNumeroVoyage = new System.Windows.Forms.ComboBox();
            this.RecetteParVoyagedataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RecetteParVoyagedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Recette
            // 
            this.Recette.AutoSize = true;
            this.Recette.Location = new System.Drawing.Point(543, 262);
            this.Recette.Name = "Recette";
            this.Recette.Size = new System.Drawing.Size(0, 13);
            this.Recette.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Recette";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Numero Voyage";
            // 
            // comboNumeroVoyage
            // 
            this.comboNumeroVoyage.FormattingEnabled = true;
            this.comboNumeroVoyage.Location = new System.Drawing.Point(546, 185);
            this.comboNumeroVoyage.Name = "comboNumeroVoyage";
            this.comboNumeroVoyage.Size = new System.Drawing.Size(121, 21);
            this.comboNumeroVoyage.TabIndex = 48;
            this.comboNumeroVoyage.SelectedIndexChanged += new System.EventHandler(this.comboNumeroVoyage_SelectedIndexChanged);
            // 
            // RecetteParVoyagedataGridView
            // 
            this.RecetteParVoyagedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecetteParVoyagedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.RecetteParVoyagedataGridView.Location = new System.Drawing.Point(134, 185);
            this.RecetteParVoyagedataGridView.Name = "RecetteParVoyagedataGridView";
            this.RecetteParVoyagedataGridView.Size = new System.Drawing.Size(243, 150);
            this.RecetteParVoyagedataGridView.TabIndex = 47;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Voyage";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Recette";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(284, 115);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(194, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "Recette par Voyage";
            // 
            // Recette_Voyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Recette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboNumeroVoyage);
            this.Controls.Add(this.RecetteParVoyagedataGridView);
            this.Controls.Add(this.label5);
            this.Name = "Recette_Voyage";
            this.Text = "Recette_Voyage";
            this.Load += new System.EventHandler(this.Recette_Voyage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecetteParVoyagedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recette;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNumeroVoyage;
        private System.Windows.Forms.DataGridView RecetteParVoyagedataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label5;
    }
}