using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace solution1.Rapport
{
    public partial class Rapports : Form
    {
        public Rapports()
        {
            InitializeComponent();
        }

      
        UserControl_listebiens biens = new UserControl_listebiens();
        UserControllisate_ibenpar_catégorie catgorie_bien = new UserControllisate_ibenpar_catégorie();
        UserCrt_statistique stat = new UserCrt_statistique();
        UC_bien_pers bien_pers = new UC_bien_pers();

        private void liste_bien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            biens.Location = new Point(10, 10);
            panelbien.Controls.Clear();
            panelbien.Controls.Add(biens);
        }


        private void bien_categorie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            catgorie_bien.Location = new Point(10, 10);
            panelbien.Controls.Clear();
            panelbien.Controls.Add(catgorie_bien);
        }

        private void Statistique_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stat.Location = new Point(10, 10);
            panelbien.Controls.Clear();
            panelbien.Controls.Add(stat);
        }

        private void personne_bien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stat.Location = new Point(10, 10);
            panelbien.Controls.Clear();
            panelbien.Controls.Add(bien_pers);
        }
    }
}
