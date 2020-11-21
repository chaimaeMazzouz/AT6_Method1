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
    public partial class Modification_chauffeur : Form
    {
        classConnexion g1 = new classConnexion();
        SqlCommand chauffeur_cmd = new SqlCommand();
        SqlDataReader chauffeur_drd;
        string ID;
        void remplir_combo()
        {
            comboBox1.Items.Clear();
            chauffeur_cmd = new SqlCommand("", g1.voyage_connexion);
            chauffeur_cmd.CommandText = "select ID_chauffeur from chauffeur";
            try
            {
                g1.voyage_connexion.Open();
                chauffeur_drd = chauffeur_cmd.ExecuteReader();
                while (chauffeur_drd.Read())
                {
                    comboBox1.Items.Add(chauffeur_drd.GetString(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                chauffeur_drd.Close();
                g1.voyage_connexion.Close();
            }
            comboBox1.SelectedIndex = 0;
        }
        public Modification_chauffeur()
        {
            InitializeComponent();
        }

        private void Modification_chauffeur_Load(object sender, EventArgs e)
        {
            remplir_combo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chauffeur_cmd = new SqlCommand("", g1.voyage_connexion);
            chauffeur_cmd.CommandText = "select * from chauffeur where ID_chauffeur = '"+comboBox1.Text+"'";
            try
            {
                g1.voyage_connexion.Open();
                chauffeur_drd = chauffeur_cmd.ExecuteReader();
                while (chauffeur_drd.Read())
                {
                    ID = chauffeur_drd[0].ToString();
                    textBox2.Text = chauffeur_drd[1].ToString();
                    textBox3.Text = chauffeur_drd[2].ToString();
                    textBox4.Text = chauffeur_drd[3].ToString();
                    dateTimePicker1.Text = chauffeur_drd[4].ToString();
                    textBox5.Text = chauffeur_drd[5].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                chauffeur_drd.Close();
                g1.voyage_connexion.Close();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand chauffeur_cmd = new SqlCommand("", g1.voyage_connexion);
                chauffeur_cmd.Parameters.Add("@IDCH", SqlDbType.VarChar, 10);
                chauffeur_cmd.Parameters.Add("@Nm", SqlDbType.VarChar, 15);
                chauffeur_cmd.Parameters.Add("@Prm", SqlDbType.VarChar, 15);
                chauffeur_cmd.Parameters.Add("@Adresse", SqlDbType.VarChar, 40);
                chauffeur_cmd.Parameters.Add("@Dt_rec", SqlDbType.Date);
                chauffeur_cmd.Parameters.Add("@Salaire", SqlDbType.Money);

                chauffeur_cmd.Parameters[0].Value = ID;
                chauffeur_cmd.Parameters[1].Value = textBox2.Text;
                chauffeur_cmd.Parameters[2].Value = textBox3.Text;
                chauffeur_cmd.Parameters[3].Value = textBox4.Text;
                chauffeur_cmd.Parameters[4].Value = dateTimePicker1.Text;
                chauffeur_cmd.Parameters[5].Value = textBox5.Text;

                chauffeur_cmd.CommandText = "update chauffeur set Nom = @Nm,Prenom = @Prm,Adresse= @Adresse,Date_Recrutement= @Dt_rec,Salaire= @Salaire where ID_chauffeur=@IDCH";
              
                string rep = MessageBox.Show($"voulez vous modifier le chauffeur {textBox2.Text} {textBox3.Text} ",
               "Modification chauffeur", MessageBoxButtons.YesNo).ToString();
                if (rep == "Yes")
                {
                    try
                    {
                        g1.voyage_connexion.Open();
                        chauffeur_drd = chauffeur_cmd.ExecuteReader();
                        MessageBox.Show("Opération réussie");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        chauffeur_drd.Close();
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
