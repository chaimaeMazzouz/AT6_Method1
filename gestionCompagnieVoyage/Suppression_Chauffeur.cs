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
    public partial class Suppression_Chauffeur : Form
    {
        public Suppression_Chauffeur()
        {
            InitializeComponent();
        }
        classConnexion g1 = new classConnexion();
        SqlCommand chauffeur_cmd = new SqlCommand();
        SqlDataReader chauffeur_drd;
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

        }
        private void btnSuppression_Click(object sender, EventArgs e)
        {
            chauffeur_cmd = new SqlCommand("", g1.voyage_connexion);
            chauffeur_cmd.CommandText = "delete chauffeur where ID_chauffeur = '"+comboBox1.Text+"'";
            string rep = MessageBox.Show($"voulez vous supprimer le chauffeur {textBox2.Text} {textBox3.Text} ",
                "Supprission chauffeur", MessageBoxButtons.YesNo).ToString();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chauffeur_cmd = new SqlCommand("", g1.voyage_connexion);
            chauffeur_cmd.Parameters.Add("@IDCH", SqlDbType.VarChar, 10);
            chauffeur_cmd.Parameters[0].Value = comboBox1.Text.ToString();
            chauffeur_cmd.CommandText = "select * from chauffeur where ID_chauffeur = @IDCH";
            try
            {
                g1.voyage_connexion.Open();
                chauffeur_drd = chauffeur_cmd.ExecuteReader();
                while (chauffeur_drd.Read())
                {
                    textBox2.Text = chauffeur_drd[1].ToString();
                    textBox3.Text = chauffeur_drd[2].ToString();
                    textBox4.Text = chauffeur_drd[3].ToString();
                    textBox5.Text = chauffeur_drd[4].ToString();
                    textBox6.Text = chauffeur_drd[5].ToString();
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

        private void Suppression_Chauffeur_Load(object sender, EventArgs e)
        {
            remplir_combo();
        }
    }
}
