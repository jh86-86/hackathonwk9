import logo from "./logo.svg";
import "./App.css";
import FilterButton from '../Buttons/index'

const initialState = {};
function App() {
  function reducer(state, action) {
    switch (action.type) {
      case "Snacks":
        // return { };

      case "Beverages":
        // return { };

      case "Desserts":
        // return { };

      case "Mains":
        // return { };

      default:
        throw new Error();
    }
  }

  return (
    <div className="App">
      <h1>Recipes</h1>
      <div className="Buttons">
      <filterButton handleClick={}/>
      <filterButton handleClick={}/>
      <filterButton handleClick={}/>
      <filterButton handleClick={}/>
      </div>
    </div>
  );
}

export default App;
