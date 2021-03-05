//import logo from "./logo.svg";
import "./App.css";
import React,{useReducer,useState, useEffect} from 'react';
import DisplayData from '../DisplayData';
//import FilterButton from '../Buttons/index'

const initialState = {
  number:1,
};



function App() {
 
  const [state, dispatch] = useReducer(reducer, initialState);
  console.log(state);
  
  function reducer(state, action) {
    switch (action.type) {
      case "Snacks":
        console.log("snacks button pressed");
       
        return {...state, number: action.payload};
        
      break;
      case "Beverages":
        console.log("beverages button pressed");
        return {...state, number: action.payload};
      break;
      case "Desserts":
        console.log("desserts button pressed");
        return {...state, number: action.payload};
      break;
      case "Mains":
        console.log("mains button pressed");
        return {...state, number: action.payload};
      break;
      default:
        throw new Error();
    }
  }

  //async function
  // 

  return (
    <div className="App">
      <h1>RECIPES</h1>
      <div className="Buttons">
      <button onClick={()=>{dispatch({type: "Snacks", payload:'1' })}}> Snacks</button>
      <button onClick={()=>{dispatch({type: "Beverages", payload:'2'})}}> Beverages</button>
      <button onClick={()=>{dispatch({type: "Desserts", payload: '4'})}}> Desserts</button>
      <button onClick={()=>{dispatch({type: "Mains", payload:'3'})}}> Main</button>
      <DisplayData state={state}/>
      
      </div>
    </div>
  );
}

export default App;
