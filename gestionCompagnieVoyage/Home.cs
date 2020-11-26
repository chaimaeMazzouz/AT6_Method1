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


        Liste_CH lsForm = new Liste_CH();
        Ajout_chauffeur ajForm = new Ajout_chauffeur();
        Suppression_Chauffeur spCHForm = new Suppression_Chauffeur();
        Modification_chauffeur mdCHForm = new Modification_chauffeur();
        Vehicules_liste lsVcForm = new Vehicules_liste();
        Vehicule_Ajout ajVhcForm = new Vehicule_Ajout();
        Vehicule_modification modVhcForm = new Vehicule_modification();
        Vehicule_suppression supVhForm = new Vehicule_suppression();
        voyage_list lisVogForm = new voyage_list();
        voyage_Ajout ajVogForm = new voyage_Ajout();
        Nombre_de_lignes NbrLignes = new Nombre_de_lignes();
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
            Changer_Form(lsForm);
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(ajForm);
        }

        private void suppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(spCHForm);
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(mdCHForm);
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(lsVcForm);
        }

        private void ajoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(ajVhcForm);
        }

        private void modificationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(modVhcForm);
        }

        private void suppressionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changer_Form(supVhForm);
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Changer_Form(lisVogForm);
        }

        private void ajoutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Changer_Form(ajVogForm);
        }

        private void nombreDeLignesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(NbrLignes);
        }
    }
}
