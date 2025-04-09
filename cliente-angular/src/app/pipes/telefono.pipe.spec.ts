import { TelefonoPipe } from './telefono.pipe';

describe('TelefonoPipe', () => {
  const pipe = new TelefonoPipe();

  it('formatea un número correctamente', () => {
    expect(pipe.transform('56912345678')).toBe('+569 1234 5678');
  });

  it('devuelve vacío si no hay número', () => {
    expect(pipe.transform('')).toBe('');
  });
});