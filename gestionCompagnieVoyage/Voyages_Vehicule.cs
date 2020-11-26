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
    public partial class Voyages_Vehicule : Form
    {
        public Voyages_Vehicule()
        {
            InitializeComponent();
        }

        classConnexion g1 = new classConnexion();
        SqlCommand voyageVehicule_cmd = new SqlCommand();
        SqlDataReader voyageVehicule_drd;
        void remplir_combo()
        {
            comboBox1.Items.Clear();
            voyageVehicule_cmd = new SqlCommand("", g1.voyage_connexion);
            voyageVehicule_cmd.CommandText = "select Immatricule from Vehicule";
            try
            {
                g1.voyage_connexion.Open();
                voyageVehicule_drd = voyageVehicule_cmd.ExecuteReader();
                while (voyageVehicule_drd.Read())
                {
                    comboBox1.Items.Add(voyageVehicule_drd.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voyageVehicule_drd.Close();
                g1.voyage_connexion.Close();
            }

        }

        private void Voyages_Vehicule_Load(object sender, EventArgs e)
        {
            remplir_combo();
            voyageVehicule_cmd.Connection = g1.voyage_connexion;
            voyageVehicule_cmd.CommandText = "SELECT Immatricule, COUNT(ID_Voyage) as Nb_Voyage from voyage group by Immatricule ";
            try
            {
                dataGridView1.Rows.Clear();
                g1.voyage_connexion.Open();
                voyageVehicule_drd = voyageVehicule_cmd.ExecuteReader();
                while (voyageVehicule_drd.Read())
                {
                    dataGridView1.Rows.Add(voyageVehicule_drd["Immatricule"], voyageVehicule_drd["Nb_Voyage"]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                voyageVehicule_drd.Close();
                g1.voyage_connexion.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            voyageVehicule_cmd.CommandText = "SELECT  COUNT(ID_Voyage) as Nb_Voyage from voyage where Immatricule ='" + comboBox1.Text + "'";
            try
            {
                g1.voyage_connexion.Open();
                voyageVehicule_drd = voyageVehicule_cmd.ExecuteReader();
                while (voyageVehicule_drd.Read())
                {
                    lblNombreVoyage.Text = voyageVehicule_drd["Nb_Voyage"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                voyageVehicule_drd.Close();
                g1.voyage_connexion.Close();
            }
        }
    }
}
