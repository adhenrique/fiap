//
//  CarsTableViewController.swift
//  Carros
//
//  Created by Usuário Convidado on 09/08/2018.
//  Copyright © 2018 FIAP. All rights reserved.
//

import UIKit

class CarsTableViewController: UITableViewController {
    
    var cars: [Car] = []
    
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if let vc = segue.destination as? CarViewController {
            if let row = tableView.indexPathForSelectedRow?.row {
                vc.car = cars[row]
            }
        }
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()
    }
    
    override func viewWillAppear(_ animated: Bool) {
        super.viewWillAppear(animated)
        API.loadCars { (cars) in
            self.cars = cars
            DispatchQueue.main.async {
                self.tableView.reloadData()
            }
        }
    }

    override func numberOfSections(in tableView: UITableView) -> Int {
        return 1
    }
    
    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return cars.count
    }
    
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = tableView.dequeueReusableCell(withIdentifier: "cell", for: indexPath)
        
        let car = cars[indexPath.row]
        
        cell.textLabel?.text = car.name
        cell.detailTextLabel?.text = car.brand
        return cell
    }
    
    override func tableView(_ tableView: UITableView, commit editingStyle: UITableViewCell.EditingStyle, forRowAt indexPath: IndexPath) {
        if editingStyle == .delete {
            let car = cars[indexPath.row]
            API.deleteCar(car) { (success) in
                if success {
                    self.cars.remove(at: indexPath.row)
                    DispatchQueue.main.async {
                        self.tableView.deleteRows(at: [indexPath], with: UITableView.RowAnimation.automatic)
                    }
                }
            }
        }
    }
}
