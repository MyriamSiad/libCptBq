namespace libCptBq
{
    public class Compte
    {
        private int numero;
        private string nom;
        private float solde;
        private int decouvert;

        public Compte (int numero, string nom, float solde, int decouvert)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvert = decouvert;
            
        }

        public Compte()
        {
            this.numero = 0;
            this.decouvert=0;
            this.numero = 0;
            this.solde=0;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public string getNom()
        {
            return this.nom;
        }

        public float getSolde()
        {
            return this.solde;
        }

        public int getDecouvert()
        {
            return this.decouvert;
        }

        public bool Transferer(float montant, Compte c)
        {
            bool flag = false;

            if ((this.solde-montant) >= this.decouvert)
            {
                c.solde = c.solde +  montant;
                this.solde = this.solde - montant;
                flag = true;
            }

            return flag;
        }

        public bool Superieur(Compte c)
        {
            bool flag = false;
            if (this.solde > c.solde)
            { 
                flag = true;
            }
            return flag;
        }

        public void Crediter(float montant)
        {
            this.solde = montant + this.solde;
        }

        public bool Debiter(float montant)
        {
            bool flag = true;
            
            if ((this.solde-montant)>=this.decouvert)
            {
                this.solde = this.solde - montant;
                flag = false;
            }

            return flag;
           
        }

        public override string ToString()
        {
            string str = "numero : " + this.numero + " Nom : " + this.nom + " Solde : " + this.solde +  " Découvert autorisé : " + this.decouvert;
            return str;
        }
    }
}
