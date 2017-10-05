using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GURPS_Creator {
    class Equipment {

        private string name;
        private string description;
        private int quantity;
        private double cost; //Value in dollars ($)
        private double weight; //Weight per item in pounds (lb)
        private int techLevel; //Tech level as described in the Basic Set
        private int legalityClass;
        private string reference; //Book and page this entity was found in
        private List<string> categories; //Sort categories
        private List<MeleeWeapon> meleeWeapons;
        private List<RangedWeapon> rangedWeapons;
        private List<Prerequisite> prerequisites; //Requirements to use this equipment
        private List<Feature> features; //Equipment features and bonuses

        public Equipment () {
            name = "";
            description = "";
            quantity = 1;
            cost = 0;
            weight = 1;
            techLevel = 0;
            legalityClass = 4;
            reference = "";
            categories = new List<string>();
            meleeWeapons = new List<MeleeWeapon>();
            rangedWeapons = new List<RangedWeapon>();
            prerequisites = new List<Prerequisite>();
            features = new List<Feature>();
        }

        public Equipment(XmlNode node) {
            name = node.SelectSingleNode("name").InnerText;
            description = node.SelectSingleNode("description").InnerText;
            quantity = int.Parse(node.SelectSingleNode("quantity").InnerText);
            cost = double.Parse(node.SelectSingleNode("cost").InnerText);
            weight = double.Parse(node.SelectSingleNode("weight").InnerText);
            techLevel = int.Parse(node.SelectSingleNode("tech_level").InnerText);
            legalityClass = int.Parse(node.SelectSingleNode("legality_class").InnerText);
            reference = node.SelectSingleNode("reference").InnerText;
            parseCategories(node);
            parseMeleeWeapons(node);
        }

        public void parseCategories(XmlNode node) {
            XmlNodeList nodes = node.SelectSingleNode("categories").SelectNodes("category");

            foreach(XmlNode category in nodes) {
                categories.Add(category.InnerText);
            }
        }

        public void parseMeleeWeapons(XmlNode node) {
            XmlNodeList nodes = node.SelectNodes("melee_weapon");

            foreach(XmlNode weapon in nodes) {
                categories.Add(new MeleeWeapon(weapon));
            }
        }

        public void parseRangedWeapons(XmlNode node) {
            XmlNodeList nodes = node.SelectNodes("ranged_weapon");

            foreach(XmlNode weapon in nodes) {
                categories.Add(new RangedWeapon(weapon));
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

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }

        public int Quantity {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Cost {
            get { return cost; }
            set { cost = value; }
        }

        public double Weight {
            get { return weight; }
            set { weight = value; }
        }

        public int TechLevel {
            get { return techLevel; }
            set { techLevel = value; }
        }

        public int LegalityClass {
            get { return legalityClass; }
            set { legalityClass = value; }
        }

        public string Reference {
            get { return reference; }
            set { reference = value; }
        }

        public List<string> Categories {
            get { return categories; }
            set { categories = value; }
        }

        public List<MeleeWeapon> MeleeWeapons {
            get { return meleeWeapons; }
            set { meleeWeapons = value; }
        }

        public List<RangedWeapon> RangedWeapons {
            get { return rangedWeapons; }
            set { rangedWeapons = value; }
        }

        public List<Feature> Features {
            get { return features; }
            set { features = value; }
        }

        public string getCategoryDisplay() {
            string display = "";

            if (categories.Count > 0) {
                display += categories[0];

                for(int i = 1; i < categories.Count; i++) {
                    display += ", " + categories[i];
                }

            }

            return display;
        }
    }
}
