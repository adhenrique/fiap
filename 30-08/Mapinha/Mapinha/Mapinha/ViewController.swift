//
//  ViewController.swift
//  Mapinha
//
//  Created by Usuário Convidado on 30/08/19.
//  Copyright © 2019 br.com.fiap. All rights reserved.
//

import UIKit
import MapKit

class ViewController: UIViewController {

    @IBOutlet weak var searchBar: UISearchBar!
    @IBOutlet weak var mapView: MKMapView!
    var locationManager = CLLocationManager()
    
    override func viewDidLoad() {
        super.viewDidLoad()
        searchBar.delegate = self
        mapView.delegate = self
        mapView.showsUserLocation = true
        mapView.userTrackingMode = .followWithHeading // enum, em vez de digitarmos o nome da enum por extenso, a var ja sabe que ela recebe esse enum, entao utilizamos um shortcode
        requestAuthorization()
    }
    
    func requestAuthorization() {
        locationManager.desiredAccuracy = kCLLocationAccuracyBest
        locationManager.requestWhenInUseAuthorization()
    }
}

extension ViewController: UISearchBarDelegate {
    func searchBarSearchButtonClicked(_ searchBar: UISearchBar) {
        //
    }
}
extension ViewController: MKMapViewDelegate {
    
}
