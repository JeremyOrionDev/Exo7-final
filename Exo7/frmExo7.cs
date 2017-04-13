using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exercice6;

namespace Exo7
{
    public partial class frmExo7 : Form
    {
        public frmExo7()
        {
            InitializeComponent();
        }

        private void frmExo7_Load(object sender, EventArgs e)
        {
            Donnees.TaStagiaires.Fill(Donnees.DatasetFormation.Stagiaire);
            Donnees.TaStages.Fill(Donnees.DatasetFormation.Stage);
            MStagiaire unStagiaire;
            foreach (DataSet1.StagiaireRow stagiairerow in Donnees.DatasetFormation.Stagiaire)
            {
                unStagiaire = new MStagiaire();
                unStagiaire.NumOsia = stagiairerow.numOsiaStagiaire;
                unStagiaire.Nom = stagiairerow.NomStagiaire;
                ///
                Donnees.ArrayStag.Add(unStagiaire);
                afficheStagiaires();

            }

        }
        /// <summary>
        /// rétablit la source de données de la dataGridView
        /// et rafraîchit son affichage
        /// </summary>
        private void afficheStagiaires()
        {
            //Datatable :  pour recopier les stagiaires
            // ( stockés en collection)
            // à relier au DataGridView pour personnaliser son affichage
            DataTable dt = new DataTable();
            DataRow dr;
            Int32 i;

            //ajout à la DataTable de 3 colonnes personnalisées
            dt.Columns.Add(new DataColumn("numéro OSIA", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));

            //boucle de remplissage de la DataTable à partir de la collection
            for(i=0;i<Donnees.ArrayStag.Count;i++)
            {
                // instanciation DataRow (ligne de la datatable)
                dr = dt.NewRow();
                dr[0] = Donnees.ArrayStag[i].NumOsia;
                dr[1] = Donnees.ArrayStag[i].Nom;
                dr[2] = Donnees.ArrayStag[i].Prenom;
                // ajout de la ligne à la Datatable
                //(lma propriété row est elle-même une collection)
                dt.Rows.Add(dr);
            } // fin de boucle
            //détermine l'origine des données à afficher en DataGridView
            //On pourrait donner la DataTable, on choisi la vue associée à la DataTable
            //pour pouvoir effectuer des sélections directes
            this.grdStagiaires.DataSource = dt.DefaultView;
        }
        
        /// <summary>
        /// filtrer les stagiaires affichés dans la DaaGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if(this.txtRecherche.Text!=null)
            {
                //filtrer la vue associée à la DataTable
                //Syntaxe de clause where SQL
                ((DataView)(this.grdStagiaires.DataSource)).RowFilter = "Nom like'%'" + this.txtRecherche.Text + "%'";
            }
        }
        /// <summary>
        /// bouton Ajouter: instancier un form de saisie de stagiaire
        /// puis réafficher la datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //instancie un form de saisie de stagiaire et l'affiche en modal
            frmAjouterStagiaire frmAjout = new frmAjouterStagiaire();
            // si on sort de la saisie par OK
            if (frmAjout.ShowDialog()==DialogResult.OK)
            {
                //régénère l'affichage du dataGridView
                afficheStagiaires();
            }
        }
        /// <summary>
        /// Double-clik sur la datagridview:
        /// ouvrir la feuille détail en y affichant
        /// le stagiaire correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdStagiaires_DoubleClick(object sender, EventArgs e)
        {
            //ouvrir la feuille détail en y affichant
            // le stagiaire correspondant à la ligne double cliquée

            Int32 iStag; // rang du stagiaire dans le tableau

            // récupérer l'indice du stagiaire cliqué en datagridViex
            iStag = this.grdStagiaires.CurrentRow.Index;

            // instancier un objet stgiaire pointant vers
            //le stagiaire d'origine dans la collection
            MStagiaire leStagiaire = Donnees.ArrayStag[iStag];

            //instancier un form détail pour ce stagiaire
            frmVisuStagiaire frmVisu = new frmVisuStagiaire(leStagiaire);
            //afficher le form détail en modal
            frmVisu.ShowDialog();

            //en sortie du form détail, rafraichir la dtagridview
            this.afficheStagiaires();
        }
        /// <summary>
        /// Réafficher tous les stagiaires en supprimant le filtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTous_Click(object sender, EventArgs e)
        {
            this.txtRecherche.Text = null;
            ((DataView)(this.grdStagiaires.DataSource)).RowFilter = null;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Int32 iStag;
            iStag = this.grdStagiaires.CurrentRow.Index;
            Donnees.ArrayStag.Remove(Donnees.ArrayStag.ElementAt(iStag));
            MStagiaire.Nstag--;

            this.DialogResult = DialogResult.OK;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grdStagiaires_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
