// app.routes.ts
import { Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { CalculatorComponent } from './calculator/calculator.component';

export const routes: Routes = [
  { path: '', component: AppComponent },
  { path: 'calculator', component: CalculatorComponent },
];
