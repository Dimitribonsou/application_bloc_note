using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdi
{
    public partial class Form1 : Form
    {
        string textcopie = "Bonjour";
        Form2 ft = new Form2();
        private string text;
        private string textBox;
        public Form1()
        {
            InitializeComponent();
        }


        private void nouveau(object sender, EventArgs e)
        {
            Form formTextEditor = new Form();
            formTextEditor.MdiParent = this;
            formTextEditor.Text = "Nouveau fichier.txt";
            formTextEditor.Show();
            Form2 Child = new Form2();
            Child.MdiParent = this;
            Child.Dock = DockStyle.Fill;
            Child.Show();

        }

        private void ouvrir(object sender, EventArgs e)
        {
            Form2 Child = new Form2();
            Child.MdiParent = this;
            //Child.Show();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                Child.richTextBox1.Text = sr.ReadToEnd();
                Child.Dock = DockStyle.Fill;
                Child.Show();
            }
            //if (openFileDialog.ShowDialog() == DialogResult.OK) {
            //    string filePath = openFileDialog.FileName;
            //    string fileContent = File.ReadAllText(filePath);
            //    Form formTextEditor = new Form();
            //    formTextEditor.MdiParent = this;
            //    formTextEditor.Text = filePath;
            //    TextBox textBox = new TextBox();
            //    textBox.Multiline = true;
            //    textBox.Dock = DockStyle.Fill;
            //    formTextEditor.Controls.Add(textBox);
            //    formTextEditor.Show();
            //    Form2 fm=new Form2();


            //}
        }

        private void copier(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        // Place le texte sélectionné dans le Presse-papiers.
                        Clipboard.SetDataObject(theBox.SelectedText);
                    }
                }
                catch
                {
                    MessageBox.Show("Vous devez sélectionner une RichTextBox.");
                }
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascade(object sender, EventArgs e)
        {
            Form2 Child = new Form2();

           this.LayoutMdi(MdiLayout.Cascade);
            //Form2 Child = new Form2();
            //Child.MdiParent = this;
            //this.LayoutMdi(MdiLayout.Cascade);
            //Child.Show();
        }

        private void mosaiqueVerticale(object sender, EventArgs e)
        {
            Form2 Child = new Form2();
            Child.MdiParent = this;

            this.LayoutMdi(MdiLayout.TileVertical);
            //Child.Show();
        }

        private void mosaiqueHorizontale(object sender, EventArgs e)
        {
            //Form2 Child = new Form2();
            //Child.MdiParent = this;
            this.LayoutMdi(MdiLayout.TileHorizontal);
            //Child.Show();
        }

        private void edition(object sender, EventArgs e)
        {
            this.Text = "Editeur de texte";
        }

        private void ouvrirLeTraqueurDeContact(object sender, EventArgs e)
        {
            //formContactTracker contactTracker = new formContactTracker();
            //contactTracker.mdiParent = this;
            //contactTracker.Show();
            Form fcontact = new Form();
            fcontact.MdiParent = this;
            //fcontact.Dock = DockStyle.Fill;
            fcontact.Show();
            Contact contact = new Contact();
            contact.MdiParent = this;
            contact.Dock = DockStyle.Fill;
            contact.Show();


            //formContactTracer contactTracer = new formContactTracer();
            //contactTracer.mdiParent = this;
            // contactTracer.Show();
            //configuration initial de la fenetre du traqueur de contact
            this.Text = "Traqueur de contact";
            //ButtonBase.Enabled = false;

        }

        private void ouvrirLesCasHebdomadaire(object sender, EventArgs e)
        {
            formWeeklyCases weeKlyCases = new formWeeklyCases();
            weeKlyCases.mdiParent = this;
            weeKlyCases.Show();
        }

        private void quitter(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fERMER(object sender, EventArgs e)
        {
            Form fr = new Form();
            fr.MdiParent = this;
            fr.Dock = DockStyle.Fill;
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Show();
            //this.Close();
        }

        private void enregistrer(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                using (StreamWriter writer = new StreamWriter(currentFilePath))
                {
                    //writer.Write(ft.richTextBox1.Text);
                }

            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers texte(*.txt)|*.txt|fichiers doc(*.doc)|*.doc";
                saveFileDialog.Title = "Enregistrer ";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    currentFilePath = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine(ft.richTextBox1.Text);
                        MessageBox.Show("Fichier bien  enregistrer !!");
                    }

                }
            }
        }

        public string currentFilePath { get; set; }

        private void fenetre(object sender, EventArgs e)
        {
            formTextEditor textEditor = new formTextEditor();
            textEditor.MdiParent = this;
            textEditor.Show();
        }

        private void enregistrerSous(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Enregistrer Sous";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                currentFilePath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine(ft.richTextBox1.Text);
                    MessageBox.Show("Fichier bien  enregistrer !!");
                }

            }

        }

        private void aPropos(object sender, EventArgs e)
        {
            MessageBox.Show("Ceci est une application MDI de la societé FIANGAN Impimerie");
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // textcopie = string.Copy(ft.richTextBox1.SelectedText);
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        // Place le texte sélectionné dans le Presse-papiers.

                        Clipboard.SetDataObject(theBox.SelectedText);
                    }
                }
                catch
                {
                    MessageBox.Show("Vous devez sélectionner une RichTextBox.");
                }
            }
            //Form2 f2 = new Form2();
            //try
            //{
            //    if (f2.richTextBox1.SelectedText!=null)
            //    {
            //        Clipboard.SetText(f2.richTextBox1.SelectedText);
            //    }

            //}
            //catch (Exception x)
            //{

            //    MessageBox.Show(x.Message); ;
            //}


        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        // Place le texte sélectionné dans le Presse-papiers.
                        theBox.Cut();


                    }
                }
                catch
                {
                    MessageBox.Show("Vous devez sélectionner une RichTextBox.");
                }
            }
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ft.richTextBox1.Text = ft.richTextBox1.Text + textcopie;

            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (Clipboard.ContainsText())
                    {
                        theBox.Paste();
                    }
                }
                catch
                {
                    MessageBox.Show("Vous devez sélectionner une RichTextBox.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Form activeChild = this.ActiveMdiChild;
                if (activeChild != null)
                {
                    try
                    {
                        RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                        if (theBox != null)
                        {
                            // Place le texte sélectionné dans le Presse-papiers.
                   
                            theBox.Font = fd.Font;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vous devez sélectionner une RichTextBox.");
                    }
                }
            }
        }

        private void couleurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (activeChild != null)
                {
                    try
                    {
                        RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                        if (theBox != null)
                        {
                            // Place le texte sélectionné dans le Presse-papiers.

                            theBox.ForeColor = cd.Color;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vous devez sélectionner une RichTextBox.");
                    }
                }
            }

            }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (activeChild != null)
                {
                    try
                    {
                        RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                        if (theBox != null)
                        {
                            // Place le texte sélectionné dans le Presse-papiers.

                            theBox.BackColor = cd.Color;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vous devez sélectionner une RichTextBox.");
                    }
                }
            }
        }

        private void multifenetreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=0;i<3;i++)
            {
                fenetre fg = new fenetre();
                fg.MdiParent = this;
                fg.Show();
            }
                
            
            
        }
           
    }
}
