﻿namespace AiTraining
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
      this.menuStripMain = new System.Windows.Forms.MenuStrip();
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
      this.tabControlMain = new System.Windows.Forms.TabControl();
      this.tabPageAITraining = new System.Windows.Forms.TabPage();
      this.labelLanguageDetected = new System.Windows.Forms.Label();
      this.buttonDetect = new System.Windows.Forms.Button();
      this.textBoxSource = new System.Windows.Forms.TextBox();
      this.buttonPeekFile = new System.Windows.Forms.Button();
      this.labelPasteOrPeekFile = new System.Windows.Forms.Label();
      this.tabPageAddNewLanguage = new System.Windows.Forms.TabPage();
      this.comboBoxLanguagesAvailable = new System.Windows.Forms.ComboBox();
      this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
      this.buttonTraining = new System.Windows.Forms.Button();
      this.labelWordsFromFile = new System.Windows.Forms.Label();
      this.labelWordsFromTextBox = new System.Windows.Forms.Label();
      this.listBoxWordsFromFile = new System.Windows.Forms.ListBox();
      this.listBoxTopWords = new System.Windows.Forms.ListBox();
      this.textBoxAddNewSource = new System.Windows.Forms.TextBox();
      this.buttonAddLanguagePeekFile = new System.Windows.Forms.Button();
      this.labelAddNewPasteText = new System.Windows.Forms.Label();
      this.menuStripMain.SuspendLayout();
      this.tabControlMain.SuspendLayout();
      this.tabPageAITraining.SuspendLayout();
      this.tabPageAddNewLanguage.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStripMain
      // 
      this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
      this.menuStripMain.Location = new System.Drawing.Point(0, 0);
      this.menuStripMain.Name = "menuStripMain";
      this.menuStripMain.Size = new System.Drawing.Size(1510, 33);
      this.menuStripMain.TabIndex = 0;
      this.menuStripMain.Text = "menuStrip1";
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
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // nouveauToolStripMenuItem
      // 
      this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
      this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
      this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
      this.nouveauToolStripMenuItem.Text = "&Nouveau";
      // 
      // ouvrirToolStripMenuItem
      // 
      this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
      this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
      this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
      this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(289, 6);
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      // 
      // enregistrersousToolStripMenuItem
      // 
      this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
      this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
      this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(289, 6);
      // 
      // imprimerToolStripMenuItem
      // 
      this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
      this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
      this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
      this.imprimerToolStripMenuItem.Text = "&Imprimer";
      // 
      // aperçuavantimpressionToolStripMenuItem
      // 
      this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
      this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
      this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
      this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(289, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
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
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(290, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
      this.couperToolStripMenuItem.Text = "&Couper";
      this.couperToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
      this.copierToolStripMenuItem.Text = "Co&pier";
      this.copierToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
      this.collerToolStripMenuItem.Text = "Co&ller";
      this.collerToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(290, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      this.sélectionnertoutToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
      this.outilsToolStripMenuItem.Text = "&Outils";
      // 
      // personnaliserToolStripMenuItem
      // 
      this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
      this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
      this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
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
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // sommaireToolStripMenuItem
      // 
      this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
      this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
      this.sommaireToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // rechercherToolStripMenuItem
      // 
      this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
      this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
      this.rechercherToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(205, 6);
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
      // 
      // tabControlMain
      // 
      this.tabControlMain.Controls.Add(this.tabPageAITraining);
      this.tabControlMain.Controls.Add(this.tabPageAddNewLanguage);
      this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlMain.Location = new System.Drawing.Point(0, 33);
      this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(1510, 573);
      this.tabControlMain.TabIndex = 1;
      // 
      // tabPageAITraining
      // 
      this.tabPageAITraining.Controls.Add(this.labelLanguageDetected);
      this.tabPageAITraining.Controls.Add(this.buttonDetect);
      this.tabPageAITraining.Controls.Add(this.textBoxSource);
      this.tabPageAITraining.Controls.Add(this.buttonPeekFile);
      this.tabPageAITraining.Controls.Add(this.labelPasteOrPeekFile);
      this.tabPageAITraining.Location = new System.Drawing.Point(4, 29);
      this.tabPageAITraining.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPageAITraining.Name = "tabPageAITraining";
      this.tabPageAITraining.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPageAITraining.Size = new System.Drawing.Size(1502, 540);
      this.tabPageAITraining.TabIndex = 0;
      this.tabPageAITraining.Text = "Training";
      this.tabPageAITraining.UseVisualStyleBackColor = true;
      // 
      // labelLanguageDetected
      // 
      this.labelLanguageDetected.AutoSize = true;
      this.labelLanguageDetected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelLanguageDetected.Location = new System.Drawing.Point(339, 776);
      this.labelLanguageDetected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelLanguageDetected.Name = "labelLanguageDetected";
      this.labelLanguageDetected.Size = new System.Drawing.Size(298, 29);
      this.labelLanguageDetected.TabIndex = 14;
      this.labelLanguageDetected.Text = "Language detected is : ?";
      // 
      // buttonDetect
      // 
      this.buttonDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonDetect.Location = new System.Drawing.Point(47, 770);
      this.buttonDetect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonDetect.Name = "buttonDetect";
      this.buttonDetect.Size = new System.Drawing.Size(270, 45);
      this.buttonDetect.TabIndex = 13;
      this.buttonDetect.Text = "Detect Language";
      this.buttonDetect.UseVisualStyleBackColor = true;
      this.buttonDetect.Click += new System.EventHandler(this.ButtonDetect_Click);
      // 
      // textBoxSource
      // 
      this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxSource.Location = new System.Drawing.Point(46, 111);
      this.textBoxSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxSource.Multiline = true;
      this.textBoxSource.Name = "textBoxSource";
      this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxSource.Size = new System.Drawing.Size(1397, 300);
      this.textBoxSource.TabIndex = 12;
      this.textBoxSource.Text = resources.GetString("textBoxSource.Text");
      this.textBoxSource.TextChanged += new System.EventHandler(this.TextBoxSource_TextChanged);
      // 
      // buttonPeekFile
      // 
      this.buttonPeekFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonPeekFile.Location = new System.Drawing.Point(1245, 49);
      this.buttonPeekFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonPeekFile.Name = "buttonPeekFile";
      this.buttonPeekFile.Size = new System.Drawing.Size(198, 45);
      this.buttonPeekFile.TabIndex = 11;
      this.buttonPeekFile.Text = "Peek File";
      this.buttonPeekFile.UseVisualStyleBackColor = true;
      this.buttonPeekFile.Click += new System.EventHandler(this.ButtonPeekFile_Click);
      // 
      // labelPasteOrPeekFile
      // 
      this.labelPasteOrPeekFile.AutoSize = true;
      this.labelPasteOrPeekFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPasteOrPeekFile.Location = new System.Drawing.Point(42, 63);
      this.labelPasteOrPeekFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelPasteOrPeekFile.Name = "labelPasteOrPeekFile";
      this.labelPasteOrPeekFile.Size = new System.Drawing.Size(365, 29);
      this.labelPasteOrPeekFile.TabIndex = 10;
      this.labelPasteOrPeekFile.Text = "Paste text below or peek a file";
      // 
      // tabPageAddNewLanguage
      // 
      this.tabPageAddNewLanguage.Controls.Add(this.textBoxAddNewSource);
      this.tabPageAddNewLanguage.Controls.Add(this.buttonAddLanguagePeekFile);
      this.tabPageAddNewLanguage.Controls.Add(this.labelAddNewPasteText);
      this.tabPageAddNewLanguage.Controls.Add(this.comboBoxLanguagesAvailable);
      this.tabPageAddNewLanguage.Controls.Add(this.comboBoxLanguages);
      this.tabPageAddNewLanguage.Controls.Add(this.buttonTraining);
      this.tabPageAddNewLanguage.Controls.Add(this.labelWordsFromFile);
      this.tabPageAddNewLanguage.Controls.Add(this.labelWordsFromTextBox);
      this.tabPageAddNewLanguage.Controls.Add(this.listBoxWordsFromFile);
      this.tabPageAddNewLanguage.Controls.Add(this.listBoxTopWords);
      this.tabPageAddNewLanguage.Location = new System.Drawing.Point(4, 29);
      this.tabPageAddNewLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPageAddNewLanguage.Name = "tabPageAddNewLanguage";
      this.tabPageAddNewLanguage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPageAddNewLanguage.Size = new System.Drawing.Size(1502, 540);
      this.tabPageAddNewLanguage.TabIndex = 1;
      this.tabPageAddNewLanguage.Text = "Add new language";
      this.tabPageAddNewLanguage.UseVisualStyleBackColor = true;
      // 
      // comboBoxLanguagesAvailable
      // 
      this.comboBoxLanguagesAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxLanguagesAvailable.FormattingEnabled = true;
      this.comboBoxLanguagesAvailable.Location = new System.Drawing.Point(1242, 788);
      this.comboBoxLanguagesAvailable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.comboBoxLanguagesAvailable.Name = "comboBoxLanguagesAvailable";
      this.comboBoxLanguagesAvailable.Size = new System.Drawing.Size(234, 37);
      this.comboBoxLanguagesAvailable.TabIndex = 28;
      // 
      // comboBoxLanguages
      // 
      this.comboBoxLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxLanguages.FormattingEnabled = true;
      this.comboBoxLanguages.Location = new System.Drawing.Point(833, 795);
      this.comboBoxLanguages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.comboBoxLanguages.Name = "comboBoxLanguages";
      this.comboBoxLanguages.Size = new System.Drawing.Size(180, 37);
      this.comboBoxLanguages.TabIndex = 27;
      // 
      // buttonTraining
      // 
      this.buttonTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonTraining.Location = new System.Drawing.Point(1062, 788);
      this.buttonTraining.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonTraining.Name = "buttonTraining";
      this.buttonTraining.Size = new System.Drawing.Size(150, 45);
      this.buttonTraining.TabIndex = 26;
      this.buttonTraining.Text = "Training";
      this.buttonTraining.UseVisualStyleBackColor = true;
      // 
      // labelWordsFromFile
      // 
      this.labelWordsFromFile.AutoSize = true;
      this.labelWordsFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWordsFromFile.Location = new System.Drawing.Point(1237, 24);
      this.labelWordsFromFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelWordsFromFile.Name = "labelWordsFromFile";
      this.labelWordsFromFile.Size = new System.Drawing.Size(199, 29);
      this.labelWordsFromFile.TabIndex = 25;
      this.labelWordsFromFile.Text = "Words from File";
      // 
      // labelWordsFromTextBox
      // 
      this.labelWordsFromTextBox.AutoSize = true;
      this.labelWordsFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWordsFromTextBox.Location = new System.Drawing.Point(972, 24);
      this.labelWordsFromTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelWordsFromTextBox.Name = "labelWordsFromTextBox";
      this.labelWordsFromTextBox.Size = new System.Drawing.Size(249, 29);
      this.labelWordsFromTextBox.TabIndex = 24;
      this.labelWordsFromTextBox.Text = "Words from TextBox";
      // 
      // listBoxWordsFromFile
      // 
      this.listBoxWordsFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBoxWordsFromFile.FormattingEnabled = true;
      this.listBoxWordsFromFile.ItemHeight = 32;
      this.listBoxWordsFromFile.Location = new System.Drawing.Point(1243, 80);
      this.listBoxWordsFromFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.listBoxWordsFromFile.Name = "listBoxWordsFromFile";
      this.listBoxWordsFromFile.Size = new System.Drawing.Size(234, 676);
      this.listBoxWordsFromFile.TabIndex = 23;
      // 
      // listBoxTopWords
      // 
      this.listBoxTopWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBoxTopWords.FormattingEnabled = true;
      this.listBoxTopWords.ItemHeight = 32;
      this.listBoxTopWords.Location = new System.Drawing.Point(978, 80);
      this.listBoxTopWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.listBoxTopWords.Name = "listBoxTopWords";
      this.listBoxTopWords.Size = new System.Drawing.Size(234, 676);
      this.listBoxTopWords.TabIndex = 22;
      // 
      // textBoxAddNewSource
      // 
      this.textBoxAddNewSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxAddNewSource.Location = new System.Drawing.Point(55, 151);
      this.textBoxAddNewSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxAddNewSource.Multiline = true;
      this.textBoxAddNewSource.Name = "textBoxAddNewSource";
      this.textBoxAddNewSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxAddNewSource.Size = new System.Drawing.Size(905, 300);
      this.textBoxAddNewSource.TabIndex = 31;
      this.textBoxAddNewSource.Text = resources.GetString("textBoxAddNewSource.Text");
      // 
      // buttonAddLanguagePeekFile
      // 
      this.buttonAddLanguagePeekFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonAddLanguagePeekFile.Location = new System.Drawing.Point(812, 95);
      this.buttonAddLanguagePeekFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonAddLanguagePeekFile.Name = "buttonAddLanguagePeekFile";
      this.buttonAddLanguagePeekFile.Size = new System.Drawing.Size(148, 45);
      this.buttonAddLanguagePeekFile.TabIndex = 30;
      this.buttonAddLanguagePeekFile.Text = "Peek File";
      this.buttonAddLanguagePeekFile.UseVisualStyleBackColor = true;
      this.buttonAddLanguagePeekFile.Click += new System.EventHandler(this.ButtonAddLanguagePeekFile_Click);
      // 
      // labelAddNewPasteText
      // 
      this.labelAddNewPasteText.AutoSize = true;
      this.labelAddNewPasteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelAddNewPasteText.Location = new System.Drawing.Point(51, 103);
      this.labelAddNewPasteText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelAddNewPasteText.Name = "labelAddNewPasteText";
      this.labelAddNewPasteText.Size = new System.Drawing.Size(365, 29);
      this.labelAddNewPasteText.TabIndex = 29;
      this.labelAddNewPasteText.Text = "Paste text below or peek a file";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1510, 606);
      this.Controls.Add(this.tabControlMain);
      this.Controls.Add(this.menuStripMain);
      this.MainMenuStrip = this.menuStripMain;
      this.Name = "FormMain";
      this.Text = "A.I. Training";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStripMain.ResumeLayout(false);
      this.menuStripMain.PerformLayout();
      this.tabControlMain.ResumeLayout(false);
      this.tabPageAITraining.ResumeLayout(false);
      this.tabPageAITraining.PerformLayout();
      this.tabPageAddNewLanguage.ResumeLayout(false);
      this.tabPageAddNewLanguage.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStripMain;
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
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageAITraining;
    private System.Windows.Forms.TabPage tabPageAddNewLanguage;
    private System.Windows.Forms.Label labelLanguageDetected;
    private System.Windows.Forms.Button buttonDetect;
    private System.Windows.Forms.TextBox textBoxSource;
    private System.Windows.Forms.Button buttonPeekFile;
    private System.Windows.Forms.Label labelPasteOrPeekFile;
    private System.Windows.Forms.ComboBox comboBoxLanguagesAvailable;
    private System.Windows.Forms.ComboBox comboBoxLanguages;
    private System.Windows.Forms.Button buttonTraining;
    private System.Windows.Forms.Label labelWordsFromFile;
    private System.Windows.Forms.Label labelWordsFromTextBox;
    private System.Windows.Forms.ListBox listBoxWordsFromFile;
    private System.Windows.Forms.ListBox listBoxTopWords;
    private System.Windows.Forms.TextBox textBoxAddNewSource;
    private System.Windows.Forms.Button buttonAddLanguagePeekFile;
    private System.Windows.Forms.Label labelAddNewPasteText;
  }
}

