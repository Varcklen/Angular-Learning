import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html'
})
export class HomePageComponent implements OnInit {

  constructor( private auth: AuthService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
  }

  //openCarsPage(){
  //  this.router.navigate(['/cars'])
  //}

  openCarsPage(){
    this.router.navigate(['cars'], {relativeTo: this.route})
  }

  changeAuthStatus(status: string){
    if (status = 'login'){
      console.log(status);
      this.auth.login();
    } else {
      console.log(status);
      this.auth.logOut();
    }
  }
}
