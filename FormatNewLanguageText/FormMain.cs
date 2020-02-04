using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AIOne;

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
      textBoxFormatted.Text = AIHelper.RemoveWrongCharacters(result);
      listBoxWords.Items.Clear();
      string[] words = textBoxFormatted.Text.Split(',');
      foreach (string word in AIHelper.GetWordsDistinct(words))
      {
        listBoxWords.Items.Add(word);
      }
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
