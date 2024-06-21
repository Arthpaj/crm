using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnvoiCommandeCRM
{
  public partial class UFStd : Form
  {
    public UFStd()
    {
      InitializeComponent();
    }

    private void UFStd_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 13)
      {
        //SendKeys.Send("{tab}");
        //Control ctlNext = ActiveControl.GetNextControl((Control)sender, true);
        //ctlNext.Focus();
        //e.Handled = true;
      } 
    }
  }
}