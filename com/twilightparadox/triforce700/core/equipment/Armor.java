package com.twilightparadox.triforce700.core.equipment;

public class Armor {

	public LocationType hitLocation;
	public int damageResist;
	public boolean burningProtection;
	public boolean corrosionProtection;
	public boolean crushingProtection;
	public boolean cuttingProtection;
	public boolean impalingProtection;
	public boolean piercingProtection;
	public boolean toxicProtection;
	public boolean flexible;

	public Armor() {
		hitLocation = LocationType.Torso;
		damageResist = 1;
		burningProtection = false;
		corrosionProtection = false;
		crushingProtection = false;
		cuttingProtection = false;
		impalingProtection = false;
		piercingProtection = false;
		toxicProtection = false;
	}
	
	public LocationType getLocationType() { return hitLocation; }
	public void setLocationType(LocationType hitLocation) { this.hitLocation = hitLocation; }
	
	public int getDamageResist() { return damageResist; }
	public void setDamageResist(int damageResist) { this.damageResist = damageResist; }

	public boolean isBurningProtection() { return burningProtection; }
	public void setBurningProtection(boolean burningProtection) { this.burningProtection = burningProtection; }

	public boolean isCorrosionProtection() { return corrosionProtection; }
	public void setCorrosionProtection(boolean corrosionProtection) { this.corrosionProtection = corrosionProtection; }

	public boolean isCrushingProtection() {return crushingProtection; }
	public void setCrushingProtection(boolean crushingProtection) { this.crushingProtection = crushingProtection; }

	public boolean isCuttingProtection() { return cuttingProtection; }
	public void setCuttingProtection(boolean cuttingProtection) { this.cuttingProtection = cuttingProtection; }

	public boolean isImpalingProtection() { return impalingProtection; }
	public void setImpalingProtection(boolean impalingProtection) { this.impalingProtection = impalingProtection; }

	public boolean isPiercingProtection() { return piercingProtection; }
	public void setPiercingProtection(boolean piercingProtection) { this.piercingProtection = piercingProtection; }

	public boolean isToxicProtection() { return toxicProtection;}
	public void setToxicProtection(boolean toxicProtection) { this.toxicProtection = toxicProtection; }

	public boolean isFlexible() { return flexible; }
	public void setFlexible(boolean flexible) { this.flexible = flexible; }

}

enum LocationType {
	Suit, Torso, Arms, Legs, Hands, Feet, LeftHand, RightHand, Groin, Head, Skull, Face, Eyes, Neck
}