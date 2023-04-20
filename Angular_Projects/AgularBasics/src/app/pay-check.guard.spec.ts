import { TestBed } from '@angular/core/testing';

import { PayCheckGuard } from './pay-check.guard';

describe('PayCheckGuard', () => {
  let guard: PayCheckGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(PayCheckGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
