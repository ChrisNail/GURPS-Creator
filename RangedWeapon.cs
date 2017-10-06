using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GURPS_Creator {

    class RangedWeapon {

        public string Damage { get; set; }
        public DamageType Type { get; set; }
        public bool Explosion { get; set; }
        public int Accuracy { get; set; }
        public int HalfRange { get; set; }
        public int MaxRange { get; set; }
        public double MagazineWeight { get; set; }
        public int RateOfFire { get; set; }
        public int Shots { get; set; }
        public int Reload { get; set; }
        public bool PerShot { get; set; }
        public int Strength { get; set; }
        public bool TwoHanded { get; set; }
        public int Bulk { get; set; }
        public int Recoil { get; set; }

        public RangedWeapon() {
            Damage = "";
            Type = DamageType.Crushing;
            Explosion = false;
            Accuracy = 0;
            HalfRange = 10;
            MaxRange = 100;
            MagazineWeight = 1.0;
            RateOfFire = 1;
            Shots = 1;
            Reload = 1;
            PerShot = false;
            Strength = 10;
            TwoHanded = false;
            Bulk = 0;
            Recoil = 1;
        }

        public RangedWeapon(XmlNode node) {
            Damage = node.SelectSingleNode("Damage").InnerText;
            Type = DamageType.DamageTypes[node.SelectSingleNode("DamageType").InnerText];
            Explosion = node.SelectSingleNode("Explosion").InnerText == "true" ? true : false;
            Accuracy = int.Parse(node.SelectSingleNode("Accuracy").InnerText);
            HalfRange = int.Parse(node.SelectSingleNode("HalfRange").InnerText);
            MaxRange = int.Parse(node.SelectSingleNode("MaxRange").InnerText);
            MagazineWeight = double.Parse(node.SelectSingleNode("MagazineWeight").InnerText);
            RateOfFire = int.Parse(node.SelectSingleNode("RateOfFire").InnerText);
            Shots = int.Parse(node.SelectSingleNode("Shots").InnerText);
            Reload = int.Parse(node.SelectSingleNode("Reload").InnerText);
            PerShot = bool.Parse(node.SelectSingleNode("PerShot").InnerText);
            Strength = int.Parse(node.SelectSingleNode("Strength").InnerText);
            TwoHanded = bool.Parse(node.SelectSingleNode("TwoHanded").InnerText);
            Bulk = int.Parse(node.SelectSingleNode("Bulk").InnerText);
            Recoil = int.Parse(node.SelectSingleNode("Recoil").InnerText);
        }
    }
}
