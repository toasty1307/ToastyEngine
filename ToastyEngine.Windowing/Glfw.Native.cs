using System.Runtime.InteropServices;

namespace ToastyEngine.Windowing
{
    public static unsafe partial class Glfw
    {
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "glfwGetWin32Adapter", ExactSpelling = true)]
        public static extern sbyte* GetWin32Adapter(Monitor* monitor);

        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "glfwGetWin32Monitor", ExactSpelling = true)]
        public static extern sbyte* GetWin32Monitor(Monitor* monitor);

        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "glfwGetWin32Window", ExactSpelling = true)]
        public static extern HWND* GetWin32Window(Window* window);
    }
}
