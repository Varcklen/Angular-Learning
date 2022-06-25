/*import { 
  Component, 
  OnInit, 
  Output, 
  EventEmitter, 
  ViewChild, 
  ElementRef } from '@angular/core';

interface IType{name: string, year: number}

@Component({
  selector: 'app-add-car',
  templateUrl: './add-car.component.html',
  styleUrls: ['./add-car.component.scss']
})
export class AddCarComponent implements OnInit {

  @Output() onAddCar = new EventEmitter<IType>();
  @ViewChild('carYearInput') carYearInput!: ElementRef;

  constructor() { }

  ngOnInit(): void {
  }

  addCar(carNameEl: HTMLInputElement) : void{
    console.log(this.carYearInput);
    this.onAddCar.emit({
      name: carNameEl.value,
      year: +this.carYearInput.nativeElement.value
    });
    carNameEl.value = '';
    this.carYearInput.nativeElement.value = 2000;
  }
}

*/