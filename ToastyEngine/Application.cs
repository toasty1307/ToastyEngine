using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ToastyEngine.Windowing;

namespace ToastyEngine;

public class Application
{
    public IWindow Window { get; private set; }
    
    public Application()
    {
        Window = new GlfwWindow(800, 600, "toaster");
    }
    
    public void Run()
    {
    }
}
