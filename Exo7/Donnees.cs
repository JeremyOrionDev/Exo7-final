using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice6
{
    /// <summary>
    /// classe générale des données à gérer
    /// -----------------------------------
    /// classe qui regroupe les données
    /// de l'application de gestion des stagiaires
    /// dans une collection d'objets définie en static (=non instanciable)
    /// </summary>
    public class Donnees
    {
        /// <summary>
        /// collection d'objets MStagiaire
        /// </summary>
        public static List<MStagiaire>ArrayStag = new List<MStagiaire>();
        public static Exo7.DataSet1 DatasetFormation = new Exo7.DataSet1();
        public static Exo7.DataSet1TableAdapters.StagiaireTableAdapter TaStagiaires = new Exo7.DataSet1TableAdapters.StagiaireTableAdapter();
        public static Exo7.DataSet1TableAdapters.StageTableAdapter TaStages = new Exo7.DataSet1TableAdapters.StageTableAdapter();
    }
}
