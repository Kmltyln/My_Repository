export const About=()=>
{const frontendSkills=["React","Vue","TypeScript","TailwindCSS","Svelte",];
    const backendSkills=["Node.js","Python","AWS","MongoDB","GraphQL",];
    return <section id="about" className="min-h-screen flex items-center justify-center py-20">

        <div className="max-w-3xl mx-auto px-4">
        <h2 className="text-3xl font-bond mb-8 bg-gradient from-blue-500 to-cyan-400 bg-clip-text text-center">About Me</h2>

        <div className="glass rounded-xl p-8 border-white/10 border hover:-translate-y-1 transition-all ">
        <p className="text-gray-300 mb-6">
            Passionate developer with expertise in building scalable web applications and creating innovative solutions.
        </p>
        <div className="grid grid-cols-1 md:grid-cols-2 gap-6"></div>
        <div className="rounded-xl p-6 hover:-translate-y-1 transition-all"></div>
        <h3 className="text-xl font-bold mb-4">Frontend</h3>
        <div className="flex flex-wrap gap-2"></div> 
        </div>
        </div>
    </section>
};
