using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Equipment {

    class RangedWeapon {

        public string Damage { get; set; }
        public double ArmorDivisor { get; set; }
        public DamageType Type { get; set; }
        public bool Explosion { get; set; }
        public bool Incendiary { get; set; }
        public bool Surge { get; set; }
        public int Accuracy { get; set; }
        public bool Muscle { get; set; }
        public double HalfRange { get; set; }
        public double MaxRange { get; set; }
        public double MagazineWeight { get; set; }
        public int RateOfFire { get; set; }
        public bool FullAuto { get; set; }
        public bool Jet { get; set; }
        public int Projectiles { get; set; }
        public int Shots { get; set; }
        public bool Thrown { get; set; }
        public int Reload { get; set; }
        public bool PerShot { get; set; }
        public int Strength { get; set; }
        public bool TwoHanded { get; set; }
        public bool MusketRest { get; set; }
        public bool Bipod { get; set; }
        public bool Mounted { get; set; }
        public int Bulk { get; set; }
        public int Recoil { get; set; }

        public RangedWeapon() {
            Damage = "";
            ArmorDivisor = 1.0;
            Type = DamageType.Crushing;
            Explosion = false;
            Incendiary = false;
            Surge = false;
            Accuracy = 0;
            Muscle = false;
            HalfRange = 10.0;
            MaxRange = 100.0;
            MagazineWeight = 1.0;
            RateOfFire = 1;
            FullAuto = false;
            Jet = false;
            Projectiles = 1;
            Shots = 1;
            Thrown = false;
            Reload = 1;
            PerShot = false;
            Strength = 10;
            TwoHanded = false;
            MusketRest = false;
            Bipod = false;
            Mounted = false;
            Bulk = 0;
            Recoil = 1;
        }

        public RangedWeapon(XmlNode node) {
            Damage = node.SelectSingleNode("Damage").InnerText;
            ArmorDivisor = double.Parse(node.SelectSingleNode("ArmorDivisor").InnerText);
            Type = DamageType.DamageTypes[node.SelectSingleNode("DamageType").InnerText];
            Explosion = bool.Parse(node.SelectSingleNode("Explosion").InnerText);
            Incendiary = bool.Parse(node.SelectSingleNode("Incendiary").InnerText);
            Surge = bool.Parse(node.SelectSingleNode("Surge").InnerText);
            Accuracy = int.Parse(node.SelectSingleNode("Accuracy").InnerText);
            Muscle = bool.Parse(node.SelectSingleNode("Muscle").InnerText);
            HalfRange = int.Parse(node.SelectSingleNode("HalfRange").InnerText);
            MaxRange = int.Parse(node.SelectSingleNode("MaxRange").InnerText);
            MagazineWeight = double.Parse(node.SelectSingleNode("MagazineWeight").InnerText);
            RateOfFire = int.Parse(node.SelectSingleNode("RateOfFire").InnerText);
            FullAuto = bool.Parse(node.SelectSingleNode("FullAuto").InnerText);
            Jet = bool.Parse(node.SelectSingleNode("Jet").InnerText);
            Projectiles = int.Parse(node.SelectSingleNode("Projectiles").InnerText);
            Shots = int.Parse(node.SelectSingleNode("Shots").InnerText);
            Thrown = bool.Parse(node.SelectSingleNode("Thrown").InnerText);
            Reload = int.Parse(node.SelectSingleNode("Reload").InnerText);
            PerShot = bool.Parse(node.SelectSingleNode("PerShot").InnerText);
            Strength = int.Parse(node.SelectSingleNode("Strength").InnerText);
            TwoHanded = bool.Parse(node.SelectSingleNode("TwoHanded").InnerText);
            MusketRest = bool.Parse(node.SelectSingleNode("MusketRest").InnerText);
            Bipod = bool.Parse(node.SelectSingleNode("Bipod").InnerText);
            Mounted = bool.Parse(node.SelectSingleNode("Mounted").InnerText);
            Bulk = int.Parse(node.SelectSingleNode("Bulk").InnerText);
            Recoil = int.Parse(node.SelectSingleNode("Recoil").InnerText);
        }

        public override string ToString() {
            string out = "";

            out += Damage;
            if (ArmorDivisor != 1.0) { out += "(" + ArmorDivisor + ")"; }
            out += DamageType.Code;
            if (Explosion) { out += " ex"; }
            if (Incendiary) { out += " inc"; }
            if (Surge) { out += " sur"; }
            out += ", ";
            out += "Acc " + Accuracy;
            out += ", ";
            out += "1/2D ";
            if (Muscle) { out += "x"; }
            out += HalfRange
            out += " Max "
            if (Muscle) { out += "x"; }
            out += MaxRange;
            out += ", ";
            out += MagazineWeight + "lbs.";
            out += ", ";
            out += "RoF ";
            if (!Jet) {
                out += RateOfFire;
                if (FullAuto) { out += "!"; }
                if (Projectiles > 1) { out += "x" + Projectiles; }
            } else { out += "Jet"; }
            out += ", ";
            out += "Shots ";
            if (!Thrown) { out += Shots; }
            else { out += "T"; }
            out += "(" + Reload;
            if (PerShot) { out += "i"; }
            out += ")";
            out += ", ";
            out += "ST " + Strength;
            if (TwoHanded) { out += "H"; }
            if (MusketRest) { out += "R"; }
            if (Bipod) { out += "B"; }
            if (Mounted) { out += "M"; }
            out += ", ";
            out += "Bulk " + Bulk;
            out += ", ";
            out += "Rcl " + Recoil;

            return out;
        }
    }
}
