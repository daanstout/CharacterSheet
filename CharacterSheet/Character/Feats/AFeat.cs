using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Character.Feats {
    public abstract class AFeat {
        /// <summary>
        /// The name of the feat
        /// </summary>
        public string name { get; protected set; }
        /// <summary>
        /// The flavor for the feat
        /// </summary>
        public string flavor { get; protected set; }

        /// <summary>
        /// A function that calculates whether the character can have a feat
        /// </summary>
        /// /// <param name="character">The character to check for</param>
        /// <returns>True if that character can have the feat</returns>
        public abstract bool CharacterCanHaveFeat(CharacterInfo character);

        /// <summary>
        /// Applies the feat to the character
        /// </summary>
        /// <param name="character">The character to apply the feat to</param>
        public abstract void ApplyFeat(CharacterInfo character);
    }
}
