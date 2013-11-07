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
    public partial class FormGestionCategorie : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        ModifierBien modifierBien = null;
        AjouterBien ajouterBien = null; 
            
            MDIParent Parent = null;
        string idCategorieBien = null;

        public FormGestionCategorie(MDIParent parent)
        {            
            InitializeComponent();
            this.Parent = parent;
           // gestion_utilisateur.privilege privi = new gestion_utilisateur.privilege();
           // privi.categoriebien(Parent.priv, this);
        }

        public FormGestionCategorie(ModifierBien modifierBien)
        {
            this.modifierBien = modifierBien;
            idCategorieBien = modifierBien.treeViewCategorieBien.SelectedNode.Name;
            InitializeComponent();


         
          
        }

        public FormGestionCategorie(AjouterBien ajouterBien)
        {
            this.ajouterBien = ajouterBien;
            idCategorieBien = ajouterBien.treeViewCategorieBien.SelectedNode.Name;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //chargement de l'arbre des catégories de bien
            chargerTVCategorieBien();
            treeViewCategorieBien.ExpandAll(); 
           
            //selection de la catégorie du bien
            try
            {
                int i = 0;                
                while (i < treeViewCategorieBien.Nodes.Count)
                {
                    comparer(treeViewCategorieBien.Nodes[i], idCategorieBien);
                    i++;
                }
            }
            catch (Exception) { }
        }

        void comparer(TreeNode tn, String id)
        {
            if (tn.Name == id)
            {
                tn.TreeView.SelectedNode = tn;                
            }
            else
            {
                if (tn.FirstNode != null)
                    comparer(tn.FirstNode, id);
                if (tn.NextNode != null)
                    comparer(tn.NextNode, id);                
            }
        }

        void chargerTVCategorieBien() 
        {
            try
            {
                String query = "select * from categorieBien where idCategorieBienPere is null";
                DataSet dataSet = MaConnexion.ExecuteSelect(connectionString, query);
                foreach (DataRow dRRacine in dataSet.Tables[0].Rows)
                {
                    TreeNode racine = new TreeNode(dRRacine[3].ToString(), 0, 1);

                    //on stocke l'identifant de la catégorie de bien
                    racine.Name = dRRacine[0].ToString();
                    String requete = "select * from categorieBien where idCategorieBienPere = "
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
                    subNode.Name = dRCourant[0].ToString();
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

        private void buttonAjouterCategorie_Click(object sender, EventArgs e)
        {
            if (treeViewCategorieBien.SelectedNode != null) //un noeud est seléctionné
            {               
                TreeNode node = treeViewCategorieBien.SelectedNode;
                TreeNode childNode = new TreeNode("Nouvelle catégorie", 0, 1);
                node.Nodes.Add(childNode);
                node.Expand();
                treeViewCategorieBien.SelectedNode = childNode;

                string idAmort = null;
                if (rBLineaire.Checked == true)
                    idAmort = "1";
                else
                    if (rBDegressif.Checked == true)
                        idAmort = "2";

                String query = "INSERT INTO CategorieBien (IdCategorieBienPere, IdAmort, DesigCategorieBien) VALUES (" + node.Name + "," + idAmort + ", '" + childNode.Text + "')";                
                MaConnexion.ExecuteUpdate(connectionString, query);
                DataSet ds =  MaConnexion.ExecuteSelect(connectionString, "select max(idCategorieBien) from categorieBien");
                childNode.Name = ds.Tables[0].Rows[0][0].ToString();
                childNode.BeginEdit();
            }
            else
            { //aucun noeud n'est selectionné
                TreeNode node = new TreeNode("Nouvelle catégorie", 0, 1);
                treeViewCategorieBien.Nodes.Add(node);
                treeViewCategorieBien.SelectedNode = node;
                string idAmort = null;
                if (rBLineaire.Checked == true)
                    idAmort = "1";
                else
                    if (rBDegressif.Checked == true)
                        idAmort = "2";

                String query = "INSERT INTO CategorieBien (IdCategorieBienPere, IdAmort, DesigCategorieBien) VALUES (NULL," + idAmort + ", '" + node.Text + "')";
                MaConnexion.ExecuteUpdate(connectionString, query);
                DataSet ds = MaConnexion.ExecuteSelect(connectionString, "select max(idCategorieBien) from categorieBien");
                node.Name = ds.Tables[0].Rows[0][0].ToString();
                node.BeginEdit();
            }
        }

        private void treeViewCategorieBien_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {            
            TreeNode node = treeViewCategorieBien.SelectedNode;
            string newName = null;
            if (e.Label != null)
                newName = e.Label;
            else
                newName = node.Text;
            String query = "update categorieBien set desigCategorieBien = '" + newName + "' where idCategorieBien = " + node.Name;            
            MaConnexion.ExecuteUpdate(connectionString, query);
        }

        private void treeViewCategorieBien_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeViewCategorieBien.SelectedNode;
            string query = "select idAmort from categorieBien where idCategorieBien = " + node.Name;
            DataSet ds = MaConnexion.ExecuteSelect(connectionString, query);
            try
            {
                String idCategorieBien = ds.Tables[0].Rows[0][0].ToString();            
                if (idCategorieBien == "1") // l'amortissement de la catégorie selectionnée est linéaire
                    rBLineaire.Checked = true;
                else
                    if (idCategorieBien == "2")
                        rBDegressif.Checked = true; //// l'amortissement de la catégorie selectionnée est dégressif
            }
            catch (Exception ex) // selection d'une nouvelle catégorie qui n'a pas encore d'amortissement
            {
                rBLineaire.Checked = true;
            }
                
            
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (treeViewCategorieBien.SelectedNode != null)
            {
                TreeNode node = treeViewCategorieBien.SelectedNode;
               
                string query = "delete from categorieBien where idCategorieBien = " + node.Name;
               
                if (MessageBox.Show("Voulez vous vraiment supprimer la catégorie " + node.Text + " ?", "Suppression d'une catégorie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                   // MaConnexion.ExecuteUpdate(connectionString, query);
                     if (MaConnexion.ExecuteUpdate(connectionString, query) == 1)
                         node.Remove();
                     else
                         MessageBox.Show("Impossible de supprimer cette catégorie. Cette occurence est utilisé harieur","Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }
            }
            else
                MessageBox.Show("Sélectionnez d'abord une catégorie", "Saisie incomplète", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rB_CheckedChanged(object sender, EventArgs e)
        {
            if (treeViewCategorieBien.SelectedNode != null)
            {
                TreeNode node = treeViewCategorieBien.SelectedNode;
                RadioButton rb = null;
                for (int i = 0; i < gBTypeAmortissement.Controls.Count; i++)
                {
                    rb = (RadioButton)gBTypeAmortissement.Controls[i];
                    if (rb.Checked) break;
                }
                                
                string idAmort = null;
                if (rb.Text == rBLineaire.Text)
                    idAmort = "1";
                else
                    if (rb.Text == rBDegressif.Text)
                        idAmort = "2";

                string query = "update categorieBien set idAmort = " + idAmort + " where idCategorieBien = " + node.Name;                
                MaConnexion.ExecuteUpdate(connectionString, query);
            }
            else
                MessageBox.Show("Sélectionnez d'abord une catégorie", "Saisie incomplète", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void treeViewCategorieBien_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = treeViewCategorieBien.GetNodeAt(e.X, e.Y);
            treeViewCategorieBien.SelectedNode = node;
            if (e.Button == MouseButtons.Right)
            {
                // La souris est bien au-dessus d'un menuItem
                if (node != null)
                {
                    cMSTreeViewCategorieBien.Show(treeViewCategorieBien, new Point(e.X, e.Y));
                }
            }

            //l'appuie sur une zone de l'arbre sans toucher un noeud déclanche une déselection du noeud selectionné
            if (node == null)
            {
                treeViewCategorieBien.SelectedNode = null;
                if (e.Button == MouseButtons.Right)
                {
                    cMSAjouterCatégorie.Show(treeViewCategorieBien, new Point(e.X, e.Y));
                }
            }
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();

            if (modifierBien != null && ajouterBien == null)
            {
                FormInventaire form = modifierBien.form;
                Point location = modifierBien.Location;
                modifierBien.Close();
                modifierBien = new ModifierBien(form);
                modifierBien.Location = location;
                modifierBien.tabControl1.SelectedIndex = 0;
                modifierBien.tabControl1.SelectedIndex = 1;
                modifierBien.Show();
            }
            else 
            {
                if (ajouterBien != null && modifierBien == null)
                {
                    ajouterBien.tabControl1.SelectedIndex = 0; //changer d'onglet pour provoquer l'evenement "Enter" sur tabPage0 et ainsi retrouver le nouvel amortissemnt correspondant 
                    ajouterBien.tabControl1.SelectedIndex = 1;
                }
            }
            
        }

        private void ajouterUneCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAjouterCategorie.PerformClick();
        }

        private void supprimerLaCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSupprimer.PerformClick();
        }

        private void FormGestionCategorie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (modifierBien != null && ajouterBien == null)
            {
                FormInventaire form = modifierBien.form;
                Point location = modifierBien.Location;
                modifierBien.Close();
                modifierBien = new ModifierBien(form);
                modifierBien.Location = location;
                modifierBien.tabControl1.SelectedIndex = 0;
                modifierBien.tabControl1.SelectedIndex = 1;
                modifierBien.Show();
            }
            else
            {
                if (ajouterBien != null && modifierBien == null)
                {
                    ajouterBien.tabControl1.SelectedIndex = 0; //changer d'onglet pour provoquer l'evenement "Enter" sur tabPage0 et ainsi retrouver le nouvel amortissemnt correspondant 
                    ajouterBien.tabControl1.SelectedIndex = 1;
                }

            }
        }

        private void FormGestionCategorie_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAjouterCategorie.PerformClick();
        }

    }
}
