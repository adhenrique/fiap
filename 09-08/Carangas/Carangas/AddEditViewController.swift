//
//  AddEditViewController.swift
//  Carangas
//
//  Created by Eric Brito on 16/10/17.
//  Copyright © 2017 Eric Brito. All rights reserved.
//

import UIKit

class AddEditViewController: UIViewController {

    @IBOutlet weak var tfBrand: UITextField!
    @IBOutlet weak var tfName: UITextField!
    @IBOutlet weak var tfPrice: UITextField!
    @IBOutlet weak var scGasType: UISegmentedControl!
    @IBOutlet weak var btAddEdit: UIButton!
    
    var car: Car!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        if car != nil {
            tfBrand.text = car.brand
            tfName.text = car.name
            tfPrice.text = "\(car.price)"
            scGasType.selectedSegmentIndex = car.gasType
            btAddEdit.setTitle("Alterar carro", for: .normal)
            title = car.brand
        }
    }
    
    @IBAction func addEdit(_ sender: UIButton) {
        if car == nil {
            car = Car()
        }
        car.brand = tfBrand.text!
        car.name = tfName.text!
        car.price = Double(tfPrice.text!) ?? 0
        car.gasType = scGasType.selectedSegmentIndex
        
        if car._id.isEmpty {
            API.createCar(car) { (success) in
                
            }
        } else {
            API.updateCar(car) { (success) in
                
            }
        }
    }
    
}
