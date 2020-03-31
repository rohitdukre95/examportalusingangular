import { MatButtonModule, MatSliderModule } from '@angular/material';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [MatButtonModule, MatSliderModule, CommonModule],
  exports: [MatButtonModule, MatSliderModule],
  declarations: []
})
export class AngmaterialModule { }
