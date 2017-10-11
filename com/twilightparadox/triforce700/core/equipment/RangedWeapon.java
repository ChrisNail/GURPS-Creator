package com.twilightparadox.triforce700.core.equipment;
import com.twilightparadox.triforce700.core.DamageType;

public class RangedWeapon {

    public String damage;
    public double armorDivisor;
    public DamageType damageType;
    public boolean explosion;
    public boolean incendiary;
    public boolean surge;
    public int accuracy;
    public boolean muscle;
    public double halfRange;
    public double maxRange;
    public double magazineWeight;
    public int rateOfFire;
    public boolean fullAuto;
    public boolean jet;
    public int projectiles;
    public int shots;
    public boolean thrown;
    public int reload;
    public boolean perShot;
    public int strength;
    public boolean twoHanded;
    public boolean musketRest;
    public boolean bipod;
    public boolean mounted;
    public int bulk;
    public int recoil;

    public RangedWeapon() {
        damage = "";
        armorDivisor = 1.0;
        damageType = DamageType.Crushing;
        explosion = false;
        incendiary = false;
        surge = false;
        accuracy = 0;
        muscle = false;
        halfRange = 10.0;
        maxRange = 100.0;
        magazineWeight = 1.0;
        rateOfFire = 1;
        fullAuto = false;
        jet = false;
        projectiles = 1;
        shots = 1;
        thrown = false;
        reload = 1;
        perShot = false;
        strength = 10;
        twoHanded = false;
        musketRest = false;
        bipod = false;
        mounted = false;
        bulk = 0;
        recoil = 1;
    }

    public String toString() {
        String out = "";

        out += damage;
        if (armorDivisor != 1.0) { out += "(" + armorDivisor + ")"; }
        out += damageType.getCode();
        if (explosion) { out += " ex"; }
        if (incendiary) { out += " inc"; }
        if (surge) { out += " sur"; }
        out += ", ";
        out += "Acc " + accuracy;
        out += ", ";
        out += "1/2D ";
        if (muscle) { out += "x"; }
        out += halfRange;
        out += " Max ";
        if (muscle) { out += "x"; }
        out += maxRange;
        out += ", ";
        out += magazineWeight + "lbs.";
        out += ", ";
        out += "RoF ";
        if (!jet) {
            out += rateOfFire;
            if (fullAuto) { out += "!"; }
            if (projectiles > 1) { out += "x" + projectiles; }
        } else { out += "Jet"; }
        out += ", ";
        out += "Shots ";
        if (!thrown) { out += shots; }
        else { out += "T"; }
        out += "(" + reload;
        if (perShot) { out += "i"; }
        out += ")";
        out += ", ";
        out += "ST " + strength;
        if (twoHanded) { out += "H"; }
        if (musketRest) { out += "R"; }
        if (bipod) { out += "B"; }
        if (mounted) { out += "M"; }
        out += ", ";
        out += "Bulk " + bulk;
        out += ", ";
        out += "Rcl " + recoil;

        return out;
    }
}
