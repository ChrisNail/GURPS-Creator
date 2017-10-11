package com.twilightparadox.triforce700.core.vehicle;
import java.util.HashMap;
import java.util.Map;

public class VehicleHitLocation {
	public int quantity;
	public VehicleLocationType location;
	public boolean retractable;

	public VehicleHitLocation(int quantity, VehicleLocationType location, boolean retractable) {
		this.quantity = quantity;
		this.location = location;
		this.retractable = retractable;
	}
	
	public int getQuantity() { return quantity; }
	public void setQuantity(int quantity) { this.quantity = quantity; }
	
	public VehicleLocationType getLocationType() { return location; }
	public void setLocationType(VehicleLocationType location) { this.location = location; }
	
	public boolean isRetractable()  { return retractable; }
	public void setRetractable(boolean retractable) {this.retractable = retractable; }
}

class VehicleLocationType {
	public String code;
	public String name;

	public VehicleLocationType(String code, String name) {
		this.code = code;
		this.name = name;
	}
	
	public String getCode() { return code; }
	public void setCode(String code) { this.code = code; }
	
	public String getName() { return name; }
	public void setName(String name) { this.name = name; }

	public static VehicleLocationType Arm = new VehicleLocationType("A", "Arm");
	public static VehicleLocationType ContinuousTrack = new VehicleLocationType("C", "Continuous Tracks");
	public static VehicleLocationType DraftAnimals = new VehicleLocationType("D", "Draft Animals");
	public static VehicleLocationType ExposedRider = new VehicleLocationType("E", "Exposed Rider");
	public static VehicleLocationType LargeGlassWindows = new VehicleLocationType("G", "Large Glass Windows");
	public static VehicleLocationType SmallGlassWindows = new VehicleLocationType("g", "Small Glass Windows");
	public static VehicleLocationType HelicopterRotors = new VehicleLocationType("H", "Helicopter Rotors");
	public static VehicleLocationType Leg = new VehicleLocationType("L", "Leg");
	public static VehicleLocationType Mast = new VehicleLocationType("M", "Mast");
	public static VehicleLocationType OpenCabin = new VehicleLocationType("O", "Open Cabin");
	public static VehicleLocationType Runners = new VehicleLocationType("R", "Runners");
	public static VehicleLocationType LargeSuperstructure = new VehicleLocationType("S", "Large Superstructure");
	public static VehicleLocationType SmallSuperstructure = new VehicleLocationType("s", "Small Superstructure");
	public static VehicleLocationType MainTurret = new VehicleLocationType("T", "Main Turret");
	public static VehicleLocationType OtherTurret = new VehicleLocationType("t", "Small Turret");
	public static VehicleLocationType Wheel = new VehicleLocationType("W", "Wheel");
	public static VehicleLocationType Wings = new VehicleLocationType("Wi", "Wings");
	public static VehicleLocationType ExposedWeapon = new VehicleLocationType("X", "Exposed Weapon Mount");

	public static Map<String, VehicleLocationType> LocationTypes = new HashMap<String, VehicleLocationType>();
	
	static {
		LocationTypes.put(Arm.getName(), Arm);
		LocationTypes.put(ContinuousTrack.getName(), ContinuousTrack);
		LocationTypes.put(DraftAnimals.getName(), DraftAnimals);
		LocationTypes.put(ExposedRider.getName(), ExposedRider);
		LocationTypes.put(LargeGlassWindows.getName(), LargeGlassWindows);
		LocationTypes.put(SmallGlassWindows.getName(), SmallGlassWindows);
		LocationTypes.put(HelicopterRotors.getName(), HelicopterRotors);
		LocationTypes.put(Leg.getName(), Leg);
		LocationTypes.put(Mast.getName(), Mast);
		LocationTypes.put(OpenCabin.getName(), OpenCabin);
		LocationTypes.put(Runners.getName(), Runners);
		LocationTypes.put(LargeSuperstructure.getName(), LargeSuperstructure);
		LocationTypes.put(SmallSuperstructure.getName(), SmallSuperstructure);
		LocationTypes.put(MainTurret.getName(), MainTurret);
		LocationTypes.put(OtherTurret.getName(), OtherTurret);
		LocationTypes.put(Wheel.getName(), Wheel);
		LocationTypes.put(Wings.getName(), Wings);
		LocationTypes.put(ExposedWeapon.getName(), ExposedWeapon);
	}
}