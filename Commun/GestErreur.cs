using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Commun
{
  class GestErreur
  {
    static public String Ajoute(String Nom, Exception ex)
    {
      try
      {

        String NomLog =Application.ExecutablePath;
        NomLog = NomLog.Substring(0, Application.ExecutablePath.Length - 13) + "error.log";
        StreamWriter w = File.AppendText(NomLog);
        //StreamWriter w = File.AppendText(Application.ExecutablePath.Replace("EnvoiCommandeCRM.exe", "error.log"));
        w.WriteLine("Erreur :\t" + System.Environment.UserName + "\t"
        + Nom + "\t" + DateTime.Now.ToString() + "\t" + ex.Message
        + "\t" + ex.Source + "\n" + ex.StackTrace + "\n");
        w.Flush();
        w.Close();
        return ex.Message;
      }
      catch (Exception ex1)
      {
        return ex1.Message;
      }
    }
    static public String Ajoute(String Nom, Exception ex, String Mess)
    {
      try
      {
          StreamWriter w = File.AppendText(Application.ExecutablePath.Replace("EnvoiCommandeCRM.exe", "error.log"));
        w.WriteLine("Erreur :\t" + System.Environment.UserName + "\t"
        + Nom + "\t" + DateTime.Now.ToString() + "\t" + ex.Message
        + "\t" + ex.Source + "\t" + Mess + "\n");
        w.Flush();
        w.Close();
        return Mess;
      }
      catch (Exception ex1)
      {
        return ex1.Message;
      }
    }
  }
}
