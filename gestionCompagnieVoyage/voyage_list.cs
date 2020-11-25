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
    public partial class voyage_list : Form
    {

        classConnexion g1 = new classConnexion();
        SqlCommand voyage_cmd = new SqlCommand();
        SqlDataReader voyage_drd;
        public voyage_list()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            voyage_cmd.Connection = g1.voyage_connexion;
            voyage_cmd.CommandText = "SELECT * FROM voyage";
            try
            {
                dataGridView1.Rows.Clear();
                g1.voyage_connexion.Open();
                voyage_drd = voyage_cmd.ExecuteReader();
                while (voyage_drd.Read())
                {
                    dataGridView1.Rows.Add(voyage_drd["ID_Voyage"], voyage_drd["Date_Voyage"], voyage_drd["Ville_Depart"], voyage_drd["Ville_Arrive"]
                        , voyage_drd["Duree"], voyage_drd["Nbre_Voyageurs"], voyage_drd["Place_libre"], 
                        voyage_drd["Tarif"], voyage_drd["ID_chauffeur"], voyage_drd["Immatricule"]);
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

