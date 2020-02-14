namespace FormatNewLanguageText
{
  partial class FormMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.textBoxSource = new System.Windows.Forms.TextBox();
      this.textBoxFormatted = new System.Windows.Forms.TextBox();
      this.buttonFormatText = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aperçuavantimpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listBoxWords = new System.Windows.Forms.ListBox();
      this.buttonCopy = new System.Windows.Forms.Button();
      this.buttonRemoveDuplicate = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxSource
      // 
      this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxSource.Location = new System.Drawing.Point(12, 45);
      this.textBoxSource.Multiline = true;
      this.textBoxSource.Name = "textBoxSource";
      this.textBoxSource.Size = new System.Drawing.Size(764, 245);
      this.textBoxSource.TabIndex = 0;
      this.textBoxSource.Text = resources.GetString("textBoxSource.Text");
      // 
      // textBoxFormatted
      // 
      this.textBoxFormatted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxFormatted.Location = new System.Drawing.Point(12, 336);
      this.textBoxFormatted.Multiline = true;
      this.textBoxFormatted.Name = "textBoxFormatted";
      this.textBoxFormatted.Size = new System.Drawing.Size(764, 400);
      this.textBoxFormatted.TabIndex = 1;
      // 
      // buttonFormatText
      // 
      this.buttonFormatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonFormatText.Location = new System.Drawing.Point(12, 307);
      this.buttonFormatText.Name = "buttonFormatText";
      this.buttonFormatText.Size = new System.Drawing.Size(92, 23);
      this.buttonFormatText.TabIndex = 2;
      this.buttonFormatText.Text = "Format text";
      this.buttonFormatText.UseVisualStyleBackColor = true;
      this.buttonFormatText.Click += new System.EventHandler(this.ButtonFormatText_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator,
            this.enregistrerToolStripMenuItem,
            this.enregistrersousToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem,
            this.aperçuavantimpressionToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // nouveauToolStripMenuItem
      // 
      this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
      this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
      this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.nouveauToolStripMenuItem.Text = "&Nouveau";
      // 
      // ouvrirToolStripMenuItem
      // 
      this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
      this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
      this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      // 
      // enregistrersousToolStripMenuItem
      // 
      this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
      this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
      // 
      // imprimerToolStripMenuItem
      // 
      this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
      this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
      this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.imprimerToolStripMenuItem.Text = "&Imprimer";
      // 
      // aperçuavantimpressionToolStripMenuItem
      // 
      this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
      this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
      this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      // 
      // editionToolStripMenuItem
      // 
      this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripSeparator3,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator4,
            this.sélectionnertoutToolStripMenuItem});
      this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.couperToolStripMenuItem.Text = "&Couper";
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copierToolStripMenuItem.Text = "Co&pier";
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.collerToolStripMenuItem.Text = "Co&ller";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.outilsToolStripMenuItem.Text = "&Outils";
      // 
      // personnaliserToolStripMenuItem
      // 
      this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
      this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // aideToolStripMenuItem
      // 
      this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaireToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.toolStripSeparator5,
            this.àproposdeToolStripMenuItem});
      this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // sommaireToolStripMenuItem
      // 
      this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
      this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.sommaireToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // rechercherToolStripMenuItem
      // 
      this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
      this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.rechercherToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
      // 
      // listBoxWords
      // 
      this.listBoxWords.FormattingEnabled = true;
      this.listBoxWords.Location = new System.Drawing.Point(783, 336);
      this.listBoxWords.Name = "listBoxWords";
      this.listBoxWords.Size = new System.Drawing.Size(260, 381);
      this.listBoxWords.Sorted = true;
      this.listBoxWords.TabIndex = 4;
      // 
      // buttonCopy
      // 
      this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCopy.Location = new System.Drawing.Point(783, 307);
      this.buttonCopy.Name = "buttonCopy";
      this.buttonCopy.Size = new System.Drawing.Size(92, 23);
      this.buttonCopy.TabIndex = 5;
      this.buttonCopy.Text = "Copy";
      this.buttonCopy.UseVisualStyleBackColor = true;
      this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
      // 
      // buttonRemoveDuplicate
      // 
      this.buttonRemoveDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonRemoveDuplicate.Location = new System.Drawing.Point(110, 307);
      this.buttonRemoveDuplicate.Name = "buttonRemoveDuplicate";
      this.buttonRemoveDuplicate.Size = new System.Drawing.Size(128, 23);
      this.buttonRemoveDuplicate.TabIndex = 6;
      this.buttonRemoveDuplicate.Text = "Remove Duplicate";
      this.buttonRemoveDuplicate.UseVisualStyleBackColor = true;
      this.buttonRemoveDuplicate.Click += new System.EventHandler(this.ButtonRemoveDuplicate_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1055, 736);
      this.Controls.Add(this.buttonRemoveDuplicate);
      this.Controls.Add(this.buttonCopy);
      this.Controls.Add(this.listBoxWords);
      this.Controls.Add(this.buttonFormatText);
      this.Controls.Add(this.textBoxFormatted);
      this.Controls.Add(this.textBoxSource);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.Text = "Format Text for new language";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxFormatted;
        private System.Windows.Forms.Button buttonFormatText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonRemoveDuplicate;
    }
}

