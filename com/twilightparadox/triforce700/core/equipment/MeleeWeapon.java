package com.twilightparadox.triforce700.core.equipment;
import com.twilightparadox.triforce700.core.DamageType;

public class MeleeWeapon {

    public String damage;
    public double armorDivisor;
    public DamageType damageType;
    public String reach;
    public int parry;
    public boolean noParry;
    public boolean fencing;
    public boolean unbalanced;
    public int strength;
    public boolean twoHanded;

    public MeleeWeapon() {
        damage = "";
        armorDivisor = 1.0;
        damageType = DamageType.Crushing;
        reach = "";
        parry = 0;
        noParry = false;
        fencing = false;
        unbalanced = false;
        strength = 10;
        twoHanded = false;
    }

    public String toString() {
        String out = "";

        out += damage;
        if (armorDivisor != 1.0) { out += "(" + armorDivisor + ")"; }
        out += damageType.getCode();
        out += ", ";
        out += "Reach " + reach;
        out += ", ";
        if (!noParry) {
            out += "Parry " + parry;
            if (fencing) { out += "F"; } 
            if (unbalanced) { out += "U"; }
        } else { out += "No Parry"; }
        out += ", ";
        out += "ST " + strength;
        if (twoHanded) { out += "H"; }

        return out;
    }
}
