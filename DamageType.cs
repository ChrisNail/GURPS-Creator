using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GURPS_Creator {
    class DamageType {

        private string name;
        private string code;

        public DamageType(string name, string code) {
            this.name = name;
            this.code = code;
        }

        public string Name {
            get { return name; }
        }

        public string Code {
            get { return code; }
        }

        public static DamageType Affliction     = new DamageType("Affliction",      "aff");
        public static DamageType Burning        = new DamageType("Burning",         "burn");
        public static DamageType Corrosion      = new DamageType("Corrosion",       "cor");
        public static DamageType Crushing       = new DamageType("Crushing",        "cr");
        public static DamageType Cutting        = new DamageType("Cutting",         "cut");
        public static DamageType Fatigue        = new DamageType("Fatigue",         "fat");
        public static DamageType Impaling       = new DamageType("Impaling",        "imp");
        public static DamageType SmallPiercing  = new DamageType("Small Piercing",  "pi-");
        public static DamageType Piercing       = new DamageType("Piercing",        "pi");
        public static DamageType LargePiercing  = new DamageType("Large Piercing",  "pi+");
        public static DamageType HugePiercing   = new DamageType("Huge Piercing",   "pi++");
        public static DamageType Special        = new DamageType("Special",         "spec.");
        public static DamageType Toxic          = new DamageType("Toxic",           "tox");
    }
}
