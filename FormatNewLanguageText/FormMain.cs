using System;
using System.Collections.Generic;
using System.Linq;
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

        private void ButtonRemoveDuplicate_Click(object sender, EventArgs e)
        {
            textBoxFormatted.Text = string.Empty;
            var tableau = textBoxSource.Text.Split(',');
            var dico = new List<string>();
            for (int i = 0; i < tableau.Length; i++)
            {
                if (!dico.Contains(tableau[i]))
                {
                    dico.Add(tableau[i]);
                }
            }

            foreach (string item in dico)
            {
                textBoxFormatted.Text += $"{item},";
            }
        }

        private void ButtonToLowercase_Click(object sender, EventArgs e)
        {
            textBoxFormatted.Text = textBoxFormatted.Text.ToLower();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxRemoveCharacter.Items.Clear();
            foreach (char item in Properties.Settings.Default.SpecialCharacters)
            {
                comboBoxRemoveCharacter.Items.Add(item);
            }


        }

        private void ButtonRemovecharacter_Click(object sender, EventArgs e)
        {
            if (comboBoxRemoveCharacter.SelectedIndex == -1)
            {
                return;
            }

            textBoxFormatted.Text = textBoxFormatted.Text.Replace(comboBoxRemoveCharacter.SelectedItem.ToString(), "");
        }

        private void ComboBoxRemoveCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemovecharacter.Enabled = true;
        }

        private void ButtonReloadWords_Click(object sender, EventArgs e)
        {
            string[] words = textBoxFormatted.Text.Split(',');
            listBoxWords.Items.Clear();
            foreach (string word in AIHelper.GetWordsDistinct(words))
            {
                listBoxWords.Items.Add(word.Trim());
            }
        }
    }
}
