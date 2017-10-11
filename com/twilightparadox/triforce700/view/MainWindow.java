package com.twilightparadox.triforce700.view;
import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;

import com.twilightparadox.triforce700.controller.EquipmentController;
import com.twilightparadox.triforce700.core.equipment.Equipment;
import com.twilightparadox.triforce700.core.equipment.EquipmentLibrary;

public class MainWindow extends JFrame implements ActionListener {
    
	private static final long serialVersionUID = 1L;
	
	private JMenuBar menuBar;
	private JMenu fileMenu;
	private JMenuItem equipmentLibraryItem;
	private JMenuItem exitItem;
	private JMenu editMenu;
	private JMenu itemMenu;
	private JMenuItem openDetailItem;
	private JMenuItem newEquipmentItem;
	
	private JTabbedPane tabs = new JTabbedPane(); 

	public MainWindow() {
		setTitle("GURPS Tool");
		setSize(800, 600);
		setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
		
        initializeComponents();
        buildComponents();
        addListeners();
        
        setVisible(true);
    }
	
	public void initializeComponents() {
		menuBar = new JMenuBar();
		fileMenu = new JMenu("File");
		equipmentLibraryItem = new JMenuItem("New Equipment Library");
		exitItem = new JMenuItem("Exit");
		editMenu = new JMenu("Edit");
		itemMenu = new JMenu("Item");
		openDetailItem = new JMenuItem("Open Detail Editor");
		newEquipmentItem = new JMenuItem("New Equipment");
		
		
	}
	
	public void buildComponents() {
		fileMenu.add(equipmentLibraryItem);
		fileMenu.add(exitItem);
		menuBar.add(fileMenu);
		menuBar.add(editMenu);
		menuBar.add(itemMenu);
		itemMenu.add(openDetailItem);
		itemMenu.addSeparator();
		itemMenu.add(newEquipmentItem);
		this.setJMenuBar(menuBar);
		
		this.setLayout(new BorderLayout());
		
		this.add(tabs, BorderLayout.CENTER);
	}
	
	public void addListeners() {
		equipmentLibraryItem.addActionListener(this);
		exitItem.addActionListener(this);
	}

	@Override
	public void actionPerformed(ActionEvent event) {
		if (event.getSource().equals(equipmentLibraryItem)) {
			addEquipmentLibrary();
		} else if (event.getSource().equals(exitItem)) {
			System.exit(0);
		}
	}
	
	public void addEquipmentLibrary() {
		String name = (String)JOptionPane.showInputDialog(this, "Enter Library Name:", "New Equipment Library", JOptionPane.QUESTION_MESSAGE, null, null, "New Equipment Library");
		GURPSTable t = EquipmentController.getInstance().addLibrary(name);
		tabs.addTab(name, new JScrollPane(t));
	}
	
	public void addEquipment() {
		
	}

	
}