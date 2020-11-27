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
    public partial class Voyages_Chauffeur : Form
    {
        public Voyages_Chauffeur()
        {
            InitializeComponent();
        }

        classConnexion g1 = new classConnexion();
        SqlCommand voyageChauffeur_cmd = new SqlCommand();
        SqlDataReader voyageChauffeur_drd;
        void remplir_combo()
        {
            comboIDChauffeur.Items.Clear();
            voyageChauffeur_cmd = new SqlCommand("", g1.voyage_connexion);
            voyageChauffeur_cmd.CommandText = "select ID_chauffeur from chauffeur";
            try
            {
                g1.voyage_connexion.Open();
                voyageChauffeur_drd = voyageChauffeur_cmd.ExecuteReader();
                while (voyageChauffeur_drd.Read())
                {
                    comboIDChauffeur.Items.Add(voyageChauffeur_drd.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voyageChauffeur_drd.Close();
                g1.voyage_connexion.Close();
            }

        }

        private void Voyages_Chauffeur_Load(object sender, EventArgs e)
        {
            remplir_combo();
            voyageChauffeur_cmd.Connection = g1.voyage_connexion;
            voyageChauffeur_cmd.CommandText = "SELECT ID_chauffeur, COUNT(ID_Voyage) as Nb_Voyage from voyage group by ID_chauffeur ";
            try
            {
                VoyageParVehiculedataGridView.Rows.Clear();
                g1.voyage_connexion.Open();
                voyageChauffeur_drd = voyageChauffeur_cmd.ExecuteReader();
                while (voyageChauffeur_drd.Read())
                {
                    VoyageParVehiculedataGridView.Rows.Add(voyageChauffeur_drd["ID_chauffeur"], voyageChauffeur_drd["Nb_Voyage"]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                voyageChauffeur_drd.Close();
                g1.voyage_connexion.Close();
            }
        }

        private void comboIDChauffeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            voyageChauffeur_cmd.CommandText = "SELECT  COUNT(ID_Voyage) as Nb_Voyage from voyage where ID_chauffeur ='" + comboIDChauffeur.Text + "'";
            try
            {
                g1.voyage_connexion.Open();
                voyageChauffeur_drd = voyageChauffeur_cmd.ExecuteReader();
                while (voyageChauffeur_drd.Read())
                {
                    NombreDeVoyage.Text = voyageChauffeur_drd["Nb_Voyage"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                voyageChauffeur_drd.Close();
                g1.voyage_connexion.Close();
            }
        }
    }
}
