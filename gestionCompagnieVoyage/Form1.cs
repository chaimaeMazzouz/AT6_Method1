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
    public partial class Form1 : Form
    {


        Liste_CH lsForm = new Liste_CH();
        Ajout_chauffeur ajForm = new Ajout_chauffeur();
        Suppression_Chauffeur spCHForm = new Suppression_Chauffeur();
        Modification_chauffeur mdCHForm = new Modification_chauffeur();
        public Form1()
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
    }
}
