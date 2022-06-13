using MathSharp.StorageTypes;

namespace ToastyEngine.Windowing;

public interface IWindow
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Title { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsKeyDown(int keycode);
    public bool IsKeyUp(int keycode);
    public bool IsKeyPressed(int keycode);
    
    public bool IsKeyDown(int keycode, params int[] keys);
    public bool IsKeyUp(int keycode, params int[] keys);

    public bool IsMouseDown(int button);
    public bool IsMouseUp(int button);
    
    public bool IsMouseDown(int button, params int[] buttons);
    public bool IsMouseUp(int button, params int[] buttons);

    public Vector2F MouseScrollOffset { get; set; }
    
    public unsafe void* UserPointer { get; set; }

    public unsafe event delegate* unmanaged[Cdecl]<Window*, int, int, void> WindowPositionChanged;
    public unsafe event delegate* unmanaged[Cdecl]<Window*, int, int, void> WindowSizeChanged;
    public unsafe event delegate* unmanaged[Cdecl]<Window*, int, int, int, int, void> KeyCallback;
    public unsafe event delegate* unmanaged[Cdecl]<Window*, int, int, int, void> MouseButtonCallback;
    public unsafe event delegate* unmanaged[Cdecl]<Window*, double, double, void> CursorPositionCallback;
    public unsafe event delegate* unmanaged[Cdecl]<Window*, int, void> CursorEnterCallback;
    public unsafe event delegate* unmanaged[Cdecl]<Window*, double, double, void> MouseScrollCallback;
    public unsafe event delegate* unmanaged[Cdecl]<Window*, int, char**, void> DropCallback;

    public unsafe void* WindowIcon { get; set; }

    public void Show();
    public void Hide();
    public void Close();
}