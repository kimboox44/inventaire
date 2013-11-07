using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solution1.Rapport.liste_des_biens
{
    public partial class UserControl_biens : UserControl
    {
        public UserControl_biens()
        {
            InitializeComponent();


      
   

           dataTable1TableAdapter1.Fill(dataSet_rapport1.DataTable1);
            reportViewer1.RefreshReport();        
        }

        private void UserControl_biens_Load(object sender, EventArgs e)
        {

        }
    }
}
