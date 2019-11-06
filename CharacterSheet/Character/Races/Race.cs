using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSheet.Character.Feats;
using DaanLib;

namespace CharacterSheet.Character.Races {
    /// <summary>
    /// The Race a character can be
    /// </summary>
    public abstract class ARace {
        /// <summary>
        /// The name of the race
        /// </summary>
        public abstract string name { get; }

        /// <summary>
        /// The increase in ability scores this race provides
        /// </summary>
        /// <returns>The ability score values to increase with</returns>
        public abstract AbilityScore AbilityScoreIncrease();
        /// <summary>
        /// The flavor for the ability score the race gives
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public abstract string AbilityScoreIncreaseFlavor();

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
        /// The flavor for the life span of the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public abstract string AgeLifeSpanFlavor();

        /// <summary>
        /// Gets a list of alignments that most people from that race follow
        /// </summary>
        /// <returns>A list of alignments</returns>
        public abstract List<Alignment> Alignments();
        /// <summary>
        /// The flavor for the typical alignments of the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public abstract string AlignmentsFlavor();

        /// <summary>
        /// The size of the race
        /// </summary>
        /// <returns>The size of the race</returns>
        public abstract Sizes Size();
        /// <summary>
        /// The size range of the class
        /// </summary>
        /// <returns>A pair with two floats, the minimum and maximum size a race typically is</returns>
        public abstract Pair<float, float> SizeRange();
        /// <summary>
        /// The flavor for the typical size of the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public abstract string SizeFlavor();

        /// <summary>
        /// The walking speed of the race
        /// </summary>
        /// <returns>The walking speed in feet per 6 seconds</returns>
        public abstract int Speed();
        /// <summary>
        /// The flavor for the speed entry of the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public abstract string SpeedFlavor();

        /// <summary>
        /// A list of languages that this race can speak
        /// </summary>
        /// <returns>A list of languages</returns>
        public abstract List<Languages> Languages();
        /// <summary>
        /// The flavor for the languages the race speaks
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public abstract string LanguagesFlavor();

        /// <summary>
        /// The list of subraces for a given race
        /// </summary>
        /// <returns>A list of subraces</returns>
        public abstract List<ASubrace> Subraces();
        /// <summary>
        /// The flavor for the subraces that exist for the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public abstract string SubracesFlavor();

        /// <summary>
        /// A list of feats that this race contains
        /// </summary>
        /// <returns>The list of feats this race contains</returns>
        public abstract List<AFeat> RaceFeats();

        /// <summary>
        /// Checks whether a character is of a certain race
        /// </summary>
        /// <param name="character">The character to check for</param>
        /// <returns>True if the character's race matches this race</returns>
        public virtual bool CharacterIsRace(CharacterInfo character) => character == null ? false : character.race.name == name;
    }
}
