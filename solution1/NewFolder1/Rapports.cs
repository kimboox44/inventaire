using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solution1.Rapport
{
    public partial class Rapports : Form
    {
        public Rapports()
        {
            InitializeComponent();
        }
        UserControlListeBiens biens = new UserControlListeBiens();
        private void liste_bien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelbien.Controls.Clear();
            panelbien.Controls.Add(biens);
        }
    }
}
