/*import { Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

export interface IAnswer{
  type: string,
  text: string
}

@Component({
  selector: 'app-answers',
  templateUrl: './answers.component.html',
  styleUrls: ['./answers.component.scss']
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

  defaultAnswer = 'no';
  defaultCountry = 'ru';

  formData = {};
  isSubmited = false;

  submitForm(form: NgForm){
    this.isSubmited = true;
    this.formData = this.form.value;
    this.form.reset();
    //console.log('Submited!', form);
  }

  addRandEmail(){
    const randEmail = 'wfm@gmail.com';
    //this.form.setValue({
    //  user:{
    //    pass: '',
    //    email: randEmail
    //  },
    //  country: '',
    //  answer: ''
    //})
    this.form.form.patchValue({
      user:{
        email: randEmail
      }
    })
  }
}
*/