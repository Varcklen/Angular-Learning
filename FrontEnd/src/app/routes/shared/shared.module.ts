import { NgModule } from "@angular/core";
import { ColorDirective } from "./color.directive";

//Необходимо делать отдельный модуль для глобальных вещей
//Например, для общих директив (ColorDirective)
@NgModule({
    declarations: [ColorDirective],
    exports: [ColorDirective]
})
export class SharedModule{}