using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EditeurFichier
{
    class EntreesSortiesTexte
    {
        public static String LireTexte(String nomFichier) {
            return File.ReadAllText(nomFichier);
        }

        public static void EcrireTexte(String nomFichier, String contenuFichier)
        {
            
            File.WriteAllText(nomFichier, contenuFichier);
        }

        public static String FiltrerTexte(String nomFichier)
        {
            StringBuilder contenuFichier  = new StringBuilder();
            int codeCaractere;
            StreamReader fluxFixhier = new StreamReader(nomFichier);
            while ( (codeCaractere = fluxFixhier.Read()) != -1)
            {
                char charCode = (char)codeCaractere;
                switch(codeCaractere){
                    case 34:
                        contenuFichier.Append("&quot");
                        break;
                    case 38:
                        contenuFichier.Append("&amp");
                        break;
                    case 39:
                        contenuFichier.Append("&apos");
                        break;
                    case 60:
                        contenuFichier.Append("&lt");
                        break;
                    case 62:
                        contenuFichier.Append("&gt");
                        break;
                    default:
                        contenuFichier.Append(charCode);
                        break;
                }
            }
            return contenuFichier.ToString();
        }

    }
}
