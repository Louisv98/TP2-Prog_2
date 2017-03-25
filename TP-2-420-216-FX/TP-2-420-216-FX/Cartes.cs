using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_420_216_FX
{
    public class Cartes
    {
        #region ATTRIBUTS

        /// <summary>
        /// Type de la carte
        /// </summary>
        private TypeCarte _type;

        /// <summary>
        /// Rareté de la carte
        /// </summary>
        private RareteCarte _rarete;

        /// <summary>
        /// Identifiant de la carte
        /// </summary>
        private String _identifiant;

        /// <summary>
        /// Nom de la carte
        /// </summary>
        private String _nom;

        /// <summary>
        /// Extension de la carte
        /// </summary>
        private String _extension;

        /// <summary>
        /// Coût de la carte
        /// </summary>
        private byte _cout;

        /// <summary>
        /// Texte de la carte
        /// </summary>
        private String _texte;

        /// <summary>
        /// Classe de la carte
        /// </summary>
        private ClasseCarte _classe;

        /// <summary>
        /// Mécaniques de la carte
        /// </summary>
        private MecaniqueCarte _mecanique;

        /// <summary>
        /// Points d'attaque de la carte
        /// </summary>
        private byte _pointsAttaque;

        /// <summary>
        /// Points de vie de la carte
        /// </summary>
        private byte _pointsVie;

        /// <summary>
        /// Race de la carte
        /// </summary>
        private RaceCarte _race;

        /// <summary>
        /// Durabilité de la carte
        /// </summary>
        private byte _durabilite;
    }
}
