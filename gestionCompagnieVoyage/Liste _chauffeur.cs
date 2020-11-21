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
    public partial class Liste_CH : Form
    {
      
        public Liste_CH()
        {
            InitializeComponent();
        }
        classConnexion g1 = new classConnexion();
        SqlCommand chauffeur_cmd = new SqlCommand();
        SqlDataReader chauffeur_drd;

        private void btnAfficher_CH_Click(object sender, EventArgs e)
        {

            chauffeur_cmd.Connection = g1.voyage_connexion;
            chauffeur_cmd.CommandText = "SELECT * FROM chauffeur";
            try
            {
                dataGridView1.Rows.Clear();
                g1.voyage_connexion.Open();
                chauffeur_drd = chauffeur_cmd.ExecuteReader();
                while (chauffeur_drd.Read()) 
                {
                    dataGridView1.Rows.Add(chauffeur_drd.GetString(0),
                        chauffeur_drd.GetString(1), chauffeur_drd.GetString(2),
                        chauffeur_drd.GetString(3), chauffeur_drd["Date_Recrutement"], chauffeur_drd.GetSqlMoney(5)
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
    }
}
