using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace solution1.gestion_utilisateur
{
    
    class privilege
    {

        public void ouvrirInventaire(DataSet dt, MDIParent fm)
        {

            if (dt != null)
            {
                foreach (DataRow row in dt.Tables[0].Rows)
                {
                    if ((row[3].ToString().Trim() == "Inventaire") && (row[2].ToString().Trim() == "consultation"))
                    {
                       fm.tSBNouvelInventaire.Visible = false;
                       fm.toolStripSeparator2.Visible = false;
                    }
                }
            }
        }



        public void forminventaire(DataSet dt, FormInventaire fm)
        {
            if (dt != null)
            {
                foreach (DataRow row in dt.Tables[0].Rows)
                {
                    MessageBox.Show("privilege " + row[3].ToString().Trim() + " \\ " + row[2]);
                    if ((row[3].ToString().Trim() == "Bien-Categorie") && (row[2].ToString().Trim() == "consultation"))
                    {
                        fm.ajouterUnBienToolStripMenuItem.Visible = false;
                        fm.modifierLeBienSélectionnéToolStripMenuItem.Visible = false;
                    }

                    if ((row[3].ToString().Trim() == "Site-Emplacement") && (row[2].ToString().Trim() == "consultation"))
                    {
                        fm.toolStripButton1.Visible = false;
                        fm.tSSBEmplacement.Visible = false;
                    }
                           
                    if ((row[3].ToString().Trim() == "Client-Four") && (row[2].ToString().Trim() == "non-autoriser"))
                    {
                        fm.tSSBClient.Visible = false;
                        fm.tSSBFournisseur.Visible = false;
                    }
                    else
                    {
                        if ((row[3].ToString().Trim() == "Client-Four") && (row[2].ToString().Trim() == "consultation"))
                        {
                            fm.tSMIAjouterFournisseur.Visible = false;
                            fm.ajouterUnClientToolStripMenuItem.Visible = false;
                        }       
                    }

                    if ((row[3].ToString().Trim() == "Transfert-Cession") && (row[2].ToString().Trim() == "non-autoriser"))
                    {
                        fm.toolStripSplitButton1.Visible = false;
                        fm.toolStripSplitButton2.Visible = false;
                    }
                    else
                    {
                        if ((row[3].ToString().Trim() == "Transfert-Cession") && (row[2].ToString().Trim() == "consultation"))
                        {
                            fm.toolStripSplitButton1.Visible = false;
                            fm.toolStripSplitButton2.Visible = false;
                        }
                    }
                    
                    
                }

            }
        }




        public void categoriebien(DataSet dt,FormGestionCategorie categorie)
        {
            if (dt != null)
            {
                foreach (DataRow row in dt.Tables[0].Rows)
                {
                    MessageBox.Show("privilege " + row[3].ToString().Trim() + " \\ " + row[2]);
                    if ((row[3].ToString().Trim() == "Bien-Categorie") && (row[2].ToString().Trim() == "consultation"))
                    {
                
                        categorie.buttonAjouterCategorie.Visible = false;
                        categorie.buttonSupprimer.Visible = false;
                    }
                }
            }
        
        }

    }
}
