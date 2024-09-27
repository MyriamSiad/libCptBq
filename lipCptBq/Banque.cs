using libCptBq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace banque
{
    public class Banque
    {
        private List<Compte> mesComptes;
        private List<Typee> mesTypes;

        public Banque(Compte c)
        {
            mesComptes = new List<Compte>();
            mesTypes = new List<Typee>();
        }

        public Banque()
        {
            mesComptes = new List<Compte>();
            mesTypes = new List<Typee>();
        }

        public Typee GetType(string code)
        {
            Typee ty = null;
            foreach (Typee t in mesTypes)
            {
                if (t.GetCode() == code)
                {
                    ty = t;
                }


            }
            return ty;
        }


        public void AjouterType(string code, string libelle, char sens)
        {
          
           Typee ty = new Typee(code, libelle, sens);

            if (ty != null)
            {
                this.mesTypes.Add(ty);
            }
        }

        public void AjouterType(Typee unType)
        {
            this.mesTypes.Add(unType);
        }

        public void AjouterCompte(Compte C)
        {
            mesComptes = new List<Compte>();
            this.mesComptes.Add(C);
        }
        public void AjouterCompte(int numero, string nom, float solde, int decouvert)
        {
            Compte c = new Compte(numero, nom, solde, decouvert);

            this.mesComptes.Add(c);
        }

        public Compte RendCompte(int numero)
        {
            Compte b = new Compte();

            b = null;

            foreach (Compte c in mesComptes)
            {
                if (c.getNumero() == numero)
                {
                    b = c;
                }
            }
            return b;
        }

        public Compte compteMax()
        {
            Compte a = new Compte();
            a = null;
            Compte compte = new Compte();
            foreach (Compte c in mesComptes)
            {
                if (c.Superieur(compte))
                {
                    a = c;
                };
            }
            return a;
        }

        public override string ToString()
        {
            string str = "";
            foreach (Compte c in mesComptes)
            {
                str += " numero : " + c.getNumero() + " Nom :  " + c.getNom() + " Solde : " + c.getSolde() + " Découvert autorisé : " + c.getDecouvert() + "\n";

            }
            return str;

        }

         
    }
}
