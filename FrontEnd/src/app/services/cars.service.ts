import { Injectable } from "@angular/core";
import { ConsoleService } from "./console.service";

export interface ICar{
    name: string, 
    isSold:boolean
}

@Injectable()
export class CarsService {

    constructor(private consoleService: ConsoleService){}
    
    cars:ICar[] = [
        { name: 'Ford', isSold:false }, 
        { name: 'Mazda', isSold:true },
        { name: 'Audi', isSold:false }
    ];

    addCar(name:string){
        this.cars.push({ name, isSold: false });
        this.consoleService.log('Car ' + name + ' is added.');
    }
}