using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using solution1.gestion_utilisateur;

namespace solution1.Prenom
{
    public partial class Admin : Form

    {
            ajout_utilisateur ajout = new ajout_utilisateur();
            modifier_suprimer_utilisateur modif_sup = new modifier_suprimer_utilisateur();
        public Admin()
        {
            InitializeComponent();
        }

  

        private void Ajout_util_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            panel.Controls.Clear();
            panel.Controls.Add(ajout);
            
        }

        private void mod_sup_util_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();


            panel.Controls.Add(modif_sup);


            modif_sup.dataGrid_utilisateur.CellClick += charger;
        }

        private void charger(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("le " + modif_sup.mot.ToString());
            //panel.Controls.Add(new modifier_utilisateur(modif_sup.mot, modif_sup.log));
            if (modif_sup.dataGrid_utilisateur.Columns[e.ColumnIndex].Name == "Modifier") //click sur le bouton de modification ou d'ajout
            {
                panel.Controls.Add(new modifier_utilisateur(modif_sup.dataGrid_utilisateur.Rows[e.RowIndex].Cells["mot_pass"].Value.ToString(), modif_sup.dataGrid_utilisateur.Rows[e.RowIndex].Cells["login"].Value.ToString()));
                panel.Controls.Remove(modif_sup);
            }

        }


        import_export.import_bloc importbloc = new import_export.import_bloc();
        import_export.import_tab importtab = new import_export.import_tab();
        import_export.export_données exportbdd = new import_export.export_données();
        import_export.vider_BDD vider = new import_export.vider_BDD();
        Information.inform inf = new Information.inform();

        private void import_bloc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //panel.Controls.Clear();
            panel.Controls.Clear();
            panel.Controls.Add(importbloc);
        }

        private void import_tab_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //panel.Controls.Clear();
            panel.Controls.Clear();
            panel.Controls.Add(importtab);
        }

        private void expoter_bdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // panel.Controls.Clear();
            panel.Controls.Clear();
            panel.Controls.Add(exportbdd);

        }

        private void vider_bdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            panel.Controls.Clear();
            panel.Controls.Add(vider);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(inf);
        }
    }
}
