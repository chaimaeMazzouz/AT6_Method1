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
    public partial class voyage_Ajout : Form
    {
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
                    comboID_Voyage.Items.Add(Voyage_drd.GetString(0));
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
        void remplirID_chauffeur() 
        {
            comboID_chauffeur.Items.Clear();
            Voyage_cmd = new SqlCommand("", g1.voyage_connexion);
            Voyage_cmd.CommandText = "select ID_chauffeur from chauffeur ";
            try
            {
                g1.voyage_connexion.Open();
                Voyage_drd = Voyage_cmd.ExecuteReader();
                while (Voyage_drd.Read())
                {
                    comboID_chauffeur.Items.Add(Voyage_drd.GetString(0));
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
        void remplirImmatricule()
        {
            comboImmatricule.Items.Clear();
            Voyage_cmd = new SqlCommand("", g1.voyage_connexion);
            Voyage_cmd.CommandText = "select Immatricule from Vehicule ";
            try
            {
                g1.voyage_connexion.Open();
                Voyage_drd = Voyage_cmd.ExecuteReader();
                while (Voyage_drd.Read())
                {
                    comboImmatricule.Items.Add(Voyage_drd.GetString(0));
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
        public voyage_Ajout()
        {
            InitializeComponent();
        }

        private void voyage_Ajout_Load(object sender, EventArgs e)
        {
            remplirIdVoyage();
            remplirID_chauffeur();
            remplirImmatricule();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (textDuree.Text == "" || textNbre_Voyageurs.Text == "" || textPlace_libre.Text == "" || textTarif.Text == "" || textVille_Arrive.Text == "" || textVille_Depart.Text == "")
            {
                MessageBox.Show("Remplir les champs");
            }
            else
            {
                try
                {
                    SqlCommand voyage_cmd = new SqlCommand("", g1.voyage_connexion);
                    voyage_cmd.Parameters.Add("@Date_Voyage", SqlDbType.Date);
                    voyage_cmd.Parameters.Add("@Ville_Depart", SqlDbType.VarChar, 16);
                    voyage_cmd.Parameters.Add("@Ville_Arrive", SqlDbType.VarChar, 16);
                    voyage_cmd.Parameters.Add("@Duree", SqlDbType.Decimal);
                    voyage_cmd.Parameters.Add("@Nbre_Voyageurs", SqlDbType.Int);
                    voyage_cmd.Parameters.Add("@Place_libre", SqlDbType.Int);
                    voyage_cmd.Parameters.Add("@Tarif", SqlDbType.Money);

                    voyage_cmd.Parameters[0].Value = dateTimePicker1.Text;
                    voyage_cmd.Parameters[1].Value = textVille_Depart.Text;
                    voyage_cmd.Parameters[2].Value = textVille_Arrive.Text;
                    voyage_cmd.Parameters[3].Value = textDuree.Text;
                    voyage_cmd.Parameters[4].Value = textNbre_Voyageurs.Text;
                    voyage_cmd.Parameters[5].Value = textPlace_libre.Text;
                    voyage_cmd.Parameters[6].Value = textTarif.Text;

                    voyage_cmd.CommandText = "insert into voyage(Date_Voyage,Ville_Depart,Ville_Arrive,Duree,Nbre_Voyageurs,Place_libre,Tarif) values(@Date_Voyage,@Ville_Depart,@Ville_Arrive,@Duree,@Nbre_Voyageurs,@Place_libre,@Tarif)";
                    g1.voyage_connexion.Open();
                    voyage_cmd.ExecuteNonQuery();
                    MessageBox.Show("insertion effectuée");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    g1.voyage_connexion.Close();
                }
            }
        }
    }
}
