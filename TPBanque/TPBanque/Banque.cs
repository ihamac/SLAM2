using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TPBanque
{
    class Banque
    {
        private Compte[] possede;
        private string nom;
        private int nombreCompte;

        public Banque(string nom)
        {
            this.nom = nom;
            this.nombreCompte = 0;
            this.possede = new Compte[100];
        }

        //ajouteCompte joue le même rôle que la méthode Add pour une collection
        public void AjouteCompte(Compte C)
        {
            if (this.nombreCompte < this.possede.Length)
            {
                this.possede[nombreCompte] = C;
                this.nombreCompte = this.nombreCompte + 1;
            }
            else
            { //dépassement capacité du tableau
                throw new System.Exception("Attention vous atteignez la taille maximum du tableau de compte !");
            }
        }
        //une surchage de AjouteCompte

        public void AjouteCompte(int numero, string titulaire, int solde, int decouverteMax)
        {
            Compte NouveauCompte = new Compte(numero, titulaire, solde, decouverteMax);
            this.AjouteCompte(NouveauCompte);
        }

        public int NombreCompte
        {
            get { return this.nombreCompte; }
        }

        public int GetNombreCompte()
        {
            return this.nombreCompte;
        }

        public Compte GetCompte(int position)
        {
            if (position > -1 && position < nombreCompte)
            {
                return this.possede[position];
            }
            else
            {
                throw new System.Exception("En dehors de la plage de compte");
            }
        }
        public Compte this[int position]
        {
            get { return this.GetCompte(position); }
        }

        public int Count{
            get { return this.nombreCompte; }
        }

        public int ValeurDepotsBanque() {
            int cumul = 0;
            for (int i = 0; i < nombreCompte; i++) {
                cumul += possede[i].GetSolde;
            }
            return cumul;
        }
        public int CountSoldesNegatifs()
        {
        }
        public int CountSoldesPositifs() {
        }
        public Compte CompteLePlusDeficitaire() {
        }
        public Compte PlusGrandSolde() {
        }
        public ArrayList LesSoldesNegatifs() {
        }
        public void Supprimer(int position) {
        }
        public void Inserer(int position, Compte c) {
        }
    }
}


