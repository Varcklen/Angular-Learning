/*import { Component } from '@angular/core';
import { CarsService } from './cars.service';

export interface ICar {
  name: string,
  color: string,
  id: number
}

@Component({
  selector: 'app-server-work',
  templateUrl: './server-work.component.html'
})
export class ServerWorkComponent {
  cars:ICar[] = [];

  constructor(private carsService: CarsService){}

  loadCars(){
    this.carsService
      .getCars()
      .subscribe( (cars: ICar[]) => {
        this.cars = cars;
        console.log(cars);
      });
  }
}
*/