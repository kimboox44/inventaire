using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Configuration;
using System.IO;

namespace solution1
{    
    public partial class ModifierBien : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        Bien bien = null;        
        String date = null;
        String identCategorieBien = null;       
        public FormInventaire form = null;
        OpenFileDialog dlg = null;
        string idAmortissement = null;
        string requete = null;
        DataSet dS = null;

        decimal montantAchat = 2100.00M;
        String dateAchat = "01/04/2004";
        int dureeVie = 5;
        decimal valeurRésiduelle = 0;        

        decimal baseAmortissable = 0;
        decimal annuité1 = 0;
        decimal annuitéNormale = 0;
        decimal annuitésCumulées = 0;
        decimal annuité = 0;
        decimal tauxAmortissementLinéaire = 0;
        int jour = 0;
        int mois = 0;
        int année = 0;
        int nombreJoursUtilisation = 0;
        decimal valeurNetteComptable = 0;
        String[] tabDateAchat = null;

        //spécial amortissement degressif
        decimal tauxAmortissementDegressif = 0;
        decimal taux = 0;
        decimal coefficient = 0;
        decimal nombreMois = 0;
        int nombreAnnéeRestantes = 0;
        //fin variables d'amortissement

        public ModifierBien(FormInventaire form)
        {
            this.form = form;           
            InitializeComponent();
        }

        struct structEtat
        {
            string idEtat;
            string etat;
            public structEtat(String idEtat, String etat) { this.idEtat = idEtat; this.etat = etat; }
            public string IdEtat
            {
                get { return idEtat; }
            }
            public string Etat
            {
                get { return etat; }
            }
        }

        private void modifierBien() 
        {
            float prix = float.Parse(tBValeurAquisition.Text);
            string messageErreur = controlSaisie();
            if (messageErreur == null) //pas d'erreur de saisie
            {
                int idFournisseur = -1;
                if (dGVFournisseurs.SelectedRows.Count == 1 && dGVFournisseurs.SelectedRows[0].Index != dGVFournisseurs.RowCount - 1)
                    idFournisseur = Convert.ToInt32(dGVFournisseurs.SelectedRows[0].Cells["ColumnIdFournisseur"].Value);

                string chemin = "NULL";
                if (dlg != null)
                    chemin = dlg.FileName.ToString();
                bien = new Bien(treeViewCategorieBien.SelectedNode.Name, ((structEtat)cBEtat.SelectedItem).IdEtat, tBIntitule.Text, date, tBParticularite.Text, prix, chemin, tBAncienCode.Text, idFournisseur, tBNumFacture.Text, tBNumSerie.Text, tBMarque.Text, "Non supprimé");
                String idBien = form.lVI.SubItems[0].Text;

                if (bien.modifierBien(idBien) == 1)
                {
                    //modification de la l'emplacemnt du bien                                        
                    String[] tabId = this.treeViewEmplacementBien.SelectedNode.Name.Split(new char[] { '_' });
                    String idSite = tabId[0];
                    String idEmpla = tabId[1];


                    DataSet dataTableidEmplaCmplet = MaConnexion.ExecuteSelect(connectionString, "select idEmplaComplet from Emplacement where idEmpla ='" + idEmpla + "';");
                    DataRow dRidEmplaCmplet = dataTableidEmplaCmplet.Tables[0].Rows[0];
                    String idEmplaCmplet = dRidEmplaCmplet[0].ToString();



                    //string requete = "update seTrouveB set idSite = " + idSite + " , idEmpla = " + idEmplaCmplet + " where uidInventaire = '" + form.uidInventaire + "' and idBien = '" + idBien + "' and idEtat = " + ((structEtat)cBEtat.SelectedItem).IdEtat;
                    string requete = "update seTrouveB set idSite = " + idSite + " , idEmpla ='" + idEmplaCmplet +  "', idEtat = " + ((structEtat)cBEtat.SelectedItem).IdEtat + " where uidInventaire = '" + form.uidInventaire + "' and idBien = '" + idBien + "'";
                    MaConnexion.ExecuteUpdate(connectionString, requete);

                    MessageBox.Show("Modification effectuée ", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();

                    //reinitialisation du contenu de listViewBien
                    TreeNode sauvTreeView = form.treeViewEmplacement.SelectedNode;
                    form.treeViewEmplacement.SelectedNode = null;
                    form.treeViewEmplacement.SelectedNode = sauvTreeView;

                }
                else
                {
                    MessageBox.Show("Echec de la modification du bien", "Erreur de modication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(messageErreur, "Saisie incomplète ou erronée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string controlSaisie()
        {
            string messageErreur = null;
            if (tBValeurAquisition.Text == "")
                messageErreur = "Veuillez introduire la valeur d'acquisition du bien";
            else
            {
                try
                {
                    Decimal.Parse(tBValeurAquisition.Text);

                    if (tBIntitule.Text == "")
                        messageErreur = "Veuillez introduire le nom du bien";
                    else
                    {
                        if (cBEtat.Text == "")
                            messageErreur = "Veuillez introduire l'état du bien";
                        else
                        {
                            if (treeViewCategorieBien.SelectedNode == null)
                                messageErreur = "Veuillez choisir une catégorie du bien";
                            else
                            {
                                if (treeViewEmplacementBien.SelectedNode == null)
                                    messageErreur = "Veuillez choisir un emplacement pour le bien";

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    messageErreur = "veuillez introduire un nombre decimal";
                }
            }
            return messageErreur;
        }
           
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {            
            DateTime myTime = this.dTPDateAcquisition.Value;
            date = myTime.ToString("dd/MM/yyyy");
        }

        private void parcourir() 
        {
            dlg = new OpenFileDialog();
            dlg.CheckPathExists = true;
            dlg.CheckFileExists = true;
            dlg.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|Tous les fichiers (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pBPhotoBien.Image = Image.FromFile(dlg.FileName.Replace("\\", "\\\\"));
                }
                catch (Exception)
                {
                    MessageBox.Show("Vous devez choisir une image.", "Saisie incomplète", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Ajouter_Bien_Load(object sender, EventArgs e)
        {
            chargerFournisseurs();
            chargerEtat();            
            //affichage de l'inventaire courant
            tBInventaire.Text = form.uidInventaire;
            chargerTVEmplacements();
            chargerTVCatégorieBien();
           // InitialiserAmortissement();
            initialiserValeursBien();
            chargerPhoto();
        }

        private void chargerPhoto() 
        {
            //chargement photo
            try
            {
                requete = "select photo from bien where idBien = '" + form.lVI.SubItems[0].Text + "'";
                DataSet dSphoto = MaConnexion.ExecuteSelect(connectionString, requete);
                try
                {
                    pBPhotoBien.Image = Image.FromFile(dSphoto.Tables[0].Rows[0][0].ToString());
                }
                catch (Exception)  //photo non trouvé 
                { }
            }
            catch (Exception ex)
            { }
        }
        
        private void InitialiserAmortissement() 
        {
            //activation de l'amortissement correspondant à la catégorie du bien
            DataSet dSIdAmort = MaConnexion.ExecuteSelect(connectionString, "select IdAmort from categorieBien,Bien where categorieBien.idCategorieBien = Bien.idCategorieBien and Bien.idBien = '" + form.lVI.SubItems[0].Text + "'");
            try
            {
                idAmortissement = dSIdAmort.Tables[0].Rows[0][0].ToString();

                if (idAmortissement == "1") //amortissement linéaire
                {
                    groupBox6.Enabled = true; dGVLinéaire.Enabled = true;
                    groupBox3.Enabled = false; dGVDegessif.Enabled = false;
                }
                else
                { // amortissement linéaire (dSIdAmort.Tables[0].Rows[0][0].ToString() == "2")                    
                    groupBox6.Enabled = false; dGVLinéaire.Enabled = false;
                    groupBox3.Enabled = true; dGVDegessif.Enabled = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //initialisation de l'onglet "Amortissement"
            rBPrix.Text = form.lVI.SubItems[6].Text;
            dTPDépart.Text = form.lVI.SubItems[4].Text;
        }

        private void chargerTVEmplacements() 
        {
            //chargement de l'arbre des emplacements de biens
            try
            {
                String query = "select * from emplacement where idSitePere is null and idEmplaPere is null and idSite = " + form.idSite;
                DataSet dataSet = MaConnexion.ExecuteSelect(connectionString, query);

                foreach (DataRow dRRacine in dataSet.Tables[0].Rows)
                {
                    TreeNode racine = new TreeNode(dRRacine[4].ToString(), 0, 1);

                    //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                    racine.Name = dRRacine[0].ToString() + "_" + dRRacine[1].ToString();
                    requete = "select * from emplacement where idSitePere = "
                        + dRRacine[0].ToString()
                        + " and idEmplaPere = "
                        + dRRacine[1].ToString() + ";";

                    DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, requete);

                    foreach (DataRow dRCourant in sousDataTable.Tables[0].Rows)
                    {
                        TreeNode tNCourant = new TreeNode(dRCourant[4].ToString(), 0, 1);

                        //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                        tNCourant.Name = dRCourant[0].ToString() + "_" + dRCourant[1].ToString();
                        racine.Nodes.Add(approfondir(tNCourant, dRCourant[0].ToString(), dRCourant[1].ToString()));
                    }
                    treeViewEmplacementBien.Nodes.Add(racine);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void chargerTVCatégorieBien() 
        {
            //chargement de l'arbre des catégories de bien
            try
            {
                String query = "select * from categorieBien where idCategorieBienPere is null";
                DataSet dataSet = MaConnexion.ExecuteSelect(connectionString, query);
                foreach (DataRow dRRacine in dataSet.Tables[0].Rows)
                {
                    TreeNode racine = new TreeNode(dRRacine[3].ToString(), 0, 1);

                    //on stocke l'identifant de la catégorie de bien
                    racine.Name = dRRacine[0].ToString();
                    requete = "select * from categorieBien where idCategorieBienPere = "
                        + dRRacine[0].ToString() + ";";

                    DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, requete);

                    foreach (DataRow dRCourant in sousDataTable.Tables[0].Rows)
                    {
                        TreeNode tNCourant = new TreeNode(dRCourant[3].ToString(), 0, 1);

                        //on stocke l'identifant de la catégorie de bien
                        tNCourant.Name = dRCourant[0].ToString();
                        racine.Nodes.Add(approfondirCategorieBien(tNCourant, dRCourant[0].ToString()));
                    }
                    treeViewCategorieBien.Nodes.Add(racine);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void chargerEtat() 
        {
            //chargement des etats des biens
            String requete = "select * from etat";
            DataSet dataSet = MaConnexion.ExecuteSelect(connectionString, requete);

            if (dataSet != null)
            {

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {

                    structEtat str = new structEtat(row[0].ToString(), row[1].ToString());
                    cBEtat.Items.Add(str);
                }
            }
        }

        private void initialiserValeursBien() 
        {
            try
            {
                requete = "select Bien.idBien, Bien.ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien," +
                    " Etat.DesigEtat, Bien.Prix, Bien.Particularite, Bien.idCategorieBien, seTrouveB.idEmpla, Bien.numFacture, Bien.numSerie, Bien.marque from Bien, " +
                    " Etat,CategorieBien, SeTrouveB where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and " +
                    " Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien and Bien.IdBien = '" + form.lVI.SubItems[0].Text + "' " +
                    " and seTrouveB.uidInventaire = '" + form.uidInventaire + "'";
                Console.WriteLine(requete);
                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                if (dS.Tables[0].Rows.Count == 1)
                {
                    tBIdentifiant.Text = dS.Tables[0].Rows[0][0].ToString();
                    tBAncienCode.Text = dS.Tables[0].Rows[0][1].ToString();
                    tBIntitule.Text = dS.Tables[0].Rows[0][2].ToString();
                    dTPDateAcquisition.Text = dS.Tables[0].Rows[0][4].ToString();
                    cBEtat.Text = dS.Tables[0].Rows[0][5].ToString();
                    tBValeurAquisition.Text = dS.Tables[0].Rows[0][6].ToString();
                    tBParticularite.Text = dS.Tables[0].Rows[0][7].ToString();                    
                    tBNumFacture.Text = dS.Tables[0].Rows[0][10].ToString();
                    tBNumSerie.Text = dS.Tables[0].Rows[0][11].ToString();
                    tBMarque.Text = dS.Tables[0].Rows[0][12].ToString();
                    SélectionnerCatégoreBien(dS.Tables[0].Rows[0][8].ToString());
                    sélectionnerEmplacement(dS.Tables[0].Rows[0][9].ToString());
                    sélectionnerFournisseur(dS.Tables[0].Rows[0][0].ToString());

                }
                else
                {
                    
                    MessageBox.Show("Echec du chargement des informations du bien", "Erreur de chargement des valeurs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Echec du chargement des informations du bien", "Erreur de chargement des valeurs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            /*
            //initialisation de l'onglet "Description du bien"
            textBoxIdentifiant.Text = form.lVI.SubItems[0].Text;
            tBAncienCode.Text = form.lVI.SubItems[1].Text;
            textBoxIntitule.Text = form.lVI.SubItems[2].Text;
            dateTimePicker.Text = form.lVI.SubItems[4].Text;
            comboBoxEtat.Text = form.lVI.SubItems[5].Text;
            textBoxValeurAquisition.Text = form.lVI.SubItems[6].Text;
            textBoxParticularite.Text = form.lVI.SubItems[7].Text;
             */
        }

        private void SélectionnerCatégoreBien(string idCatégorieBien) 
        {
            //Sélection de la catégorie du bien à modifier dans l'inventaire courant
            try
            {
                comparerCatégorieBien(treeViewCategorieBien.Nodes[0], idCatégorieBien);
            }
            catch (Exception) { }
        }

        private void sélectionnerEmplacement(string idEmpla) 
        {
            //Sélection de l'emplacemen du bien à modifier dans l'inventaire courant
            try
            {
                comparerEmplacement(treeViewEmplacementBien.Nodes[0], idEmpla);
            }
            catch (Exception) { }
        }

        private void sélectionnerFournisseur(string idBien) 
        {
            //recupération de l'identifiant du fournisseur qui a fournit le bien pour le sélectionner
            try
            {
                requete = "select idFournisseur from Bien where IdBien = '" + idBien + "'";
                
                dS = MaConnexion.ExecuteSelect(connectionString, requete);

                bool trouve = false;
                for (int i = 0; i < dGVFournisseurs.Rows.Count && !trouve; i++)
                {
                    if (dGVFournisseurs.Rows[i].Cells["ColumnIdFournisseur"].Value.ToString().Equals(dS.Tables[0].Rows[0][0].ToString()))
                    {
                        dGVFournisseurs.Rows[i].Selected = true;
                        trouve = true;
                    }
                }
            }
            catch (Exception)
            { }
        }

        void comparerCatégorieBien(TreeNode tn, String id)
        {
            if (tn.Name == id)
            {
                tn.TreeView.SelectedNode = tn;                
            }
            else
            {
                if (tn.FirstNode != null)
                    comparerCatégorieBien(tn.FirstNode, id);
                if (tn.NextNode != null)
                    comparerCatégorieBien(tn.NextNode, id);    
            }
        }

        void comparerEmplacement(TreeNode tn, String id)
        {
            string[] tab = tn.Name.Split(new char[] { '_' });
            if (tab[1] == id)
            {
                tn.TreeView.SelectedNode = tn;
            }
            else
            {
                if (tn.FirstNode != null)
                    comparerEmplacement(tn.FirstNode, id);
                if (tn.NextNode != null)
                    comparerEmplacement(tn.NextNode, id);
            }
        }
        
        public TreeNode approfondirCategorieBien(TreeNode node, String idCategorieBien)
        {
            String requete = "select * from categorieBien where idCategorieBienPere = "
                        + idCategorieBien;

            DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);

            if (dataTable.Tables[0].Rows.Count == 0)
            {
                return node;
            }
            else
            {
                foreach (DataRow dRCourant in dataTable.Tables[0].Rows)
                {
                    TreeNode subNode = new TreeNode(dRCourant[3].ToString(), 0, 1);

                    //on stocke l'identifant de la catégorie de bien
                    subNode.Name = dRCourant[0].ToString() ;
                    String sousRequete = "select * from categorieBien where idCategorieBienPere = "
                        + dRCourant[0].ToString();
                        

                    DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, sousRequete);
                    if (sousDataTable.Tables[0].Rows.Count != 0)
                    {
                        node.Nodes.Add(approfondirCategorieBien(subNode, dRCourant[0].ToString()));
                    }
                    else
                    {
                        node.Nodes.Add(subNode);
                    }

                }
                return node;
            }
        }

        public TreeNode approfondir(TreeNode node, String idSite, String idEmpla)
        {
            String requete = "select * from emplacement where idSitePere = "
                        + idSite
                        + " and idEmplaPere = "
                        + idEmpla + ";";

            DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);

            if (dataTable.Tables[0].Rows.Count == 0)
            {
                return node;
            }
            else
            {

                foreach (DataRow dRCourant in dataTable.Tables[0].Rows)
                {
                    TreeNode subNode = new TreeNode(dRCourant[4].ToString(), 0, 1);

                    //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                    subNode.Name = dRCourant[0].ToString() + "_" + dRCourant[1].ToString();
                    String sousRequete = "select * from emplacement where idSitePere = "
                        + dRCourant[0].ToString()
                        + " and idEmplaPere = "
                        + dRCourant[1].ToString() + ";";

                    DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, sousRequete);
                    if (sousDataTable.Tables[0].Rows.Count != 0)
                    {
                        node.Nodes.Add(approfondir(subNode, dRCourant[0].ToString(), dRCourant[1].ToString()));
                    }
                    else
                    {
                        node.Nodes.Add(subNode);
                    }
                }
                return node;
            }
        }

        private void comboBoxEtat_Validating(object sender, CancelEventArgs e)
        {
            if (cBEtat.Text != "")
            {
                int i = 0; bool b = false;
                while ((i < cBEtat.Items.Count) && (b == false))
                {
                    if (((structEtat)cBEtat.Items[i]).Etat.Equals(cBEtat.Text))
                        b = true;
                    else
                        i++;
                }
                if (b == false)
                {
                    DialogResult a = MessageBox.Show("Voulez vous rajouter l'etat", "choix", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (a == DialogResult.Yes)
                    {
                        if (MaConnexion.ExecuteUpdate(connectionString, "insert into Etat (DesigEtat,rowguid) values ('" + cBEtat.Text + "',NEWID())") == 1)
                        {
                            DataSet dataset = MaConnexion.ExecuteSelect(connectionString,"select max(idEtat) from Etat");
                            structEtat strEt = new structEtat(dataset.Tables[0].Rows[0][0].ToString(),cBEtat.Text);
                            cBEtat.Items.Add(strEt);
                            cBEtat.SelectedItem = cBEtat.Items[cBEtat.Items.Count-1];
                        }
                    }
                    else
                        cBEtat.Text = "";
                }
            }
        }

        private void comboBoxEtat_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == 0X0D)
            {
                if (cBEtat.Text != "")
                {
                    
                    int i = 0; bool b = false;
                    while ((i < cBEtat.Items.Count) && (b == false))
                    {
                        if ( ((structEtat)cBEtat.Items[i]).Etat.Equals(cBEtat.Text))
                            b = true;
                        else
                            i++;
                    }
                    if (b == false)
                    {
                        DialogResult a = MessageBox.Show("Voulez vous rajouter l'etat", "choix", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (a == DialogResult.Yes)
                        {
                            if (MaConnexion.ExecuteUpdate(connectionString, "insert into Etat (DesigEtat,rowguid) values ('" + cBEtat.Text + "',NEWID())") == 1)
                            {
                                DataSet dataset = MaConnexion.ExecuteSelect(connectionString, "select max(idEtat) from Etet");
                                structEtat strEt = new structEtat(dataset.Tables[0].Rows[0][0].ToString(), cBEtat.Text);
                                cBEtat.Items.Add(strEt);
                            }
                        }
                        else
                            cBEtat.Text = "";
                    }
                }
            }
        }

        private void treeViewCategorieBien_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode a = (TreeNode)e.Node;
            identCategorieBien = a.Name;
        }

        private void buttonAmortissement_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAmortissement == "1")//AMORTISSEMENT LINEAIRE
                {
                    //conversion et control de valeurs introduites
                    montantAchat = Decimal.Parse(rBPrix.Text);
                    valeurRésiduelle = Decimal.Parse(tBValeurRésiduelle.Text);
                    dureeVie = Convert.ToInt32(nUDDurée.Value.ToString());
                    if (montantAchat > valeurRésiduelle)
                    {
                        //AMORTISSEMENT LINEAIRE
                        tauxAmortissementLinéaire = 1 / decimal.Parse(dureeVie.ToString()); 
                        baseAmortissable = montantAchat - valeurRésiduelle; 
                        annuitéNormale = baseAmortissable * tauxAmortissementLinéaire; 

                        //calcul de l'annuité de la première année (annuité1)
                        tabDateAchat = dateAchat.Split(new char[] { '/' });
                        jour = int.Parse(tabDateAchat[0]);
                        mois = int.Parse(tabDateAchat[1]);
                        année = int.Parse(tabDateAchat[2]);
                        nombreJoursUtilisation = (30 - jour + 1) + (12 - mois) * 30; 
                        annuité1 = (annuitéNormale * nombreJoursUtilisation) / 360; 

                        annuité = annuité1;  
                        annuitésCumulées = annuité1;
                        valeurNetteComptable = baseAmortissable - annuité1; 
                        dGVLinéaire.Rows.Clear();
                        dGVDegessif.Rows.Clear();
                        dGVLinéaire.Rows.Add(new String[] { année.ToString(), baseAmortissable.ToString("0.00"), annuité.ToString("0.00"), annuitésCumulées.ToString("0.00"), valeurNetteComptable.ToString("0.00") });
                        while (valeurNetteComptable > 0)
                        {
                            année++;
                            annuité = annuitéNormale;
                            if (valeurNetteComptable - annuité < 0)
                            {
                                annuité = valeurNetteComptable;
                                valeurNetteComptable = 0;
                            }
                            else
                            {
                                valeurNetteComptable = valeurNetteComptable - annuité;
                            }
                            annuitésCumulées = annuitésCumulées + annuité;
                            dGVLinéaire.Rows.Add(new String[] { année.ToString(), baseAmortissable.ToString("0.00"), annuité.ToString("0.00"), annuitésCumulées.ToString("0.00"), valeurNetteComptable.ToString("0.00") });
                        }
                        dGVLinéaire.Rows.Add(new String[] { "Total", "", baseAmortissable.ToString("0.00"), "", "" });
                    }
                    else
                    {
                        MessageBox.Show("La valeur résiduelle doit être inférieure au prix du bien", "Saisie eronnée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
                else //(idAmortissement == "2")//AMORTISSEMENT DEGRESSIF 
                {
                    //conversion et control de valeurs introduites
                    montantAchat = Decimal.Parse(rBPrix.Text);
                    valeurRésiduelle = Decimal.Parse(tBValeurRésiduelle.Text);
                    dureeVie = Convert.ToInt32(nUDDurée.Value.ToString());
                    if (montantAchat > valeurRésiduelle)
                    {
                        DateTime myTime = this.dTPDépart.Value;
                        dateAchat = myTime.ToString("dd/MM/yyyy");
                        //fin de conversion et control de valeurs introduites

                        if (dureeVie == 3 || dureeVie == 4)
                            coefficient = 1.25M;
                        else
                            if (dureeVie == 5 || dureeVie == 6)
                                coefficient = 1.75M;
                            else
                                if (dureeVie > 6)
                                    coefficient = 2.25M;

                        tauxAmortissementLinéaire = 1 / decimal.Parse(dureeVie.ToString());
                        tauxAmortissementDegressif = coefficient * tauxAmortissementLinéaire;

                        if (tauxAmortissementLinéaire > tauxAmortissementDegressif)
                            taux = tauxAmortissementLinéaire;
                        else
                            taux = tauxAmortissementDegressif;
                        baseAmortissable = montantAchat - valeurRésiduelle;
                        annuitéNormale = baseAmortissable * taux;

                        //calcul de l'annuité de la première année (annuité1)
                        tabDateAchat = dateAchat.Split(new char[] { '/' });
                        jour = int.Parse(tabDateAchat[0]);
                        mois = int.Parse(tabDateAchat[1]);
                        année = int.Parse(tabDateAchat[2]);
                        if (jour > 26)
                            nombreMois = 12 - mois;
                        else
                            nombreMois = 12 - mois + 1;
                        annuité1 = (annuitéNormale * nombreMois) / 12;
                        annuité = annuité1;
                        annuitésCumulées = annuité1;
                        valeurNetteComptable = baseAmortissable - annuité1;
                        nombreAnnéeRestantes = dureeVie;
                        dGVLinéaire.Rows.Clear();
                        dGVDegessif.Rows.Clear();
                        dGVDegessif.Rows.Add(new String[] { année.ToString(), baseAmortissable.ToString(), annuité.ToString("0.00"), annuitésCumulées.ToString("0.00"), valeurNetteComptable.ToString("0.00"), nombreAnnéeRestantes.ToString(), (tauxAmortissementLinéaire * 100).ToString("0.00") });
                        while (valeurNetteComptable > 0)
                        {
                            année++;
                            baseAmortissable = baseAmortissable - annuité;
                            nombreAnnéeRestantes--;
                            tauxAmortissementLinéaire = 1 / decimal.Parse(nombreAnnéeRestantes.ToString());
                            if (tauxAmortissementLinéaire > tauxAmortissementDegressif)
                                taux = tauxAmortissementLinéaire;
                            else
                                taux = tauxAmortissementDegressif;

                            annuité = baseAmortissable * taux;
                            annuitésCumulées = annuitésCumulées + annuité;
                            valeurNetteComptable = valeurNetteComptable - annuité;

                            dGVDegessif.Rows.Add(new String[] { année.ToString(), baseAmortissable.ToString("0.00"), annuité.ToString("0.00"), annuitésCumulées.ToString("0.00"), valeurNetteComptable.ToString("0.00"), nombreAnnéeRestantes.ToString(), (tauxAmortissementLinéaire * 100).ToString("0.00") });
                        }
                    }
                    else 
                    {
                        MessageBox.Show("La valeur résiduelle doit être inférieure au prix du bien", "Saisie eronnée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Le prix et la valeur résiduelle doivent être des décimaux", "Saisie eronnée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGestionCategorie formGestionCategorie = new FormGestionCategorie(this);
            formGestionCategorie.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            rBPrix.Text = tBValeurAquisition.Text;
            tBValeurRésiduelle.Text = "0.00";
            nUDDurée.Value = 2;
            dTPDépart.Text = this.dTPDateAcquisition.Value.ToString("dd/MM/yyyy");
        }

        private void rBTous_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTous.Checked)
                chargerFournisseurs();
        }

        private void rBIdentifiant_CheckedChanged(object sender, EventArgs e)
        {
            if (rBIdentifiant.Checked)
                chargerFournisseurs();
        }

        private void rBRaisonSociale_CheckedChanged(object sender, EventArgs e)
        {
            if (rBRaisonSociale.Checked)
                chargerFournisseurs();
        }

        private void tBIdentifiantFournisseur_TextChanged(object sender, EventArgs e)
        {
            rBIdentifiant.Checked = true;
            chargerFournisseurs();
        }

        private void tBRaisonSocialeFournisseur_TextChanged(object sender, EventArgs e)
        {
            rBRaisonSociale.Checked = true;
            chargerFournisseurs();
        }

        private void chargerFournisseurs()
        {
            if (rBTous.Checked)
            {
                requete = "select * from Fournisseur where etat = 'Non supprimé'";
            }
            else
            {
                if (rBIdentifiant.Checked)
                {
                    requete = "select * from Fournisseur where etat = 'Non supprimé' and idFournisseur = " + tBIdentifiantFournisseur.Text;

                }
                else
                {
                    if (rBRaisonSociale.Checked)
                    {
                        requete = "select * from Fournisseur where etat = 'Non supprimé' and nom like '" + tBRaisonSocialeFournisseur.Text + "%';";

                    }
                }
            }

            dGVFournisseurs.Rows.Clear();
            dS = MaConnexion.ExecuteSelect(connectionString, requete);
            try
            {
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] ligneClient = new object[] { null, null, row[0].ToString(), row[1].ToString(), row[2].ToString() };
                    dGVFournisseurs.Rows.Add(ligneClient);
                }
            }
            catch (Exception) { }
        }

        private void dGVFournisseurs_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVFournisseurs.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVFournisseurs.RowCount - 1)
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
            }
            else
                if (dGVFournisseurs.Columns[e.ColumnIndex].Name == "ColumnModifier")
                {
                    if (e.RowIndex != dGVFournisseurs.RowCount - 1)
                    {
                        e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                        int intTop = (e.CellBounds.Height - 16) / 2 + e.CellBounds.Top;
                        int intLeft = (e.CellBounds.Width - 10) / 2 + e.CellBounds.Left;
                        try
                        {
                            e.Graphics.DrawImage(System.Drawing.Image.FromFile("modifier.gif"), intLeft, intTop);
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

        private void dGVFournisseurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            if (dGVFournisseurs.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVFournisseurs.RowCount - 1) //bouton de suppression
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer ce fournisseur ?", "Supprimer un fournisseur", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        requete = "update fournisseur set etat = 'Supprimé' where idFournisseur =" + dGVFournisseurs.Rows[e.RowIndex].Cells["ColumnIdFournisseur"].Value;
                        

                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                        {
                            chargerFournisseurs();
                        }
                        else
                            MessageBox.Show("La suppression a échoué", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
                if (dGVFournisseurs.Columns[e.ColumnIndex].Name == "ColumnModifier") //click sur le bouton de modification ou d'ajout
                {
                    if (e.RowIndex != dGVFournisseurs.RowCount - 1) //click sur le bouton de modification
                    {
                        (new ModierFournisseur(dGVFournisseurs.Rows[e.RowIndex].Cells["ColumnIdFournisseur"].Value.ToString())).ShowDialog();
                    }
                    else //click sur le bouton d'ajout
                    {
                        (new AjouterFournisseur()).ShowDialog();
                    }
                    chargerFournisseurs();
                }
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            modifierBien();
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBPhotoBien_Click(object sender, EventArgs e)
        {
            parcourir();
        }

        private void tBValeurAquisition_TextChanged(object sender, EventArgs e)
        {
            DateTime myTime = this.dTPDateAcquisition.Value;
            date = myTime.ToString("dd/MM/yyyy");
        }

      
    }
}
