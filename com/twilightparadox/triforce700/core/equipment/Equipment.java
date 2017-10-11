package com.twilightparadox.triforce700.core.equipment;

import java.util.List;
import java.util.Vector;

import com.twilightparadox.triforce700.core.Item;

public class Equipment implements Item {

    public String name;
    public String description;
    public int quantity;
    public double cost; //Value in dollars
    public double weight; //Weight per item in pounds
    public int techLevel; //Technology level as described in the Basic Set
    public int legalityClass;
    public String reference; //Book and page this entity was found in
    public List<String> categories; //Sort categories
    public List<MeleeWeapon> meleeWeapons;
    public List<RangedWeapon> rangedWeapons;
    //public List<Prerequisite> Prerequisites { get; set; } //Requirements to use this equipment
    //public List<Feature> Features { get; set; } //Equipment features and bonuses
    
    public final static Vector<String> COLUMN_NAMES = new Vector<String>();
    static {
    	COLUMN_NAMES.add("Name");
    	COLUMN_NAMES.add("Quantity");
		COLUMN_NAMES.add("Cost");
		COLUMN_NAMES.add("Weight");
		COLUMN_NAMES.add("Tech Level");
		COLUMN_NAMES.add("Legality Class");
		COLUMN_NAMES.add("Reference");
		COLUMN_NAMES.add("Categories");
	};
    public final static int COLUNN_COUNT = 8;

    public Equipment () {
        name = "";
        description = "";
        quantity = 1;
        cost = 0;
        weight = 1;
        techLevel = 0;
        legalityClass = 4;
        reference = "";
        categories = new Vector<String>();
        meleeWeapons = new Vector<MeleeWeapon>();
        rangedWeapons = new Vector<RangedWeapon>();
        //prerequisites = new List<Prerequisite>();
        //features = new List<Feature>();
    }

    public void parseCategories(String categoryList) {
        categories.clear();

        String[] result = categoryList.split(", ");

        for (String cat : result) {
            categories.add(cat);
        }
    }

    public String getCategoryDisplay() {
        String display = "";

        if (categories.size() > 0) {
            display += categories.get(0);

            for(int i = 1; i < categories.size(); i++) {
                display += ", " + categories.get(i);
            }

        }

        return display;
    }
    
    public Vector<Object> getColumnData() {
    	Vector<Object> columns = new Vector<Object>();
    	
    	columns.add(name);
    	columns.add(quantity);
    	columns.add(cost);
    	columns.add(weight);
    	columns.add(techLevel);
    	columns.add(legalityClass);
    	columns.add(reference);
    	columns.add(getCategoryDisplay());
    	
    	return columns;
    }
}
