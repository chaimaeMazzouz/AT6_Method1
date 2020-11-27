using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace gestionCompagnieVoyage
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }
        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Liste_chauffeur());
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Ajout_chauffeur());
        }

        private void suppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Suppression_Chauffeur());
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Modification_chauffeur());
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Vehicules_liste());
        }

        private void ajoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Vehicule_Ajout());
        }

        private void modificationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Vehicule_modification());
        }

        private void suppressionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Vehicule_suppression());
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Changer_Form(new voyage_list());
        }

        private void ajoutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Changer_Form(new voyage_Ajout());
        }

        private void nombreDeLignesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Nombre_de_lignes());
        }

        private void billetsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Billets_Voyage());
        }

        private void voyagesChauffeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Voyages_Vehicule());
        }

        private void suppressionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Changer_Form(new voyage_suppression());
        }

        private void modificationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Changer_Form(new voyage_modification());
        }

        private void listeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Changer_Form(new billet_list());
        }

        private void ajoutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Changer_Form(new billet_Ajout());
        }

        private void suppressionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Changer_Form(new billet_suppression());
        }

        private void modificationToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Changer_Form(new billet_Modification());
        }

        private void voyagesChauffeurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(new Voyages_Chauffeur());
        }

        private void recetteVoyageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Recette_Voyage());
        }
    }
}
