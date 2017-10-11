package com.twilightparadox.triforce700.core.equipment;

import java.util.List;
import java.util.Vector;

import com.twilightparadox.triforce700.core.Library;

public class EquipmentLibrary extends Library {

	private List<Equipment> equipmentList;
	
	public EquipmentLibrary() {
		super("New Equipment Library", Equipment.COLUMN_NAMES);
		equipmentList = new Vector<Equipment>();
	}
	
	public EquipmentLibrary(String name) {
		super(name, Equipment.COLUMN_NAMES);
		equipmentList = new Vector<Equipment>();
	}
	
	public List<Equipment> getList() { return equipmentList; }
	public void setList(List<Equipment> equipmentList) { this.equipmentList = equipmentList; }
	
	public Vector<Object> getTableData() {
		Vector<Object> rows = new Vector<Object>();
		
		for (Equipment e : equipmentList) {
			rows.add(e.getColumnData());
		}
		
		return rows;
	}
}