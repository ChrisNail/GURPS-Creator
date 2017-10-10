using System;
using System.Collections.Generic;

namespace Vehicles {

	class Vehicle {

		public string Name { get; set; }
		public int Cost { get; set; }
		public int TechLevel { get; set; } //Tech level as described in the Basic Set
		public int StrengthHP { get; set; } //The Strength and HP value for this vehicle
		public int Handling { get; set; }
		public int Stability { get; set; }
		public int Health { get; set; } //Measure of reliability and ruggedness
		public bool Combustible { get; set; }
		public bool Flammable { get; set; }
		public bool Explosive { get; set; }
		public string Acceleration { get; set; }
		public string TopSpeed { get; set; }
		public bool Roadbound { get; set; }
		public bool Railbound { get; set; } //Must follow rails
		public double LoadedWeight { get; set; } //Weight with maximum payload and a full load of fuel
		public double Load { get; set; } //The weight of occupants and cargo the vehicle can carry
		public int SizeMod { get; set; }
		public int Crew { get; set; } //Number of crew members
		public int Passengers { get; set; } //Number of passengers
		public bool Accommodation { get; set; } //Indicates a vehicle built for long-term accommodation
		public bool Sealed { get; set; }
		public bool PressureSupport { get; set; }
		public bool VacuumSupport { get; set; }
		public List<VehicularArmor> DamageResistances { get; set; }
		public int Range { get; set; }
		public bool Fatigue { get; set; }
		public List<HitLocation> SpecialHitLocations { get; set; }
		public int Draft { get; set; } //Minimum depth of water, in feet, it can safely operate in
		public int Stall { get; set; } //Minimum speed, in yards/second, it must maintain to take off and stay airborne. “0” means it can hover

		public Vehicle() {
			Name = "";
			Cost = 0;
			TechLevel = 0;
			StrengthHP = 0;
			Handling = 0;
			Stability = 0;
			Health = 0;
			Combustible = false;
			Flammable = false;
			Explosive = false;
			Acceleration = "";
			TopSpeed = "";
			Roadbound = false;
			Railbound = false;
			LoadedWeight = 0.0;
			Load = 0.0;
			SizeMod = 0;
			Crew = 1;
			Passengers = 0;
			Accommodation = false;
			Sealed = false;
			PressureSupport = false;
			VacuumSupport = false;
			DamageResistances = new List<VehicularArmor>();
			Range = 0;
			Fatigue = false;
			SpecialHitLocations = new List<VehicleHitLocation>();
			Draft = 0;
			Stall = 0;
		}

	}

	class VehicularArmor {
		public int DamageResistance { get; set; }
		public string Side { get; set; }

		public VehicularArmor(int resistance, string side) {
			this.DamageResistance = resistance;
			this.Side = side;
		}
	}
}