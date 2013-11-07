using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solution1
{
    public partial class GénérerRapport : Form
    {
        string idUtilisateur = null;
        public GénérerRapport(string idUtilisateur)
        {
            this.idUtilisateur = idUtilisateur;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    /*    private void button1_Click(object sender, EventArgs e)
        {
            switch (lBRapports.SelectedIndex) 
            {
                case 0 : (new FormCRListeBien()).Show(); break;                
                case 1: (new FormCRBienParCategorie()).Show(); break;                
                case 2: (new FormCRBienParInventaireSiteEmpla()).Show(); break;                
                case 3: (new Comparer2Inventaires(idUtilisateur)).Show(); break;                
            }            
        }*/

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            bGénérer.PerformClick();
        }

        private void lBRapports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
