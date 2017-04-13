using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice6
{
    /// <summary>
    /// classe des stagiaires :
    /// permet de mémoriser les informations concernant un stagiaire
    /// comporte des membres propriétés et attributs
    /// et le nombre de stagiaires,
    /// donnée partagée par toutes les instances (==>static)
    /// </summary>
    public class MStagiaire
    {
        /// <summary>
        /// nombre de stagiaires de la classe
        /// (donnée partagée par toutes les instances)
        /// </summary>
        public static Int32 Nstag;
        /// <summary>
        /// obtient le numéro du stagiaire
        /// </summary>
        private Int32 numOsia;
        /// <summary>
        /// numéro du stagiaire,
        /// l'appelant devra prendre garde à passer un entier valide
        /// </summary>
        public Int32 NumOsia
        {
            get { return numOsia; }
            set { numOsia = value; }
        }
        /// <summary>
        /// le nom du stagiaire
        /// </summary>
        private String nomStagiaire;

        public String Nom
        {
            //en lecture, retourne la var privée
            get { return this.nomStagiaire; }
            //Cette portion de code sert à l'affectation d'une nouvelle valeur;
            //c'est ici que l'on effectue des contrôles de saisie
            //ou des transformations (ici:mettre le nom en majuscules)
            set { this.nomStagiaire = value.Trim().ToUpper(); }//met le nom en majuscules
        }
        /// <summary>
        /// le prénom du stagiaire
        /// </summary>
        private String prenomStagiaire;
        /// <summary>
        /// obtient ou défini le prénom du stagiaire en minuscule
        /// </summary>
        public String Prenom
        {
            get { return prenomStagiaire; }// lecture de la var privée prénom
            set { prenomStagiaire = value.Trim().ToLower(); }//met le prénom en minuscule
        }
        /// <summary>
        /// immeuble, rue et numéro, le format est libre
        /// </summary>
        private String rue;
        /// <summary>
        /// obtient ou défini l'immeuble, la rue et le numéro
        /// </summary>
        public String Rue
        {
            get { return rue; }
            set { rue = value; }
        }
        /// <summary>
        /// le nom de la ville
        /// </summary>
        private String villeStagiaire;
        /// <summary>
        /// obtient ou défnii le nom de la ville, forcé en majuscule
        /// </summary>
        public String Ville
        {
            get { return villeStagiaire; }
            set { villeStagiaire = value.Trim().ToUpper(); }
        }
        /// <summary>
        /// le code postal, l'appelant devra prendre en garde à passer
        /// un code postal valide à 5 chiffres
        /// </summary>
        private String codePostalStagiaire;
        /// <summary>
        /// obtient ou définit le code postal (contrôle : 5 car, tous chiffres)
        /// </summary>
        /// <exception cref="Exception">Si le code postal non valide</exception>
        public String CodePostal
        {
            get { return codePostalStagiaire; }//en lecture retourne le code postal du stagiaire
            set
            {
                //l'appelant doit fournir un code postal valide à 5 chiffres
                Int32 i;//var boucle
                Boolean erreur = false;//indicateur erreur
                if (value.Length==5)//5 car attendus : OK
                {
                    for (i=0;i<value.Length;i++)//contrôle chiffres en boucle
                    {
                        if (! (Char.IsDigit(value[i])))//vérifie si le char n'est pas un chiffre décimal
                        { erreur = true; }
                    
                    }//fin de boucle vérification char
                    if(erreur)//si erreur on renvoi un message indiquant l'erreur
                    {
                        //2e soluce
                        throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide uniquement des chiffres");
                    }
                    else
                    {
                        codePostalStagiaire = value; // code postal Ok on enregistre
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres,  pas plus, pas moins !!!", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        /// <summary>
        /// nombre de notes obtenues
        /// </summary>
        private Int32 nbreNotes;
        /// <summary>
        /// cumul des points obtenus
        /// </summary>
        private Double pointsNotes;
        /// <summary>
        /// alimente nbreNote et pointsNotes
        /// </summary>
        /// <param name="laNote">la nouvelle note à prendre en compte</param>
        /// <param name="laNote"></param>
        public void RecevoirNote(float laNote)
        {
            this.nbreNotes++;
            this.pointsNotes += laNote;
        }
        /// <summary>
        /// calcule et retourne lamoyenne des notes
        /// </summary>
        /// <returns>nouvelle moyenne des notes</returns>
        public Double DonnerMoyenne()
        {
            return this.pointsNotes / this.nbreNotes;
        }

    }
}
