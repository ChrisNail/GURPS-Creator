package com.twilightparadox.triforce700.core;

import java.util.HashMap;
import java.util.Map;

public class DamageType {

    public String name;
    public String code;
    public double penetratingMultiplier;

    public DamageType(String name, String code, double multiplier) {
        this.name = name;
        this.code = code;
        this.penetratingMultiplier = multiplier;
    }

    public String getName() { return name; }
	public void setName(String name) { this.name = name; }

	public String getCode() { return code; }
	public void setCode(String code) { this.code = code; }

	public double getPenetratingMultiplier() { return penetratingMultiplier; }
	public void setPenetratingMultiplier(double penetratingMultiplier) { this.penetratingMultiplier = penetratingMultiplier; }

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

    public static Map<String, DamageType> DamageTypes = new HashMap<String, DamageType>();
    
    static {
        DamageTypes.put(Affliction.name, Affliction);
        DamageTypes.put(Burning.name, Burning);
        DamageTypes.put(Corrosion.name, Corrosion);
        DamageTypes.put(Crushing.name, Crushing);
        DamageTypes.put(Cutting.name, Cutting);
        DamageTypes.put(Fatigue.name, Fatigue);
        DamageTypes.put(Impaling.name, Impaling);
        DamageTypes.put(SmallPiercing.name, SmallPiercing);
        DamageTypes.put(Piercing.name, Piercing);
        DamageTypes.put(LargePiercing.name, LargePiercing);
        DamageTypes.put(HugePiercing.name, HugePiercing);
        DamageTypes.put(Special.name, Special);
        DamageTypes.put(Toxic.name, Toxic);
    }
}
