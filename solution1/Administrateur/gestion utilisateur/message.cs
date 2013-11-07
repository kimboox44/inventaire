using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solution1.Prenom.gestion_utilisateur
{
    public partial class message : Form
    {
        
        public message()
        {
            InitializeComponent();
            //ajout_admin( nom, prenom, login,  pass);
        }

        private void message_Load(object sender, EventArgs e)
        {
         
        }

        public void ajout_admin(string nom, string prenom, string login, string pass)
        {
            panel_ajoutadmin.Visible = true;
            panel_util.Visible = false;
            //ajout_util.
            label6.Text = nom;
            label7.Text = prenom;
            label8.Text = login;
            label9.Text = pass;

        }
        public void ajout_util(string nom, string prenom, string login, string pass,DataGridView data) 
        {
            panel_ajoutadmin.Visible =false;
            panel_util.Visible = true;

            label13.Text = nom;
            label12.Text = prenom;
            label11.Text = login;
            label10.Text = pass;

            int nbrow = data.Rows.Count;

            for (int i = 0; i < nbrow - 1; i++)
            {
                string privilege = data.Rows[i].Cells[0].Value.ToString();
                string droit = data.Rows[i].Cells[1].Value.ToString();
                label20.Text = droit +" "+ privilege;
            }
            


        }

        private void ok_Click(object sender, EventArgs e)
        {
            solution1.gestion_utilisateur.ajout_utilisateur ajout_util = new solution1.gestion_utilisateur.ajout_utilisateur();
            
            //Admin.
            this.Close();
        }
    }
}
