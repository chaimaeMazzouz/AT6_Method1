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
    public partial class voyage_suppression : Form
    {
        public voyage_suppression()
        {
            InitializeComponent();
        }
        classConnexion g1 = new classConnexion();
        SqlCommand Voyage_cmd = new SqlCommand();
        SqlDataReader Voyage_drd;
        void remplirIdVoyage()
        {
            comboID_Voyage.Items.Clear();
            Voyage_cmd = new SqlCommand("", g1.voyage_connexion);
            Voyage_cmd.CommandText = "select ID_Voyage from voyage ";
            try
            {
                g1.voyage_connexion.Open();
                Voyage_drd = Voyage_cmd.ExecuteReader();
                while (Voyage_drd.Read())
                {
                    comboID_Voyage.Items.Add(Voyage_drd.GetInt32(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Voyage_drd.Close();
                g1.voyage_connexion.Close();
            }

        }
      
      

        private void comboID_Voyage_SelectedIndexChanged(object sender, EventArgs e)
        {

            Voyage_cmd = new SqlCommand("", g1.voyage_connexion);
            Voyage_cmd.CommandText = "select * from voyage where ID_Voyage = '" + comboID_Voyage.Text + "'";
            try
            {
                g1.voyage_connexion.Open();
                Voyage_drd = Voyage_cmd.ExecuteReader();
                while (Voyage_drd.Read())
                {
                    
                    DateVoyage.Text = Voyage_drd[1].ToString();
                    villeDepart.Text = Voyage_drd[2].ToString();
                    VilleArrive.Text = Voyage_drd.GetString(3);
                    duree.Text = Voyage_drd.GetDecimal(4).ToString();
                    NombresVoyageurs.Text = Voyage_drd.GetInt32(5).ToString();
                    PlaceLibre.Text = Voyage_drd.GetInt32(6).ToString();
                    Tarif.Text = Voyage_drd.GetSqlMoney(7).ToString();
                    txtID_chauffeur.Text = Voyage_drd.GetString(8);
                    txtImmatricule.Text = Voyage_drd.GetString(9);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Voyage_drd.Close();
                g1.voyage_connexion.Close();
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            Voyage_cmd = new SqlCommand("", g1.voyage_connexion);
            Voyage_cmd.CommandText = "delete voyage where ID_Voyage = '" + comboID_Voyage.Text + "'";
            string rep = MessageBox.Show($"voulez vous supprimer le Voyage {comboID_Voyage.Text}",
                "Supprission Voyage", MessageBoxButtons.YesNo).ToString();
            if (rep == "Yes")
            {
                try
                {
                    g1.voyage_connexion.Open();
                    Voyage_drd = Voyage_cmd.ExecuteReader();
                    MessageBox.Show("Opération réussie");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Voyage_drd.Close();
                    g1.voyage_connexion.Close();
                }
            }
        }

        private void voyage_suppression_Load(object sender, EventArgs e)
        {
            remplirIdVoyage();
        }
    }
}
