using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSheet.Character.Feats;
using DaanLib;

namespace CharacterSheet.Character.Races {
    public class Dwarf : ARace {
        /// <summary>
        /// The instance of this race
        /// </summary>
        public static Dwarf instance { get; } = new Dwarf();

        /// <summary>
        /// A private constructor so no new Dwarf instances can be created
        /// </summary>
        private Dwarf() { }

        /// <summary>
        /// The name of the class
        /// </summary>
        public override string name => "Dwarf";

        /// <summary>
        /// The increase in ability scores this race provides
        /// </summary>
        /// <returns>The ability score values to increase with</returns>
        public override AbilityScore AbilityScoreIncrease() {
            AbilityScore score = new AbilityScore(0, 0, 2, 0, 0, 0);

            return score;
        }
        /// <summary>
        /// The flavor for the ability score the race gives
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public override string AbilityScoreIncreaseFlavor() => "Your Constitution score increases by 2.";

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
        public override Pair<int, int> AgeLifespan() {
            Pair<int, int> age = new Pair<int, int>(50, 350);

            return age;
        }
        /// <summary>
        /// The flavor for the life span of the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public override string AgeLifeSpanFlavor() {
            return "Dwarves mature at the same rate as humans, but they're considered young until they reach the age of 50. " +
                "On average, they live about 350 years.";
        }

        /// <summary>
        /// Gets a list of alignments that most people from that race follow
        /// </summary>
        /// <returns>A list of alignments</returns>
        public override List<Alignment> Alignments() {
            List<Alignment> alignments = new List<Alignment>() {
                new Alignment(ChaosLaw.Lawful, GoodBad.Good)
            };

            return alignments;
        }
        /// <summary>
        /// The flavor for the typical alignments of the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public override string AlignmentsFlavor() {
            return "Most dwarves are lawful, believing firmly in the benefits of a well-ordered society. " +
                "They tend toward good as well, with a strong sense of fair play and a belief that everyone deserves to share in the benefits of a just order.";
        }

        /// <summary>
        /// A list of languages that this race can speak
        /// </summary>
        /// <returns>A list of languages</returns>
        public override List<Languages> Languages() {
            List<Languages> languages = new List<Languages>() {
                Character.Languages.Dwarvish,
                Character.Languages.Common
            };

            return languages;
        }
        /// <summary>
        /// The flavor for the languages the race speaks
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public override string LanguagesFlavor() {
            return "You can speak, read, and write Common and Dwarvish. " +
                "Dwarvish is full of hard consonants and guttural sounds, and those characteristics spill over into whatever other language a dwarf might speak";
        }

        /// <summary>
        /// The size of the race
        /// </summary>
        /// <returns>The size of the race</returns>
        public override Sizes Size() => Sizes.Medium;
        /// <summary>
        /// The size range of the class
        /// </summary>
        /// <returns>A pair with two floats, the minimum and maximum size a race typically is</returns>
        public override Pair<float, float> SizeRange() => new Pair<float, float>(4.0f, 5.0f);
        /// <summary>
        /// The flavor for the typical size of the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public override string SizeFlavor() => "Dwarves stand between 4 and 5 feet tall and average about 150 pounds. Your size is Medium.";

        /// <summary>
        /// The walking speed of the race
        /// </summary>
        /// <returns>The walking speed in feet per 6 seconds</returns>
        public override int Speed() => 25;
        /// <summary>
        /// The flavor for the speed entry of the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public override string SpeedFlavor() => "Your base walking speed is 25 feet. Your speed is not reduced byt wearing heavy armor";

        /// <summary>
        /// The list of subraces for a given race
        /// </summary>
        /// <returns>A list of subraces</returns>
        public override List<ASubrace> Subraces() {
            List<ASubrace> subraces = new List<ASubrace>() {

            };

            return subraces;
        }
        /// <summary>
        /// The flavor for the subraces that exist for the race
        /// </summary>
        /// <returns>A string containing the flavor for this entry</returns>
        public override string SubracesFlavor() => "Two main subraces of dwarves populate the worlds of D&D: hill dwarves and mountain dwarves. Choose one of these subraces.";
        /// <summary>
        /// A list of feats that this race contains
        /// </summary>
        /// <returns>The list of feats this race contains</returns>
        public override List<AFeat> RaceFeats() {
            List<AFeat> feats = new List<AFeat>() {

            };

            return feats;
        }
    }
}
