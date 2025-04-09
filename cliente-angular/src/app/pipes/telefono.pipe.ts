import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'telefonoFormateado' })
export class TelefonoPipe implements PipeTransform {
  transform(value: string): string {
    if (!value) return '';
    const cleaned = value.replace(/\D/g, '');
    return cleaned.replace(/^(\d{3})(\d{4})(\d{4})$/, '+$1 $2 $3');
  }
}