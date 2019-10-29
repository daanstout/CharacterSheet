using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Character.Classes {
    /// <summary>
    /// A Class a character can use
    /// </summary>
    public interface IClass {
        /// <summary>
        /// The character's level in the class
        /// </summary>
        int level { get; }
    }
}
