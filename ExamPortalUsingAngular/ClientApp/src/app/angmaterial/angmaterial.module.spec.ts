import { AngmaterialModule } from './angmaterial.module';

describe('AngmaterialModule', () => {
  let angmaterialModule: AngmaterialModule;

  beforeEach(() => {
    angmaterialModule = new AngmaterialModule();
  });

  it('should create an instance', () => {
    expect(angmaterialModule).toBeTruthy();
  });
});
