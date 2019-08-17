//
//  ViewController.swift
//  Carangas
//
//  Created by Eric Brito on 14/10/17.
//  Copyright © 2017 Eric Brito. All rights reserved.
//

import UIKit

class CarViewController: UIViewController {
    
    @IBOutlet weak var lbBrand: UILabel!
    @IBOutlet weak var lbGasType: UILabel!
    @IBOutlet weak var lbPrice: UILabel!
    
    var car: Car!
    
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if let vc = segue.destination as? AddEditViewController {
            vc.car = car
        }
    }
    
    override func viewWillAppear(_ animated: Bool) {
        super.viewWillAppear(animated)
        
        if car != nil {
            lbBrand.text = car.brand
            lbGasType.text = car.gas
            lbPrice.text = "R$ \(car.price)"
            title = car.brand
        }
    }
}
