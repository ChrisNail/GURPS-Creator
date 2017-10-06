public class Armor {

	public LocationType hitLocation { get; set; }
	public int damageResist { get; set; }
	public bool burningProtection { get; set; }
	public bool corrosionProtection { get; set; }
	public bool crushingProtection { get; set; }
	public bool cuttingProtection { get; set; }
	public bool impalingProtection { get; set; }
	public bool piercingProtection { get; set; }
	public bool toxicProtection { get; set; }
	public bool flexible { get; set; }

	public Armor() {
		LocationType = LocationType.Torso;
		damageResist = 1;
		burningProtection = corrosionProtection = crushingProtection = cuttingProtection = impalingProtection = piercingProtection = toxicProtection = false;
	}

	public Armor(XmlNode node) {
		hitLocation = node.SelectSingleNode("HitLocaton").InnerText;
		damageResist = int.Parse(node.SelectSingleNode("DamageResist").InnerText);
		burningProtection = bool.Parse(node.SelectSingleNode("BurningProtection").InnerText);
		corrosionProtection = bool.Parse(node.SelectSingleNode("CorrosionProtection").InnerText);
		crushingProtection = bool.Parse(node.SelectSingleNode("CrushingProtection").InnerText);
		cuttingProtection = bool.Parse(node.SelectSingleNode("CuttingProtection").InnerText);
		impalingProtection = bool.Parse(node.SelectSingleNode("ImpalingProtection").InnerText);
		piercingProtection = bool.Parse(node.SelectSingleNode("PiercingProtection").InnerText);
		toxicProtection = bool.Parse(node.SelectSingleNode("ToxicProtection").InnerText);
		flexible = bool.Parse(node.SelectSingleNode("Flexible").InnerText);
	}

}

public enum LocationType {
	Suit, Torso, Arms, Legs, Hands, Feet, LeftHand, RightHand, Groin, Head, Skull, Face, Eyes, Neck
}