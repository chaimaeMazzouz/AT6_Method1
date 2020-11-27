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
    public partial class Recette_Voyage : Form
    {
        public Recette_Voyage()
        {
            InitializeComponent();
        }
        classConnexion g1 = new classConnexion();
        SqlCommand recetteVoyage_cmd = new SqlCommand();
        SqlDataReader recetteVoyage_drd;
        void remplir_combo()
        {
            comboNumeroVoyage.Items.Clear();
            recetteVoyage_cmd = new SqlCommand("", g1.voyage_connexion);
            recetteVoyage_cmd.CommandText = "select ID_Voyage from voyage";
            try
            {
                g1.voyage_connexion.Open();
                recetteVoyage_drd = recetteVoyage_cmd.ExecuteReader();
                while (recetteVoyage_drd.Read())
                {
                    comboNumeroVoyage.Items.Add(recetteVoyage_drd.GetInt32(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                recetteVoyage_drd.Close();
                g1.voyage_connexion.Close();
            }

        }

        private void comboNumeroVoyage_SelectedIndexChanged(object sender, EventArgs e)
        {
            recetteVoyage_cmd.CommandText = "SELECT  ID_Voyage, Nbre_Voyageurs *Tarif as recette from voyage where ID_Voyage ='" + comboNumeroVoyage.Text + "'";
            try
            {
                g1.voyage_connexion.Open();
                recetteVoyage_drd = recetteVoyage_cmd.ExecuteReader();
                while (recetteVoyage_drd.Read())
                {
                    Recette.Text = recetteVoyage_drd["recette"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                recetteVoyage_drd.Close();
                g1.voyage_connexion.Close();
            }
        }

        private void Recette_Voyage_Load(object sender, EventArgs e)
        {
            remplir_combo();
            recetteVoyage_cmd.Connection = g1.voyage_connexion;
            recetteVoyage_cmd.CommandText = "SELECT  ID_Voyage, Nbre_Voyageurs *Tarif as recette from voyage";
            try
            {
                RecetteParVoyagedataGridView.Rows.Clear();
                g1.voyage_connexion.Open();
                recetteVoyage_drd = recetteVoyage_cmd.ExecuteReader();
                while (recetteVoyage_drd.Read())
                {
                    RecetteParVoyagedataGridView.Rows.Add(recetteVoyage_drd["ID_Voyage"], recetteVoyage_drd["recette"]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                recetteVoyage_drd.Close();
                g1.voyage_connexion.Close();
            }
        }
    }
}
