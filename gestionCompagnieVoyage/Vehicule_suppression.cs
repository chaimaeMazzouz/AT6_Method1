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
    public partial class Vehicule_suppression : Form
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
        public Vehicule_suppression()
        {
            InitializeComponent();
        }

        private void Vehicule_suppression_Load(object sender, EventArgs e)
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

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Vehicule_cmd = new SqlCommand("", g1.voyage_connexion);
            Vehicule_cmd.CommandText = "delete Vehicule where Immatricule = '" + comboBox1.Text + "'";
            string rep = MessageBox.Show($"voulez vous supprimer le Vehicule {comboBox1.Text}",
                "Supprission chauffeur", MessageBoxButtons.YesNo).ToString();
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
    }
}
