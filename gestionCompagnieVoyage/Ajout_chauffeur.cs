﻿using System;
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
    public partial class Ajout_chauffeur : Form
    {
        classConnexion g1 = new classConnexion();
        public Ajout_chauffeur()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="" || textBox2.Text=="" || textBox3.Text == "" || textBox4.Text== "" || textBox5.Text== "")
            {
                MessageBox.Show("Remplir les champs");
            }
            else
            {
                try
                {
                    SqlCommand chauffeur_cmd = new SqlCommand("", g1.voyage_connexion);
                    chauffeur_cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.VarChar, 10));
                    chauffeur_cmd.Parameters.Add("@Nm", SqlDbType.VarChar, 15);
                    chauffeur_cmd.Parameters.Add("@Prm", SqlDbType.VarChar, 15);
                    chauffeur_cmd.Parameters.Add("@Adresse", SqlDbType.VarChar, 40);
                    chauffeur_cmd.Parameters.Add("@Dt_rec", SqlDbType.Date);
                    chauffeur_cmd.Parameters.Add("@Salaire", SqlDbType.Money);

                    chauffeur_cmd.Parameters[0].Value = textBox1.Text;
                    chauffeur_cmd.Parameters[1].Value = textBox2.Text;
                    chauffeur_cmd.Parameters[2].Value = textBox3.Text;
                    chauffeur_cmd.Parameters[3].Value = textBox4.Text;
                    chauffeur_cmd.Parameters[4].Value = dateTimePicker1.Text;
                    chauffeur_cmd.Parameters[5].Value = textBox5.Text;

                    chauffeur_cmd.CommandText = "insert into chauffeur values(@ID, @Nm, @Prm, @Adresse, @Dt_rec, @Salaire)";
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
