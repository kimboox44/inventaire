
using System.Drawing.Printing;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Collections.ObjectModel;


namespace solution1
{
    public partial class Imprimer : Form
    {
        BarcodeLib.Barcode barecodeLib = new BarcodeLib.Barcode();
        private List<Bien> listeBien = null;
        string typeCodage = null;
        int numCodeBarres = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;


        public Imprimer(List<Bien> listeBien, string typeCodage)
        {
            this.listeBien = listeBien;
            this.typeCodage = typeCodage;
            InitializeComponent();
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {            
            Bitmap temp = new Bitmap(1, 1);
            temp.SetPixel(0, 0, this.BackColor);
            
            this.cbEncodeType.SelectedItem = typeCodage;
            this.cbBarcodeAlign.SelectedIndex = 0;
            this.cbLabelLocation.SelectedIndex = 0;

            this.cbRotateFlip.DataSource = System.Enum.GetNames(typeof(RotateFlipType));

            int i = 0;
            foreach (object o in cbRotateFlip.Items)
            {
                if (o.ToString().Trim().ToLower() == "rotatenoneflipnone")
                    break;
                i++;
            }//foreach
            this.cbRotateFlip.SelectedIndex = i;

            this.btnBackColor.BackColor = this.barecodeLib.BackColor;
            this.btnForeColor.BackColor = this.barecodeLib.ForeColor;

            //Encodage
            btnEncode.PerformClick();

        }//Form1_Load

        private void btnEncode_Click(object sender, EventArgs e)
        {
            dGVCodeBarres.Rows.Clear();
            errorProvider1.Clear();
            int W = (int)(float.Parse(this.txtWidth.Text.Trim()) * 37.795275591f); //41.15226f
            int H = (int)(float.Parse(this.txtHeight.Text.Trim()) * 37.795275591f);  //37.795275591f
            BarcodeLib.AlignmentPositions Align = BarcodeLib.AlignmentPositions.CENTER;

            //barcode alignment            
            switch (traduireAlignement(cbBarcodeAlign.SelectedItem.ToString().Trim().ToLower()))
            {
                case "left": Align = BarcodeLib.AlignmentPositions.LEFT;  break;
                case "right": Align = BarcodeLib.AlignmentPositions.RIGHT; break;
                default: Align = BarcodeLib.AlignmentPositions.CENTER; break;
            }//switch

            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            switch (cbEncodeType.SelectedItem.ToString().Trim())
            {
                case "UPC-A": type = BarcodeLib.TYPE.UPCA; break;
                case "UPC-E": type = BarcodeLib.TYPE.UPCE; break;
                case "UPC 2 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_2DIGIT; break;
                case "UPC 5 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_5DIGIT; break;
                case "EAN-13": type = BarcodeLib.TYPE.EAN13; break;
                case "JAN-13": type = BarcodeLib.TYPE.JAN13; break;
                case "EAN-8": type = BarcodeLib.TYPE.EAN8; break;
                case "ITF-14": type = BarcodeLib.TYPE.ITF14; break;
                case "Codabar": type = BarcodeLib.TYPE.Codabar; break;
                case "PostNet": type = BarcodeLib.TYPE.PostNet; break;
                case "Bookland/ISBN": type = BarcodeLib.TYPE.BOOKLAND; break;
                case "Code 11": type = BarcodeLib.TYPE.CODE11; break;
                case "Code 39": type = BarcodeLib.TYPE.CODE39; break;
                case "Code 39 Extended": type = BarcodeLib.TYPE.CODE39Extended; break;
                case "Code 93": type = BarcodeLib.TYPE.CODE93; break;
                case "LOGMARS": type = BarcodeLib.TYPE.LOGMARS; break;
                case "MSI": type = BarcodeLib.TYPE.MSI_Mod10; break;
                case "Interleaved 2 of 5": type = BarcodeLib.TYPE.Interleaved2of5; break;
                case "Standard 2 of 5": type = BarcodeLib.TYPE.Standard2of5; break;
                case "Code 128": type = BarcodeLib.TYPE.CODE128; break;
                case "Code 128-A": type = BarcodeLib.TYPE.CODE128A; break;
                case "Code 128-B": type = BarcodeLib.TYPE.CODE128B; break;
                case "Code 128-C": type = BarcodeLib.TYPE.CODE128C; break;
                case "Telepen": type = BarcodeLib.TYPE.TELEPEN; break;
                default: MessageBox.Show("Sélectionnez le type d'encodage", "Norme", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
            }//switch

            try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    barecodeLib.IncludeLabel = this.chkGenerateLabel.Checked;
                    barecodeLib.Alignment = Align;
                    barecodeLib.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), this.cbRotateFlip.SelectedItem.ToString(), true);

                    //label alignment and position
                    switch ( traduirePosition(this.cbLabelLocation.SelectedItem.ToString().Trim().ToUpper()))
                    {
                        case "BOTTOMLEFT": barecodeLib.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT; break;
                        case "BOTTOMRIGHT": barecodeLib.LabelPosition = BarcodeLib.LabelPositions.BOTTOMRIGHT; break;
                        case "TOPCENTER": barecodeLib.LabelPosition = BarcodeLib.LabelPositions.TOPCENTER; break;
                        case "TOPLEFT": barecodeLib.LabelPosition = BarcodeLib.LabelPositions.TOPLEFT; break;
                        case "TOPRIGHT": barecodeLib.LabelPosition = BarcodeLib.LabelPositions.TOPRIGHT; break;
                        default: barecodeLib.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER; break;
                    }//switch

                    try
                    {
                        dGVCodeBarres.RowTemplate.Height = (int)(float.Parse(this.txtHeight.Text.Trim()) * 37.795275591f) + 20;
                        if ((int)(float.Parse(this.txtWidth.Text.Trim()) * 37.795275591f) > 300)
                            dGVCodeBarres.Columns["ColumnCB"].Width = (int)(float.Parse(this.txtWidth.Text.Trim()) * 37.795275591f) + 20;

                        //augmentation des dimentions de l'image pour inserer le logo
                        //dGVCodeBarres.RowTemplate.Height += dGVCodeBarres.RowTemplate.Height / 2;
                        //dGVCodeBarres.Columns["ColumnCB"].Width += dGVCodeBarres.Columns["ColumnCB"].Width / 2;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur de redimentionnement du datagridview", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //===== Encoding performed here =====
                    for (int i = 0; i < listeBien.Count; i++) 
                    {
                        Image image = barecodeLib.Encode(BarcodeLib.TYPE.CODE128, listeBien[i].getIdentifiant(), this.btnForeColor.BackColor, this.btnBackColor.BackColor, W, H / 2);

                        Brush textBrush = new System.Drawing.SolidBrush( Color.Black);
                        StringFormat stringFlags = new StringFormat();
                        Rectangle tabBounds = new Rectangle(new Point(50, 100), new Size(W, 50));
                        stringFlags.Alignment = StringAlignment.Center;
                        stringFlags.LineAlignment = StringAlignment.Center;
                        Font font = new Font("Code 39 JK", (float)12.0, FontStyle.Regular, GraphicsUnit.Pixel);

                        Bitmap m_Bitmap = new Bitmap(global::solution1.Properties.Resources.CB, 50, 50);
                        Bitmap m_BitmapCB = new Bitmap(image);
                        Graphics g = Graphics.FromImage(image);

                        g.DrawString(listeBien[i].getDesignation(), font, textBrush, tabBounds, stringFlags);
                       

                        //g.DrawImage(m_Bitmap, 0, 0);
                        g.DrawImage(image, 0, 15);


                        Object[] row = new Object[] { m_BitmapCB };
                        
                        dGVCodeBarres.Rows.Add(row);
                        //Graphics g = ((DataGridViewImageCell)dGVCodeBarres.Rows[dGVCodeBarres.Rows.Count-2].Cells[0].Value). .Graphics;
                        //g.DrawImage(theImage, ClientRectangle);

                    }
                    
                }//if
            }//try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//catch
        }//btnEncode_Click

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 2;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  savetype = BarcodeLib.SaveTypes.BMP; break;
                    case 2: /* GIF */  savetype = BarcodeLib.SaveTypes.GIF; break;
                    case 3: /* JPG */  savetype = BarcodeLib.SaveTypes.JPG; break;
                    case 4: /* PNG */  savetype = BarcodeLib.SaveTypes.PNG; break;
                    case 5: /* TIFF */ savetype = BarcodeLib.SaveTypes.TIFF; break;
                    default: break;
                }//switch
                barecodeLib.SaveImage(sfd.FileName, savetype);
            }//if
        }//btnSave_Click

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
           
        }//splitContainer1_SplitterMoved

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    this.barecodeLib.ForeColor = cdialog.Color;
                    this.btnForeColor.BackColor = this.barecodeLib.ForeColor;
                }//if
            }//using
        }//btnForeColor_Click

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    this.barecodeLib.BackColor = cdialog.Color;
                    this.btnBackColor.BackColor = this.barecodeLib.BackColor;
                }//if
            }//using
        }//btnBackColor_Click

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            btnEncode_Click(sender, e);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML Files|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                    {
                        sw.Write(barecodeLib.XML);
                    }//using
                }//if
            }//using
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }//btnGetXML_Click

        string traduireAlignement(string alig)
        {
            switch (alig)
            {
                case "centre": alig = "center"; break;
                case "gauche": alig = "left"; break;
                case "droite": alig = "right"; break;
            }
            return alig;
        }

        string traduirePosition(string pos) 
        {
            switch (pos)
            {
                case "bas centre": pos = "bottomcenter"; break;
                case "bas gauche": pos = "bottomleft"; break;
                case "bas droite": pos = "bottomright"; break;
                case "haut centre": pos = "topcenter"; break;
                case "haut gauche": pos = "topleft"; break;
                case "haut droite": pos = "topright"; break;                
            }
            return pos;
        }

        private void cbLabelLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbBarcodeAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chkGenerateLabel_CheckedChanged(object sender, EventArgs e)
        {
            try { btnEncode.PerformClick(); }
            catch (Exception) { } 
        }

        private void bImprimer_Click(object sender, EventArgs e)
        {

        }

        private void bImprimer_Click_1(object sender, EventArgs e)
        {
            numCodeBarres = 0;
            PrintDocument printDocument = new PrintDocument();                

            PrintDialog pdd = new PrintDialog();
            pdd.ShowDialog();
    
            while (numCodeBarres < dGVCodeBarres.Rows.Count-1) 
            {
                Console.WriteLine("numCodeBarres : " + numCodeBarres);
                string key = "+{PRTSC}";                
                SendKeys.SendWait(key);                
                printDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);                
                pdd.Document = printDocument;
                printDocument.Print();                                
                numCodeBarres++;                
            }
     
        }




        

        public Image GetImageById(int imageID)
        {
            Image result = null;
            SqlDataReader imageReader;

            SqlConnection conn = new SqlConnection(connectionString);// your connection string I place mine for illustration.. DON'T HARDLY WRITE IT, pass it as argument or add it in application configuration 
            string selectString = "[dbo].[GetImageByID]";
            SqlCommand selectCommand = new SqlCommand(selectString, conn);
            selectCommand.CommandType = CommandType.StoredProcedure;
            selectCommand.Parameters.AddWithValue("@id", imageID.ToString());

            conn.Open();
            imageReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (imageReader.Read())
            {
                result = Image.FromStream(new MemoryStream((byte[])imageReader.GetValue(0)));
            }
            return result;
        }
        





        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {            
            Point posBacode = new Point(5, 45);
            Point posLogo = new Point(5, 2);
            Brush textBrush = new System.Drawing.SolidBrush( Color.Black);
            StringFormat stringFlags = new StringFormat();
            Rectangle tabBounds = new Rectangle(new Point(0, 80), new Size(200, 20));
            Rectangle tabBoundDate = new Rectangle(new Point(50, 10), new Size(150, 10));
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;
            Font font = new Font("Lucida Fax", (float)12.0, FontStyle.Regular, GraphicsUnit.Pixel);

           // DataSet ds = MaConnexion.ExecuteSelect(connectionString, "select * from information");

            //Image i = Image.FromStream(E:\Mobility\Projects\asset\solution1\solution1\bin\Debug\logo\logo.jpg);


            //Image i = GetImageById(1);

            Bitmap m_Bitmap = new Bitmap((Bitmap)GetImageById(1),40,40);
            

           // Bitmap m_Bitmap = new Bitmap(global::solution1.Properties.Resources.Sogral, 30, 30);

            e.Graphics.DrawImage(m_Bitmap, posLogo);
            e.Graphics.DrawImage((Image)dGVCodeBarres.Rows[numCodeBarres].Cells[0].Value, posBacode);
            e.Graphics.DrawString(listeBien[numCodeBarres].getDesignation(), font, textBrush, tabBounds, stringFlags);
            e.Graphics.DrawString(listeBien[numCodeBarres].getAncien(), font, textBrush, tabBoundDate, stringFlags);
        }
        
        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0X0D)
                btnEncode.PerformClick();
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0X0D)
                btnEncode.PerformClick();
        }

        private void cbRotateFlip_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
        }

        private void txtHeight_Validating(object sender, CancelEventArgs e)
        {
            btnEncode.PerformClick();            
        }

        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            btnEncode.PerformClick();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Image)dGVCodeBarres.Rows[0].Cells[0].Value).Save("E:/Mobility/Projects/asset/solution1/solution1/Resources/CB.jpeg");
        }

       

        private void dGVCodeBarres_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (this.dGVCodeBarres.Columns["ColumnCB"].Index == e.ColumnIndex && e.RowIndex >= 0) 
            {
                e.Graphics.DrawImage(global::solution1.Properties.Resources.CB, new Rectangle(e.CellBounds.X + 20, e.CellBounds.Y + 20, 30, 20));
            }

        }

        private void cbEncodeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
