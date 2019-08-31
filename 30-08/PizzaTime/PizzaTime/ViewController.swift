//
//  ViewController.swift
//  PizzaTime
//
//  Created by Usuário Convidado on 23/08/19.
//  Copyright © 2019 FIAP. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var tfName: UITextField!
    @IBOutlet weak var tfPrice: UITextField!
    @IBOutlet weak var btAddEdit: UIButton!
    
    var pizza: Pizza!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        if pizza != nil {
            tfName.text = pizza.name
            tfPrice.text = "\(pizza.price)"
            btAddEdit.setTitle("Alterar pizza", for: .normal)
        }
        
    }

    @IBAction func addEditPizza(_ sender: Any) {
        if pizza == nil {
            pizza = Pizza(context: context)
        }
        pizza.name = tfName.text
        pizza.price = Double(tfPrice.text!) ?? 0
        try? context.save()
        navigationController?.popViewController(animated: true)
    }
    
    
}

