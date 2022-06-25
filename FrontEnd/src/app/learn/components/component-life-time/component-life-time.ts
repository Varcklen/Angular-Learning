/*import { 
    Component, 
    ElementRef, 
    Input, 
    ViewChild, 
    OnInit, 
    OnChanges, 
    SimpleChanges, 
    DoCheck,
    AfterContentInit,
    AfterContentChecked,
    AfterViewInit,
    AfterViewChecked,
    OnDestroy
  } from '@angular/core';
  
  @Component({
    selector: 'app-car',
    templateUrl: './car.component.html',
    styleUrls: ['./car.component.scss']
  })
  export class CarComponent implements 
    OnInit, 
    OnChanges,
    DoCheck,
    AfterContentInit,
    AfterContentChecked,
    AfterViewInit,
    AfterViewChecked,
    OnDestroy
  {
    @Input('carItem') car!: {name: string, year: number};
    @Input() name! : string;
    @ViewChild('carHeading') carHeading!: ElementRef;
  
    constructor(){
      console.log('constructor');
    }
  
    ngOnInit(): void {
      console.log('ngOnInit');
    }
  
    ngOnChanges(changes: SimpleChanges): void {
      console.log('ngOnChanges', changes);
    }
  
    ngDoCheck(): void {
      console.log('ngDoCheck');
    }
  
    ngAfterContentInit(): void {
      console.log('ngAfterContentInit');
    }
  
    ngAfterContentChecked(): void {
      console.log('ngAfterContentChecked');
    }  
  
    ngAfterViewInit(): void {
      console.log('ngAfterViewInit');
    }
  
    ngAfterViewChecked(): void {
      console.log('ngAfterViewChecked');
    }
  
    ngOnDestroy(): void {
      console.log('ngOnDestroy');
    }
  }
  */