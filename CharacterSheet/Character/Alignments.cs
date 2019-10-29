using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Character {
    public enum ChaosLaw {
        Lawful = 0,
        Neutral,
        Chaotic
    }

    public enum GoodBad {
        Good = 0,
        Neutral,
        Bad
    }

    public struct Alignment : IEquatable<Alignment> {
        public ChaosLaw chaosLawAlignment { get; set; }
        public GoodBad goodBadAlignment { get; set; }

        public Alignment(ChaosLaw chaosLaw, GoodBad goodBad) {
            chaosLawAlignment = chaosLaw;
            goodBadAlignment = goodBad;
        }

        public override string ToString() {
            if (chaosLawAlignment == ChaosLaw.Neutral && goodBadAlignment == GoodBad.Neutral)
                return "True Neutral";
            else
                return chaosLawAlignment.ToString() + " " + goodBadAlignment.ToString();
        }

        #region Visual Studio Generated
        public override bool Equals(object obj) => obj is Alignment alignment && Equals(alignment);
        public bool Equals(Alignment other) => chaosLawAlignment == other.chaosLawAlignment && goodBadAlignment == other.goodBadAlignment;

        public override int GetHashCode() {
            var hashCode = 2079033530;
            hashCode = hashCode * -1521134295 + chaosLawAlignment.GetHashCode();
            hashCode = hashCode * -1521134295 + goodBadAlignment.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Alignment left, Alignment right) {
            return left.Equals(right);
        }

        public static bool operator !=(Alignment left, Alignment right) {
            return !(left == right);
        }
        #endregion
    }
}
