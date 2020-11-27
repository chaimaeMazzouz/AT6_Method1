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
    public partial class billet_Ajout : Form
    {
        public billet_Ajout()
        {
            InitializeComponent();
        }
        classConnexion g1 = new classConnexion();
        SqlCommand billet_cmd = new SqlCommand();
        SqlDataReader billet_drd;
        void remplirIdVoyage()
        {
            comboID_Voyage.Items.Clear();
            billet_cmd = new SqlCommand("", g1.voyage_connexion);
            billet_cmd.CommandText = "select ID_Voyage from voyage ";
            try
            {
                g1.voyage_connexion.Open();
                billet_drd = billet_cmd.ExecuteReader();
                while (billet_drd.Read())
                {
                    comboID_Voyage.Items.Add(billet_drd.GetInt32(0));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                billet_drd.Close();
                g1.voyage_connexion.Close();
            }

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (nobreBillet.Text == "" )
            {
                MessageBox.Show("Remplir les champs");
            }
            else
            {
                try
                {
                    SqlCommand billet_cmd = new SqlCommand("", g1.voyage_connexion);
                    billet_cmd.Parameters.Add("@NBillet", SqlDbType.Int);
                    billet_cmd.Parameters.Add("@DateDelivrance", SqlDbType.Date);
                    billet_cmd.Parameters.Add("@IDVoyage", SqlDbType.Int);

                    billet_cmd.Parameters[0].Value = nobreBillet.Text;
                    billet_cmd.Parameters[1].Value = dateDelivrance.Text;
                    billet_cmd.Parameters[2].Value = comboID_Voyage.Text;

                    billet_cmd.CommandText = "insert into billet values(@NBillet,@DateDelivrance,@IDVoyage)";
                    g1.voyage_connexion.Open();
                    billet_cmd.ExecuteNonQuery();
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

        private void billet_Ajout_Load(object sender, EventArgs e)
        {
            remplirIdVoyage();
        }
    }
}
