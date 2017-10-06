using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Equipment {

    class Equipment {

        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; } //Value in dollars ($)
        public double Weight { get; set; } //Weight per item in pounds (lb)
        public int TechLevel { get; set; } //Tech level as described in the Basic Set
        public int LegalityClass { get; set; }
        public string Reference { get; set; } //Book and page this entity was found in
        public List<string> Categories { get; set; } //Sort categories
        public List<MeleeWeapon> MeleeWeapons { get; set; }
        public List<RangedWeapon> RangedWeapons { get; set; }
        //public List<Prerequisite> Prerequisites { get; set; } //Requirements to use this equipment
        //public List<Feature> Features { get; set; } //Equipment features and bonuses

        public Equipment () {
            Name = "";
            Description = "";
            Quantity = 1;
            Cost = 0;
            Weight = 1;
            TechLevel = 0;
            LegalityClass = 4;
            Reference = "";
            Categories = new List<string>();
            MeleeWeapons = new List<MeleeWeapon>();
            RangedWeapons = new List<RangedWeapon>();
            //prerequisites = new List<Prerequisite>();
            //features = new List<Feature>();
        }

        public Equipment(XmlNode node) {
            Name = node.SelectSingleNode("name").InnerText;
            Description = node.SelectSingleNode("description").InnerText;
            Quantity = int.Parse(node.SelectSingleNode("quantity").InnerText);
            Cost = double.Parse(node.SelectSingleNode("cost").InnerText);
            Weight = double.Parse(node.SelectSingleNode("weight").InnerText);
            TechLevel = int.Parse(node.SelectSingleNode("tech_level").InnerText);
            LegalityClass = int.Parse(node.SelectSingleNode("legality_class").InnerText);
            Reference = node.SelectSingleNode("reference").InnerText;
            parseCategories(node);
            parseMeleeWeapons(node);
        }

        /*
        public void parseCategories(XmlNode node) {
            XmlNodeList nodes = node.SelectSingleNode("categories").SelectNodes("category");

            foreach(XmlNode category in nodes) {
                Categories.Add(category.InnerText);
            }
        }

        public void parseMeleeWeapons(XmlNode node) {
            XmlNodeList nodes = node.SelectNodes("melee_weapon");

            foreach(XmlNode weapon in nodes) {
                MeleeWeapons.Add(new MeleeWeapon(weapon));
            }
        }

        public void parseRangedWeapons(XmlNode node) {
            XmlNodeList nodes = node.SelectNodes("ranged_weapon");

            foreach(XmlNode weapon in nodes) {
                RangedWeapons.Add(new RangedWeapon(weapon));
            }
        }

        public void parsePrerequisites(XmlNode node) {
            XmlNodeList nodes = node.SelectNodes("prerequisite");

            foreach(XmlNode prerequisite in nodes) {
                categories.Add(new Prerequisite(prerequisite));
            }
        }

        public void parseFeatures(XmlNode node) {
            XmlNodeList nodes = node.SelectNodes("feature");

            foreach(XmlNode feature in nodes) {
                categories.Add(new Feature(feature));
            }
        }
        */

        public string getCategoryDisplay() {
            string display = "";

            if (Categories.Count > 0) {
                display += Categories[0];

                for(int i = 1; i < Categories.Count; i++) {
                    display += ", " + Categories[i];
                }

            }

            return display;
        }
    }
}
