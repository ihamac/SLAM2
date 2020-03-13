using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPBanque
{
    class Compte
    {
        private int decouvertMax;
        private int numero;
        private int solde;
        private string titulaire;

        public Compte(int numero, string titulaire, int solde, int decouvertMax) {
            this.numero = numero;
            this.titulaire = titulaire;
            this.solde = solde;
            this.decouvertMax = decouvertMax;
        }

        public string ToString() {
            return string.Format("Bonjour {0} ! Votre numéro de compte est {1}, vous avez une solde de {2} euros et un découvert de {3} euros.",this.titulaire,this.numero,this.solde,this.decouvertMax);
        }
        public int GetSolde
        {
            get { return solde; }
        }
    }
}
