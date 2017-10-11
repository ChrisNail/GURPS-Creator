package com.twilightparadox.triforce700.core.vehicle;
import java.util.List;
import java.util.Vector;

public class Vehicle {

	public String name;
	public int cost;
	public int techLevel; //Tech level as described in the Basic Set
	public int strengthHP; //The Strength and HP value for this vehicle
	public int handling;
	public int stability;
	public int health; //Measure of reliability and ruggedness
	public boolean combustible;
	public boolean flammable;
	public boolean explosive;
	public String acceleration;
	public String topSpeed;
	public boolean roadbound;
	public boolean railbound; //Must follow rails
	public double loadedWeight; //Weight with maximum payload and a full load of fuel
	public double load; //The weight of occupants and cargo the vehicle can carry
	public int sizeMod;
	public int crew; //Number of crew members
	public int passengers; //Number of passengers
	public boolean accommodation; //Indicates a vehicle built for long-term accommodation
	public boolean sealed;
	public boolean pressureSupport;
	public boolean vacuumSupport;
	public List<VehicularArmor> damageResistances;
	public int range;
	public boolean fatigue;
	public List<VehicleHitLocation> specialHitLocations;
	public int draft; //Minimum depth of water, in feet, it can safely operate in
	public int stall; //Minimum speed, in yards/second, it must maintain to take off and stay airborne. â€œ0â€� means it can hover

	public Vehicle() {
		name = "";
		cost = 0;
		techLevel = 0;
		strengthHP = 0;
		handling = 0;
		stability = 0;
		health = 0;
		combustible = false;
		flammable = false;
		explosive = false;
		acceleration = "";
		topSpeed = "";
		roadbound = false;
		railbound = false;
		loadedWeight = 0.0;
		load = 0.0;
		sizeMod = 0;
		crew = 1;
		passengers = 0;
		accommodation = false;
		sealed = false;
		pressureSupport = false;
		vacuumSupport = false;
		damageResistances = new Vector<VehicularArmor>();
		range = 0;
		fatigue = false;
		specialHitLocations = new Vector<VehicleHitLocation>();
		draft = 0;
		stall = 0;
	}

}

class VehicularArmor {
	public int damageResistance;
	public String side;

	public VehicularArmor(int resistance, String side) {
		this.damageResistance = resistance;
		this.side = side;
	}
}