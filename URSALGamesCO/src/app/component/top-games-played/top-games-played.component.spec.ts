import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TopGamesPlayedComponent } from './top-games-played.component';

describe('TopGamesPlayedComponent', () => {
  let component: TopGamesPlayedComponent;
  let fixture: ComponentFixture<TopGamesPlayedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TopGamesPlayedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TopGamesPlayedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
