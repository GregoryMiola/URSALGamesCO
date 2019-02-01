import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DataPersistenceComponent } from './data-persistence.component';

describe('DataPersistenceComponent', () => {
  let component: DataPersistenceComponent;
  let fixture: ComponentFixture<DataPersistenceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DataPersistenceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DataPersistenceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
