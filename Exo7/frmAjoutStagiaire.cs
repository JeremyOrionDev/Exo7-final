using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exo7;

namespace exercice6
{
    public partial class frmAjouterStagiaire : exercice6.frmStagiaire
    {
        public frmAjouterStagiaire()
        {
            InitializeComponent();
        }

        private void frmAjouterStagiaire_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// méthode déclenchée apr le bouton OK
        /// instancie un objet Mstagiaire et le renseigne
        /// puis le référence dans la collection d'objets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //créer une référence d'objet Mstagiaire
            MStagiaire nouveauStagiaire = new MStagiaire();

            //Controle vraissemblance des données saisies sur le form
            if(this.controle())
            {
                if(this.instancie())
                {
                    //cas général :
                    //si l'instanciation stagiaire et 
                    //son ajout à la collection est OK:
                    //- incrémentation compteurs de stagiaires
                    MStagiaire.Nstag += 1;
                    
                    //-fermeture de la boite de dialogue par validation
                    this.DialogResult = DialogResult.OK;
                }
            }
            
        }
        /// <summary>
        /// fonction de controle de vraissemblance des différents
        /// champs du form:
        /// (appelée avant d'instancier un objet MStagiaire
        /// et d'affecter ses membres)
        /// </summary>
        /// <returns>Booléen : true = OK, false = erreur</returns>
        private Boolean controle()
        {
            //contrôler la vraissemblancede tous les champs
            Boolean code = true;//le code de retour; OK a priori

            //appel fonction générique de controle
            if(!(estEntier(this.txtBxVirtuelStagiaireNumeroOsia.Text)))
            {
                //la chaine reçue n'est pas convertible
                code = false;
                MessageBox.Show("le code OSIA saisi n'est pas un entier valide", "ERREUR", MessageBoxButtons.OK);
            }
            if(!(estEntier(this.txtBxVirtuelStagiaireCodePostal.Text)))
            {
                code = false;
                MessageBox.Show("le code postal saisi n'est pas correct", "ERREUR", MessageBoxButtons.OK);

            }
            return code;
        }
        /// <summary>
        /// fonction générique de contrôle qu'une chaine reçue
        /// pourra se convertir en Int32
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Booléen : true = OK, false = erreur</returns>
        private Boolean estEntier(String s)
        {
            /* vérifier que la chaine reçue représente bien un entier valide :
             * - uniquement des chiffres
             * - pas vide
             * - pas plus que 9 chiffres (capacité maxi du type Int32)
             */
            Int32 i;                //indice de parcours de chaine
            Char c;                 //caractère courant
            Boolean code = true;    // code retour; OK a priori
            
            //test longueur chaine reçue
            if(s.Length<10&&s.Length>0)
            {
                //vérifier 1 à 1 que tous les caractères sont des chiffres
                for (i=0;i<s.Length;i++)
                {
                    c = s[i]; //extrait le i° char
                    if(!(Char.IsDigit(c))) //si ce n'est pas un chiffre
                    {
                        code = false; // erreur detectée

                    }
                } // fin de boucle for
            }
            else // erreur de longueur de chaine
            {
                code = false; // erreur detectée
            }
            return code;
        }
        /// <summary>
        /// fonction qui instancie un nouvel objet MStagiaire
        /// puis tente d'affecter ses membres (var. ou prop.)
        /// avec interception d'erreur éventuelle levée apr la classe MStagiaire
        /// </summary>
        /// <returns>Boolean : true = OK, false = erreur</returns>
        private Boolean instancie()
        {
            //créer une référence d'objet MStagiaire
            MStagiaire nouveauStagiaire = new MStagiaire();
            try
            {
                // affecter les données de l'objet MStagiaire :
                // variables simples, ou propriétés
                // ce qui déclenche alors le code des méthodes set
                //
                // conversion numOsia saisi en textbox vers le type integer
                nouveauStagiaire.NumOsia = Int32.Parse(base.txtBxVirtuelStagiaireNumeroOsia.Text.Trim());
                // avec conversion en MAJ
                nouveauStagiaire.Nom = base.txtBxVirtuelStagiaireNom.Text;
                // avec conversion en min
                nouveauStagiaire.Prenom = base.txtBxVirtuelStagiairePrenom.Text;
                nouveauStagiaire.Rue = base.txtBxVirtuelStagiaireAdresse.Text;
                // avec conversion en MAJ
                nouveauStagiaire.Ville = base.txtBxVirtuelStagiaireVille.Text;
                //avec controle de saisie
                nouveauStagiaire.CodePostal = base.txtBxVirtuelStagiaireCodePostal.Text.Trim();
                //ajouter la référence d'objet MSTagiaire dans la collection
                Donnees.ArrayStag.Add(nouveauStagiaire);

                // instancier un StagiaireRow et le renseigner
                DataSet1.StagiaireRow SR ;
                SR = Donnees.DatasetFormation.Stagiaire.NewStagiaireRow();
                SR.numOsiaStagiaire = nouveauStagiaire.NumOsia;
                SR.NomStagiaire = nouveauStagiaire.Nom;
                SR.prenomStagiaire = nouveauStagiaire.Prenom;
                SR.rueStagiaire = nouveauStagiaire.Rue;
                SR.villeStagiaire = nouveauStagiaire.Ville;
                SR.codePostalStagiaire = nouveauStagiaire.CodePostal;
                SR.CodeSection = 1; // à compléter
                SR.PointsNotes = 0; // bug
                SR.NbreNotes = 0;
                // ajouter le StagiaireRow au dataTable du DataSet
               Donnees.DatasetFormation.Stagiaire.AddStagiaireRow(SR);
                // impacter la MAJ en BDD
               Donnees.TaStagiaires.Update(Donnees.DatasetFormation.Stagiaire);
                return true;
            }
            catch(Exception ex)
            {
                nouveauStagiaire = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de stagiaire");
                return false;
            }
        }




        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //fermeture de la boite de dialogue par abandon
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
