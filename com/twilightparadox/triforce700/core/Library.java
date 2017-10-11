package com.twilightparadox.triforce700.core;

import java.util.Vector;

public abstract class Library {
	
	private String name;
	private Vector<String> columnNames;
	
	public Library(String name) {
		this.name = name;
		columnNames = new Vector<String>();
	}
	
	public Library(String name, Vector<String> columnNames) {
		this.name = name;
		this.columnNames = columnNames;
	}
	
	public String getName() { return name; }
	public void setName(String name) { this.name = name; }
	
	public Vector<String> getColumnNames() { return columnNames; }
	public void setColumnNames(Vector<String> columnNames) { this.columnNames = columnNames; }
	
	public abstract Vector<Object> getTableData();
}
