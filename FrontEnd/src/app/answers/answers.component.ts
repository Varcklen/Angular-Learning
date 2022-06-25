import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

export interface IAnswer{
  type: string,
  text: string
}

@Component({
  selector: 'app-answers',
  templateUrl: './answers.component.html'
})
export class AnswersComponent implements OnInit {

  answers:IAnswer[] = [{
    type: 'yes',
    text: 'Correct'
  }, {
    type: 'no',
    text: 'Wrong'
  }];

  form!: FormGroup;
  charsCount = 5;

  ngOnInit(): void {
    this.form = new FormGroup({
      user: new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
        pass: new FormControl('', [Validators.required, this.checkForLength.bind(this)]),
      }),
      country: new FormControl('ru'),
      answer: new FormControl('no')
    });
  }

  onSubmit(){
    console.log('submitted', this.form);
  }

  checkForLength(control: FormControl){
    if (control.value.length <= this.charsCount){
      return {
        'lengthError': true
      };
    }
    return null;
  }
}
