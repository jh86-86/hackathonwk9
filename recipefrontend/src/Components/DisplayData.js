import React from 'react';
import {useState, useEffect} from 'react';

const BACKEND_URL = "http://localhost:5000";

// async function loadInitialPage(state) {
//     const res = await fetch(`${BACKEND_URL}/receipes/id=${state}`);
//     const data = await res.json();
//     data.forEach(renderBook);
//   }
function DisplayData({state}){
  const[dataState,setDataState]=useState({});
  //const[title,setTitle]=useState('');

useEffect(()=> {
    async function getRecipe(){
    let response =  await fetch(`${BACKEND_URL}/recipes/${state.number}`);
    let data = await response.json();
      setDataState(data);
      console.log(data);
    //  let categoryDish= data.CategoryDish;
    //  setTitle(data.Title);
    //  let theme=   data.Theme;  
    // let prepTime= data.PrepTime;
    // let cookingTime=  data.CookingTime;
    // let portion=   data.Portion;
    // let ingredient=   data.Ingredient;
    // let instructions= data.Instructions;  
    // let picture= data.Picture ;
    }
    getRecipe();
  } ,[state]);

  
 return (
   <div id="recipe">
     <h2>{dataState.title}</h2>
     <h3>PrepTime: {dataState.prepTime}</h3>
     <p>Ingredient: {dataState.ingredient}</p>
     <p>Instruction: {dataState.instruction}</p>
     
     {/* <img src={} /> */}
    </div> 
 )
}

export default DisplayData;

// {Id:
//   CategoryDish:
//   Title:
//   Theme:
//   PrepTime:
//   CookingTime:
//   Portion:
//   Ingredient:
//   Instructions:
//   Picture :
//   },