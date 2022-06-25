import { NgModule } from "@angular/core";
import { Routes, RouterModule, PreloadAllModules } from '@angular/router';

import { HomePageComponent } from "./routes/home-page/home-page.component";
import { NewPageComponent } from "./routes/new-page/new-page.component";
import { NotFoundComponent } from "./routes/not-found/not-found.component";

const appRoutes: Routes = [
    { path: '', component: HomePageComponent },
    { path: 'cars', loadChildren: () => import('./routes/modules/cars.module').then(x => x.CarsModule) },
    { path: 'new', component: NewPageComponent },
    { path: 'not-found', component: NotFoundComponent},
    { path: '**', redirectTo: '/not-found'}
];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes
        //, {preloadingStrategy: PreloadAllModules}
        )],
    exports: [RouterModule]
})
export class AppRoutingModule{}