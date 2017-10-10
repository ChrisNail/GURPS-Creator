using System;

namespace Vehicles {

	class VehicleHitLocation {
		public int Quantity { get; set; }
		public LocationType Location { get; set; }
		public bool Retractable { get; set; }

		public HitLocation(int quantity, LocationType location, bool retractable) {
			this.Quantity = quantity;
			this.Location = location;
			this.Retractable = retractable;
		}
	}

	class VehicleLocationType {
		public string Code { get; set; }
		public string Name { get; set; }

		public LocationType(string code, string name) {
			this.Code = code;
			this.Name = name;
		}

		public static LocationType Arm = new LocationType("A", "Arm");
		public static LocationType ContinuousTrack = new LocationType("C", "Continuous Tracks");
		public static LocationType DraftAnimals = new LocationType("D", "Draft Animals");
		public static LocationType ExposedRider = new LocationType("E", "Exposed Rider");
		public static LocationType LargeGlassWindows = new LocationType("G", "Large Glass Windows");
		public static LocationType SmallGlassWindows = new LocationType("g", "Small Glass Windows");
		public static LocationType HelicopterRotors = new LocationType("H", "Helicopter Rotors");
		public static LocationType Leg = new LocationType("L", "Leg");
		public static LocationType Mast = new LocationType("M", "Mast");
		public static LocationType OpenCabin = new LocationType("O", "Open Cabin");
		public static LocationType Runners = new LocationType("R", "Runners");
		public static LocationType LargeSuperstructure = new LocationType("S", "Large Superstructure");
		public static LocationType SmallSuperstructure = new LocationType("s", "Small Superstructure");
		public static LocationType MainTurret = new LocationType("T", "Main Turret");
		public static LocationType OtherTurret = new LocationType("t", "Small Turret");
		public static LocationType Wheel = new LocationType("W", "Wheel");
		public static LocationType Wings = new LocationType("Wi", "Wings");
		public static LocationType ExposedWeapon = new LocationType('X', "Exposed Weapon Mount");

		public static Dictionary<String, VehicleLocationType> LocationTypes = new Dictionary<String, VehicleLocationType>() {
			{ Arm.Name, Arm },
			{ ContinuousTrack.Name, ContinuousTrack },
			{ DraftAnimals.Name, DraftAnimals },
			{ ExposedRider.Name, ExposedRider },
			{ LargeGlassWindows.Name, LargeGlassWindows },
			{ SmallGlassWindows.Name, SmallGlassWindows },
			{ HelicopterRotors.Name, HelicopterRotors },
			{ Leg.Name, Leg },
			{ Mast.Name, Mast },
			{ OpenCabin.Name, OpenCabin },
			{ Runners.Name, Runners },
			{ LargeSuperstructure.Name, LargeSuperstructure },
			{ SmallSuperstructure.Name, SmallSuperstructure },
			{ MainTurret.Name, MainTurret },
			{ OtherTurret.Name, OtherTurret },
			{ Wheel.Name, Wheel },
			{ Wings.Name, Wings },
			{ ExposedWeapon.Name, ExposedWeapon }
		}
	}
}