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
    public partial class Vehicule_Ajout : Form
    {
        classConnexion g1 = new classConnexion();
        public Vehicule_Ajout()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (textImmatricule.Text == "" || textMarque.Text == "" || textTypeVhc.Text == "" )
            {
                MessageBox.Show("Remplir les champs");
            }
            else
            {
                try
                {
                    SqlCommand chauffeur_cmd = new SqlCommand("", g1.voyage_connexion);
                    chauffeur_cmd.Parameters.Add(new SqlParameter("@Immatricule", SqlDbType.VarChar, 12));
                    chauffeur_cmd.Parameters.Add("@Marque", SqlDbType.VarChar, 15);
                    chauffeur_cmd.Parameters.Add("@TypeVehicule", SqlDbType.VarChar, 8);
                    chauffeur_cmd.Parameters.Add("@DateMiseService", SqlDbType.Date);

                    chauffeur_cmd.Parameters[0].Value = textImmatricule.Text;
                    chauffeur_cmd.Parameters[1].Value = textMarque.Text;
                    chauffeur_cmd.Parameters[2].Value = textTypeVhc.Text;
                    chauffeur_cmd.Parameters[3].Value = dateTimePicker1.Text;

                    chauffeur_cmd.CommandText = "insert into Vehicule values(@Immatricule, @Marque, @TypeVehicule, @DateMiseService)";
                    g1.voyage_connexion.Open();
                    chauffeur_cmd.ExecuteNonQuery();
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
