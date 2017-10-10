using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Equipment {

    class MeleeWeapon {

        public string Damage { get; set; }
        public double ArmorDivisor { get; set; }
        public DamageType Type { get; set; }
        public string Reach { get; set; }
        public int Parry { get; set; }
        public bool NoParry { get; set; }
        public bool Fencing { get; set; }
        public bool Unbalanced { get; set; }
        public int Strength { get; set; }
        public bool TwoHanded { get; set; }

        public MeleeWeapon() {
            Damage = "";
            ArmorDivisor = 1.0;
            Type = DamageType.Crushing;
            Reach = "";
            Parry = 0;
            NoParry = false;
            Fencing = false;
            Unbalanced = false;
            Strength = 10;
            TwoHanded = false;
        }

        public MeleeWeapon(XmlNode node) {
            Damage = node.SelectSingleNode("Damage").InnerText;
            ArmorDivisor = double.Parse(node.SelectSingleNode("ArmorDivisor").InnerText);
            Type = DamageType.DamageTypes[node.SelectSingleNode("DamageType").InnerText];
            Reach = node.SelectSingleNode("Reach").InnerText;
            Parry = int.Parse(node.SelectSingleNode("Parry").InnerText);
            NoParry = bool.Parse(node.SelectSingleNode("NoParry").InnerText);
            Fencing = bool.Parse(node.SelectSingleNode("Fencing").InnerText);
            Unbalanced = bool.Parse(node.SelectSingleNode("Unbalanced").InnerText);
            Strength = int.Parse(node.SelectSingleNode("Strength").InnerText);
            TwoHanded = bool.Parse(node.SelectSingleNode("TwoHanded").InnerText);
        }

        public override string ToString() {
            string out = "";

            out += Damage;
            if (ArmorDivisor != 1.0) { out += "(" + ArmorDivisor + ")"; }
            out += DamageType.Code;
            out += ", ";
            out += "Reach " + Reach;
            out += ", ";
            if (!NoParry) {
                out += "Parry " + Parry;
                if (Fencing) { out += "F"; } 
                if (Unbalanced) { out += "U"; }
            } else { out += "No Parry"; }
            out += ", ";
            out += "ST " + Strength;
            if (TwoHanded) { out += "H"; }

            return out;
        }
    }
}
