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
            this.buttonToLowercase = new System.Windows.Forms.Button();
            this.buttonRemovecharacter = new System.Windows.Forms.Button();
            this.comboBoxRemoveCharacter = new System.Windows.Forms.ComboBox();
            this.buttonReloadWords = new System.Windows.Forms.Button();
            this.buttonRemoveOneCharacter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSource.Location = new System.Drawing.Point(0, 28);
            this.textBoxSource.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(1728, 315);
            this.textBoxSource.TabIndex = 0;
            this.textBoxSource.Text = resources.GetString("textBoxSource.Text");
            // 
            // textBoxFormatted
            // 
            this.textBoxFormatted.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxFormatted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFormatted.Location = new System.Drawing.Point(0, 461);
            this.textBoxFormatted.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFormatted.Multiline = true;
            this.textBoxFormatted.Name = "textBoxFormatted";
            this.textBoxFormatted.Size = new System.Drawing.Size(1728, 445);
            this.textBoxFormatted.TabIndex = 1;
            // 
            // buttonFormatText
            // 
            this.buttonFormatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormatText.Location = new System.Drawing.Point(16, 378);
            this.buttonFormatText.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFormatText.Name = "buttonFormatText";
            this.buttonFormatText.Size = new System.Drawing.Size(123, 28);
            this.buttonFormatText.TabIndex = 2;
            this.buttonFormatText.Text = "Format text";
            this.buttonFormatText.UseVisualStyleBackColor = true;
            this.buttonFormatText.Click += new System.EventHandler(this.ButtonFormatText_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1728, 28);
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
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
            this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.nouveauToolStripMenuItem.Text = "&Nouveau";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
            this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(252, 6);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
            this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            // 
            // enregistrersousToolStripMenuItem
            // 
            this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
            this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
            this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.imprimerToolStripMenuItem.Text = "&Imprimer";
            // 
            // aperçuavantimpressionToolStripMenuItem
            // 
            this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
            this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
            this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(252, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
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
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.editionToolStripMenuItem.Text = "&Edition";
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.annulerToolStripMenuItem.Text = "&Annuler";
            // 
            // rétablirToolStripMenuItem
            // 
            this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.rétablirToolStripMenuItem.Text = "&Rétablir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
            this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.couperToolStripMenuItem.Text = "&Couper";
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
            this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.copierToolStripMenuItem.Text = "Co&pier";
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
            this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.collerToolStripMenuItem.Text = "Co&ller";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(202, 6);
            // 
            // sélectionnertoutToolStripMenuItem
            // 
            this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
            this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.outilsToolStripMenuItem.Text = "&Outils";
            // 
            // personnaliserToolStripMenuItem
            // 
            this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
            this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
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
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // sommaireToolStripMenuItem
            // 
            this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
            this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.sommaireToolStripMenuItem.Text = "&Sommaire";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.rechercherToolStripMenuItem.Text = "&Rechercher";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(180, 6);
            // 
            // àproposdeToolStripMenuItem
            // 
            this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
            this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.àproposdeToolStripMenuItem.Text = "À &propos de...";
            // 
            // listBoxWords
            // 
            this.listBoxWords.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.ItemHeight = 16;
            this.listBoxWords.Location = new System.Drawing.Point(1440, 343);
            this.listBoxWords.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(288, 118);
            this.listBoxWords.Sorted = true;
            this.listBoxWords.TabIndex = 4;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.Location = new System.Drawing.Point(1200, 380);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(221, 28);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = "Copy all words to clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // buttonRemoveDuplicate
            // 
            this.buttonRemoveDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveDuplicate.Location = new System.Drawing.Point(147, 378);
            this.buttonRemoveDuplicate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveDuplicate.Name = "buttonRemoveDuplicate";
            this.buttonRemoveDuplicate.Size = new System.Drawing.Size(171, 28);
            this.buttonRemoveDuplicate.TabIndex = 6;
            this.buttonRemoveDuplicate.Text = "Remove Duplicate";
            this.buttonRemoveDuplicate.UseVisualStyleBackColor = true;
            this.buttonRemoveDuplicate.Click += new System.EventHandler(this.ButtonRemoveDuplicate_Click);
            // 
            // buttonToLowercase
            // 
            this.buttonToLowercase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToLowercase.Location = new System.Drawing.Point(336, 378);
            this.buttonToLowercase.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToLowercase.Name = "buttonToLowercase";
            this.buttonToLowercase.Size = new System.Drawing.Size(171, 28);
            this.buttonToLowercase.TabIndex = 7;
            this.buttonToLowercase.Text = "To Lowercase";
            this.buttonToLowercase.UseVisualStyleBackColor = true;
            this.buttonToLowercase.Click += new System.EventHandler(this.ButtonToLowercase_Click);
            // 
            // buttonRemovecharacter
            // 
            this.buttonRemovecharacter.Enabled = false;
            this.buttonRemovecharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemovecharacter.Location = new System.Drawing.Point(515, 379);
            this.buttonRemovecharacter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemovecharacter.Name = "buttonRemovecharacter";
            this.buttonRemovecharacter.Size = new System.Drawing.Size(171, 27);
            this.buttonRemovecharacter.TabIndex = 8;
            this.buttonRemovecharacter.Text = "Remove character:";
            this.buttonRemovecharacter.UseVisualStyleBackColor = true;
            this.buttonRemovecharacter.Click += new System.EventHandler(this.ButtonRemovecharacter_Click);
            // 
            // comboBoxRemoveCharacter
            // 
            this.comboBoxRemoveCharacter.FormattingEnabled = true;
            this.comboBoxRemoveCharacter.Location = new System.Drawing.Point(693, 381);
            this.comboBoxRemoveCharacter.Name = "comboBoxRemoveCharacter";
            this.comboBoxRemoveCharacter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRemoveCharacter.TabIndex = 9;
            this.comboBoxRemoveCharacter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRemoveCharacter_SelectedIndexChanged);
            // 
            // buttonReloadWords
            // 
            this.buttonReloadWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReloadWords.Location = new System.Drawing.Point(1052, 380);
            this.buttonReloadWords.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReloadWords.Name = "buttonReloadWords";
            this.buttonReloadWords.Size = new System.Drawing.Size(140, 28);
            this.buttonReloadWords.TabIndex = 10;
            this.buttonReloadWords.Text = "Reload words";
            this.buttonReloadWords.UseVisualStyleBackColor = true;
            this.buttonReloadWords.Click += new System.EventHandler(this.ButtonReloadWords_Click);
            // 
            // buttonRemoveOneCharacter
            // 
            this.buttonRemoveOneCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveOneCharacter.Location = new System.Drawing.Point(821, 380);
            this.buttonRemoveOneCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveOneCharacter.Name = "buttonRemoveOneCharacter";
            this.buttonRemoveOneCharacter.Size = new System.Drawing.Size(223, 27);
            this.buttonRemoveOneCharacter.TabIndex = 11;
            this.buttonRemoveOneCharacter.Text = "Remove one character";
            this.buttonRemoveOneCharacter.UseVisualStyleBackColor = true;
            this.buttonRemoveOneCharacter.Click += new System.EventHandler(this.ButtonRemoveOneCharacter_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 906);
            this.Controls.Add(this.buttonRemoveOneCharacter);
            this.Controls.Add(this.buttonReloadWords);
            this.Controls.Add(this.comboBoxRemoveCharacter);
            this.Controls.Add(this.buttonRemovecharacter);
            this.Controls.Add(this.buttonToLowercase);
            this.Controls.Add(this.buttonRemoveDuplicate);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.buttonFormatText);
            this.Controls.Add(this.textBoxFormatted);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Format Text for new language";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
        private System.Windows.Forms.Button buttonToLowercase;
        private System.Windows.Forms.Button buttonRemovecharacter;
        private System.Windows.Forms.ComboBox comboBoxRemoveCharacter;
        private System.Windows.Forms.Button buttonReloadWords;
        private System.Windows.Forms.Button buttonRemoveOneCharacter;
    }
}

