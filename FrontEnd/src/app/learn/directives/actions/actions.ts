/*import { Directive, ElementRef, HostBinding, HostListener, OnInit, Renderer2 } from "@angular/core";

@Directive({
    selector: '[appBackground]'
})
export class BackgroundDirective implements OnInit {

    @HostBinding('style.backgroundColor') background!: string;

    constructor(private element: ElementRef, private renderer: Renderer2) {}

    ngOnInit(): void {}

    @HostListener('mouseenter', ['$event']) mouseEnter(event: Event) {
        //const {nativeElement} = this.element;
        //this.renderer.setStyle(this.element.nativeElement, 'background-color', 'yellowgreen');
        //this.renderer.addClass(nativeElement, 'white-text');
        //OR
        this.background = 'yellowgreen';
    }

    @HostListener('mouseleave') mouseLeave() {
        //const {nativeElement} = this.element;
        //this.renderer.setStyle(this.element.nativeElement, 'background-color', 'transparent');
        //this.renderer.removeClass(nativeElement, 'white-text');
        //OR
        this.background = 'transparent';
    }
}*/