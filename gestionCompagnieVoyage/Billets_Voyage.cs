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
    public partial class Billets_Voyage : Form
    {
        public Billets_Voyage()
        {
            InitializeComponent();
        }
        classConnexion g1 = new classConnexion();
        SqlCommand billetVoyage_cmd = new SqlCommand();
        SqlDataReader billetVoyage_drd;
        void remplir_combo()
        {
            comboBox1.Items.Clear();
            billetVoyage_cmd = new SqlCommand("", g1.voyage_connexion);
            billetVoyage_cmd.CommandText = "select ID_Voyage from voyage";
            try
            {
                g1.voyage_connexion.Open();
                billetVoyage_drd = billetVoyage_cmd.ExecuteReader();
                while (billetVoyage_drd.Read())
                {
                    comboBox1.Items.Add(billetVoyage_drd.GetInt32(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                billetVoyage_drd.Close();
                g1.voyage_connexion.Close();
            }
           
        }

        private void Billets_Voyage_Load(object sender, EventArgs e)
        {
            remplir_combo();
            billetVoyage_cmd.Connection = g1.voyage_connexion;
            billetVoyage_cmd.CommandText = "SELECT ID_Voyage, COUNT(N_Billet) as Nb_billet from billet group by ID_Voyage ";
            try
            {
                dataGridView1.Rows.Clear();
                g1.voyage_connexion.Open();
                billetVoyage_drd = billetVoyage_cmd.ExecuteReader();
                while (billetVoyage_drd.Read())
                {
                    dataGridView1.Rows.Add(billetVoyage_drd["ID_Voyage"], billetVoyage_drd["Nb_billet"]);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                billetVoyage_drd.Close();
                g1.voyage_connexion.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            billetVoyage_cmd.CommandText = "SELECT  COUNT(N_Billet) as Nb_billet from billet where ID_Voyage ='" + comboBox1.Text+"'";
            try
            {
                g1.voyage_connexion.Open();
                billetVoyage_drd = billetVoyage_cmd.ExecuteReader();
                while (billetVoyage_drd.Read())
                {
                    lblNombreBillets.Text = billetVoyage_drd["Nb_billet"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                billetVoyage_drd.Close();
                g1.voyage_connexion.Close();
            }
        }
    }
}
