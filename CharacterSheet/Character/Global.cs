using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

[assembly: NeutralResourcesLanguage("en-US")]
namespace CharacterSheet.Character {
    /// <summary>
    /// Global variables for the project
    /// </summary>
    public static class GlobalVariables {
        public static ResourceManager stringManager { get; } = new ResourceManager("en-US", Assembly.GetExecutingAssembly());
    }
}
