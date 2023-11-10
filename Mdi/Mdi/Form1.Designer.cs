namespace Mdi
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaiqueHorizontaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLeTraqueurDeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLesCasHebdomadaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multifenetreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fERMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.fenetreToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.fERMERToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.fToolStripMenuItem.Text = "Fichier";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.policeToolStripMenuItem,
            this.couleurToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.editionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.editionToolStripMenuItem.Text = "Edition";
            this.editionToolStripMenuItem.Click += new System.EventHandler(this.edition);
            // 
            // policeToolStripMenuItem
            // 
            this.policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            this.policeToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.policeToolStripMenuItem.Text = "Police";
            this.policeToolStripMenuItem.Click += new System.EventHandler(this.policeToolStripMenuItem_Click);
            // 
            // couleurToolStripMenuItem
            // 
            this.couleurToolStripMenuItem.Name = "couleurToolStripMenuItem";
            this.couleurToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.couleurToolStripMenuItem.Text = "Couleur";
            this.couleurToolStripMenuItem.Click += new System.EventHandler(this.couleurToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.themeToolStripMenuItem.Text = "Theme";
            this.themeToolStripMenuItem.Click += new System.EventHandler(this.themeToolStripMenuItem_Click);
            // 
            // fenetreToolStripMenuItem
            // 
            this.fenetreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.editionToolStripMenuItem1,
            this.mosaiqueHorizontaleToolStripMenuItem,
            this.ouvrirLeTraqueurDeContactToolStripMenuItem,
            this.ouvrirLesCasHebdomadaireToolStripMenuItem,
            this.multifenetreToolStripMenuItem});
            this.fenetreToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fenetreToolStripMenuItem.Name = "fenetreToolStripMenuItem";
            this.fenetreToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.fenetreToolStripMenuItem.Text = "Fenetre";
            this.fenetreToolStripMenuItem.Click += new System.EventHandler(this.fenetre);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascade);
            // 
            // editionToolStripMenuItem1
            // 
            this.editionToolStripMenuItem1.Name = "editionToolStripMenuItem1";
            this.editionToolStripMenuItem1.Size = new System.Drawing.Size(273, 24);
            this.editionToolStripMenuItem1.Text = "Mosaique verticale";
            this.editionToolStripMenuItem1.Click += new System.EventHandler(this.mosaiqueVerticale);
            // 
            // mosaiqueHorizontaleToolStripMenuItem
            // 
            this.mosaiqueHorizontaleToolStripMenuItem.Name = "mosaiqueHorizontaleToolStripMenuItem";
            this.mosaiqueHorizontaleToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.mosaiqueHorizontaleToolStripMenuItem.Text = "Mosaique horizontale";
            this.mosaiqueHorizontaleToolStripMenuItem.Click += new System.EventHandler(this.mosaiqueHorizontale);
            // 
            // ouvrirLeTraqueurDeContactToolStripMenuItem
            // 
            this.ouvrirLeTraqueurDeContactToolStripMenuItem.Name = "ouvrirLeTraqueurDeContactToolStripMenuItem";
            this.ouvrirLeTraqueurDeContactToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.ouvrirLeTraqueurDeContactToolStripMenuItem.Text = "Ouvrir le traqueur de contact";
            this.ouvrirLeTraqueurDeContactToolStripMenuItem.Click += new System.EventHandler(this.ouvrirLeTraqueurDeContact);
            // 
            // ouvrirLesCasHebdomadaireToolStripMenuItem
            // 
            this.ouvrirLesCasHebdomadaireToolStripMenuItem.Name = "ouvrirLesCasHebdomadaireToolStripMenuItem";
            this.ouvrirLesCasHebdomadaireToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.ouvrirLesCasHebdomadaireToolStripMenuItem.Text = "Ouvrir les cas hebdomadaire";
            this.ouvrirLesCasHebdomadaireToolStripMenuItem.Click += new System.EventHandler(this.ouvrirLesCasHebdomadaire);
            // 
            // multifenetreToolStripMenuItem
            // 
            this.multifenetreToolStripMenuItem.Name = "multifenetreToolStripMenuItem";
            this.multifenetreToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.multifenetreToolStripMenuItem.Text = "multifenetre";
            this.multifenetreToolStripMenuItem.Click += new System.EventHandler(this.multifenetreToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aideToolStripMenuItem.Image = global::Mdi.Properties.Resources.help1;
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aPropos);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Image = global::Mdi.Properties.Resources.new2;
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.ToolTipText = "Créer un nouveau fichier";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveau);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = global::Mdi.Properties.Resources.open2;
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.ToolTipText = "Ouvrir un fichier existant";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrir);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = global::Mdi.Properties.Resources._03_enregistrer;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrer);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Image = global::Mdi.Properties.Resources._03_enregistrer;
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSous);
            // 
            // fERMERToolStripMenuItem
            // 
            this.fERMERToolStripMenuItem.Image = global::Mdi.Properties.Resources.exit2;
            this.fERMERToolStripMenuItem.Name = "fERMERToolStripMenuItem";
            this.fERMERToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.fERMERToolStripMenuItem.Text = "Fermer";
            this.fERMERToolStripMenuItem.Click += new System.EventHandler(this.fERMER);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::Mdi.Properties.Resources.close2;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitter);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Image = global::Mdi.Properties.Resources._04_couper;
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Image = global::Mdi.Properties.Resources._05_copier;
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Image = global::Mdi.Properties.Resources._06_coller;
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 359);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fERMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenetreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mosaiqueHorizontaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLeTraqueurDeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLesCasHebdomadaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multifenetreToolStripMenuItem;
    }
}

