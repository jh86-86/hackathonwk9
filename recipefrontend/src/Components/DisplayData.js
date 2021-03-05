import React from 'react';

const BACKEND_URL = "http://localhost:5000";

async function loadInitialPage() {
    const res = await fetch(`${BACKEND_URL}/receipes`);
    const data = await res.json();
    data.forEach(renderBook);
  }

useEffect(()=> {
    async function getRecipe(){
    let response =  await fetch("url...";
  let data = await response.json();
    })}
  })