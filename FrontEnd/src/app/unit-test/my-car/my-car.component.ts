import { Component, OnInit } from '@angular/core';
import { MyCarService } from './my-car.service';

@Component({
  selector: 'app-my-car',
  templateUrl: './my-car.component.html',
  providers: [MyCarService]
})
export class MyCarComponent implements OnInit {

  isCarVisible!:boolean;
  title = 'My car header';

  constructor(private myCarService: MyCarService) { }

  ngOnInit(): void {
    this.isCarVisible = this.myCarService.getVisibility();
  }

}
