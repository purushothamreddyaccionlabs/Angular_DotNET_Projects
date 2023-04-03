import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuydialogboxComponent } from './buydialogbox.component';

describe('BuydialogboxComponent', () => {
  let component: BuydialogboxComponent;
  let fixture: ComponentFixture<BuydialogboxComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BuydialogboxComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BuydialogboxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
