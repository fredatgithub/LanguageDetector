using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormatNewLanguageText
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void ButtonFormatText_Click(object sender, EventArgs e)
    {
      if (textBoxSource.Text == string.Empty)
      {
        return;
      }

      textBoxFormatted.Text = string.Empty;
      string result = textBoxSource.Text;
      result = Regex.Replace(result, @"[\d-]", string.Empty);
      result = result.Replace(".", "");
      result = result.Replace(";", "");
      result = result.Replace("!", "");
      result = result.Replace(" ", ",");
      result = result.Replace(",,", ",");
      result = result.Replace(",,", ",");
      result = result.Replace("/", "");

      textBoxFormatted.Text = result;

      listBoxWords.Items.Clear();
      string[] words = textBoxFormatted.Text.Split(',');
      foreach (string word in GetWordsDistinct(words))
      {
        listBoxWords.Items.Add(word);
      }
    }

    public static IEnumerable<string> GetWordsDistinct(string[] words)
    {
      List<string> result = new List<string>();
      for (int i = 0; i < words.Length; i++)
      {
        if (!result.Contains(words[i].ToLower()))
        {
          result.Add(words[i].ToLower());
        }
      }

      return result;
    }

    public static string RemoveSpecialCharacters(string sentence, char[] specialCharacters)
    {
      return new string(sentence.Except(specialCharacters).ToArray());
    }

    private void ButtonCopy_Click(object sender, EventArgs e)
    {
      string result = string.Empty;
      foreach (string word in listBoxWords.Items)
      {
        result += word.ToLower().Trim() + ",";
      }

      result = result.TrimEnd(',');
      Clipboard.SetText(result);
    }
  }
}
