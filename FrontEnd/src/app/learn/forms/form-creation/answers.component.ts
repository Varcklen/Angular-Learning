/*mport { Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

export interface IAnswer{
  type: string,
  text: string
}

@Component({
  selector: 'app-answers',
  templateUrl: './answers.component.html'
})
export class AnswersComponent {

  @ViewChild('form') form!: NgForm;

  answers:IAnswer[] = [{
    type: 'yes',
    text: 'Correct'
  }, {
    type: 'no',
    text: 'Wrong'
  }];

  //submitForm(form: NgForm){
  //  console.log('Submited!', form);
  //}

  submitForm(){
    console.log('Submited!', this.form);
  }
}
*/