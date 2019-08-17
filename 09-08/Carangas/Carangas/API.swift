//
//  API.swift
//  Carangas
//
//  Created by Usuário Convidado on 09/08/19.
//  Copyright © 2019 Eric Brito. All rights reserved.
//

import Foundation

class API {
    static let path = "https://carangas.herokuapp.com/cars"
    static let session = URLSession.shared
    
    class func loadCars(onComplete: @escaping ([Car])->Void) {
        guard let url = URL(string: path) else {
            return
        }
        
        // Data - dados
        // Response - codigo status
        // Error - erro
        let dataTask = session.dataTask(with: url) { (data, response, error) in
            if error != nil {
                print(error!.localizedDescription)
                return
            }
            
            guard let response = response as? HTTPURLResponse, response.statusCode == 200 else {
                API.errorMessage()
                return
            }
            
            guard let data = data else{
                API.errorMessage()
                return
            }
            
            do {
                let cars = try JSONDecoder().decode([Car].self, from: data)
                print("O total de carros é \(cars.count)")
                onComplete(cars)
            } catch {
                API.errorMessage()
                return
            }
        }
        
        dataTask.resume()
    }
    
    class func errorMessage() {
        print("Deu merda!")
    }
    
    class func createCar(_ car: Car, onComplete: @escaping (Bool)->Void) {
        restOperation(car: car, httpMethod: "POST", onComplete: onComplete)
    }
    
    class func updateCar(_ car: Car, onComplete: @escaping (Bool)->Void) {
        restOperation(car: car, httpMethod: "PUT", onComplete: onComplete)
    }
    
    class func deleteCar(_ car: Car, onComplete: @escaping (Bool)->Void) {
        restOperation(car: car, httpMethod: "DELETE", onComplete: onComplete)
    }
    
    private class func restOperation(car: Car, httpMethod: String, onComplete: @escaping (Bool)->Void) {
        let urlString = path + "/" + car._id
        guard let url = URL(string: urlString) else {
            onComplete(false)
            return
        }
        
        var urlRequest = URLRequest(url: url)
        urlRequest.httpMethod = httpMethod
        urlRequest.addValue("application/json", forHTTPHeaderField: "Content-Type")
        
        do {
            urlRequest.httpBody = try JSONEncoder().encode(car)
        } catch {
            onComplete(false)
            return
        }
        
        let dataTask = session.dataTask(with: urlRequest) { (data, response, error) in
            if data != nil {
                onComplete(true)
            } else {
                onComplete(false)
            }
        }
        dataTask.resume()
    }
}
