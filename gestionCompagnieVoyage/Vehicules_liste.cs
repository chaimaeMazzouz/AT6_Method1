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
        classConnexion g1 = new classConnexion();
        SqlCommand Vehicule_cmd = new SqlCommand();
        SqlDataReader Vehicule_drd;

        

        private void btnAfficher_vehicules_Click(object sender, EventArgs e)
        {
            Vehicule_cmd.Connection = g1.voyage_connexion;
            Vehicule_cmd.CommandText = "SELECT * FROM Vehicule";
            try
            {
                dataGridView1.Rows.Clear();
                g1.voyage_connexion.Open();
                Vehicule_drd = Vehicule_cmd.ExecuteReader();
                while (Vehicule_drd.Read())
                {
                    dataGridView1.Rows.Add(Vehicule_drd.GetString(0),
                        Vehicule_drd.GetString(1), Vehicule_drd.GetString(2),
                        Vehicule_drd.GetSqlDateTime(3)
                );
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


        /* */

    }
}
