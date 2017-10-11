package com.twilightparadox.triforce700.controller;

import java.util.Vector;

import com.twilightparadox.triforce700.core.Library;
import com.twilightparadox.triforce700.core.equipment.Equipment;
import com.twilightparadox.triforce700.core.equipment.EquipmentLibrary;
import com.twilightparadox.triforce700.view.GURPSTable;

public class EquipmentController implements Controller {
	
	private static EquipmentController instance = new EquipmentController();
	
	private Vector<EquipmentLibrary> openLibraries = new Vector<EquipmentLibrary>();
	
	public static Controller getInstance() { return instance; }
	
	@Override
	public GURPSTable addLibrary() {
		return addLibrary("New Equipment Library");
	}
	
	@Override
	public GURPSTable addLibrary(String name) {
		EquipmentLibrary library = new EquipmentLibrary(name);
		openLibraries.add(library);
		return new GURPSTable(library.getTableData(), Equipment.COLUMN_NAMES);
	}
}
