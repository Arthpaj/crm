using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Management;


namespace Commun
{
  class Commun
  {
        static public string GetToken(string cleToken)
        {
            //string cleToken = Properties.Settings.Default.Cle_Token.Trim();
            string basetoken = cleToken + DateTime.Today.ToString("yyyyMMdd");
            // step 1, calculate MD5 hash from input        
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(basetoken);
            byte[] hash = md5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string        
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();

        }
        static public String SubString(String chaine, Int32 longueur)
    {
      if (chaine == "")
      {
        chaine = "CHAINEVIDE";
      }
      else
      {
        chaine = chaine.ToUpper();
        if (chaine.Length > longueur)
        {
          chaine = chaine.Trim().Replace(" ", "");
          chaine = chaine.Substring(0, longueur);
        }
        else
        {
        }
      }
      return chaine;
    }

    static public String ConvertDate(String chaine, String format)
    {
      String Annee, Mois, Jour, Final = "";
      Annee = chaine.Substring(0, 4);
      Mois = chaine.Substring(4, 2);
      Jour = chaine.Substring(6, 2);
      Final = Jour + "/" + Mois + "/" + Annee;
      Final = Convert.ToDateTime(Final).ToString(format);
      return Final;
    }

    static public String AD1(String adresse1)
    {
      if (adresse1.Length > 30)
      {
        adresse1 = adresse1.Substring(0, 30);
      }
      return adresse1;
    }

    static public String AD2(String adresse1)
    {
      String Final = "";
      if (adresse1.Length > 60)
      {
        Final = adresse1.Substring(30, 60);
      }
      else
      {
        if (adresse1.Length > 30)
        {
          Final = adresse1.Substring(30, adresse1.Length - 30);
        }
      }
      return Final;
    }

    static public String AD3(String adresse1)
    {
      String Final = "";
      if (adresse1.Length > 90)
      {
        Final = adresse1.Substring(60, 90);
      }
      else
      {
        if (adresse1.Length > 60)
        {
          Final = adresse1.Substring(60, adresse1.Length - 60);
        }
      }
      return Final;
    }

    static public String ConvertBool(String chaine)
    {
      String Final = "null";
      if (chaine == "Oui")
      {
        Final = "1";
      }
      if (chaine == "Non")
      {
        Final = "0";
      }
      return Final;
    }

    static public String ConvertDouble(String chaine)
    {
      Double Final = 0;
      Final = Convert.ToDouble(chaine);
      //Final = Final / 100; MODIFICATION DU FICHIER D'IMPORT LE 18/02/2008
      return Final.ToString("0.00").Replace(",", ".");
    }

    static public string CorrigeTelephone(string NumeroTelephone) // NB-20110215 - Norme téléphone : xx xx xx xx xx si FR
    {
      String sNumTelDepart, sNumtel;
      int sizeTel, nbreChar = 0;
      sNumTelDepart = NumeroTelephone;
      sNumtel = sNumTelDepart;

      sNumtel = sNumtel.Replace(".", "");
      sNumtel = sNumtel.Replace("-", "");
      sNumtel = sNumtel.Replace("/", "");
      sNumtel = sNumtel.Replace(" ", "");
      sizeTel = sNumtel.Length;
      if (sizeTel != 10)
      {
        return sNumTelDepart;
      }
      else
      {
        int nbreInter = 0;
        while (nbreChar < sizeTel)
        {

          if (nbreInter == 2)
          {
            sNumtel = sNumtel.Insert(nbreChar, " ");
            nbreInter = 0;
            sizeTel++;
            nbreChar++;
          }
          nbreChar++;
          nbreInter++;
        }
        return sNumtel;
      }
    }
    static public Boolean CorrigeEmail(string ChaineEmail, out string Error)   // NB-20110215
    {
      if (ChaineEmail.Length == 0)
      {
        //Email vide autorisé... Error = "e-mail address is required.";
        Error = "";
        return true; //false
      }

      // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
      if (ChaineEmail.IndexOf("@") > -1)
      {
        if (ChaineEmail.IndexOf(".", ChaineEmail.IndexOf("@")) > ChaineEmail.IndexOf("@"))
        {
          Error = "";
          return true;
        }
      }

      Error = "L'adresse E-mail  doit être d'un format d'e-mail valide.\n" +
         "Exemple 'someone@example.com' ";
      return false;
    }
    static public string AdiInputBox(String Entete, String Question, String Defaut)
    {
      EnvoiCommandeCRM.Divers.UFInputBox IB = new EnvoiCommandeCRM.Divers.UFInputBox();
      IB.Text = Entete;
      IB.Question.Text = Question;
      IB.Reponse.Text = Defaut;
      if (IB.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        return IB.Reponse.Text;
      }
      else
      {
        return "";
      }
    }

    static public bool ExistProcessusIdentique()
    {
        int MonProcId = Process.GetCurrentProcess().Id;
        string wmiQueryMoi = string.Format("Select Handle, Name, CommandLine From Win32_Process Where Handle = " +
            MonProcId.ToString());
        ManagementObjectSearcher searcherMoi = new ManagementObjectSearcher(wmiQueryMoi);
        ManagementObjectCollection retObjectCollectionMoi = searcherMoi.Get();
        string MonProcName = "";
        string MonProcCmd = "";
        foreach (ManagementObject retObjectMoi in retObjectCollectionMoi)
        {
            MonProcName = retObjectMoi["Name"].ToString();
            MonProcCmd = retObjectMoi["CommandLine"].ToString();
        }

        //MessageBox.Show(MonProcCmd);

        string wmiQueryAutre = string.Format("Select Handle, Name, CommandLine From Win32_Process Where (Handle <> " +
            MonProcId.ToString() + ") and (Name='" + MonProcName + "')");
        ManagementObjectSearcher searcherAutre = new ManagementObjectSearcher(wmiQueryAutre);
        ManagementObjectCollection retObjectCollectionAutre = searcherAutre.Get();
        bool Resultat = false;
        foreach (ManagementObject retObjectAutre in retObjectCollectionAutre)
        {
            //LB.Items.Add("____________________________________________________________");
            try
            {
                //MessageBox.Show(retObjectAutre["CommandLine"].ToString());

                /*LB.Items.Add("Hand : " + retObjectAutre["Handle"].ToString());
                LB.Items.Add("Name : " + retObjectAutre["Name"].ToString());
                LB.Items.Add("Cmd  : " + retObjectAutre["CommandLine"].ToString());*/
                if (retObjectAutre["CommandLine"].ToString() == MonProcCmd)
                {
                    Resultat = true;
                    //MessageBox.Show(retObjectAutre["CommandLine"].ToString() + "______________" + 
                    //    MonProcCmd);
                    break;
                }
            }
            catch
            {
                //LB.Items.Add("?");
            }

        }
        //LB.Items.Add("FINI");
        return Resultat;
    }

    static public bool LancementProgramme()
    {
        String CheminSage = "";
        String SocSage = "";
        String TypeSage="";
        
        String[] arguments = Environment.GetCommandLineArgs();
        for (int i = 0; i < arguments.Length; ++i)
        {
            if (i == 1)
                CheminSage = arguments[1];
            if (i == 2)
                SocSage = arguments[2].Trim();
            if (i == 3)
                TypeSage = arguments[3].ToUpper();
        }
        if ((CheminSage != "") && (SocSage != ""))
            return true;
        else
            return false;
    }

  }

}
