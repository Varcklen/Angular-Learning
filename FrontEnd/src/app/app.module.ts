import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'

import { AppComponent } from './app.component';
import { BackgroundDirective } from './directives/background.directive';
import { PowPipe } from './pipes/pow.pipe';
import { CarFilterPipe } from './pipes/car-filter.pipe';
import { ConsoleService } from './services/console.service';
import { AnswersComponent } from './answers/answers.component';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AuthService } from './routes/auth.service';
import { AuthGuard } from './routes/auth-guard.service'
import { SharedModule } from './routes/shared/shared.module';
import { HomePageComponent } from './routes/home-page/home-page.component';
import { NotFoundComponent } from './routes/not-found/not-found.component';
import { NewPageComponent } from './routes/new-page/new-page.component';
import { FirstAnimationComponent } from './animations/first-animation/first-animation.component';
import { SecondAnimationComponent } from './animations/second-animation/second-animation.component';
import { MyCarComponent } from './unit-test/my-car/my-car.component';

@NgModule({
  declarations: [
    AppComponent,
    BackgroundDirective,
    PowPipe,
    CarFilterPipe,
    AnswersComponent,
    HomePageComponent,
    NotFoundComponent,
    NewPageComponent,
    FirstAnimationComponent,
    SecondAnimationComponent,
    MyCarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    AppRoutingModule,
    SharedModule,
    BrowserAnimationsModule
  ],
  providers: [
    ConsoleService,
    AuthService,
    AuthGuard
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
