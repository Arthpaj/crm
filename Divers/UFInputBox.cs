using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnvoiCommandeCRM.Divers
{
    public partial class UFInputBox : EnvoiCommandeCRM.UFStd
  {
    public UFInputBox()
    {
      InitializeComponent();
    }

    private void BoutExit_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    private void BoutValid_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}
