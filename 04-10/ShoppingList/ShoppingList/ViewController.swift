//
//  ViewController.swift
//  ShoppingList
//
//  Created by Usuário Convidado on 25/08/2018.
//  Copyright © 2018 FIAP. All rights reserved.
//

import UIKit
import Firebase

class ViewController: UIViewController {

    @IBOutlet weak var tfEmail: UITextField!
    @IBOutlet weak var tfPassword: UITextField!
    @IBOutlet weak var tfName: UITextField!
    
    override func viewDidLoad() {
        super.viewDidLoad()
    }

    @IBAction func login(_ sender: UIButton) {
        Auth.auth().signIn(withEmail: tfEmail.text!, password: tfPassword.text!) { (result, error) in
            if let error = error {
                print(error)
            } else {
                print("Usuário logado com sucesso!!!")
                self.updateUserAndProceed()
            }
        }
    }
    
    @IBAction func signup(_ sender: UIButton) {
        Auth.auth().createUser(withEmail: tfEmail.text!, password: tfPassword.text!) { (result, error) in
            if let error = error {
                print(error)
            } else {
                print("Usuário criado com sucesso!!!")
                self.updateUserAndProceed()
            }
        }
    }
    
    func updateUserAndProceed() {
        if tfName.text!.isEmpty {
            showMainScreen()
        } else {
            guard let user = Auth.auth().currentUser else {return}
            let changeRequest = user.createProfileChangeRequest()
            changeRequest.displayName = tfName.text!
            changeRequest.commitChanges { (error) in
                if let error = error {
                    print(error)
                } else {
                    print("Nome alterado com sucesso!")
                }
                self.showMainScreen()
            }
        }
    }
    
    func showMainScreen() {
        guard let vc = storyboard?.instantiateViewController(withIdentifier: "TableViewController") else {return}
        navigationController?.viewControllers = [vc]
        
        
    }
}

