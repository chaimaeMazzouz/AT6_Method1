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

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (matricule.Text == "" || marque.Text == "" || type.Text == "")
            {
                MessageBox.Show("Remplir les champs");
            }
            else
            {
                try
                {
                    SqlCommand vehicule_cmd = new SqlCommand("", g1.voyage_connexion);
                    vehicule_cmd.Parameters.Add("@matricule", SqlDbType.VarChar, 12);
                    vehicule_cmd.Parameters.Add("@marque", SqlDbType.VarChar, 15);
                    vehicule_cmd.Parameters.Add("@type", SqlDbType.VarChar, 8);
                    vehicule_cmd.Parameters.Add("@dateMiseService", SqlDbType.Date);

                    vehicule_cmd.Parameters[0].Value = matricule.Text;
                    vehicule_cmd.Parameters[1].Value = marque.Text;
                    vehicule_cmd.Parameters[2].Value = type.Text;
                    vehicule_cmd.Parameters[3].Value = dateMiseService.Text;

                    vehicule_cmd.CommandText = "insert into vehicule values(@matricule,@marque,@type,@dateMiseService)";
                    g1.voyage_connexion.Open();
                    vehicule_cmd.ExecuteNonQuery();
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
