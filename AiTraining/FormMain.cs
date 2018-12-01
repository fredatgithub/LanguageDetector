using AIOne;
using AiTraining.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AiTraining
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveWindowValue();
      Application.Exit();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.comboBoxLanguagesAvailableIndex = comboBoxLanguagesAvailable.SelectedIndex;
      Settings.Default.tabControlMainIndexSelected = tabControlMain.SelectedIndex;
      Settings.Default.Save();
    }

    private void ButtonTraining_Click(object sender, EventArgs e)
    {
      // getting words from text to study
      var listOfWords = AIHelper.SplitWords(AIHelper.RemovePunctuation(textBoxSource.Text));
      listBoxTopWords.Items.Clear();
      // displaying number of words found
      foreach (KeyValuePair<string, int> item in listOfWords.OrderByDescending(k => k.Value))
      {
        listBoxTopWords.Items.Add($"{item.Key.ToLower()}-{item.Value}");
      }

      // is the text written in French
      // for each language file available, check if language does match
      string languageSelectedFileName = $"{comboBoxLanguagesAvailable.SelectedItem}-words.txt";
      if (!File.Exists(languageSelectedFileName))
      {
        try
        {
          using (StreamWriter sw = new StreamWriter(languageSelectedFileName))
          {
            foreach (KeyValuePair<string, int> item in listOfWords.OrderByDescending(k => k.Value))
            {
              sw.WriteLine($"{item.Key},{item.Value}");
              //sw.WriteLine($"{item.Key}"); //use to create list of most used words
            }
          }
        }
        catch (Exception exception)
        {
          MessageBox.Show($"exception while writing the dictionary: {exception.Message}");
        }

        // display listbox from file
        LoadlistBox(listBoxWordsFromFile, listOfWords);
        return; // end
      }


      // the file exists so we add new result to it.
      //read file first
      Dictionary<string, int> dicofile = new Dictionary<string, int>();
      try
      {
        using (StreamReader sw = new StreamReader(languageSelectedFileName))
        {
          while (!sw.EndOfStream)
          {
            string line = sw.ReadLine();
            if (line != null)
            {
              var lineSplitted = line.Split(',');
              int wordOccurence = int.Parse(lineSplitted[1]);
              dicofile.Add(lineSplitted[0].ToLower(), wordOccurence);
            }
          }
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show($"exception while reading the word stats dictionary: {exception.Message}");
      }

      // add results to existing file
      Dictionary<string, int> newDico = AIHelper.AddTwoDictionaries(dicofile, listOfWords);
      File.Delete(languageSelectedFileName);
      try
      {
        using (StreamWriter sw = new StreamWriter(languageSelectedFileName))
        {
          foreach (KeyValuePair<string, int> item in newDico.OrderByDescending(k => k.Value))
          {
            sw.WriteLine($"{item.Key},{item.Value}");
          }
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show($"exception while writing the dictionary: {exception.Message}");
      }

      //update listbox from file
      LoadlistBox(listBoxWordsFromFile, newDico);
    }

    private static void LoadlistBox(ListBox listBox, Dictionary<string, int> dico)
    {
      listBox.Items.Clear();
      foreach (KeyValuePair<string, int> item in dico.OrderByDescending(k => k.Value))
      {
        listBox.Items.Add($"{item.Key}-{item.Value}");
      }
    }

    private static void AddDicoToListBox(ListBox listBox, Dictionary<string, int> listOfWords)
    {
      listBox.Items.Clear();
      foreach (KeyValuePair<string, int> word in listOfWords)
      {
        listBox.Items.Add($"{word.Key}-{word.Value}");
      }
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      // verify languages files
      LoadLanguages();
      LoadSettingsAtStartup();
    }

    private void LoadSettingsAtStartup()
    {
      DisplayTitle();
      GetWindowValue();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      comboBoxLanguagesAvailable.SelectedIndex = Settings.Default.comboBoxLanguagesAvailableIndex;
      tabControlMain.SelectedIndex = Settings.Default.tabControlMainIndexSelected;
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += $@" V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}.{fvi.FilePrivatePart}";

    }

    private void LoadLanguages()
    {
      comboBoxLanguagesAvailable.Items.Clear();
      object[] listOfLanguages = { "french", "english", "spanish", "italian" };
      comboBoxLanguagesAvailable.Items.AddRange(listOfLanguages);
      comboBoxLanguagesAvailable.SelectedIndex = 0;
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxSource });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CopyToClipboard(tb);
      }
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxSource });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CutToClipboard(tb);
      }
    }

    private void CutToClipboard(TextBoxBase tb, string errorMessage = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage("There is " + errorMessage + " to cut ", errorMessage, MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage("No text has been selected", errorMessage, MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
      tb.SelectedText = string.Empty;
    }

    private void DisplayMessage(string message, string title, MessageBoxButtons buttons)
    {
      MessageBox.Show(this, message, title, buttons);
    }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxSource });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        PasteFromClipboard(tb);
      }
    }

    private void PasteFromClipboard(TextBoxBase tb)
    {
      if (tb != ActiveControl) return;
      var selectionIndex = tb.SelectionStart;
      tb.SelectedText = Clipboard.GetText();
      tb.SelectionStart = selectionIndex + Clipboard.GetText().Length;
    }

    private void CopyToClipboard(TextBoxBase tb, string message = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage("There is nothing to copy", message, MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage("No text has been selected", message, MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
    }

    private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxSource });
      TextBox control = focusedControl as TextBox;
      control?.SelectAll();
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

    private static string PeekFile(bool shortName = true)
    {
      string result = string.Empty;
      OpenFileDialog fd = new OpenFileDialog();
      if (fd.ShowDialog() == DialogResult.OK)
      {
        result = shortName ? fd.SafeFileName: fd.FileName;
      }

      return result;
    }
    private static string PeekDirectory()
    {
      string result = string.Empty;
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        result = fbd.SelectedPath;
      }

      return result;
    }

    private void ButtonDetect_Click(object sender, EventArgs e)
    {
      var languageDetected = new Dictionary<string, double>();
      foreach (string language in Settings.Default.ListOfLanguages.Split(','))
      {
        languageDetected.Add(language, 0.0);
      }

      var listOfWords = AIHelper.SplitWords(AIHelper.RemovePunctuation(textBoxSource.Text));
      var languageDetectedTmp = new Dictionary<string, double>();
      foreach (KeyValuePair<string, double> pair in languageDetected)
      {
        languageDetectedTmp[pair.Key] = AIHelper.CountFoundWords(GetLanguageWords(pair.Key), listOfWords);
      }

      double maxValue = languageDetectedTmp.Max(v => v.Value);
      string languageDetectedGuess = "unknown";
      if (maxValue != 0.0)
      {
        languageDetectedGuess = languageDetectedTmp
          .FirstOrDefault(x => x.Value == maxValue).Key;
      }

      labelLanguageDetected.Text = $"Language detected is : {languageDetectedGuess.ToUpper()}";
      labelLanguageDetected.ForeColor = GetColor(languageDetectedGuess);
    }

    private static Color GetColor(string languageDetected)
    {
      return languageDetected.ToLower() == "unknown" ? Color.Red : Color.Green;
    }

    private static List<string> GetLanguageWords(string language)
    {
      var result = new List<string>();
      switch (language.Trim().ToLower())
      {
        case "french":
          result = Settings.Default.FrenchWords.Split(',').ToList();
          break;
        case "english":
          result = Settings.Default.EnglishWords.Split(',').ToList();
          break;
        default:
          result = new List<string>();
          break;
      }

      return result;
    }

    private void TextBoxSource_TextChanged(object sender, EventArgs e)
    {
      if (textBoxSource.Text.Trim() == string.Empty)
      {
        labelLanguageDetected.Text = "Language detected is : unknown";
        labelLanguageDetected.ForeColor = GetColor("unknown");
        buttonDetect.Enabled = false;
      }
      else
      {
        buttonDetect.Enabled = true;
      }
    }

    private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      QuitterToolStripMenuItem_Click(sender, e);
    }

    private void ButtonPeekFile_Click(object sender, EventArgs e)
    {
      textBoxSource.Text = string.Empty;
      var fileName = PeekFile(false);
      // read file and put it in textbox
      try
      {
        using (StreamReader sr = new StreamReader(fileName))
        {
          while (!sr.EndOfStream)
          {
            textBoxSource.Text += sr.ReadLine(); // TODO to be debug
          }
        }
      }
      catch (Exception)
      {
        // ignored
      }
    }
  }
}