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
    public partial class voyage_modification : Form
    {
        public voyage_modification()
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
                    comboID_chauffeur.Text = Voyage_drd.GetString(8);
                    comboImmatricule.Text = Voyage_drd.GetString(9);
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

        private void Modifier_Click(object sender, EventArgs e)
        {
            
                try
                {
                    Voyage_cmd = new SqlCommand("", g1.voyage_connexion);
                    Voyage_cmd.Parameters.Add("@Date_Voyage", SqlDbType.Date);
                    Voyage_cmd.Parameters.Add("@Ville_Depart", SqlDbType.VarChar, 16);
                    Voyage_cmd.Parameters.Add("@Ville_Arrive", SqlDbType.VarChar, 16);
                    Voyage_cmd.Parameters.Add("@Duree", SqlDbType.Decimal);
                    Voyage_cmd.Parameters.Add("@Nbre_Voyageurs", SqlDbType.Int);
                    Voyage_cmd.Parameters.Add("@Place_libre", SqlDbType.Int);
                    Voyage_cmd.Parameters.Add("@Tarif", SqlDbType.Money);
                    Voyage_cmd.Parameters.Add("@ID_chauffeur", SqlDbType.VarChar,10);
                    Voyage_cmd.Parameters.Add("@Immatricule", SqlDbType.VarChar, 12);

                    Voyage_cmd.Parameters[0].Value = DateVoyage.Text;
                    Voyage_cmd.Parameters[1].Value = villeDepart.Text;
                    Voyage_cmd.Parameters[2].Value = VilleArrive.Text;
                    Voyage_cmd.Parameters[3].Value = duree.Text;
                    Voyage_cmd.Parameters[4].Value = NombresVoyageurs.Text;
                    Voyage_cmd.Parameters[5].Value = PlaceLibre.Text;
                    Voyage_cmd.Parameters[6].Value = Tarif.Text;
                    Voyage_cmd.Parameters[7].Value = comboID_chauffeur.Text;
                    Voyage_cmd.Parameters[8].Value = comboImmatricule.Text;
                Voyage_cmd.CommandText = "update voyage set Date_Voyage=@Date_Voyage, Ville_Depart=@ville_Depart, Ville_Arrive=@Ville_Arrive," +
            "Duree=@Duree,Nbre_Voyageurs=@Nbre_Voyageurs,Place_libre=@Place_libre,Tarif=@Tarif,ID_chauffeur=@ID_chauffeur" +
            $",Immatricule=@Immatricule where ID_Voyage= {comboID_Voyage.Text}";

                string rep = MessageBox.Show($"voulez vous modifier le Voyage {comboID_Voyage.Text}",
                    "Modification  Voyage", MessageBoxButtons.YesNo).ToString();
                if (rep == "Yes")
                {
                    try
                    {
                        g1.voyage_connexion.Open();
                        Voyage_drd = this.Voyage_cmd.ExecuteReader();
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

        private void voyage_modification_Load(object sender, EventArgs e)
        {
            remplirIdVoyage();
            remplirID_chauffeur();
            remplirImmatricule();
        }
    }
    
}
