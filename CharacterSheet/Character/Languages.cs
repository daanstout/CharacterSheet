using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Character {
    public enum Script {
        None = -1,
        Common,
        Dwarvish,
        Elvish,
        Infernal,
        Celestial,
        Draconic,
    }

    public struct Languages : IEquatable<Languages> {
        public bool isStandard { get; private set; }
        public string language { get; private set; }

        public Script script { get; private set; }

        private readonly string[] typicalSpeakers;

        public string[] TypicalSpeakers() => typicalSpeakers.Clone() as string[];

        private Languages(bool isStandard, string language, Script script, string[] typicalSpeakers) {
            this.isStandard = isStandard;
            this.language = language;
            this.script = script;
            this.typicalSpeakers = typicalSpeakers;
        }

        public static readonly Languages Common = new Languages(true, "Common", Script.Common, new string[] { "Humans" });
        public static readonly Languages Dwarvish = new Languages(true, "Dwarvish", Script.Dwarvish, new string[] { "Dwarves" });
        public static readonly Languages Elvish = new Languages(true, "Elvish", Script.Elvish, new string[] { "Elves" });
        public static readonly Languages Giant = new Languages(true, "Giant", Script.Dwarvish, new string[] { "Ogres", "Giants" });
        public static readonly Languages Gnomish = new Languages(true, "Gnomish", Script.Dwarvish, new string[] { "Gnomes" });
        public static readonly Languages Goblin = new Languages(true, "Goblin", Script.Dwarvish, new string[] { "Goblinoids" });
        public static readonly Languages Halfling = new Languages(true, "Halfling", Script.Common, new string[] { "Halflings" });
        public static readonly Languages Orc = new Languages(true, "Orc", Script.Dwarvish, new string[] { "Orcs" });

        public static readonly Languages Abyssal = new Languages(false, "Abyssal", Script.Infernal, new string[] { "Demons" });
        public static readonly Languages Celestial = new Languages(false, "Celestial", Script.Celestial, new string[] { "Celestials" });
        public static readonly Languages Draconic = new Languages(false, "Draconic", Script.Draconic, new string[] { "Dragons", "Dragonborn" });
        public static readonly Languages DeepSpeech = new Languages(false, "Deep Speech", Script.None, new string[] { "Mind flayers", "Beholders" });
        public static readonly Languages Infernal = new Languages(false, "Infernal", Script.Infernal, new string[] { "Devils" });
        public static readonly Languages Primordial = new Languages(false, "Primordial", Script.Dwarvish, new string[] { "Elementals" });
        public static readonly Languages Sylvan = new Languages(false, "Sylvan", Script.Elvish, new string[] { "Fey creatures" });
        public static readonly Languages Undercommon = new Languages(false, "Undercommon", Script.Elvish, new string[] { "Underdark traders" });

        #region Visual Studio Generated
        public override bool Equals(object obj) => obj is Languages languages && Equals(languages);
        public bool Equals(Languages other) => isStandard == other.isStandard && language == other.language && script == other.script && EqualityComparer<string[]>.Default.Equals(typicalSpeakers, other.typicalSpeakers);

        public override int GetHashCode() {
            var hashCode = 1235526550;
            hashCode = hashCode * -1521134295 + isStandard.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(language);
            hashCode = hashCode * -1521134295 + script.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string[]>.Default.GetHashCode(typicalSpeakers);
            return hashCode;
        }

        public static bool operator ==(Languages left, Languages right) {
            return left.Equals(right);
        }

        public static bool operator !=(Languages left, Languages right) {
            return !(left == right);
        }

        #endregion
    }
}
