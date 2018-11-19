using System;
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
      Application.Exit();
    }

    private void ButtonTraining_Click(object sender, EventArgs e)
    {

    }

    private void TabPageAITraining_Click(object sender, EventArgs e)
    {

    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      // verify languages files

    }
  }
}