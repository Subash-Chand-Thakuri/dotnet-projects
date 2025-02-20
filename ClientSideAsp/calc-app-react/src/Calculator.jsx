// src/Calculator.jsx
import React, { useState } from "react";

function Calculator() {
  const [number1, setNumber1] = useState("");
  const [number2, setNumber2] = useState("");
  const [operation, setOperation] = useState("+");
  const [result, setResult] = useState(null);

  const calculate = () => {
    const num1 = parseFloat(number1);
    const num2 = parseFloat(number2);
    let res;
    switch (operation) {
      case "+":
        res = num1 + num2;
        break;
      case "-":
        res = num1 - num2;
        break;
      case "*":
        res = num1 * num2;
        break;
      case "/":
        res = num1 / num2;
        break;
      default:
        res = 0;
    }
    setResult(res);
  };

  return (
    <div>
      <h1>Calculator</h1>
      <input
        type="number"
        value={number1}
        onChange={(e) => setNumber1(e.target.value)}
        placeholder="Number 1"
      />
      <select value={operation} onChange={(e) => setOperation(e.target.value)}>
        <option value="+">+</option>
        <option value="-">-</option>
        <option value="*">*</option>
        <option value="/">/</option>
      </select>
      <input
        type="number"
        value={number2}
        onChange={(e) => setNumber2(e.target.value)}
        placeholder="Number 2"
      />
      <button onClick={calculate}>Calculate</button>
      {result !== null && <h2>Result: {result}</h2>}
    </div>
  );
}

export default Calculator;
