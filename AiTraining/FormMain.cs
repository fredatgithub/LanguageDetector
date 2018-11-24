using AIOne;
using AiTraining.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

      //is the text is written in French
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
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CopyToClipboard(tb);
      }
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
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
        DisplayMessage("There Is " + errorMessage + " To Cut ", errorMessage, MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage("No Text Has Been Selected", errorMessage, MessageBoxButtons.OK);
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
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
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
        DisplayMessage("ThereIsNothingToCopy", message, MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage("NoTextHasBeenSelected", message, MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
    }

    private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { }); // add your controls in the List
      TextBox control = focusedControl as TextBox;
      if (control != null) control.SelectAll();
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
  }
}