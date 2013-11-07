using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace solution1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("McSkin");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent());
            //Application.Run(new Form1(null, "0"));
            //Application.Run(new AjouterBien(new Form1(null, "0")));            
            //Application.Run(new Comparer2Inventaires("2"));
            //Application.Run(new FormGestionCategorie());
            //Application.Run(new AjouterOuvrage(new Form1(null, "0")));
            //Application.Run(new GénérerRapport());
            //List<string> list = new List<string>() { "038000356216", "123456789012", "1234876756423" };
            //List<string> list = new List<string>() { "0380003562", "1234567890", "1234876756" };
            //List<string> list = new List<string>() { "0380003562"};
            //Application.Run(new Imprimer(list, "Code 39"));
            //Application.Run(new OuvrirInventaire());
            //Application.Run(new GestionUtilisteurInventaire()); 
            //Application.Run(new FormAdhérent());
            //Application.Run(new FormPortique());            
            //Application.Run(new PVs());
            //Application.Run(new FormBonsDeTransfert());
            //Application.Run(new AjouterBonDeTransfert());
            //Application.Run(new FormCRBonTransfert("21"));
            //Application.Run(new FormCRRetracerBien());
            //Application.Run(new FormCRInventairesDeBien());                        
            //Application.Run(new FormRapports());     
            //Application.Run(new MAJClient());
            //Application.Run(new MAJFournisseur());
            //Application.Run(new AjouterBien(null));
            //Application.Run(new MAJSites());
            //Application.Run(new MAJResponsableEmplacement("2","26"));
            //Application.Run(new MAJResponsableSite("2"));
        }
    }
}
