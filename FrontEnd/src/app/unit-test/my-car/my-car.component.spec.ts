import { MyCarComponent } from './my-car.component'
import { ComponentFixture, TestBed} from '@angular/core/testing'
import { MyCarService } from './my-car.service';

describe('MyCarComponent', () => {

  let fixture: ComponentFixture<MyCarComponent>;
  let component: MyCarComponent;
  let carService: MyCarService;

  beforeEach( () => {
    TestBed.configureTestingModule({
      declarations: [MyCarComponent]
    });

    fixture = TestBed.createComponent(MyCarComponent);
    component = fixture.debugElement.componentInstance;
    carService = fixture.debugElement.injector.get(MyCarService);
  });

  it('should create component instance', () => {
    expect(component).toBeTruthy();
  });

  it(`should render h1 tag with title 'My car header'`, () => {
    fixture.detectChanges();
    const nativeElement = fixture.debugElement.nativeElement;
    const text = nativeElement.querySelector('h1').textContent;
    expect(text).toEqual('My car header');
  })

  it('should inject carService', () => {
    fixture.detectChanges();
    expect(component.isCarVisible).toEqual(carService.getVisibility());
  })

  it('should display car if is visible', () => {
    carService.showCar();
    fixture.detectChanges();
    const nativeElement = fixture.debugElement.nativeElement;
    const text = nativeElement.querySelector('span').textContent;
    expect(text).toEqual('Car is Visible');
  })

  it('should display car if is not visible', () => {
    carService.hideCar();
    fixture.detectChanges();
    const nativeElement = fixture.debugElement.nativeElement;
    const text = nativeElement.querySelector('span').textContent;
    expect(text).not.toEqual('Car is Visible');
  })
  

});