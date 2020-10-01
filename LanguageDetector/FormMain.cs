#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using LanguageDetector.Properties;

namespace LanguageDetector
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
      // initialize other variables if needed
    }

    public readonly Dictionary<string, string> LanguageDicoEn = new Dictionary<string, string>();
    public readonly Dictionary<string, string> LanguageDicoFr = new Dictionary<string, string>();
    private string _currentLanguage = "english";
    private ConfigurationOptions _configurationOptions = new ConfigurationOptions();

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveWindowValue();
      Application.Exit();
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBoxApplication aboutBoxApplication = new AboutBoxApplication();
      aboutBoxApplication.ShowDialog();
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += $" V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}.{fvi.FilePrivatePart}";
    }

    private void FormMainLoad(object sender, EventArgs e)
    {
      LoadSettingsAtStartup();
    }

    private void LoadSettingsAtStartup()
    {
      // loads all initialization values at startup
      DisplayTitle();
      GetWindowValue();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      LoadLanguagesIntoComboBox();
    }

    private void LoadLanguagesIntoComboBox()
    {
      comboBoxLanguages.Items.Clear();
      // should be loaded from an XML file
      comboBoxLanguages.Items.Add("French");
      comboBoxLanguages.Items.Add("English");
      comboBoxLanguages.Items.Add("Spanish");
      comboBoxLanguages.Items.Add("Italian");
      comboBoxLanguages.SelectedIndex = 0;
    }

    private void LoadConfigurationOptions()
    {
      // loading the configuration options
      _configurationOptions.Option1Name = Settings.Default.Option1Name;
      _configurationOptions.Option2Name = Settings.Default.Option2Name;
    }

    private void SaveConfigurationOptions()
    {
      // saving the configuration options
      _configurationOptions.Option1Name = Settings.Default.Option1Name;
      _configurationOptions.Option2Name = Settings.Default.Option2Name;
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc;
      try
      {
        xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      }
      catch (Exception exception)
      {
        MessageBox.Show(Resources.Error_while_loading_the + Punctuation.OneSpace +
          Settings.Default.LanguageFileName + Punctuation.OneSpace + Resources.XML_file +
          Punctuation.OneSpace + exception.Message);
        CreateLanguageFile();
        return;
      }

      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElementName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };
      foreach (var i in result)
      {
        if (!LanguageDicoEn.ContainsKey(i.name))
        {
          LanguageDicoEn.Add(i.name, i.englishValue);
        }
#if DEBUG
        else
        {
          MessageBox.Show(Resources.Your_XML_file_has_duplicate_like + Punctuation.Colon +
            Punctuation.OneSpace + i.name);
        }
#endif
        if (!LanguageDicoFr.ContainsKey(i.name))
        {
          LanguageDicoFr.Add(i.name, i.frenchValue);
        }
#if DEBUG
        else
        {
          MessageBox.Show(Resources.Your_XML_file_has_duplicate_like + Punctuation.Colon +
            Punctuation.OneSpace + i.name);
        }
#endif
      }
    }

    private static void CreateLanguageFile()
    {
      List<string> minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf-8\" ?>",
        "<terms>",
         "<term>",
        "<name>MenuFile</name>",
        "<englishValue>File</englishValue>",
        "<frenchValue>Fichier</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileNew</name>",
        "<englishValue>New</englishValue>",
        "<frenchValue>Nouveau</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileOpen</name>",
        "<englishValue>Open</englishValue>",
        "<frenchValue>Ouvrir</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileSave</name>",
        "<englishValue>Save</englishValue>",
        "<frenchValue>Enregistrer</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileSaveAs</name>",
        "<englishValue>Save as ...</englishValue>",
        "<frenchValue>Enregistrer sous ...</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFilePrint</name>",
        "<englishValue>Print ...</englishValue>",
        "<frenchValue>Imprimer ...</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenufilePageSetup</name>",
          "<englishValue>Page setup</englishValue>",
          "<frenchValue>Aperçu avant impression</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenufileQuit</name>",
          "<englishValue>Quit</englishValue>",
          "<frenchValue>Quitter</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEdit</name>",
          "<englishValue>Edit</englishValue>",
          "<frenchValue>Edition</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCancel</name>",
          "<englishValue>Cancel</englishValue>",
          "<frenchValue>Annuler</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditRedo</name>",
          "<englishValue>Redo</englishValue>",
          "<frenchValue>Rétablir</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCut</name>",
          "<englishValue>Cut</englishValue>",
          "<frenchValue>Couper</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCopy</name>",
          "<englishValue>Copy</englishValue>",
          "<frenchValue>Copier</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditPaste</name>",
          "<englishValue>Paste</englishValue>",
          "<frenchValue>Coller</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditSelectAll</name>",
          "<englishValue>Select All</englishValue>",
          "<frenchValue>Sélectionner tout</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuTools</name>",
          "<englishValue>Tools</englishValue>",
          "<frenchValue>Outils</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuToolsCustomize</name>",
          "<englishValue>Customize ...</englishValue>",
          "<frenchValue>Personaliser ...</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuToolsOptions</name>",
          "<englishValue>Options</englishValue>",
          "<frenchValue>Options</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguage</name>",
          "<englishValue>Language</englishValue>",
          "<frenchValue>Langage</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguageEnglish</name>",
          "<englishValue>English</englishValue>",
          "<frenchValue>Anglais</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguageFrench</name>",
          "<englishValue>French</englishValue>",
          "<frenchValue>Français</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelp</name>",
          "<englishValue>Help</englishValue>",
          "<frenchValue>Aide</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpSummary</name>",
          "<englishValue>Summary</englishValue>",
          "<frenchValue>Sommaire</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpIndex</name>",
          "<englishValue>Index</englishValue>",
          "<frenchValue>Index</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpSearch</name>",
          "<englishValue>Search</englishValue>",
          "<frenchValue>Rechercher</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpAbout</name>",
          "<englishValue>About</englishValue>",
          "<frenchValue>A propos de ...</frenchValue>",
        "</term>",
        "</terms>"
      };

      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    private void GetWindowValue()
    {
      // load window values at startup, add some if needed here
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      SetDisplayOption(Settings.Default.DisplayToolStripMenuItem);
      LoadConfigurationOptions();
    }

    private void SaveWindowValue()
    {
      // save all window values, add some if needed here
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.DisplayToolStripMenuItem = GetDisplayOption();
      SaveConfigurationOptions();
      Settings.Default.Save();
    }

    private string GetDisplayOption()
    {
      //returns small, medium or large
      if (SmallToolStripMenuItem.Checked)
      {
        return "Small";
      }

      if (MediumToolStripMenuItem.Checked)
      {
        return "Medium";
      }

      return LargeToolStripMenuItem.Checked ? "Large" : string.Empty;
    }

    private void SetDisplayOption(string option)
    {
      //uncheck all options first
      UncheckAllOptions();
      switch (option.ToLower())
      {
        case "small":
          SmallToolStripMenuItem.Checked = true;
          break;
        case "medium":
          MediumToolStripMenuItem.Checked = true;
          break;
        case "large":
          LargeToolStripMenuItem.Checked = true;
          break;
        default:
          SmallToolStripMenuItem.Checked = true;
          break;
      }
    }

    private void UncheckAllOptions()
    {
      //could be refactor with a list of menu items
      SmallToolStripMenuItem.Checked = false;
      MediumToolStripMenuItem.Checked = false;
      LargeToolStripMenuItem.Checked = false;
    }

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      // We save Window values before closing the application
      SaveWindowValue();
    }

    private void frenchToolStripMenuItemClick(object sender, EventArgs e)
    {
      _currentLanguage = Language.French.ToString();
      SetLanguage(Language.French.ToString());
      AdjustAllControls();
    }

    private void englishToolStripMenuItemClick(object sender, EventArgs e)
    {
      _currentLanguage = Language.English.ToString();
      SetLanguage(Language.English.ToString());
      AdjustAllControls();
    }

    private void SetLanguage(string myLanguage)
    {
      switch (myLanguage)
      {
        case "English":
          frenchToolStripMenuItem.Checked = false;
          englishToolStripMenuItem.Checked = true;
          fileToolStripMenuItem.Text = LanguageDicoEn["MenuFile"];
          newToolStripMenuItem.Text = LanguageDicoEn["MenuFileNew"];
          openToolStripMenuItem.Text = LanguageDicoEn["MenuFileOpen"];
          saveToolStripMenuItem.Text = LanguageDicoEn["MenuFileSave"];
          saveasToolStripMenuItem.Text = LanguageDicoEn["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = LanguageDicoEn["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = LanguageDicoEn["MenufilePageSetup"];
          quitToolStripMenuItem.Text = LanguageDicoEn["MenufileQuit"];
          editToolStripMenuItem.Text = LanguageDicoEn["MenuEdit"];
          cancelToolStripMenuItem.Text = LanguageDicoEn["MenuEditCancel"];
          redoToolStripMenuItem.Text = LanguageDicoEn["MenuEditRedo"];
          cutToolStripMenuItem.Text = LanguageDicoEn["MenuEditCut"];
          copyToolStripMenuItem.Text = LanguageDicoEn["MenuEditCopy"];
          pasteToolStripMenuItem.Text = LanguageDicoEn["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = LanguageDicoEn["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = LanguageDicoEn["MenuTools"];
          personalizeToolStripMenuItem.Text = LanguageDicoEn["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = LanguageDicoEn["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = LanguageDicoEn["MenuLanguage"];
          englishToolStripMenuItem.Text = LanguageDicoEn["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = LanguageDicoEn["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = LanguageDicoEn["MenuHelp"];
          summaryToolStripMenuItem.Text = LanguageDicoEn["MenuHelpSummary"];
          indexToolStripMenuItem.Text = LanguageDicoEn["MenuHelpIndex"];
          searchToolStripMenuItem.Text = LanguageDicoEn["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = LanguageDicoEn["MenuHelpAbout"];
          DisplayToolStripMenuItem.Text = LanguageDicoEn["Display"];
          SmallToolStripMenuItem.Text = LanguageDicoEn["Small"];
          MediumToolStripMenuItem.Text = LanguageDicoEn["Medium"];
          LargeToolStripMenuItem.Text = LanguageDicoEn["Large"];


          _currentLanguage = "English";
          break;
        case "French":
          frenchToolStripMenuItem.Checked = true;
          englishToolStripMenuItem.Checked = false;
          fileToolStripMenuItem.Text = LanguageDicoFr["MenuFile"];
          newToolStripMenuItem.Text = LanguageDicoFr["MenuFileNew"];
          openToolStripMenuItem.Text = LanguageDicoFr["MenuFileOpen"];
          saveToolStripMenuItem.Text = LanguageDicoFr["MenuFileSave"];
          saveasToolStripMenuItem.Text = LanguageDicoFr["MenuFileSaveAs"];
          printPreviewToolStripMenuItem.Text = LanguageDicoFr["MenuFilePrint"];
          printPreviewToolStripMenuItem.Text = LanguageDicoFr["MenufilePageSetup"];
          quitToolStripMenuItem.Text = LanguageDicoFr["MenufileQuit"];
          editToolStripMenuItem.Text = LanguageDicoFr["MenuEdit"];
          cancelToolStripMenuItem.Text = LanguageDicoFr["MenuEditCancel"];
          redoToolStripMenuItem.Text = LanguageDicoFr["MenuEditRedo"];
          cutToolStripMenuItem.Text = LanguageDicoFr["MenuEditCut"];
          copyToolStripMenuItem.Text = LanguageDicoFr["MenuEditCopy"];
          pasteToolStripMenuItem.Text = LanguageDicoFr["MenuEditPaste"];
          selectAllToolStripMenuItem.Text = LanguageDicoFr["MenuEditSelectAll"];
          toolsToolStripMenuItem.Text = LanguageDicoFr["MenuTools"];
          personalizeToolStripMenuItem.Text = LanguageDicoFr["MenuToolsCustomize"];
          optionsToolStripMenuItem.Text = LanguageDicoFr["MenuToolsOptions"];
          languagetoolStripMenuItem.Text = LanguageDicoFr["MenuLanguage"];
          englishToolStripMenuItem.Text = LanguageDicoFr["MenuLanguageEnglish"];
          frenchToolStripMenuItem.Text = LanguageDicoFr["MenuLanguageFrench"];
          helpToolStripMenuItem.Text = LanguageDicoFr["MenuHelp"];
          summaryToolStripMenuItem.Text = LanguageDicoFr["MenuHelpSummary"];
          indexToolStripMenuItem.Text = LanguageDicoFr["MenuHelpIndex"];
          searchToolStripMenuItem.Text = LanguageDicoFr["MenuHelpSearch"];
          aboutToolStripMenuItem.Text = LanguageDicoFr["MenuHelpAbout"];
          DisplayToolStripMenuItem.Text = LanguageDicoFr["Display"];
          SmallToolStripMenuItem.Text = LanguageDicoFr["Small"];
          MediumToolStripMenuItem.Text = LanguageDicoFr["Medium"];
          LargeToolStripMenuItem.Text = LanguageDicoFr["Large"];

          _currentLanguage = "French";
          break;
          // other languages could be added
        default:
          // ReSharper disable once TailRecursiveCall
          SetLanguage("English");
          break;
      }
    }

    private void cutToolStripMenuItemClick(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CutToClipboard(tb);
      }
    }

    private void copyToolStripMenuItemClick(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CopyToClipboard(tb);
      }
    }

    private void pasteToolStripMenuItemClick(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        PasteFromClipboard(tb);
      }
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      TextBox control = focusedControl as TextBox;
      // if (control != null) control.SelectAll();
      control?.SelectAll();
    }

    private void CutToClipboard(TextBoxBase textBox, string errorMessage = "nothing")
    {
      if (textBox != ActiveControl) return;
      if (textBox.Text == string.Empty)
      {
        DisplayMessage(Translate("ThereIs") + Punctuation.OneSpace +
          Translate(errorMessage) + Punctuation.OneSpace +
          Translate("ToCut") + Punctuation.OneSpace, Translate(errorMessage),
          MessageBoxButtons.OK);
        return;
      }

      if (textBox.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("NoTextHasBeenSelected"),
          Translate(errorMessage), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(textBox.SelectedText);
      textBox.SelectedText = string.Empty;
    }

    private void CopyToClipboard(TextBoxBase textBox, string message = "nothing")
    {
      if (textBox != ActiveControl) return;
      if (textBox.Text == string.Empty)
      {
        DisplayMessage(Translate("ThereIsNothingToCopy") + Punctuation.OneSpace,
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      if (textBox.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("NoTextHasBeenSelected"),
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(textBox.SelectedText);
    }

    private void PasteFromClipboard(TextBoxBase textBox)
    {
      if (textBox != ActiveControl) return;
      var selectionIndex = textBox.SelectionStart;
      textBox.SelectedText = Clipboard.GetText();
      textBox.SelectionStart = selectionIndex + Clipboard.GetText().Length;
    }

    private void DisplayMessage(string message, string title, MessageBoxButtons buttons)
    {
      MessageBox.Show(this, message, title, buttons);
    }

    private string Translate(string index)
    {
      string result = string.Empty;
      switch (_currentLanguage.ToLower())
      {
        case "english":
          result = LanguageDicoEn.ContainsKey(index) ? LanguageDicoEn[index] :
           "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
        case "french":
          result = LanguageDicoFr.ContainsKey(index) ? LanguageDicoFr[index] :
            "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
      }

      return result;
    }

    private static Control FindFocusedControl(Control container)
    {
      foreach (Control childControl in container.Controls.Cast<Control>().Where(childControl => childControl.Focused))
      {
        return childControl;
      }

      return (from Control childControl in container.Controls
              select FindFocusedControl(childControl)).FirstOrDefault(maybeFocusedControl => maybeFocusedControl != null);
    }

    private static Control FindFocusedControl(List<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static Control FindFocusedControl(params Control[] container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static Control FindFocusedControl(IEnumerable<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static string PeekDirectoryPath()
    {
      string result = string.Empty;
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        result = fbd.SelectedPath;
      }

      return result;
    }

    private static string PeekFileName()
    {
      string result = string.Empty;
      OpenFileDialog fd = new OpenFileDialog();
      if (fd.ShowDialog() == DialogResult.OK)
      {
        result = fd.SafeFileName;
      }

      return result;
    }

    private void SmallToolStripMenuItemClick(object sender, EventArgs e)
    {
      UncheckAllOptions();
      SmallToolStripMenuItem.Checked = true;
      AdjustAllControls();
    }

    private void MediumToolStripMenuItemClick(object sender, EventArgs e)
    {
      UncheckAllOptions();
      MediumToolStripMenuItem.Checked = true;
      AdjustAllControls();
    }

    private void LargeToolStripMenuItemClick(object sender, EventArgs e)
    {
      UncheckAllOptions();
      LargeToolStripMenuItem.Checked = true;
      AdjustAllControls();
    }

    private static void AdjustControls(params Control[] listOfControls)
    {
      if (listOfControls.Length == 0)
      {
        return;
      }

      int position = listOfControls[0].Width + 33; // 33 is the initial padding, can be increased
      bool isFirstControl = true;
      foreach (Control control in listOfControls)
      {
        if (isFirstControl)
        {
          isFirstControl = false;
        }
        else
        {
          control.Left = position + 10;
          position += control.Width;
        }
      }
    }

    private void AdjustAllControls()
    {
      AdjustControls(); // Insert here all labels, textboxes and buttons, one method per line of controls
    }

    private void optionsToolStripMenuItemClick(object sender, EventArgs e)
    {
      FormOptions frmOptions = new FormOptions(_configurationOptions);

      if (frmOptions.ShowDialog() == DialogResult.OK)
      {
        _configurationOptions = frmOptions.ConfigurationOptions2;
      }
    }

    private static void SetButtonEnabled(Button button, params Control[] controls)
    {
      // Set buttons enable
      bool result = true;
      foreach (Control ctrl in controls)
      {
        if (ctrl.GetType() == typeof(TextBox))
        {
          if (((TextBox)ctrl).Text == string.Empty)
          {
            result = false;
            break;
          }
        }

        if (ctrl.GetType() == typeof(ListView))
        {
          if (((ListView)ctrl).Items.Count == 0)
          {
            result = false;
            break;
          }
        }

        if (ctrl.GetType() == typeof(ComboBox))
        {
          if (((ComboBox)ctrl).SelectedIndex == -1)
          {
            result = false;
            break;
          }
        }
      }

      button.Enabled = result;
    }

    private void textBoxNameKeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        // do something
      }
    }

    private void buttonPeekFile_Click(object sender, EventArgs e)
    {
      string filePeek = PeekFileName();
      textBoxSource.Text = filePeek;
    }

    public static Dictionary<string, int> CreateDictionary(string theText)
    {
      Dictionary<string, int> result = new Dictionary<string, int>();
      var tmpWords = theText.Split(' ');
      foreach (string word in tmpWords)
      {
        if (result.ContainsKey(word))
        {
          result[word]++;
        }
        else
        {
          result.Add(word, 1);
        }
      }

      return result;
    }

    private void ButtonDetect_Click(object sender, EventArgs e)
    {
            MessageBox.Show("no implementation yet");

    }

    private void ButtonTraining_Click(object sender, EventArgs e)
    {
      Dictionary<string, int> sampleDico = new Dictionary<string, int>();
      sampleDico = CreateDictionary(textBoxSource.Text);
      // write result into XML
      listBoxTopWords.Items.Clear();
      foreach (KeyValuePair<string, int> pair in sampleDico.OrderByDescending(k=>k.Value))
      {
        listBoxTopWords.Items.Add($"{pair.Key} - {pair.Value}");
      }
    }

    private static IEnumerable<KeyValuePair<string, int>> SortDicoByValue(Dictionary<string, int> sampleDico)
    {
      return sampleDico.OrderByDescending(key => key.Value);
    }

    private static int CountWords(string phrase)
    {
      var dico = new Dictionary<string, int>();
      foreach (var word in SplitWords(phrase))
      {
        if (dico.ContainsKey(word.Key))
        {
          dico[word.Key]++;
        }
        else
        {
          dico.Add(word.Key, 1);
        }
      }

      return dico.Count;
    }

    private static Dictionary<string, int> SplitWords(string phrase)
    {
      var listOfWords = phrase.Split(' ');
      var dico = new Dictionary<string, int>();
      foreach (string word in listOfWords)
      {
        if (word.Trim() == string.Empty)
        {
          continue;
        }

        if (dico.ContainsKey(word))
        {
          dico[word]++;
        }
        else
        {
          dico.Add(word, 1);
        }
      }

      return dico;
    }
  }
}