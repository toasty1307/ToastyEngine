using System.Runtime.InteropServices;

namespace ToastyEngine.Windowing;

public struct HWND
{
}

public partial struct Monitor
{
}

public partial struct Window
{
}

public partial struct Cursor
{
}

[StructLayout(LayoutKind.Sequential)]
public partial struct VideoMode
{
    public int Width;

    public int Height;

    public int RedBits;

    public int GreenBits;

    public int BlueBits;

    public int RefreshRate;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct GammaRamp
{
    public ushort* Red;

    public ushort* Green;

    public ushort* Blue;

    public uint Size;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct Image
{
    public int Width;

    public int Height;

    public byte* Pixels;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct GamepadState
{
    public fixed byte Buttons[15];

    public fixed float Axes[6];
}