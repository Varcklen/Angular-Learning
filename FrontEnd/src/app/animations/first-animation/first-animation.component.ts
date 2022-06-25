import { 
  animate,
  state, 
  style, 
  transition, 
  trigger
} from '@angular/animations';
import { Component } from '@angular/core';

@Component({
  selector: 'app-first-animation',
  templateUrl: './first-animation.component.html',
  animations: [
    trigger('clickedDiv', [
      state('start', style({
        backgroundColor: 'blue',
        width: '150px',
        height: '150px'
      })),
      state('end', style({
        backgroundColor: 'red',
        width: '300px',
        height: '300px'
      })),
      state('active', style({
        backgroundColor: 'orange',
        width: '170px',
        height: '170px'
      })),
      transition('start <-> end', animate('800ms ease-in')),
      transition('start -> active', animate(400)),
      transition('active -> end', animate(400))
    ]),
    trigger('multi', [
      state('start', style({
        width: '150px',
        height: '150px',
        border: '5px solid black'
      })),
      state('end', style({
        width: '170px',
        height: '170px',
        backgroundColor: 'blue'
      })),
      transition('start <-> end', [
        style({
          backgroundColor: 'red'
        }),
        animate(1000, style({
          backgroundColor: 'yellow'
        })),
        animate(1000, style({
          width: '200px',
          height: '200px'
        })),
        animate(1000)
      ]),
    ])
  ]
})
export class FirstAnimationComponent {
  clickedDivState = 'start';
  multiState = 'start';
  
  changeDivState(){
    this.clickedDivState = 'end';
    setTimeout(() => {
      this.clickedDivState = 'start';
    }, 3000)
  }
}
