import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-calculator',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css'],
})
export class CalculatorComponent {
  number1: number = 0;
  number2: number = 0;
  operation: string = 'add';
  result: number = 0;

  compute() {
    switch (this.operation) {
      case 'add':
        this.result = this.number1 + this.number2;
        break;
      case 'subtract':
        this.result = this.number1 - this.number2;
        break;
      case 'multiply':
        this.result = this.number1 * this.number2;
        break;
      default:
        this.result = 0;
    }
  }
}
