using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCptBq
{
   public  class Typee
    {
        private string code;
        private string libelle;
        private char sens;

        public Typee(string code, string libelle, char sens)
        {
            this.code = code;
            this.libelle = libelle;
            this.sens = sens;
        }

        public Typee (string code, char sens)
        {
            this.code = code;
        }

        public string GetCode()
        {
            return this.code;
        }

       

        public char GetSens()
        {
            return this.sens;
        }

        public override string ToString()
        {
            
            string str = "code : " + this.code + " libellé : " + this.libelle + " sens : " + this.sens ;
            return str;
        }


    }
}
