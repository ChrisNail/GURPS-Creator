using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Equipment {

    class MeleeWeapon {

        public string Damage { get; set; }
        public string ArmorDivisor { get; set; }
        public DamageType Type { get; set; }
        public string Reach { get; set; }
        public string Parry { get; set; }
        public int Strength { get; set; }
        public bool TwoHanded { get; set; }

        public MeleeWeapon() {
            Damage = "";
            ArmorDivisor = "";
            Type = DamageType.Crushing;
            Reach = "";
            Parry = "";
            Strength = 10;
            TwoHanded = false;
        }

        public MeleeWeapon(XmlNode node) {
            Damage = node.SelectSingleNode("Damage").InnerText;
            Type = DamageType.DamageTypes[node.SelectSingleNode("DamageType").InnerText];
            Reach = node.SelectSingleNode("Reach").InnerText;
            Parry = node.SelectSingleNode("Parry").InnerText;
            Strength = int.Parse(node.SelectSingleNode("Strength").InnerText);
            TwoHanded = bool.Parse(node.SelectSingleNode("TwoHanded").InnerText);
        }
    }
}
