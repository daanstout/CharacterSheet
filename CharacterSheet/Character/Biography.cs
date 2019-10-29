using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Character {
    /// <summary>
    /// A character's biography
    /// <para>This contains all roleplaying aspects of a character</para>
    /// </summary>
    public class Biography {
        /// <summary>
        /// The character's alignment
        /// </summary>
        public Alignment alignment { get; set; }

        /// <summary>
        /// The age of the character
        /// </summary>
        public int age { get; set; }
        
        /// <summary>
        /// The height of the character
        /// </summary>
        public float size { get; set; }
    }
}
