import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PostcompletoComponent } from './postcompleto.component';

describe('PostcompletoComponent', () => {
  let component: PostcompletoComponent;
  let fixture: ComponentFixture<PostcompletoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PostcompletoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PostcompletoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
