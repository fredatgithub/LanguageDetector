namespace AiTraining
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
      this.labelWordsFromFile = new System.Windows.Forms.Label();
      this.labelWordsFromTextBox = new System.Windows.Forms.Label();
      this.listBoxWordsFromFile = new System.Windows.Forms.ListBox();
      this.comboBoxLanguagesAvailable = new System.Windows.Forms.ComboBox();
      this.listBoxTopWords = new System.Windows.Forms.ListBox();
      this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
      this.buttonTraining = new System.Windows.Forms.Button();
      this.labelLanguageDetected = new System.Windows.Forms.Label();
      this.buttonDetect = new System.Windows.Forms.Button();
      this.textBoxSource = new System.Windows.Forms.TextBox();
      this.buttonPeekFile = new System.Windows.Forms.Button();
      this.labelPasteOrPeekFile = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.menuStripMain.SuspendLayout();
      this.tabControlMain.SuspendLayout();
      this.tabPageAITraining.SuspendLayout();
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
      this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
      this.menuStripMain.Size = new System.Drawing.Size(1007, 24);
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
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
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
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.couperToolStripMenuItem.Text = "&Couper";
      this.couperToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.copierToolStripMenuItem.Text = "Co&pier";
      this.copierToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.collerToolStripMenuItem.Text = "Co&ller";
      this.collerToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(203, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      this.sélectionnertoutToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
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
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
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
      // tabControlMain
      // 
      this.tabControlMain.Controls.Add(this.tabPageAITraining);
      this.tabControlMain.Controls.Add(this.tabPage2);
      this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlMain.Location = new System.Drawing.Point(0, 24);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(1007, 651);
      this.tabControlMain.TabIndex = 1;
      // 
      // tabPageAITraining
      // 
      this.tabPageAITraining.Controls.Add(this.labelWordsFromFile);
      this.tabPageAITraining.Controls.Add(this.labelWordsFromTextBox);
      this.tabPageAITraining.Controls.Add(this.listBoxWordsFromFile);
      this.tabPageAITraining.Controls.Add(this.comboBoxLanguagesAvailable);
      this.tabPageAITraining.Controls.Add(this.listBoxTopWords);
      this.tabPageAITraining.Controls.Add(this.comboBoxLanguages);
      this.tabPageAITraining.Controls.Add(this.buttonTraining);
      this.tabPageAITraining.Controls.Add(this.labelLanguageDetected);
      this.tabPageAITraining.Controls.Add(this.buttonDetect);
      this.tabPageAITraining.Controls.Add(this.textBoxSource);
      this.tabPageAITraining.Controls.Add(this.buttonPeekFile);
      this.tabPageAITraining.Controls.Add(this.labelPasteOrPeekFile);
      this.tabPageAITraining.Location = new System.Drawing.Point(4, 22);
      this.tabPageAITraining.Name = "tabPageAITraining";
      this.tabPageAITraining.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
      this.tabPageAITraining.Size = new System.Drawing.Size(999, 625);
      this.tabPageAITraining.TabIndex = 0;
      this.tabPageAITraining.Text = "Training";
      this.tabPageAITraining.UseVisualStyleBackColor = true;
      // 
      // labelWordsFromFile
      // 
      this.labelWordsFromFile.AutoSize = true;
      this.labelWordsFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWordsFromFile.Location = new System.Drawing.Point(810, 36);
      this.labelWordsFromFile.Name = "labelWordsFromFile";
      this.labelWordsFromFile.Size = new System.Drawing.Size(135, 20);
      this.labelWordsFromFile.TabIndex = 21;
      this.labelWordsFromFile.Text = "Words from File";
      // 
      // labelWordsFromTextBox
      // 
      this.labelWordsFromTextBox.AutoSize = true;
      this.labelWordsFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWordsFromTextBox.Location = new System.Drawing.Point(633, 36);
      this.labelWordsFromTextBox.Name = "labelWordsFromTextBox";
      this.labelWordsFromTextBox.Size = new System.Drawing.Size(170, 20);
      this.labelWordsFromTextBox.TabIndex = 20;
      this.labelWordsFromTextBox.Text = "Words from TextBox";
      // 
      // listBoxWordsFromFile
      // 
      this.listBoxWordsFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBoxWordsFromFile.FormattingEnabled = true;
      this.listBoxWordsFromFile.ItemHeight = 24;
      this.listBoxWordsFromFile.Location = new System.Drawing.Point(814, 72);
      this.listBoxWordsFromFile.Name = "listBoxWordsFromFile";
      this.listBoxWordsFromFile.Size = new System.Drawing.Size(157, 460);
      this.listBoxWordsFromFile.TabIndex = 19;
      // 
      // comboBoxLanguagesAvailable
      // 
      this.comboBoxLanguagesAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxLanguagesAvailable.FormattingEnabled = true;
      this.comboBoxLanguagesAvailable.Location = new System.Drawing.Point(814, 584);
      this.comboBoxLanguagesAvailable.Name = "comboBoxLanguagesAvailable";
      this.comboBoxLanguagesAvailable.Size = new System.Drawing.Size(157, 28);
      this.comboBoxLanguagesAvailable.TabIndex = 18;
      // 
      // listBoxTopWords
      // 
      this.listBoxTopWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBoxTopWords.FormattingEnabled = true;
      this.listBoxTopWords.ItemHeight = 24;
      this.listBoxTopWords.Location = new System.Drawing.Point(637, 72);
      this.listBoxTopWords.Name = "listBoxTopWords";
      this.listBoxTopWords.Size = new System.Drawing.Size(157, 460);
      this.listBoxTopWords.TabIndex = 17;
      // 
      // comboBoxLanguages
      // 
      this.comboBoxLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxLanguages.FormattingEnabled = true;
      this.comboBoxLanguages.Location = new System.Drawing.Point(541, 588);
      this.comboBoxLanguages.Name = "comboBoxLanguages";
      this.comboBoxLanguages.Size = new System.Drawing.Size(121, 28);
      this.comboBoxLanguages.TabIndex = 16;
      // 
      // buttonTraining
      // 
      this.buttonTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonTraining.Location = new System.Drawing.Point(694, 584);
      this.buttonTraining.Name = "buttonTraining";
      this.buttonTraining.Size = new System.Drawing.Size(100, 29);
      this.buttonTraining.TabIndex = 15;
      this.buttonTraining.Text = "Training";
      this.buttonTraining.UseVisualStyleBackColor = true;
      this.buttonTraining.Click += new System.EventHandler(this.ButtonTraining_Click);
      // 
      // labelLanguageDetected
      // 
      this.labelLanguageDetected.AutoSize = true;
      this.labelLanguageDetected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelLanguageDetected.Location = new System.Drawing.Point(227, 593);
      this.labelLanguageDetected.Name = "labelLanguageDetected";
      this.labelLanguageDetected.Size = new System.Drawing.Size(208, 20);
      this.labelLanguageDetected.TabIndex = 14;
      this.labelLanguageDetected.Text = "Language detected is : ?";
      // 
      // buttonDetect
      // 
      this.buttonDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonDetect.Location = new System.Drawing.Point(32, 589);
      this.buttonDetect.Name = "buttonDetect";
      this.buttonDetect.Size = new System.Drawing.Size(180, 29);
      this.buttonDetect.TabIndex = 13;
      this.buttonDetect.Text = "Detect Language";
      this.buttonDetect.UseVisualStyleBackColor = true;
      this.buttonDetect.Click += new System.EventHandler(this.ButtonDetect_Click);
      // 
      // textBoxSource
      // 
      this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxSource.Location = new System.Drawing.Point(31, 72);
      this.textBoxSource.Multiline = true;
      this.textBoxSource.Name = "textBoxSource";
      this.textBoxSource.Size = new System.Drawing.Size(583, 491);
      this.textBoxSource.TabIndex = 12;
      this.textBoxSource.Text = resources.GetString("textBoxSource.Text");
      this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
      // 
      // buttonPeekFile
      // 
      this.buttonPeekFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonPeekFile.Location = new System.Drawing.Point(482, 32);
      this.buttonPeekFile.Name = "buttonPeekFile";
      this.buttonPeekFile.Size = new System.Drawing.Size(132, 29);
      this.buttonPeekFile.TabIndex = 11;
      this.buttonPeekFile.Text = "Peek File";
      this.buttonPeekFile.UseVisualStyleBackColor = true;
      // 
      // labelPasteOrPeekFile
      // 
      this.labelPasteOrPeekFile.AutoSize = true;
      this.labelPasteOrPeekFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPasteOrPeekFile.Location = new System.Drawing.Point(28, 41);
      this.labelPasteOrPeekFile.Name = "labelPasteOrPeekFile";
      this.labelPasteOrPeekFile.Size = new System.Drawing.Size(250, 20);
      this.labelPasteOrPeekFile.TabIndex = 10;
      this.labelPasteOrPeekFile.Text = "Paste text below or peek a file";
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
      this.tabPage2.Size = new System.Drawing.Size(999, 627);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1007, 675);
      this.Controls.Add(this.tabControlMain);
      this.Controls.Add(this.menuStripMain);
      this.MainMenuStrip = this.menuStripMain;
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "FormMain";
      this.Text = "A.I. Training";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStripMain.ResumeLayout(false);
      this.menuStripMain.PerformLayout();
      this.tabControlMain.ResumeLayout(false);
      this.tabPageAITraining.ResumeLayout(false);
      this.tabPageAITraining.PerformLayout();
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
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.ListBox listBoxTopWords;
    private System.Windows.Forms.ComboBox comboBoxLanguages;
    private System.Windows.Forms.Button buttonTraining;
    private System.Windows.Forms.Label labelLanguageDetected;
    private System.Windows.Forms.Button buttonDetect;
    private System.Windows.Forms.TextBox textBoxSource;
    private System.Windows.Forms.Button buttonPeekFile;
    private System.Windows.Forms.Label labelPasteOrPeekFile;
    private System.Windows.Forms.ComboBox comboBoxLanguagesAvailable;
    private System.Windows.Forms.ListBox listBoxWordsFromFile;
    private System.Windows.Forms.Label labelWordsFromFile;
    private System.Windows.Forms.Label labelWordsFromTextBox;
  }
}

