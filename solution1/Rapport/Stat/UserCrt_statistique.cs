using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solution1.Rapport
{
    public partial class UserCrt_statistique : UserControl
    {
        public UserCrt_statistique()
        {
            InitializeComponent();
            



            BienTableAdapter.Fill(DataSet_stat.Bien);
            reportViewer1.RefreshReport();

            //DataTable1TableAdapter.Fill(Rapport.Data_rapport2.DataTable1);


       
        }

        private void UserCrt_statistique_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }



    }
}
