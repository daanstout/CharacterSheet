using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Character {
    /// <summary>
    /// The sizes that are possible for characters
    /// </summary>
    public class Sizes {
        /// <summary>
        /// The name of the size
        /// </summary>
        public string categoryName { get; }
        /// <summary>
        /// The maximum height that size can be
        /// </summary>
        public float maxHeight { get; }
        /// <summary>
        /// The maximum weight that size can be
        /// </summary>
        public float maxWeight { get; }
        /// <summary>
        /// The space a character of that size takes up in square feet
        /// </summary>
        public float space { get; }
        /// <summary>
        /// The carrying capacity modifier of that size
        /// </summary>
        public  float carryingCapacityModifier { get; }

        /// <summary>
        /// Creates a new Size
        /// </summary>
        /// <param name="categoryName">The name of the size category</param>
        /// <param name="maxHeight">The maximum height of a creature of that size</param>
        /// <param name="maxWeight">The maximum weight of a creature of that size</param>
        /// <param name="space">The space that creature occupies, in square feet</param>
        /// <param name="carryingCapacityModifier">The modifier to the carrying capacity of a creature of that size</param>
        private Sizes(string categoryName, float maxHeight, float maxWeight, float space, float carryingCapacityModifier) {
            this.categoryName = categoryName ?? throw new ArgumentNullException(nameof(categoryName));
            this.maxHeight = maxHeight;
            this.maxWeight = maxWeight;
            this.space = space;
            this.carryingCapacityModifier = carryingCapacityModifier;
        }

        /// <summary>
        /// Gets the size based of the height of a creature
        /// </summary>
        /// <param name="height">The height of a creature in feet</param>
        /// <returns>The size corresponding to that creature</returns>
        public static Sizes GetSizeFromHeight(float height) {
            if (height <= 0)
                //throw new ArgumentException(message: heightErrorMessage);
                throw new ArgumentException("Height cannot be equal to or less than zero");

            // Go through each size, from smaller to larger, until you find a size who's max size is larger than the give size
            foreach (Sizes size in sizes)
                if (size.maxHeight > height)
                    return size;

            // We always default to the Colossal size, though we shouldn't realistically get here
            return Colossal;
        }

        /// <summary>
        /// A list of all sizes, ranging from smallest to largest
        /// </summary>
        private static List<Sizes> sizes { get; } = new List<Sizes>() {
            Fine,
            Diminutive,
            Tiny,
            Small,
            Medium,
            Large,
            Huge,
            Gargantuan,
            Colossal
        };

        /// <summary>
        /// A Fine creature, about the size of a hand
        /// </summary>
        public static readonly Sizes Fine = new Sizes("Fine", 0.5f, 0.125f, 0.5f, 0.125f);
        /// <summary>
        /// A Diminutive creature, about the size of half an arm
        /// </summary>
        public static readonly Sizes Diminutive = new Sizes("Diminutive", 1.0f, 1.0f, 1.0f, 0.25f);
        /// <summary>
        /// A Tiny creature, about the size of a leg
        /// </summary>
        public static readonly Sizes Tiny = new Sizes("Tiny", 2.0f, 8.0f, 2.5f, 0.5f);
        /// <summary>
        /// A Small creature, creatures that reaches to around the belly of the average human
        /// </summary>
        public static readonly Sizes Small = new Sizes("Small", 4.0f, 60.0f, 5.0f, 0.75f);
        /// <summary>
        /// A medium creature, most humanoid creatures fall into this category, including humans
        /// </summary>
        public static readonly Sizes Medium = new Sizes("Medium", 8.0f, 500.0f, 5.0f, 1.0f);
        /// <summary>
        /// A Large creature, like horses or centaurs. Typically quite a lot larger than humans
        /// </summary>
        public static readonly Sizes Large = new Sizes("Large", 16.0f, 2000.0f, 10.0f, 2.0f);
        /// <summary>
        /// A Huge creature, Can range from filling a room easily, to about as large as a 2 or 3 story house
        /// </summary>
        public static readonly Sizes Huge = new Sizes("Huge", 32.0f, 16000.0f, 15.0f, 4.0f);
        /// <summary>
        /// A Gargantuan creature, these are about as tall or long as smaller storage houses
        /// </summary>
        public static readonly Sizes Gargantuan = new Sizes("Gargantuan", 64.0f, 125000.0f, 20.0f, 8.0f);
        /// <summary>
        /// A Colossal creature, this is the largest category. Anything that is larger that Gargantuan is in here
        /// </summary>
        public static readonly Sizes Colossal = new Sizes("Colossal", float.MaxValue, float.MaxValue, 30.0f, 16.0f);
    }
}
