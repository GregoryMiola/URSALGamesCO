import { TestBed } from '@angular/core/testing';

import { URSALGamesCOService } from './ursalgames-co.service';

describe('URSALGamesCOService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: URSALGamesCOService = TestBed.get(URSALGamesCOService);
    expect(service).toBeTruthy();
  });
});
