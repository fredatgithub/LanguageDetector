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
      var listOfWords = AIHelper.SplitWords(AIHelper.RemovePunctuation(textBoxSource.Text));
      listBoxTopWords.Items.Clear();
      foreach (KeyValuePair<string, int> item in listOfWords.OrderByDescending(k => k.Value))
      {
        listBoxTopWords.Items.Add($"{item.Key.ToLower()}-{item.Value}");
      }

      string frenchFileName = "french-words.txt";
      if (!File.Exists(frenchFileName))
      {
        try
        {
          using (StreamWriter sw = new StreamWriter(frenchFileName))
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

        return; // end
      }


      // the file exists so we add new result to it.
      //read file first
      Dictionary<string, int> dicofile = new Dictionary<string, int>();
      try
      {
        using (StreamReader sw = new StreamReader(frenchFileName))
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
      Dictionary<string, int> newDico = AddTwoDictionaries(dicofile, listOfWords);
      File.Delete(frenchFileName);
      try
      {
        using (StreamWriter sw = new StreamWriter(frenchFileName))
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
    }

    private static Dictionary<string, int> AddTwoDictionaries(Dictionary<string, int> dico1, Dictionary<string, int> dico2)
    {
      foreach (KeyValuePair<string, int> pair in dico2)
      {
        if (dico1.ContainsKey(pair.Key))
        {
          dico1[pair.Key] = dico1[pair.Key] + pair.Value;
        }
        else
        {
          dico1.Add(pair.Key, pair.Value);
        }
      }

      return dico1;
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
  }
}