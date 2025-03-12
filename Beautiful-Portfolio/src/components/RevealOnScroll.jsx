import { useEffect } from "react";
import { useRef } from "react";
export const RevealOnScroll=({children})=>
{
    
    const ref=useRef(null);
    useEffect(()=>{

    })
    return (
        <div ref={ref}className="reveal">
         {children}   </div>
    );
};