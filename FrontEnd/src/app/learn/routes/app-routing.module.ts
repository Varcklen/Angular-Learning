/*import { NgModule } from "@angular/core";
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from "./routes/auth-guard.service";
import { CarPageComponent } from "./routes/car-page/car-page.component";
import { CarsPageComponent } from "./routes/cars-page/cars-page.component";
import { HomePageComponent } from "./routes/home-page/home-page.component";
import { NewPageComponent } from "./routes/new-page/new-page.component";
import { NotFoundComponent } from "./routes/not-found/not-found.component";

const appRoutes: Routes = [
    /*{ path: '', component: HomePageComponent },
    { path: 'cars', component: CarsPageComponent, 
    canActivate: [AuthGuard],
    children:[
        { path: ':id/:name', component: CarPageComponent },
    ] },
    { path: 'new', component: NewPageComponent },
    { path: 'not-found', component: NotFoundComponent},
    { path: '**', redirectTo: '/not-found'}
];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule]
})
export class AppRoutingModule{}*/