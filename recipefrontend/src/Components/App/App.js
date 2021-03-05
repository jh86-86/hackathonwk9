//import logo from "./logo.svg";
import "./App.css";
import React,{useReducer,useState} from 'react';
//import FilterButton from '../Buttons/index'

const initialState = {};



function App() {
 
  const [state, dispatch] = useReducer(reducer, initialState);


  function reducer(state, action) {
    switch (action.type) {
      case "Snacks":
        // return { };
        console.log("snacks button pressed");
      break;
      case "Beverages":
        // return { };
        console.log("beverages button pressed");
      break;
      case "Desserts":
        // return { };
        console.log("desserts button pressed");
      break;
      case "Mains":
        // return { };
        console.log("mains button pressed");
      break;
      default:
        throw new Error();
    }
  }

  //async function
  // 

  return (
    <div className="App">
      <h1>Recipes</h1>
      <div className="Buttons">
      <button onClick={()=>{dispatch({type: "Snacks"})}}> Snacks</button>
      <button onClick={()=>{dispatch({type: "Beverages"})}}> Beverages</button>
      <button onClick={()=>{dispatch({type: "Desserts"})}}> Desserts</button>
      <button onClick={()=>{dispatch({type: "Mains"})}}> Main</button>
      
      </div>
    </div>
  );
}

export default App;
