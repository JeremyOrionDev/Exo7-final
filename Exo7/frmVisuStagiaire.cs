using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using exercice6;

namespace Exo7
{
    public partial class frmVisuStagiaire : exercice6.frmStagiaire
    {
        /// <summary>
        /// Constructeur adapté : mémorise le stagiaire à traiter
        /// </summary>
        /// <param name="unStagiaire">la référence de l'objet MStagiaire à gérer dans ce form</param>
        public frmVisuStagiaire(MStagiaire unStagiaire)
        {
            //Créer une référence d'objet stagiaire
            // pointant vers le stagiaire reçu en paramètre
            this.leStagiaire = unStagiaire;
            InitializeComponent();
        }
        /// <summary>
        /// la référence du stagaiaire à afficher / modifier
        /// </summary>
        public MStagiaire leStagiaire;


        private void frmVisuStagiaire_Load(object sender, EventArgs e)
        {
            //afficher le stagiaire
            this.afficheStagiaire(this.leStagiaire);
        }

        private void afficheStagiaire(MStagiaire unStagiaire)
        {
            //affecter les textbox
            this.txtBxVirtuelStagiaireNumeroOsia.Text = unStagiaire.NumOsia.ToString();
            this.txtBxVirtuelStagiaireNom.Text = unStagiaire.Nom.ToString();
            this.txtBxVirtuelStagiairePrenom.Text = unStagiaire.Prenom.ToString();
            this.txtBxVirtuelStagiaireVille.Text = unStagiaire.Ville.ToString();
            this.txtBxVirtuelStagiaireCodePostal.Text = unStagiaire.CodePostal.ToString();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MStagiaire unStagiaire = leStagiaire;
           unStagiaire.NumOsia = Int32.Parse(txtBxVirtuelStagiaireNumeroOsia.Text.Trim());
            unStagiaire.Nom = txtBxVirtuelStagiaireNom.Text;
            unStagiaire.Prenom = txtBxVirtuelStagiairePrenom.Text;
            unStagiaire.Ville = txtBxVirtuelStagiaireVille.Text;
            unStagiaire.CodePostal = txtBxVirtuelStagiaireCodePostal.Text.Trim();
            unStagiaire.Rue = txtBxVirtuelStagiaireAdresse.Text;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Donnees.ArrayStag.Remove(this.leStagiaire);
            MStagiaire.Nstag--;
            this.DialogResult = DialogResult.OK;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
