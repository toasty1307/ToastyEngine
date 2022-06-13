using System.Runtime.InteropServices;
using MathSharp.StorageTypes;

namespace ToastyEngine.Windowing;

public class GlfwWindow : IWindow
{
    public readonly unsafe Window* Handle;
    
    private string _title;
    private int _width;
    private int _height;

    public unsafe GlfwWindow(int width, int height, string title)
    {
        var init = Glfw.Init();
        if (init == 0)
            throw new Exception("Failed to initialize GLFW");
        
        var titlePtr = Marshal.StringToHGlobalAnsi(title);
        Handle = Glfw.CreateWindow(width, height, (byte*) titlePtr, null, null);
        
        _title = title;
        _width = width;
        _height = height;
        
        Marshal.FreeHGlobal(titlePtr);
    }
    
    public Vector2F Position { get; set; }
    public Vector2F Size { get; set; }

    public unsafe string Title
    {
        get => _title;
        set
        {
            _title = value;
            var titlePtr = Marshal.StringToHGlobalAnsi(value);
            Glfw.SetWindowTitle(Handle, (byte*) titlePtr);
            Marshal.FreeHGlobal(titlePtr);
        }
    }

    public int X { get; set; }
    public int Y { get; set; }
    public bool IsKeyDown(int keycode)
    {
        throw new NotImplementedException();
    }

    public bool IsKeyUp(int keycode)
    {
        throw new NotImplementedException();
    }

    public bool IsKeyPressed(int keycode)
    {
        throw new NotImplementedException();
    }

    public bool IsKeyDown(int keycode, params int[] keys)
    {
        throw new NotImplementedException();
    }

    public bool IsKeyUp(int keycode, params int[] keys)
    {
        throw new NotImplementedException();
    }

    public bool IsMouseDown(int button)
    {
        throw new NotImplementedException();
    }

    public bool IsMouseUp(int button)
    {
        throw new NotImplementedException();
    }

    public bool IsMouseDown(int button, params int[] buttons)
    {
        throw new NotImplementedException();
    }

    public bool IsMouseUp(int button, params int[] buttons)
    {
        throw new NotImplementedException();
    }

    public Vector2F MouseScrollOffset { get; set; }
    public unsafe void* UserPointer { get; set; }
    public unsafe event delegate*unmanaged[Cdecl]<Window*, int, int, void>? WindowPositionChanged;
    public unsafe event delegate*unmanaged[Cdecl]<Window*, int, int, void>? WindowSizeChanged;
    public unsafe event delegate*unmanaged[Cdecl]<Window*, int, int, int, int, void>? KeyCallback;
    public unsafe event delegate*unmanaged[Cdecl]<Window*, int, int, int, void>? MouseButtonCallback;
    public unsafe event delegate*unmanaged[Cdecl]<Window*, double, double, void>? CursorPositionCallback;
    public unsafe event delegate*unmanaged[Cdecl]<Window*, int, void>? CursorEnterCallback;
    public unsafe event delegate*unmanaged[Cdecl]<Window*, double, double, void>? MouseScrollCallback;
    public unsafe event delegate*unmanaged[Cdecl]<Window*, int, char**, void>? DropCallback;
    public unsafe void* WindowIcon { get; set; }

    public unsafe int Width
    {
        get => _width;
        set => Glfw.SetWindowSize(Handle, _width = value, _height);
    }
    
    public unsafe int Height
    {
        get => _height;
        set => Glfw.SetWindowSize(Handle, _width, _height = value);
    }

    public unsafe void Show()
    {
        Glfw.ShowWindow(Handle);
    }

    public unsafe void Hide()
    {
        Glfw.HideWindow(Handle);
    }

    public unsafe void Close()
    {
        Glfw.SetWindowShouldClose(Handle, 1);
    }
}