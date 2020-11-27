using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestionCompagnieVoyage
{
    public partial class Nombre_de_lignes : Form
    {
        classConnexion g1 = new classConnexion();
        SqlCommand NbrLignes_cmd = new SqlCommand();
        public Nombre_de_lignes()
        {
            InitializeComponent();
        }

        private void Nombre_de_lignes_Load(object sender, EventArgs e)
        {
            NbrLignes_cmd = new SqlCommand("", g1.voyage_connexion);
            g1.voyage_connexion.Open();

            NbrLignes_cmd.CommandText = "SELECT count (*) FROM chauffeur ";
            txtNbChauffeurs.Text = NbrLignes_cmd.ExecuteScalar().ToString();
            NbrLignes_cmd.CommandText = "SELECT count (*) FROM Vehicule ";
            textNbVehicules.Text = NbrLignes_cmd.ExecuteScalar().ToString();
            NbrLignes_cmd.CommandText = "SELECT count (*) FROM voyage ";
            textNbVoyages.Text = NbrLignes_cmd.ExecuteScalar().ToString();
            NbrLignes_cmd.CommandText = "SELECT count (*) FROM Billet ";
            textNbBillets.Text = NbrLignes_cmd.ExecuteScalar().ToString();

            g1.voyage_connexion.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
