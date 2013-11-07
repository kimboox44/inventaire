using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace solution1
{
    public partial class GestionUtilisateurInventaire : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;        
        string requete;        

        public GestionUtilisateurInventaire()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chargement des utilisateur dans dGVUtilisateur
            DataSet dSUtilisateur =  MaConnexion.ExecuteSelect(connectionString, "select idUtilisateur, pseudo, motDePasse, Administrateur, etat from utilisateur where etat = 'Valide'");
            if (dSUtilisateur != null) 
            {
                foreach (DataRow row in dSUtilisateur.Tables[0].Rows)
                {                    
                    object[] newRow = new object[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), null };
                    dGVUtilisateur.Rows.Add(newRow);                    
                }
            }

            //chargement des inventaires dans dGVInventaire
            DataSet dSInventaire = MaConnexion.ExecuteSelect(connectionString, "select UIdInventaire, DesigInventaire, DateInventaire from inventaire where etat = 'Valide' order by DateInventaire");
            if (dSInventaire != null)
            {
                foreach (DataRow row in dSInventaire.Tables[0].Rows)
                {                    
                    object[] newRow = new object[] { null, row[0].ToString(), row[1].ToString(), row[2].ToString(), null };
                    dGVInventaire.Rows.Add(newRow);
                }
            }

            //Deselection des cellules selectionnées automatiquement
            try 
            {
                dGVUtilisateur.SelectedCells[0].Selected = false;
                dGVInventaire.SelectedCells[0].Selected = false;
            }
            catch (Exception) { }

        }

        private void dGVUtilisateur_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dGVUtilisateur_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {        
           
        }

        private void dGVUtilisateur_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVUtilisateur.Columns[e.ColumnIndex].Name == "ColumnSupprimerUtilisateur")
            {
                if (e.RowIndex != dGVUtilisateur.RowCount - 1)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    int intTop = (e.CellBounds.Height - 16) / 2 + e.CellBounds.Top;
                    int intLeft = (e.CellBounds.Width - 16) / 2 + e.CellBounds.Left;
                    try
                    {
                        e.Graphics.DrawImage(System.Drawing.Image.FromFile("delete.gif"), intLeft, intTop);
                    }
                    catch (Exception)
                    { }
                    e.Handled = true;
                }
                else 
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    int intTop = (e.CellBounds.Height - 16) / 2 + e.CellBounds.Top;
                    int intLeft = (e.CellBounds.Width - 16) / 2 + e.CellBounds.Left;
                    try
                    {
                        e.Graphics.DrawImage(System.Drawing.Image.FromFile("images.jpeg"), intLeft, intTop);
                    }
                    catch (Exception)
                    { }
                    e.Handled = true;
                }             
            }   
         
        }

        private void dGVUtilisateur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ) return;

            //click sur le bouton de suppression
            if (dGVUtilisateur.Columns[e.ColumnIndex].Name == "ColumnSupprimerUtilisateur")
            {
                if (e.RowIndex != dGVUtilisateur.RowCount - 1) //bouton de suppression
                {                    
                    if (MessageBox.Show("Voulez vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        requete = "update utilisateur set etat = 'Non Valide' where idUtilisateur =" + dGVUtilisateur.Rows[e.RowIndex].Cells["ColumnIdUtilisateur"].Value;
                        
                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                            dGVUtilisateur.Rows.Remove(dGVUtilisateur.Rows[e.RowIndex]);
                        else
                            MessageBox.Show("La suppression a échoué", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else //bouton d     
                {
                    // faire un count ou lieu du max
                    DataSet nbligneutilisateur = MaConnexion.ExecuteSelect(connectionString, "select max(idUtilisateur) from Utilisateur");
                    MessageBox.Show( nbligneutilisateur.Tables[0].Rows[0][0].ToString());
                    requete = "INSERT INTO Utilisateur (pseudo, motDePasse, Administrateur, etat) VALUES ('Utilisateur" + nbligneutilisateur.Tables[0].Rows[0][0].ToString() + "','Mot de passe', 'False', 'Valide')";
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                    {
                        DataSet dSIdUtilisateur = MaConnexion.ExecuteSelect(connectionString, "select max(idUtilisateur) from Utilisateur");
                        MessageBox.Show(dSIdUtilisateur.Tables[0].Rows[0][0].ToString());
                        object[] newRow = new object[] { dSIdUtilisateur.Tables[0].Rows[0][0].ToString(), "Pseudo" + dSIdUtilisateur.Tables[0].Rows[0][0].ToString(), "Mot de passe", false, null };
                        dGVUtilisateur.Rows.Add(newRow);


                                 
                    }
                    else 
                    {
                        MessageBox.Show("Un utilisateur portant le même pseudo existe déja", "Utilisateur existant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }                
            }

            //mise à jour des inventaires qui correspondent à l'utilisateur seléctionné
            try
            {                
                requete = "select Inventaire.uidInventaire from inventorier, inventaire " +
                          "where inventorier.uidInventaire = inventaire.uidInventaire and " +
                          "idUtilisateur = " + dGVUtilisateur.Rows[e.RowIndex].Cells["ColumnIdUtilisateur"].Value;                
                DataSet dSInventaires = MaConnexion.ExecuteSelect(connectionString, requete);
                for (int i = 0; i < dGVInventaire.Rows.Count - 1; i++)
                {
                    ((DataGridViewCheckBoxCell)dGVInventaire.Rows[i].Cells["ColumnAvoirAcces"]).Value = false;
                }
                ((DataGridViewCheckBoxColumn)dGVInventaire.Columns["ColumnAvoirAcces"]).ReadOnly = false;

                if (dSInventaires != null)
                {
                    foreach (DataRow row in dSInventaires.Tables[0].Rows)
                    {
                        for (int i = 0; i < dGVInventaire.Rows.Count - 1; i++)
                        {
                            if (dGVInventaire.Rows[i].Cells["ColumnIdentifiant"].Value.ToString() == row[0].ToString())
                            {
                                ((DataGridViewCheckBoxCell)dGVInventaire.Rows[i].Cells["ColumnAvoirAcces"]).Value = true;
                            }
                        }
                    }
                }

                //si l'utilisateur sélectionné est un administrateur alors la colonne "columnAvoirAcces" de dGVInventaire est non editable
                if (((DataGridViewCheckBoxCell)dGVUtilisateur.Rows[e.RowIndex].Cells["ColumnAdministrateur"]).Value.ToString().ToLower() == "true")
                {
                    ((DataGridViewCheckBoxColumn)dGVInventaire.Columns["ColumnAvoirAcces"]).ReadOnly = true;                    
                }
                else
                {
                    ((DataGridViewCheckBoxColumn)dGVInventaire.Columns["ColumnAvoirAcces"]).ReadOnly = false;                    
                }
            }
            catch (Exception ex) {}
        }

        private void dGVUtilisateur_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {           
            if (dGVUtilisateur.Columns[e.ColumnIndex].Name == "ColumnAdministrateur")
            {
                try 
                {                       
                    bool administrateurBool = (bool)((DataGridViewCell)dGVUtilisateur.Rows[e.RowIndex].Cells["ColumnAdministrateur"]).Value;
                    
                    //mise à jour du champs Administrateur de la table Utilisateur
                    requete = "update utilisateur set Administrateur = '" + administrateurBool + "' where idUtilisateur = " + dGVUtilisateur.Rows[e.RowIndex].Cells["ColumnIdUtilisateur"].Value;                    
                    MaConnexion.ExecuteUpdate(connectionString, requete);

                    if (administrateurBool) 
                    {
                        //un utilisateur de type administrateur peut avoir accès à tous les inventaires
                        //tous les inventaires seront cochés
                        ((DataGridViewCheckBoxColumn)dGVInventaire.Columns["ColumnAvoirAcces"]).ReadOnly = true;
                        for (int i = 0; i < dGVInventaire.Rows.Count - 1; i++)
                        {
                            ((DataGridViewCheckBoxCell)dGVInventaire.Rows[i].Cells["ColumnAvoirAcces"]).Value = true;
                        }
                    }
                    else
                    {
                        ((DataGridViewCheckBoxColumn)dGVInventaire.Columns["ColumnAvoirAcces"]).ReadOnly = false;
                    }
                }
                catch (Exception) { }
            }
            else
                if ((dGVUtilisateur.Columns[e.ColumnIndex].Name == "ColumnPseudo"))
                {
                    requete = "update utilisateur set Pseudo = '" + dGVUtilisateur.Rows[e.RowIndex].Cells["ColumnPseudo"].Value.ToString() +
                                            "' where idUtilisateur = " + dGVUtilisateur.Rows[e.RowIndex].Cells["ColumnIdUtilisateur"].Value;
                    MaConnexion.ExecuteUpdate(connectionString, requete);
                }
                else
                    if ((dGVUtilisateur.Columns[e.ColumnIndex].Name == "ColumnMotDePasse"))
                    {
                        requete = "update utilisateur set motDePasse = '" + dGVUtilisateur.Rows[e.RowIndex].Cells["ColumnMotDePasse"].Value.ToString() +
                                                "' where idUtilisateur = " + dGVUtilisateur.Rows[e.RowIndex].Cells["ColumnIdUtilisateur"].Value;                        
                        MaConnexion.ExecuteUpdate(connectionString, requete);
                    }
        }

        private void dGVUtilisateur_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void bNouvelUtilisateur_Click(object sender, EventArgs e)
        {
            
        }

        private void dGVInventaire_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVInventaire.Columns[e.ColumnIndex].Name == "ColumnSupprimerInventaire")
            {
                if (e.RowIndex != dGVInventaire.RowCount -1)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    int intTop = (e.CellBounds.Height - 16) / 2 + e.CellBounds.Top;
                    int intLeft = (e.CellBounds.Width - 16) / 2 + e.CellBounds.Left;
                    try
                    {
                        e.Graphics.DrawImage(System.Drawing.Image.FromFile("delete.gif"), intLeft, intTop);
                    }
                    catch (Exception)
                    { }
                    e.Handled = true;
                }
                else 
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    int intTop = (e.CellBounds.Height - 16) / 2 + e.CellBounds.Top;
                    int intLeft = (e.CellBounds.Width - 16) / 2 + e.CellBounds.Left;
                    try
                    {
                        e.Graphics.DrawImage(System.Drawing.Image.FromFile("images.jpeg"), intLeft, intTop);
                    }
                    catch (Exception)
                    { }
                    e.Handled = true;
                }
                
            }            
        }

        private void dGVInventaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGVUtilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGVInventaire_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dGVInventaire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ) return;

            //click sur le bouton de suppression d'inventaire
            if (dGVInventaire.Columns[e.ColumnIndex].Name == "ColumnSupprimerInventaire")
            {
                if (e.RowIndex != dGVInventaire.RowCount - 1) //bouton de suppression
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer cet inventaire ?", "Supprimer un inventaire", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        requete = "update inventaire set etat = 'Non Valide' where uidInventaire = '" + dGVInventaire.Rows[e.RowIndex].Cells["ColumnIdentifiant"].Value + "'";                        
                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                            dGVInventaire.Rows.Remove(dGVInventaire.Rows[e.RowIndex]);
                        else
                            MessageBox.Show("La suppression a échoué", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else //bouton d'ajout
                {
                    DateTime date = DateTime.Now;
                    requete = "INSERT INTO Inventaire (UIdInventaire ,DesigInventaire ,DateInventaire ,etat,rowguid) VALUES (NEWID(),'Nouvel inventaire', '" + date.ToString("yyyy/MM/dd H:m:s") + "', 'Valide',NEWID())";                    
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                    {
                        DataSet dSIdInventaire = MaConnexion.ExecuteSelect(connectionString, "select uidInventaire from inventaire where dateInventaire >= ALL (select dateInventaire from inventaire)");
                        object[] newRow = new object[] { null, dSIdInventaire.Tables[0].Rows[0][0].ToString(), "Nouvel inventaire", date.ToString("dd/MM/yyyy H:m:s"), null };
                        dGVInventaire.Rows.Add(newRow);
                    }
                    else
                    {
                        MessageBox.Show("Changez d'abord le nom de l'inventaire que vous venez de créer", "Saisie incomplète", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dGVInventaire_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVInventaire.Columns[e.ColumnIndex].Name == "ColumnAvoirAcces")
            {                
                try
                {
                    bool avoirAcces = (bool)((DataGridViewCell)dGVInventaire.Rows[e.RowIndex].Cells["ColumnAvoirAcces"]).Value;                    
                    if (avoirAcces) // donner à l'utilisateur selectinné l'acces a l'inventaire coché 
                    {
                        requete = "insert into inventorier (uidInventaire, idUtilisateur,rowguid) values ('" +
                                   dGVInventaire.Rows[e.RowIndex].Cells["ColumnIdentifiant"].Value + "', " +
                                   dGVUtilisateur.Rows[dGVUtilisateur.CurrentCell.RowIndex].Cells["ColumnIdUtilisateur"].Value + ",NEWID())";                                                
                        MaConnexion.ExecuteUpdate(connectionString, requete);                           
                    }                        
                    else //Enlever à l'utilisateur selectionné l'accès à l'inventaire décoché
                    {
                        requete = "delete from inventorier where uidInventaire = '" +
                                   dGVInventaire.Rows[e.RowIndex].Cells["ColumnIdentifiant"].Value +
                                   "' and idUtilisateur = " +
                                   dGVUtilisateur.Rows[dGVUtilisateur.CurrentCell.RowIndex].Cells["ColumnIdUtilisateur"].Value;
                        MaConnexion.ExecuteUpdate(connectionString, requete);                        
                    }
                }
                catch (Exception) { }
            }
            else
                if (dGVInventaire.Columns[e.ColumnIndex].Name == "ColumnNom")
                {
                    requete = "update inventaire set DesigInventaire = '" +
                               dGVInventaire.Rows[e.RowIndex].Cells["ColumnNom"].Value + "' where UIdInventaire = '" +
                               dGVInventaire.Rows[e.RowIndex].Cells["ColumnIdentifiant"].Value + "'";                    
                    MaConnexion.ExecuteUpdate(connectionString, requete);
                }            
        }

        private void dGVUtilisateur_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   

        }

        private void bNouvelInventaire_Click(object sender, EventArgs e)
        {
            
        }

        private void dGVUtilisateur_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dGVUtilisateur_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell sauvCurrentCell = dGVUtilisateur.CurrentCell;
            dGVUtilisateur.CurrentCell = null;
            dGVUtilisateur.CurrentCell = sauvCurrentCell; 
        }

        private void dGVInventaire_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell sauvCurrentCell = dGVInventaire.CurrentCell;
            dGVInventaire.CurrentCell = null;
            dGVInventaire.CurrentCell = sauvCurrentCell;
        }

        private void dGVUtilisateur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGVUtilisateur_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
