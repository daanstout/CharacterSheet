using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Character {
    public struct AbilityScore : IEquatable<AbilityScore> {
        private readonly int[] scores;

        public int[] Scores() => scores.Clone() as int[];

        public AbilityScore(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) {
            scores = new int[] { strength, dexterity, constitution, intelligence, wisdom, charisma };
        }

        public void Add(AbilityScore other) {
            for (int i = 0; i < 6; i++)
                scores[i] += other.scores[i];
        }

        #region Visual Studio Generated
        public override bool Equals(object obj) => obj is AbilityScore score && Equals(score);
        public bool Equals(AbilityScore other) => EqualityComparer<int[]>.Default.Equals(scores, other.scores);
        public override int GetHashCode() => -642832670 + EqualityComparer<int[]>.Default.GetHashCode(scores);

        public static bool operator ==(AbilityScore left, AbilityScore right) {
            return left.Equals(right);
        }

        public static bool operator !=(AbilityScore left, AbilityScore right) {
            return !(left == right);
        }
        #endregion
    }
}
