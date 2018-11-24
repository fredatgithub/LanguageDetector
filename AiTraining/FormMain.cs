using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AIOne;

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
      Application.Exit();
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

    }

    private void LoadLanguages()
    {
      comboBoxLanguagesAvailable.Items.Clear();
      object[] listOfLanguages = { "french", "english", "spanish", "italian" };
      comboBoxLanguagesAvailable.Items.AddRange(listOfLanguages);
      comboBoxLanguagesAvailable.SelectedIndex = 0;
    }

    private void CopierToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}