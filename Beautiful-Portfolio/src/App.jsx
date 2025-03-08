import { useState } from "react";
import "./App.css";
import {LoadingScreen} from "./components/LoadingScreen";
import{Navbar} from "./components/Navbar";
import "./index.css";
function App() {
  const[isLoaded,setIsLoaded]=useState(false);
  const [menuOpen, setMenuOpen] = useState(false);
  return  (
    <>
    {!isLoaded && <LoadingScreen onComplete={()=>setIsLoaded(true)}/>}{""}
      <div className={'min-h-screen transition-opacity duration-700 ${isLoaded ? "opacity-100":"opacity-9"}bg-black text-gray-100'}>

<Navbar/>
      </div>
      
      
      </>
    
  );
  
}

export default App;
