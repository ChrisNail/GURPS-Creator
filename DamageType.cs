using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GURPS_Creator {

    class DamageType {

        public string Name { get; }
        public string Code { get; }
        public double PenetratingMultiplier { get; }

        public DamageType(string name, string code, double multiplier) {
            this.Name = name;
            this.Code = code;
            this.PenetratingMultiplier = multiplier;
        }

        public static DamageType Affliction = new DamageType("Affliction", "aff", 1.0);
        public static DamageType Burning = new DamageType("Burning", "burn", 1.0);
        public static DamageType Corrosion = new DamageType("Corrosion", "cor", 1.0);
        public static DamageType Crushing = new DamageType("Crushing", "cr", 1.0);
        public static DamageType Cutting = new DamageType("Cutting", "cut", 1.5);
        public static DamageType Fatigue = new DamageType("Fatigue", "fat", 1.0);
        public static DamageType Impaling = new DamageType("Impaling", "imp", 2.0);
        public static DamageType SmallPiercing = new DamageType("Small Piercing", "pi-", 0.5);
        public static DamageType Piercing = new DamageType("Piercing", "pi", 1.0);
        public static DamageType LargePiercing = new DamageType("Large Piercing", "pi+", 1.5);
        public static DamageType HugePiercing = new DamageType("Huge Piercing", "pi++", 2.0);
        public static DamageType Special = new DamageType("Special", "spec.", 1.0);
        public static DamageType Toxic = new DamageType("Toxic", "tox", 1.0);

        public static Dictionary<String, DamageType> DamageTypes = new Dictionary<String, DamageType>() {
            { Affliction.Name, Affliction },
            { Burning.Name, Burning },
            { Corrosion.Name, Corrosion },
            { Crushing.Name, Crushing },
            { Cutting.Name, Cutting },
            { Fatigue.Name, Fatigue },
            { Impaling.Name, Impaling },
            { SmallPiercing.Name, SmallPiercing },
            { Piercing.Name, Piercing },
            { LargePiercing.Name, LargePiercing },
            { HugePiercing.Name, HugePiercing },
            { Special.Name, Special },
            { Toxic.Name, Toxic }
        };
    }
}
