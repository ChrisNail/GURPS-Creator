package com.twilightparadox.triforce700.view;

import java.util.Vector;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import com.twilightparadox.triforce700.core.Library;

public class GURPSTable extends JTable {
	
	private Vector<String> columnNames;
	
	public GURPSTable(Vector<Object> tableData, Vector<String> columnNames) {
		super(new GURPSTableModel(tableData, columnNames));
		
		this.columnNames = columnNames;
	}
	
	public void updateModel(Vector<Object> newTableData) {
		((GURPSTableModel)this.getModel()).setDataVector(newTableData, columnNames);
	}

}

class GURPSTableModel extends DefaultTableModel {
	
	public GURPSTableModel(Vector<Object> tableData, Vector<String> columnNames) {
		super(tableData, columnNames);
	}
	
	public boolean isCellEditable(int row, int column) {
		return false;
	}
}