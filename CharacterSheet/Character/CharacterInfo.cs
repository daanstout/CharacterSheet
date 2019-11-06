using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSheet.Character.Backgrounds;
using CharacterSheet.Character.Classes;
using CharacterSheet.Character.Races;

namespace CharacterSheet.Character {
    /// <summary>
    /// A Character Sheet, used to display a character
    /// </summary>
    public class CharacterInfo {
        #region Variables
        /// <summary>
        /// The character name
        /// </summary>
        public string characterName { get; set; }
        /// <summary>
        /// The player name
        /// </summary>
        public string playerName { get; set; }

        /// <summary>
        /// The primary class of the character
        /// </summary>
        public IClass primaryClass { get; private set; }

        /// <summary>
        /// The classes the character multi-classed into
        /// </summary>
        public List<IClass> multiClasses { get; private set; }

        /// <summary>
        /// The background of the character
        /// </summary>
        public IBackground background { get; private set; }

        /// <summary>
        /// The race of the character
        /// </summary>
        public ARace race { get; private set; }

        /// <summary>
        /// The total experience points the character has
        /// </summary>
        public int experiencePoints { get; set; }

        /// <summary>
        /// The player level
        /// <para>This is the same as the sum of all class levels</para>
        /// </summary>
        public int level { get; set; }

        /// <summary>
        /// The ability scores of the character
        /// </summary>
        public AbilityScore scores { get; set; }

        /// <summary>
        /// The character's biography
        /// </summary>
        public Biography biography { get; private set; }
        #endregion

        #region Properties
        /// <summary>
        /// Whether the class is multiclassed
        /// </summary>
        public bool isMultiClassed => multiClasses == null ? false : multiClasses.Count == 0; // check if multiclass list is null or empty
        #endregion

        public CharacterInfo(ARace race) {
            this.race = race;
        }
    }
}
