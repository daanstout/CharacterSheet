using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaanLib;

namespace CharacterSheet.Character.Races {
    /// <summary>
    /// The Race a character can be
    /// </summary>
    public abstract class ARace {
        /// <summary>
        /// The increase in ability scores this race provides
        /// </summary>
        /// <returns>The ability score values to increase with</returns>
        public abstract AbilityScore AbilityScoreIncrease();

        /// <summary>
        /// Gets the lifespan of the race, as well as when the race is considered an adult
        /// <para>The first value is the age for when the race is considered adult</para>
        /// <para>The second value is the expected life span of the race</para>
        /// </summary>
        /// <returns>
        /// A pair of ages
        /// <para>The first value is the age for when the race is considered adult</para>
        /// <para>The second value is the expected life span of the race</para>
        /// </returns>
        public abstract Pair<int, int> AgeLifespan();

        /// <summary>
        /// Gets a list of alignments that most people from that race follow
        /// </summary>
        /// <returns>A list of alignments</returns>
        public abstract List<Alignment> Alignments();
    }
}
