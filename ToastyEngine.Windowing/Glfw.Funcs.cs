using System.Runtime.InteropServices;
using System.Security;

namespace ToastyEngine.Windowing;

[SuppressUnmanagedCodeSecurity]
public static partial class Glfw
{
    public const string Library =
#if Linux
"glfw"
#elif Windows
            "glfw3"
#elif OSX
"libglfw.3"
#endif
        ;

    [DllImport(Library, EntryPoint = "glfwInit", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Init();

    [DllImport(Library, EntryPoint = "glfwTerminate", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Terminate();

    [DllImport(Library, EntryPoint = "glfwGetVersion", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetVersion(int* major, int* minor, int* rev);

    [DllImport(Library, EntryPoint = "glfwInitHint", CallingConvention = CallingConvention.Cdecl)]
    public static extern void InitHint(int hint, int value);

    [DllImport(Library, EntryPoint = "glfwGetVersionString", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* GetVersionString();

    [DllImport(Library, EntryPoint = "glfwGetError", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe int GetError(byte** description);

    [DllImport(Library, EntryPoint = "glfwSetErrorCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<int, char*, void> SetErrorCallback(
        delegate* unmanaged[Cdecl]<int, char*, void> cbFun);

    [DllImport(Library, EntryPoint = "glfwGetMonitors", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe Monitor** GetMonitors(int* count);

    [DllImport(Library, EntryPoint = "glfwGetPrimaryMonitor", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe Monitor* GetPrimaryMonitor();

    [DllImport(Library, EntryPoint = "glfwGetMonitorPos", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetMonitorPos(Monitor* monitor, int* xPos, int* yPos);

    [DllImport(Library, EntryPoint = "glfwGetMonitorPhysicalSize", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetMonitorPhysicalSize(Monitor* monitor, int* widthMm, int* heightMm);

    [DllImport(Library, EntryPoint = "glfwGetMonitorWorkarea", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetMonitorWorkarea(Monitor* monitor, int* xPos, int* yPos, int* width,
        int* height);

    [DllImport(Library, EntryPoint = "glfwGetMonitorContentScale", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetMonitorContentScale(Monitor* monitor, float* xScale, float* yScale);

    [DllImport(Library, EntryPoint = "glfwGetMonitorName", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* GetMonitorName(Monitor* monitor);

    [DllImport(Library, EntryPoint = "glfwSetMonitorUserPointer", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetMonitorUserPointer(Monitor* monitor, void* userPointer);

    [DllImport(Library, EntryPoint = "glfwGetMonitorUserPointer", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void* GetMonitorUserPointer(Monitor* monitor);

    [DllImport(Library, EntryPoint = "glfwSetMonitorCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Monitor*, int, void> SetMonitorCallback(
        delegate* unmanaged[Cdecl]<Monitor*, int, void> cbFun);

    [DllImport(Library, EntryPoint = "glfwGetVideoModes", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe VideoMode** GetVideoModes(Monitor* monitor, int* count);

    [DllImport(Library, EntryPoint = "glfwGetVideoMode", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe VideoMode* GetVideoMode(Monitor* monitor);

    [DllImport(Library, EntryPoint = "glfwSetGamma", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetGamma(Monitor* monitor, float gamma);

    [DllImport(Library, EntryPoint = "glfwGetGammaRamp", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe GammaRamp* GetGammaRamp(Monitor* monitor);

    [DllImport(Library, EntryPoint = "glfwSetGammaRamp", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetGammaRamp(Monitor* monitor, GammaRamp* ramp);

    [DllImport(Library, EntryPoint = "glfwDefaultWindowHints", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DefaultWindowHints();

    [DllImport(Library, EntryPoint = "glfwWindowHint", CallingConvention = CallingConvention.Cdecl)]
    public static extern void WindowHint(WindowHints target, int hint);

    [DllImport(Library, EntryPoint = "glfwWindowHintString", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void WindowHintString(WindowHints target, byte* hint);

    [DllImport(Library, EntryPoint = "glfwCreateWindow", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe Window* CreateWindow(int width, int height, byte* title, Monitor* monitor,
        Window* share);

    [DllImport(Library, EntryPoint = "glfwDestroyWindow", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void DestroyWindow(Window* window);

    [DllImport(Library, EntryPoint = "glfwWindowShouldClose", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe int WindowShouldClose(Window* window);

    [DllImport(Library, EntryPoint = "glfwSetWindowShouldClose", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowShouldClose(Window* window, int value);

    [DllImport(Library, EntryPoint = "glfwSetWindowTitle", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowTitle(Window* window, byte* title);

    [DllImport(Library, EntryPoint = "glfwSetWindowIcon", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowIcon(Window* window, int count, Image* images);

    [DllImport(Library, EntryPoint = "glfwGetWindowPos", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetWindowPos(Window* window, int* xpos, int* ypos);

    [DllImport(Library, EntryPoint = "glfwSetWindowPos", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowPos(Window* window, int xpos, int ypos);

    [DllImport(Library, EntryPoint = "glfwGetWindowSize", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetWindowSize(Window* window, int* width, int* height);

    [DllImport(Library, EntryPoint = "glfwSetWindowSizeLimits", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowSizeLimits(Window* window, int minwidth, int minheight, int maxwidth,
        int maxheight);

    [DllImport(Library, EntryPoint = "glfwSetWindowAspectRatio", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowAspectRatio(Window* window, int numer, int denom);

    [DllImport(Library, EntryPoint = "glfwSetWindowSize", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowSize(Window* window, int width, int height);

    [DllImport(Library, EntryPoint = "glfwGetFramebufferSize", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetFramebufferSize(Window* window, int* width, int* height);

    [DllImport(Library, EntryPoint = "glfwGetWindowFrameSize", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetWindowFrameSize(Window* window, int* left, int* top, int* right,
        int* bottom);

    [DllImport(Library, EntryPoint = "glfwGetWindowContentScale", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetWindowContentScale(Window* window, float* xscale, float* yscale);

    [DllImport(Library, EntryPoint = "glfwGetWindowOpacity", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe float GetWindowOpacity(Window* window);

    [DllImport(Library, EntryPoint = "glfwSetWindowOpacity", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowOpacity(Window* window, float opacity);

    [DllImport(Library, EntryPoint = "glfwIconifyWindow", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void IconifyWindow(Window* window);

    [DllImport(Library, EntryPoint = "glfwRestoreWindow", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void RestoreWindow(Window* window);

    [DllImport(Library, EntryPoint = "glfwMaximizeWindow", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void MaximizeWindow(Window* window);

    [DllImport(Library, EntryPoint = "glfwShowWindow", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void ShowWindow(Window* window);

    [DllImport(Library, EntryPoint = "glfwHideWindow", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void HideWindow(Window* window);

    [DllImport(Library, EntryPoint = "glfwFocusWindow", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void FocusWindow(Window* window);

    [DllImport(Library, EntryPoint = "glfwRequestWindowAttention", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void RequestWindowAttention(Window* window);

    [DllImport(Library, EntryPoint = "glfwGetWindowMonitor", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe Monitor* GetWindowMonitor(Window* window);

    [DllImport(Library, EntryPoint = "glfwSetWindowMonitor", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowMonitor(Window* window, Monitor* monitor, int xpos, int ypos,
        int width, int height, int refreshRate);

    [DllImport(Library, EntryPoint = "glfwGetWindowAttrib", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe int GetWindowAttrib(Window* window, int attrib);

    [DllImport(Library, EntryPoint = "glfwSetWindowAttrib", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowAttrib(Window* window, int attrib, int value);

    [DllImport(Library, EntryPoint = "glfwSetWindowUserPointer", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetWindowUserPointer(Window* window, void* pointer);

    [DllImport(Library, EntryPoint = "glfwGetWindowUserPointer", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void* GetWindowUserPointer(Window* window);

    [DllImport(Library, EntryPoint = "glfwSetWindowPosCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, int, void> SetWindowPosCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, int, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetWindowSizeCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, int, void> SetWindowSizeCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, int, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetWindowCloseCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, void> SetWindowCloseCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetWindowRefreshCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, void> SetWindowRefreshCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetWindowFocusCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, void> SetWindowFocusCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetWindowIconifyCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, void> SetWindowIconifyCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetWindowMaximizeCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, void> SetWindowMaximizeCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetFramebufferSizeCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, int, void> SetFramebufferSizeCallback(
        Window* window, delegate* unmanaged[Cdecl]<Window*, int, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetWindowContentScaleCallback",
        CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, float, float, void> SetWindowContentScaleCallback(
        Window* window, delegate* unmanaged[Cdecl]<Window*, float, float, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwPollEvents", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PollEvents();

    [DllImport(Library, EntryPoint = "glfwWaitEvents", CallingConvention = CallingConvention.Cdecl)]
    public static extern void WaitEvents();

    [DllImport(Library, EntryPoint = "glfwWaitEventsTimeout", CallingConvention = CallingConvention.Cdecl)]
    public static extern void WaitEventsTimeout(double timeout);

    [DllImport(Library, EntryPoint = "glfwPostEmptyEvent", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PostEmptyEvent();

    [DllImport(Library, EntryPoint = "glfwGetInputMode", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe int GetInputMode(Window* window, int mode);

    [DllImport(Library, EntryPoint = "glfwSetInputMode", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetInputMode(Window* window, int mode, int value);

    [DllImport(Library, EntryPoint = "glfwRawMouseMotionSupported", CallingConvention = CallingConvention.Cdecl)]
    public static extern int RawMouseMotionSupported();

    [DllImport(Library, EntryPoint = "glfwGetKeyName", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* GetKeyName(int key, int scancode);

    [DllImport(Library, EntryPoint = "glfwGetKeyScancode", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetKeyScancode(int key);

    [DllImport(Library, EntryPoint = "glfwGetKey", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe int GetKey(Window* window, int key);

    [DllImport(Library, EntryPoint = "glfwGetMouseButton", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe int GetMouseButton(Window* window, int button);

    [DllImport(Library, EntryPoint = "glfwGetCursorPos", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void GetCursorPos(Window* window, double* xpos, double* ypos);

    [DllImport(Library, EntryPoint = "glfwSetCursorPos", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetCursorPos(Window* window, double xpos, double ypos);

    [DllImport(Library, EntryPoint = "glfwCreateCursor", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe Cursor* CreateCursor(Image* image, int xhot, int yhot);

    [DllImport(Library, EntryPoint = "glfwCreateStandardCursor", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe Cursor* CreateStandardCursor(int shape);

    [DllImport(Library, EntryPoint = "glfwDestroyCursor", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void DestroyCursor(Cursor* cursor);

    [DllImport(Library, EntryPoint = "glfwSetCursor", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetCursor(Window* window, Cursor* cursor);

    [DllImport(Library, EntryPoint = "glfwSetKeyCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, int, int, int, void> SetKeyCallback(
        Window* window, delegate* unmanaged[Cdecl]<Window*, int, int, int, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetCharCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, uint, int, void> SetCharCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, uint, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetCharModsCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, uint, int, int, void> SetCharModsCallback(
        Window* window, delegate* unmanaged[Cdecl]<Window*, uint, int, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetMouseButtonCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, int, int, void> SetMouseButtonCallback(
        Window* window, delegate* unmanaged[Cdecl]<Window*, int, int, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetCursorPosCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, double, double, void> SetCursorPosCallback(
        Window* window, delegate* unmanaged[Cdecl]<Window*, double, double, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetCursorEnterCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, void> SetCursorEnterCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, int, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetScrollCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, double, double, void> SetScrollCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, double, double, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwSetDropCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<Window*, int, char**, void> SetDropCallback(Window* window,
        delegate* unmanaged[Cdecl]<Window*, int, char*[], void> cbfun);

    [DllImport(Library, EntryPoint = "glfwJoystickPresent", CallingConvention = CallingConvention.Cdecl)]
    public static extern int JoystickPresent(int joy);

    [DllImport(Library, EntryPoint = "glfwGetJoystickAxes", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe float* GetJoystickAxes(int joy, float* axes, int numaxes);

    [DllImport(Library, EntryPoint = "glfwGetJoystickButtons", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* GetJoystickButtons(int joy, int* numbuttons);

    [DllImport(Library, EntryPoint = "glfwGetJoystickHats", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* GetJoystickHats(int joy, int* numhats);

    [DllImport(Library, EntryPoint = "glfwGetJoystickName", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* GetJoystickName(int joy);

    [DllImport(Library, EntryPoint = "glfwGetJoystickGUID", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* GetJoystickGUID(int joy);

    [DllImport(Library, EntryPoint = "glfwSetJoystickUserPointer", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetJoystickUserPointer(int joy, void* pointer);

    [DllImport(Library, EntryPoint = "glfwGetJoystickUserPointer", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void* GetJoystickUserPointer(int joy);

    [DllImport(Library, EntryPoint = "glfwSetJoystickCallback", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe delegate* unmanaged[Cdecl]<int, int, float*, byte*, byte*, void> SetJoystickCallback(
        delegate* unmanaged[Cdecl]<int, int, float*, byte*, byte*, void> cbfun);

    [DllImport(Library, EntryPoint = "glfwUpdateGamepadMappings", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void UpdateGamepadMappings(byte* @string);

    [DllImport(Library, EntryPoint = "glfwGetGamepadName", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* GetGamepadName(int joy);

    [DllImport(Library, EntryPoint = "glfwGetGamepadState", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe int GetGamepadState(int joy, GamepadState* state);

    [DllImport(Library, EntryPoint = "glfwSetClipboardString", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SetClipboardString(Window* window, byte* @string);

    [DllImport(Library, EntryPoint = "glfwGetClipboardString", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* GetClipboardString(Window* window);

    [DllImport(Library, EntryPoint = "glfwGetTime", CallingConvention = CallingConvention.Cdecl)]
    public static extern double GetTime();

    [DllImport(Library, EntryPoint = "glfwSetTime", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetTime(double time);

    [DllImport(Library, EntryPoint = "glfwGetTimerValue", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetTimerValue();

    [DllImport(Library, EntryPoint = "glfwGetTimerFrequency", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetTimerFrequency();

    [DllImport(Library, EntryPoint = "glfwMakeContextCurrent", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void MakeContextCurrent(Window* window);

    [DllImport(Library, EntryPoint = "glfwGetCurrentContext", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe Window* GetCurrentContext();

    [DllImport(Library, EntryPoint = "glfwSwapBuffers", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void SwapBuffers(Window* window);

    [DllImport(Library, EntryPoint = "glfwSwapInterval", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SwapInterval(int interval);

    [DllImport(Library, EntryPoint = "glfwExtensionSupported", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe int ExtensionSupported(byte* extension);

    [DllImport(Library, EntryPoint = "glfwGetProcAddress", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void* GetProcAddress(byte* procname);

    [DllImport(Library, EntryPoint = "glfwVulkanSupported", CallingConvention = CallingConvention.Cdecl)]
    public static extern int VulkanSupported();

    [DllImport(Library, EntryPoint = "glfwGetRequiredInstanceExtensions",
        CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte** GetRequiredInstanceExtensions(uint* count);

    [DllImport(Library, EntryPoint = "glfwGetInstanceProcAddress", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void* GetInstanceProcAddress(void* instance, byte* procname);

    [DllImport(Library, EntryPoint = "glfwGetPhysicalDevicePresentationSupport",
        CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe int GetPhysicalDevicePresentationSupport(void* instance, uint device,
        uint queuefamily);

    [DllImport(Library, EntryPoint = "glfwCreateWindowSurface", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe void* CreateWindowSurface(void* instance, Window* window, void* allocator,
        void* surface);
}