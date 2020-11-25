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
    public partial class Vehicule_modification : Form
    {
        classConnexion g1 = new classConnexion();
        SqlCommand Vehicule_cmd = new SqlCommand();
        SqlDataReader Vehicule_drd;
        string Imm;
        void remplir_combo()
        {
            comboBox1.Items.Clear();
            Vehicule_cmd = new SqlCommand("", g1.voyage_connexion);
            Vehicule_cmd.CommandText = "select Immatricule from Vehicule";
            try
            {
                g1.voyage_connexion.Open();
                Vehicule_drd = Vehicule_cmd.ExecuteReader();
                while (Vehicule_drd.Read())
                {
                    comboBox1.Items.Add(Vehicule_drd.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Vehicule_drd.Close();
                g1.voyage_connexion.Close();
            }
            comboBox1.SelectedIndex = 0;
        }
        public Vehicule_modification()
        {
            InitializeComponent();
        }

        private void Vehicule_modification_Load(object sender, EventArgs e)
        {
            remplir_combo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicule_cmd = new SqlCommand("", g1.voyage_connexion);
            Vehicule_cmd.CommandText = "select * from Vehicule where Immatricule = '" + comboBox1.Text + "'";
            try
            {
                g1.voyage_connexion.Open();
                Vehicule_drd = Vehicule_cmd.ExecuteReader();
                while (Vehicule_drd.Read())
                {
                    Imm = Vehicule_drd[0].ToString();
                    textMarqe.Text = Vehicule_drd[1].ToString();
                    textTypeVhc.Text = Vehicule_drd[2].ToString();
                    dateTimePicker1.Text = Vehicule_drd[3].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Vehicule_drd.Close();
                g1.voyage_connexion.Close();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Vehicule_cmd = new SqlCommand("", g1.voyage_connexion);
                Vehicule_cmd.Parameters.Add("@Immatricule", SqlDbType.VarChar, 12);
                Vehicule_cmd.Parameters.Add("@Marque", SqlDbType.VarChar, 15);
                Vehicule_cmd.Parameters.Add("@TypeVehicule", SqlDbType.VarChar, 8);
                Vehicule_cmd.Parameters.Add("@DateMiseService", SqlDbType.Date);

                Vehicule_cmd.Parameters[0].Value = Imm;
                Vehicule_cmd.Parameters[1].Value = textMarqe.Text;
                Vehicule_cmd.Parameters[2].Value = textTypeVhc.Text;
                Vehicule_cmd.Parameters[3].Value = dateTimePicker1.Text;

                Vehicule_cmd.CommandText = "update Vehicule set Marque = @Marque,Type_Vehicule= @TypeVehicule,Dt_Mise_Service= @DateMiseService where Immatricule=@Immatricule";

                string rep = MessageBox.Show($"voulez vous modifier ",
               "Modification Vehicule", MessageBoxButtons.YesNo).ToString();
                if (rep == "Yes")
                {
                    try
                    {
                        g1.voyage_connexion.Open();
                        Vehicule_drd = Vehicule_cmd.ExecuteReader();
                        MessageBox.Show("Opération réussie");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Vehicule_drd.Close();
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

