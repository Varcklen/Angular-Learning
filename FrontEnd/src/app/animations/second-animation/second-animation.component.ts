import { Component } from '@angular/core';
import { changeWidthTrigger, detailTrigger, divTrigger } from './second-animation.animation';
import { AnimationEvent } from '@angular/animations';

@Component({
  selector: 'app-second-animation',
  templateUrl: './second-animation.component.html',
  animations: [divTrigger, detailTrigger, changeWidthTrigger]
})
export class SecondAnimationComponent  {
  isVisible = false;
  
  onAnimStart(event: AnimationEvent){
    console.log('Start: ', event);
  }
  
  onAnimDone(event: AnimationEvent){
    console.log('Done: ', event);
  }
}
