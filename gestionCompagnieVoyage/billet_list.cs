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
    public partial class billet_list : Form
    {
        public billet_list()
        {
            InitializeComponent();
        }
        classConnexion g1 = new classConnexion();
        SqlCommand billet_cmd = new SqlCommand();
        SqlDataReader billet_drd;

        private void Afficher_Click(object sender, EventArgs e)
        {
            billet_cmd.Connection = g1.voyage_connexion;
            billet_cmd.CommandText = "SELECT * FROM billet";
            try
            {
                billetdataGridView.Rows.Clear();
                g1.voyage_connexion.Open();
                billet_drd = billet_cmd.ExecuteReader();
                while (billet_drd.Read())
                {
                    billetdataGridView.Rows.Add(billet_drd["N_Billet"],
                        billet_drd["Date_Delivrance"], billet_drd["ID_Voyage"]);
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
