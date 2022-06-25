import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";

import { CarPageComponent } from "../car-page/car-page.component";
import { CarsPageComponent } from "../cars-page/cars-page.component";
import { CarsService } from "../cars-page/cars.service";
import { SharedModule } from "../shared/shared.module";
import { CarsRoutingModule } from "./cars-routing.module";

@NgModule({
    declarations: [
        CarsPageComponent,
        CarPageComponent
    ],
    imports: [
        CommonModule,
        CarsRoutingModule,
        SharedModule
    ],
    providers: [CarsService]
})
export class CarsModule {}