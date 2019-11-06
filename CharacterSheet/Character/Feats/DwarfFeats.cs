using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSheet.Character.Races;

namespace CharacterSheet.Character.Feats {
    public class DwarvenResilience : AFeat {
        /// <summary>
        /// The instance of the Dwarven Resilience feat
        /// </summary>
        public static DwarvenResilience instance { get; } = new DwarvenResilience();

        /// <summary>
        /// Private constructor so no new Dwarven Resilience instances can be created
        /// </summary>
        private DwarvenResilience() {
            name = "Dwarven Resilience";
            flavor = "You have advantage on saving throws against poison, and you have resistance against poison damage.";
        }

        /// <summary>
        /// A function that calculates whether the character can have a feat
        /// </summary>
        /// /// <param name="character">The character to check for</param>
        /// <returns>True if that character can have the feat</returns>
        public override bool CharacterCanHaveFeat(CharacterInfo character) => Dwarf.instance.CharacterIsRace(character);

        /// <summary>
        /// Applies the feat to the character
        /// </summary>
        /// <param name="character">The character to apply the feat to</param>
        public override void ApplyFeat(CharacterInfo character) {
            if (character == null)
                return;


        }
    }
}
