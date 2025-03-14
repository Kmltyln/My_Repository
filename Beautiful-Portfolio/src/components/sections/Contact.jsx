import {RevealOnScroll} from "../RevealOnScroll";
import emailjs from 'emailjs-com'
export const Contact=()=>{

const SERVICE_ID="service_jct65jb"
const TEMPLATE_ID=" "
const handleSubmit=(e)=>{
    e.preventDefault()
    emailjs.sendForm()
}

    return <section id="contact" className="min-h-screen flex items-center justify-center py-20">
        <RevealOnScroll>
<div>
<div className="px-4 w-150"> 
<h2 className="text-3xl font-bold mb-8 bg-gradient-to-r from-blue-500 to-cyan-400 bg-clip-text text-transparent text-center">
    {""}
Get In Touch     
</h2>
<form className="space-y-6">
    <div className="relative">
        <input type="text" 
        id="name"name="name"
         required className="w-full bg-white/5 border border-white/10 rounded px-4 py-3 text-white transition focus:outline-none focus:border-blue focus:bg-blue-500/5"/>
        placeholder="Name..."
         />
        </div> 


</form>


</div>


</div>


        </RevealOnScroll>



    </section>
}