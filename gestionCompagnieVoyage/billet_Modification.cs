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
    public partial class billet_Modification : Form
    {
        public billet_Modification()
        {
            InitializeComponent();
        }

        classConnexion g1 = new classConnexion();
        SqlCommand billet_cmd = new SqlCommand();
        SqlDataReader billet_drd;
        void remplirIdVoyage()
        {
            comboID_Voyage.Items.Clear();
            billet_cmd = new SqlCommand("", g1.voyage_connexion);
            billet_cmd.CommandText = "select ID_Voyage from voyage ";
            try
            {
                g1.voyage_connexion.Open();
                billet_drd = billet_cmd.ExecuteReader();
                while (billet_drd.Read())
                {
                    comboID_Voyage.Items.Add(billet_drd.GetInt32(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                billet_drd.Close();
                g1.voyage_connexion.Close();
            }

        }
        void remplirNBillet()
        {
            comboNombreBillet.Items.Clear();
            billet_cmd = new SqlCommand("", g1.voyage_connexion);
            billet_cmd.CommandText = "select N_Billet from billet ";
            try
            {
                g1.voyage_connexion.Open();
                billet_drd = billet_cmd.ExecuteReader();
                while (billet_drd.Read())
                {
                    comboNombreBillet.Items.Add(billet_drd.GetInt32(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                billet_drd.Close();
                g1.voyage_connexion.Close();
            }

        }

        private void billet_Modification_Load(object sender, EventArgs e)
        {
            remplirNBillet();
            remplirIdVoyage();
        }

        private void comboNombreBillet_SelectedIndexChanged(object sender, EventArgs e)
        {
            billet_cmd = new SqlCommand("", g1.voyage_connexion);
            billet_cmd.CommandText = "select * from billet where N_Billet = '" + comboNombreBillet.Text + "'";
            try
            {
                g1.voyage_connexion.Open();
                billet_drd = billet_cmd.ExecuteReader();
                while (billet_drd.Read())
                {

                    dateDelivrance.Text = billet_drd[1].ToString();
                    comboID_Voyage.Text = billet_drd.GetInt32(2).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                billet_drd.Close();
                g1.voyage_connexion.Close();
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand billet_cmd = new SqlCommand("", g1.voyage_connexion);
                billet_cmd.Parameters.Add("@dateDelivrance", SqlDbType.Date);
                billet_cmd.Parameters.Add("@idVoyage", SqlDbType.Int);

                billet_cmd.Parameters[0].Value = dateDelivrance.Text;
                billet_cmd.Parameters[1].Value = comboID_Voyage.Text;

                billet_cmd.CommandText = $"update billet set Date_Delivrance = @dateDelivrance,ID_Voyage = @idVoyage where N_Billet= {comboNombreBillet.Text}";

                string rep = MessageBox.Show($"voulez vous modifier le billet {comboNombreBillet.Text}",
               "Modification chauffeur", MessageBoxButtons.YesNo).ToString();
                if (rep == "Yes")
                {
                    try
                    {
                        g1.voyage_connexion.Open();
                        billet_drd = billet_cmd.ExecuteReader();
                        MessageBox.Show("Opération réussie");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        billet_drd.Close();
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
                g1.voyage_connexion.Close();
            }
        }
    }
    }

