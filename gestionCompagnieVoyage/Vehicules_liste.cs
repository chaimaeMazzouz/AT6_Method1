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
    public partial class Vehicules_liste : Form
    {
        public Vehicules_liste()
        {
            InitializeComponent();
        }
        classConnexion g2 = new classConnexion();
        SqlCommand Vehicule_cmd = new SqlCommand();
       SqlDataReader Vehicule_drd;

        

        private void btnAfficher_vehicules_Click(object sender, EventArgs e)
        {
            Vehicule_cmd.Connection = g2.voyage_connexion;
            Vehicule_cmd.CommandText = "SELECT * FROM Vehicule";
            try
            {
                dGV_Vehicule.Rows.Clear();
                g2.voyage_connexion.Open();
                 Vehicule_drd = Vehicule_cmd.ExecuteReader();
                 while (Vehicule_drd.Read())
                 {
                dGV_Vehicule.Rows.Add(Vehicule_drd["Immatricule"],
                          Vehicule_drd["Marque"], Vehicule_drd["Type_Vehicule"],
                          Vehicule_drd["Dt_Mise_Service"]);
                 
                 }
              


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                g2.voyage_connexion.Close();
            }

        }


        /* */

    }
}
