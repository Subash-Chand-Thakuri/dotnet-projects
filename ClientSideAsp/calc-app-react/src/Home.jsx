// src/Home.jsx
import React from "react";
import { Link } from "react-router-dom";

function Home() {
  return (
    <div>
      <h1>Welcome to the Calculator App</h1>
      <Link to="/calculator">Go to Calculator</Link>
    </div>
  );
}

export default Home;
