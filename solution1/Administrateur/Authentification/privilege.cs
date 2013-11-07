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
                    if ((row[4].ToString().Trim() == "Inventaire") && (row[3].ToString().Trim() == "Consultation"))
                    {
                        fm.nvInvTSMI.Visible = false;
                        fm.gestInventTSMI.Visible = false;
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
                    if ((row[4].ToString().Trim() == "Bien-Categorie") && (row[3].ToString().Trim() == "Consultation"))
                    {
                        fm.ajouterUnBienToolStripMenuItem.Visible = false;
                        fm.modifierLeBienSélectionnéToolStripMenuItem.Visible = false;
                    }

                    if ((row[4].ToString().Trim() == "Site-Emplacement") && (row[3].ToString().Trim() == "Consultation"))
                    {
                        fm.toolStripButton1.Visible = false;
                        fm.tSSBEmplacement.Visible = false;
                    }

                    if ((row[4].ToString().Trim() == "Client-Fournisseur") && (row[3].ToString().Trim() == "Aucun accée"))
                    {
                        fm.tSSBClient.Visible = false;
                        fm.tSSBFournisseur.Visible = false;
                    }
                    else
                    {
                        if ((row[4].ToString().Trim() == "Client-Fournisseur") && (row[3].ToString().Trim() == "Consultation"))
                        {
                            fm.tSMIAjouterFournisseur.Visible = false;
                            fm.ajouterUnClientToolStripMenuItem.Visible = false;
                        }       
                    }

                    if ((row[4].ToString().Trim() == "Transfert-Cession") && (row[3].ToString().Trim() == "Aucun accée"))
                    {
                        fm.toolStripSplitButton1.Visible = false;
                        fm.toolStripSplitButton2.Visible = false;
                    }
                    else
                    {
                        if ((row[4].ToString().Trim() == "Transfert-Cession") && (row[3].ToString().Trim() == "Consultation"))
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
                    MessageBox.Show("privilege " + row[4].ToString().Trim() + " \\ " + row[3]);
                    if ((row[4].ToString().Trim() == "Bien-Categorie") && (row[3].ToString().Trim() == "Consultation"))
                    {
                
                        categorie.buttonAjouterCategorie.Visible = false;
                        categorie.buttonSupprimer.Visible = false;
                    }
                }
            }
        
        }

    }
}
