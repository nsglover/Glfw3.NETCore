using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace glfw3
{
    public static class Glfw
    {
#if MACOS
        private const string Glfw3Dll = "libglfw.dylib";
#elif LINUX
        private const string Glfw3Dll = "libglfw.so.3.3";
#elif WINDOWS
        private const string Glfw3Dll = "glfw3.dll";
#endif

        #region Enum

        public const int VersionMajor = 3;
        public const int VersionMinor = 3;
        public const int VersionRevision = 0;
        public const int True = 1;
        public const int False = 0;
        public const int Release = 0;
        public const int Press = 1;
        public const int Repeat = 2;
        public const byte HatCentered = 0;
        public const byte HatUp = 1;
        public const byte HatRight = 2;
        public const byte HatDown = 4;
        public const byte HatLeft = 8;
        public const byte HatRightUp = HatRight | HatUp;
        public const byte HatRightDown = HatRight | HatDown;
        public const byte HatLeftUp = HatLeft | HatUp;
        public const byte HatLeftDown = HatLeft | HatDown;
        public const int KeyUnknown = -1;
        public const int KeySpace = 32;
        public const int KeyApostrophe = 39; /* ' */
        public const int KeyComma = 44; /* , */
        public const int KeyMinus = 45; /* - */
        public const int KeyPeriod = 46; /* . */
        public const int KeySlash = 47; /* / */
        public const int Key0 = 48;
        public const int Key1 = 49;
        public const int Key2 = 50;
        public const int Key3 = 51;
        public const int Key4 = 52;
        public const int Key5 = 53;
        public const int Key6 = 54;
        public const int Key7 = 55;
        public const int Key8 = 56;
        public const int Key9 = 57;
        public const int KeySemicolon = 59; /* ; */
        public const int KeyEqual = 61; /* = */
        public const int KeyA = 65;
        public const int KeyB = 66;
        public const int KeyC = 67;
        public const int KeyD = 68;
        public const int KeyE = 69;
        public const int KeyF = 70;
        public const int KeyG = 71;
        public const int KeyH = 72;
        public const int KeyI = 73;
        public const int KeyJ = 74;
        public const int KeyK = 75;
        public const int KeyL = 76;
        public const int KeyM = 77;
        public const int KeyN = 78;
        public const int KeyO = 79;
        public const int KeyP = 80;
        public const int KeyQ = 81;
        public const int KeyR = 82;
        public const int KeyS = 83;
        public const int KeyT = 84;
        public const int KeyU = 85;
        public const int KeyV = 86;
        public const int KeyW = 87;
        public const int KeyX = 88;
        public const int KeyY = 89;
        public const int KeyZ = 90;
        public const int KeyLeftBracket = 91; /* [ */
        public const int KeyBackslash = 92; /* \ */
        public const int KeyRightBracket = 93; /* ] */
        public const int KeyGraveAccent = 96; /* ` */
        public const int KeyWorld1 = 161; /* non-US#1 */
        public const int KeyWorld2 = 162; /* non-US#2 */
        public const int KeyEscape = 256;
        public const int KeyEnter = 257;
        public const int KeyTab = 258;
        public const int KeyBackspace = 259;
        public const int KeyInsert = 260;
        public const int KeyDelete = 261;
        public const int KeyRight = 262;
        public const int KeyLeft = 263;
        public const int KeyDown = 264;
        public const int KeyUp = 265;
        public const int KeyPageUp = 266;
        public const int KeyPageDown = 267;
        public const int KeyHome = 268;
        public const int KeyEnd = 269;
        public const int KeyCapsLock = 280;
        public const int KeyScrollLock = 281;
        public const int KeyNumLock = 282;
        public const int KeyPrintScreen = 283;
        public const int KeyPause = 284;
        public const int KeyF1 = 290;
        public const int KeyF2 = 291;
        public const int KeyF3 = 292;
        public const int KeyF4 = 293;
        public const int KeyF5 = 294;
        public const int KeyF6 = 295;
        public const int KeyF7 = 296;
        public const int KeyF8 = 297;
        public const int KeyF9 = 298;
        public const int KeyF10 = 299;
        public const int KeyF11 = 300;
        public const int KeyF12 = 301;
        public const int KeyF13 = 302;
        public const int KeyF14 = 303;
        public const int KeyF15 = 304;
        public const int KeyF16 = 305;
        public const int KeyF17 = 306;
        public const int KeyF18 = 307;
        public const int KeyF19 = 308;
        public const int KeyF20 = 309;
        public const int KeyF21 = 310;
        public const int KeyF22 = 311;
        public const int KeyF23 = 312;
        public const int KeyF24 = 313;
        public const int KeyF25 = 314;
        public const int KeyKp0 = 320;
        public const int KeyKp1 = 321;
        public const int KeyKp2 = 322;
        public const int KeyKp3 = 323;
        public const int KeyKp4 = 324;
        public const int KeyKp5 = 325;
        public const int KeyKp6 = 326;
        public const int KeyKp7 = 327;
        public const int KeyKp8 = 328;
        public const int KeyKp9 = 329;
        public const int KeyKpDecimal = 330;
        public const int KeyKpDivide = 331;
        public const int KeyKpMultiply = 332;
        public const int KeyKpSubtract = 333;
        public const int KeyKpAdd = 334;
        public const int KeyKpEnter = 335;
        public const int KeyKpEqual = 336;
        public const int KeyLeftShift = 340;
        public const int KeyLeftControl = 341;
        public const int KeyLeftAlt = 342;
        public const int KeyLeftSuper = 343;
        public const int KeyRightShift = 344;
        public const int KeyRightControl = 345;
        public const int KeyRightAlt = 346;
        public const int KeyRightSuper = 347;
        public const int KeyMenu = 348;
        public const int KeyLast = KeyMenu;
        public const int ModShift = 0x0001;
        public const int ModControl = 0x0002;
        public const int ModAlt = 0x0004;
        public const int ModSuper = 0x0008;
        public const int ModCapsLock = 0x0010;
        public const int ModNumLock = 0x0020;
        public const int MouseButton1 = 0;
        public const int MouseButton2 = 1;
        public const int MouseButton3 = 2;
        public const int MouseButton4 = 3;
        public const int MouseButton5 = 4;
        public const int MouseButton6 = 5;
        public const int MouseButton7 = 6;
        public const int MouseButton8 = 7;
        public const int MouseButtonLast = MouseButton8;
        public const int MouseButtonLeft = MouseButton1;
        public const int MouseButtonRight = MouseButton2;
        public const int MouseButtonMiddle = MouseButton3;
        public const int Joystick1 = 0;
        public const int Joystick2 = 1;
        public const int Joystick3 = 2;
        public const int Joystick4 = 3;
        public const int Joystick5 = 4;
        public const int Joystick6 = 5;
        public const int Joystick7 = 6;
        public const int Joystick8 = 7;
        public const int Joystick9 = 8;
        public const int Joystick10 = 9;
        public const int Joystick11 = 10;
        public const int Joystick12 = 11;
        public const int Joystick13 = 12;
        public const int Joystick14 = 13;
        public const int Joystick15 = 14;
        public const int Joystick16 = 15;
        public const int JoystickLast = Joystick16;
        public const int GamepadButtonA = 0;
        public const int GamepadButtonB = 1;
        public const int GamepadButtonX = 2;
        public const int GamepadButtonY = 3;
        public const int GamepadButtonLeftBumper = 4;
        public const int GamepadButtonRightBumper = 5;
        public const int GamepadButtonBack = 6;
        public const int GamepadButtonStart = 7;
        public const int GamepadButtonGuide = 8;
        public const int GamepadButtonLeftThumb = 9;
        public const int GamepadButtonRightThumb = 10;
        public const int GamepadButtonDpadUp = 11;
        public const int GamepadButtonDpadRight = 12;
        public const int GamepadButtonDpadDown = 13;
        public const int GamepadButtonDpadLeft = 14;
        public const int GamepadButtonLast = GamepadButtonDpadLeft;
        public const int GamepadButtonCross = GamepadButtonA;
        public const int GamepadButtonCircle = GamepadButtonB;
        public const int GamepadButtonSquare = GamepadButtonX;
        public const int GamepadButtonTriangle = GamepadButtonY;
        public const int GamepadAxisLeftX = 0;
        public const int GamepadAxisLeftY = 1;
        public const int GamepadAxisRightX = 2;
        public const int GamepadAxisRightY = 3;
        public const int GamepadAxisLeftTrigger = 4;
        public const int GamepadAxisRightTrigger = 5;
        public const int GamepadAxisLast = GamepadAxisRightTrigger;
        public const int NoError = 0;
        public const int NotInitialized = 0x00010001;
        public const int NoCurrentContext = 0x00010002;
        public const int InvalidEnum = 0x00010003;
        public const int InvalidValue = 0x00010004;
        public const int OutOfMemory = 0x00010005;
        public const int ApiUnavailable = 0x00010006;
        public const int VersionUnavailable = 0x00010007;
        public const int PlatformError = 0x00010008;
        public const int FormatUnavailable = 0x00010009;
        public const int NoWindowContext = 0x0001000A;
        public const int Focused = 0x00020001;
        public const int Iconified = 0x00020002;
        public const int Resizable = 0x00020003;
        public const int Visible = 0x00020004;
        public const int Decorated = 0x00020005;
        public const int AutoIconify = 0x00020006;
        public const int Floating = 0x00020007;
        public const int Maximized = 0x00020008;
        public const int CenterCursor = 0x00020009;
        public const int TransparentFramebuffer = 0x0002000A;
        public const int Hovered = 0x0002000B;
        public const int FocusOnShow = 0x0002000C;
        public const int RedBits = 0x00021001;
        public const int GreenBits = 0x00021002;
        public const int BlueBits = 0x00021003;
        public const int AlphaBits = 0x00021004;
        public const int DepthBits = 0x00021005;
        public const int StencilBits = 0x00021006;
        public const int AccumRedBits = 0x00021007;
        public const int AccumGreenBits = 0x00021008;
        public const int AccumBlueBits = 0x00021009;
        public const int AccumAlphaBits = 0x0002100A;
        public const int AuxBuffers = 0x0002100B;
        public const int Stereo = 0x0002100C;
        public const int Samples = 0x0002100D;
        public const int SrgbCapable = 0x0002100E;
        public const int RefreshRate = 0x0002100F;
        public const int Doublebuffer = 0x00021010;
        public const int ClientApi = 0x00022001;
        public const int ContextVersionMajor = 0x00022002;
        public const int ContextVersionMinor = 0x00022003;
        public const int ContextRevision = 0x00022004;
        public const int ContextRobustness = 0x00022005;
        public const int OpenglForwardCompat = 0x00022006;
        public const int OpenglDebugContext = 0x00022007;
        public const int OpenglProfile = 0x00022008;
        public const int ContextReleaseBehavior = 0x00022009;
        public const int ContextNoError = 0x0002200A;
        public const int ContextCreationApi = 0x0002200B;
        public const int ScaleToMonitor = 0x0002200C;
        public const int CocoaRetinaFramebuffer = 0x00023001;
        public const int CocoaFrameName = 0x00023002;
        public const int CocoaGraphicsSwitching = 0x00023003;
        public const int X11ClassName = 0x00024001;
        public const int X11InstanceName = 0x00024002;
        public const int NoApi = 0;
        public const int OpenglApi = 0x00030001;
        public const int OpenglEsApi = 0x00030002;
        public const int NoRobustness = 0;
        public const int NoResetNotification = 0x00031001;
        public const int LoseContextOnReset = 0x00031002;
        public const int OpenglAnyProfile = 0;
        public const int OpenglCoreProfile = 0x00032001;
        public const int OpenglCompatProfile = 0x00032002;
        public const int Cursor = 0x00033001;
        public const int StickyKeys = 0x00033002;
        public const int StickyMouseButtons = 0x00033003;
        public const int LockKeyMods = 0x00033004;
        public const int RawMouseMotion = 0x00033005;
        public const int CursorNormal = 0x00034001;
        public const int CursorHidden = 0x00034002;
        public const int CursorDisabled = 0x00034003;
        public const int AnyReleaseBehavior = 0;
        public const int ReleaseBehaviorFlush = 0x00035001;
        public const int ReleaseBehaviorNone = 0x00035002;
        public const int NativeContextApi = 0x00036001;
        public const int EglContextApi = 0x00036002;
        public const int OsmesaContextApi = 0x00036003;
        public const int ArrowCursor = 0x00036001;
        public const int IbeamCursor = 0x00036002;
        public const int CrosshairCursor = 0x00036003;
        public const int HandCursor = 0x00036004;
        public const int HresizeCursor = 0x00036005;
        public const int VresizeCursor = 0x00036006;
        public const int Connected = 0x00040001;
        public const int Disconnected = 0x00040002;
        public const int JoystickHatButtons = 0x00050001;
        public const int CocoaChdirResources = 0x00051001;
        public const int CocoaMenubar = 0x00051002;
        public const int DontCare = -1;

        #endregion

        #region Delegates

        public delegate void ErrorFun(int error, string description);

        public delegate void WindowPosFun(IntPtr window, int xpos, int ypos);

        public delegate void WindowSizeFun(IntPtr window, int width, int height);

        public delegate void WindowCloseFun(IntPtr window);

        public delegate void WindowRefreshFun(IntPtr window);

        public delegate void WindowFocusFun(IntPtr window, int focused);

        public delegate void WindowIconifyFun(IntPtr window, int iconified);

        public delegate void FramebufferSizeFun(IntPtr window, int width, int height);

        public delegate void MouseButtonFun(IntPtr window, int button, int action, int mods);

        public delegate void CursorPosFun(IntPtr window, double xpos, double ypos);

        public delegate void CursorEnterFun(IntPtr window, int entered);

        public delegate void ScrollFun(IntPtr window, double xoffset, double yoffset);

        public delegate void KeyFun(IntPtr window, int key, int scancode, int action, int mods);

        public delegate void CharFun(IntPtr window, uint codepoint);

        [Obsolete]
        public delegate void CharModsFun(IntPtr window, uint codepoint, int mods);

        private unsafe delegate void UnmanagedDropFun(IntPtr window, int count, sbyte** paths);

        public delegate void DropFun(IntPtr window, int count, string[] paths);

        public delegate void MonitorFun(IntPtr monitor, int connectionEvent);

        public delegate void JoystickFun(int joy, int connectionEvent);

        public delegate void WindowMaximizeFun(IntPtr window, int maximized);

        public delegate void WindowContentScaleFun(IntPtr window, float xscale, float yscale);

        #endregion

        #region Structs

        [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
        [StructLayout(LayoutKind.Sequential)]
        public struct VidMode
        {
            public readonly int Width;
            public readonly int Height;
            public readonly int RedBits;
            public readonly int GreenBits;
            public readonly int BlueBits;
            public readonly int RefreshRate;
        }

        [StructLayout(LayoutKind.Sequential)]
        private unsafe struct UnmanagedGammaRamp
        {
            internal ushort* red;
            internal ushort* green;
            internal ushort* blue;
            [MarshalAs(UnmanagedType.U4)] internal uint size;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GammaRamp
        {
            public ushort[] Red;
            public ushort[] Green;
            public ushort[] Blue;
            public uint Size;
        }

        [StructLayout(LayoutKind.Sequential)]
        private unsafe struct UnmanagedImage
        {
            internal int width;
            internal int height;
            internal byte* pixels;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Image
        {
            public readonly int Width;
            public readonly int Height;
            public readonly byte[] Pixels;
        }

        [StructLayout(LayoutKind.Sequential)]
        private unsafe struct UnmanagedGamepadState
        {
            internal fixed byte buttons[15];
            internal fixed float axes[6];
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GamepadState
        {
            public readonly byte[] Buttons;
            public readonly float[] Axes;

            internal GamepadState(byte[] buttons, float[] axes)
            {
                Buttons = buttons;
                Axes = axes;
            }
        }

        #endregion

        #region Functions

        [DllImport(Glfw3Dll, EntryPoint = "glfwInit")]
        public static extern int Init();

        [DllImport(Glfw3Dll, EntryPoint = "glfwTerminate")]
        public static extern void Terminate();

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetVersion")]
        public static extern void GetVersion(out int major, out int minor, out int rev);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetVersionString")]
        private static extern IntPtr _GetVersionString();

        public static string GetVersionString() => Marshal.PtrToStringAnsi(_GetVersionString());

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetErrorCallback")]
        private static extern void _SetErrorCallback(ErrorFun cbfun);

        private static ErrorFun currentErrorFun;

        public static void SetErrorCallback(ErrorFun cbfun)
        {
            currentErrorFun = cbfun;
            _SetErrorCallback(currentErrorFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetMonitors")]
        private static extern IntPtr _GetMonitors(out int count);

        public static IntPtr[] GetMonitors(out int count)
        {
            var rawMonitors = _GetMonitors(out int num);
            count = num;
            var monitors = new IntPtr[num];
            Marshal.Copy(rawMonitors, monitors, 0, num);
            return monitors;
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetPrimaryMonitor")]
        public static extern IntPtr GetPrimaryMonitor();

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetMonitorPos")]
        public static extern void GetMonitorPos(IntPtr monitor, out int xpos, out int ypos);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetMonitorPhysicalSize")]
        public static extern void GetMonitorPhysicalSize(IntPtr monitor, out int widthMm, out int heightMm);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetMonitorName")]
        private static extern IntPtr _GetMonitorName(IntPtr monitor);

        public static string GetMonitorName(IntPtr monitor) => Marshal.PtrToStringAnsi(_GetMonitorName(monitor));

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetMonitorCallback")]
        private static extern void _SetMonitorCallback(MonitorFun cbfun);

        private static MonitorFun currentMonitorFun;

        public static void SetMonitorCallback(MonitorFun cbfun)
        {
            currentMonitorFun = cbfun;
            _SetMonitorCallback(currentMonitorFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetVideoModes")]
        private static extern IntPtr _GetVideoModes(IntPtr monitor, out int count);

        public static VidMode[] GetVideoModes(IntPtr monitor, out int count)
        {
            var rawVidModes = _GetVideoModes(monitor, out int num);
            count = num;
            var vidModes = new VidMode[num];
            for(int i = 0; i < vidModes.Length; i++)
            {
                vidModes[i] = Marshal.PtrToStructure<VidMode>(rawVidModes + i * Marshal.SizeOf<VidMode>());
            }

            return vidModes;
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetVideoMode")]
        private static extern IntPtr _GetVideoMode(IntPtr monitor);

        public static VidMode GetVideoMode(IntPtr monitor) => Marshal.PtrToStructure<VidMode>(_GetVideoMode(monitor));

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetGamma")]
        public static extern void SetGamma(IntPtr monitor, float gamma);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetGammaRamp")]
        private static extern unsafe UnmanagedGammaRamp* _GetGammaRamp(IntPtr monitor);

        public static GammaRamp GetGammaRamp(IntPtr monitor)
        {
            unsafe
            {
                var internalRamp = _GetGammaRamp(monitor);

                var ramp = new GammaRamp
                {
                    Red = new ushort[internalRamp->size],
                    Green = new ushort[internalRamp->size],
                    Blue = new ushort[internalRamp->size],
                    Size = internalRamp->size
                };

                for(uint i = 0; i < ramp.Size; i++)
                {
                    ramp.Red[i] = internalRamp->red[i];
                    ramp.Green[i] = internalRamp->green[i];
                    ramp.Blue[i] = internalRamp->blue[i];
                }

                return ramp;
            }
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetGammaRamp")]
        private static extern void _SetGammaRamp(IntPtr monitor, IntPtr ramp);

        public static void SetGammaRamp(IntPtr monitor, ref GammaRamp ramp)
        {
            unsafe
            {
                fixed(ushort* rampRed = ramp.Red, rampGreen = ramp.Green, rampBlue = ramp.Blue)
                {
                    var internalRamp = new UnmanagedGammaRamp {red = rampRed, green = rampGreen, blue = rampBlue, size = ramp.Size};
                    _SetGammaRamp(monitor, new IntPtr(&internalRamp));
                }
            }
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwDefaultWindowHints")]
        public static extern void DefaultWindowHints();
        
        [DllImport(Glfw3Dll, EntryPoint = "glfwWindowHint")]
        public static extern void WindowHint(int hint, int value);

        [DllImport(Glfw3Dll, EntryPoint = "glfwCreateWindow")]
        public static extern IntPtr CreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);

        [DllImport(Glfw3Dll, EntryPoint = "glfwDestroyWindow")]
        public static extern void DestroyWindow(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwWindowShouldClose")]
        public static extern int WindowShouldClose(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowShouldClose")]
        public static extern void SetWindowShouldClose(IntPtr window, int value);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowTitle")]
        public static extern void SetWindowTitle(IntPtr window, string title);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowIcon")]
        private static extern void _SetWindowIcon(IntPtr window, int count, IntPtr images);

        public static void SetWindowIcon(IntPtr window, int count, Image[] images)
        {
            unsafe
            {
                var internalImages = new UnmanagedImage[images.Length];
                for(int i = 0; i < internalImages.Length; i++)
                {
                    fixed(byte* pixels = images[i].Pixels)
                    {
                        internalImages[i] = new UnmanagedImage {width = images[i].Width, height = images[i].Height, pixels = pixels};
                    }
                }

                fixed(UnmanagedImage* arrayPtr = internalImages)
                {
                    _SetWindowIcon(window, count, new IntPtr(arrayPtr));
                }
            }
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetWindowPos")]
        public static extern void GetWindowPos(IntPtr window, out int xpos, out int ypos);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowPos")]
        public static extern void SetWindowPos(IntPtr window, int xpos, int ypos);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetWindowSize")]
        public static extern void GetWindowSize(IntPtr window, out int width, out int height);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowSizeLimits")]
        public static extern void SetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowAspectRatio")]
        public static extern void SetWindowAspectRatio(IntPtr window, int numer, int denom);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowSize")]
        public static extern void SetWindowSize(IntPtr window, int width, int height);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetFramebufferSize")]
        public static extern void GetFramebufferSize(IntPtr window, out int width, out int height);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetWindowFrameSize")]
        public static extern void GetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

        [DllImport(Glfw3Dll, EntryPoint = "glfwIconifyWindow")]
        public static extern void IconifyWindow(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwRestoreWindow")]
        public static extern void RestoreWindow(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwMaximizeWindow")]
        public static extern void MaximizeWindow(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwShowWindow")]
        public static extern void ShowWindow(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwHideWindow")]
        public static extern void HideWindow(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwFocusWindow")]
        public static extern void FocusWindow(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetWindowMonitor")]
        public static extern IntPtr GetWindowMonitor(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowMonitor")]
        public static extern void SetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetWindowAttrib")]
        public static extern int GetWindowAttrib(IntPtr window, int attrib);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowUserPointer")]
        public static extern void SetWindowUserPointer(IntPtr window, IntPtr pointer);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetWindowUserPointer")]
        public static extern IntPtr GetWindowUserPointer(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowPosCallback")]
        private static extern void _SetWindowPosCallback(IntPtr window, WindowPosFun cbfun);

        private static WindowPosFun currentWindowPosFun;
        
        public static void SetWindowPosCallback(IntPtr window, WindowPosFun cbfun)
        {
            currentWindowPosFun = cbfun;
            _SetWindowPosCallback(window, currentWindowPosFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowSizeCallback")]
        private static extern void _SetWindowSizeCallback(IntPtr window, WindowSizeFun cbfun);

        private static WindowSizeFun currentWindowSizeFun;

        public static void SetWindowSizeCallback(IntPtr window, WindowSizeFun cbfun)
        {
            currentWindowSizeFun = cbfun;
            _SetWindowSizeCallback(window, currentWindowSizeFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowCloseCallback")]
        private static extern void _SetWindowCloseCallback(IntPtr window, WindowCloseFun cbfun);

        private static WindowCloseFun currentWindowCloseFun;

        public static void SetWindowCloseCallback(IntPtr window, WindowCloseFun cbfun)
        {
            currentWindowCloseFun = cbfun;
            _SetWindowCloseCallback(window, currentWindowCloseFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowRefreshCallback")]
        private static extern void _SetWindowRefreshCallback(IntPtr window, WindowRefreshFun cbfun);

        private static WindowRefreshFun currentWindowRefreshFun;

        public static void SetWindowRefreshCallback(IntPtr window, WindowRefreshFun cbfun)
        {
            currentWindowRefreshFun = cbfun;
            _SetWindowRefreshCallback(window, currentWindowRefreshFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowFocusCallback")]
        private static extern void _SetWindowFocusCallback(IntPtr window, WindowFocusFun cbfun);

        private static WindowFocusFun currentWindowFocusFun;

        public static void SetWindowFocusCallback(IntPtr window, WindowFocusFun cbfun)
        {
            currentWindowFocusFun = cbfun;
            _SetWindowFocusCallback(window, currentWindowFocusFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowIconifyCallback")]
        private static extern void _SetWindowIconifyCallback(IntPtr window, WindowIconifyFun cbfun);

        private static WindowIconifyFun currentWindowIconifyFun;

        public static void SetWindowIconifyCallback(IntPtr window, WindowIconifyFun cbfun)
        {
            currentWindowIconifyFun = cbfun;
            _SetWindowIconifyCallback(window, currentWindowIconifyFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetFramebufferSizeCallback")]
        private static extern void _SetFramebufferSizeCallback(IntPtr window, FramebufferSizeFun cbfun);

        private static FramebufferSizeFun currentFramebufferSizeFun;

        public static void SetFramebufferSizeCallback(IntPtr window, FramebufferSizeFun cbfun)
        {
            currentFramebufferSizeFun = cbfun;
            _SetFramebufferSizeCallback(window, cbfun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwPollEvents")]
        public static extern void PollEvents();

        [DllImport(Glfw3Dll, EntryPoint = "glfwWaitEvents")]
        public static extern void WaitEvents();

        [DllImport(Glfw3Dll, EntryPoint = "glfwWaitEvents")]
        public static extern void WaitEventsTimeout(double timeout);

        [DllImport(Glfw3Dll, EntryPoint = "glfwPostEmptyEvent")]
        public static extern void PostEmptyEvent();

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetInputMode")]
        public static extern int GetInputMode(IntPtr window, int mode);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetInputMode")]
        public static extern void SetInputMode(IntPtr window, int mode, int value);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetKeyName")]
        private static extern IntPtr _GetKeyName(int key, int scancode);

        public static string GetKeyName(int key, int scancode) => Marshal.PtrToStringAnsi(_GetKeyName(key, scancode));

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetKey")]
        public static extern int GetKey(IntPtr window, int key);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetMouseButton")]
        public static extern int GetMouseButton(IntPtr window, int button);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetCursorPos")]
        public static extern void GetCursorPos(IntPtr window, out double xpos, out double ypos);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetCursorPos")]
        public static extern void SetCursorPos(IntPtr window, double xpos, double ypos);

        [DllImport(Glfw3Dll, EntryPoint = "glfwCreateCursor")]
        private static extern IntPtr _CreateCursor(IntPtr image, int xhot, int yhot);

        public static IntPtr CreateCursor(Image image, int xhot, int yhot)
        {
            unsafe
            {
                fixed(byte* pixels = image.Pixels)
                {
                    var internalImage = new UnmanagedImage {width = image.Width, height = image.Height, pixels = pixels};
                    return _CreateCursor(new IntPtr(&internalImage), xhot, yhot);
                }
            }
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwCreateStandardCursor")]
        public static extern IntPtr CreateStandardCursor(int shape);

        [DllImport(Glfw3Dll, EntryPoint = "glfwDestroyCursor")]
        public static extern void DestroyCursor(IntPtr cursor);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetCursor")]
        public static extern void SetCursor(IntPtr window, IntPtr cursor);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetKeyCallback")]
        private static extern void _SetKeyCallback(IntPtr window, KeyFun cbfun);

        private static KeyFun currentKeyFun;

        public static void SetKeyCallback(IntPtr window, KeyFun cbfun)
        {
            currentKeyFun = cbfun;
            _SetKeyCallback(window, currentKeyFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetCharCallback")]
        private static extern void _SetCharCallback(IntPtr window, CharFun cbfun);

        private static CharFun currentCharFun;

        public static void SetCharCallback(IntPtr window, CharFun cbfun)
        {
            currentCharFun = cbfun;
            _SetCharCallback(window, currentCharFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetCharModsCallback")]
        private static extern void _SetCharModsCallback(IntPtr window, CharModsFun cbfun);

        private static CharModsFun currentCharModsFun;

        [Obsolete]
        public static void SetCharModsCallback(IntPtr window, CharModsFun cbfun)
        {
            currentCharModsFun = cbfun;
            _SetCharModsCallback(window, currentCharModsFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetMouseButtonCallback")]
        private static extern void _SetMouseButtonCallback(IntPtr window, MouseButtonFun cbfun);

        private static MouseButtonFun currentMouseButtonFun;

        public static void SetMouseButtonCallback(IntPtr window, MouseButtonFun cbfun)
        {
            currentMouseButtonFun = cbfun;
            _SetMouseButtonCallback(window, currentMouseButtonFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetCursorPosCallback")]
        private static extern void _SetCursorPosCallback(IntPtr window, CursorPosFun cbfun);

        private static CursorPosFun currentCursorPosFun;

        public static void SetCursorPosCallback(IntPtr window, CursorPosFun cbfun)
        {
            currentCursorPosFun = cbfun;
            _SetCursorPosCallback(window, currentCursorPosFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetCursorEnterCallback")]
        private static extern void _SetCursorEnterCallback(IntPtr window, CursorEnterFun cbfun);

        private static CursorEnterFun currentCursorEnterFun;

        public static void SetCursorEnterCallback(IntPtr window, CursorEnterFun cbfun)
        {
            currentCursorEnterFun = cbfun;
            _SetCursorEnterCallback(window, currentCursorEnterFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetScrollCallback")]
        private static extern void _SetScrollCallback(IntPtr window, ScrollFun cbfun);

        private static ScrollFun currentScrollFun;

        public static void SetScrollCallback(IntPtr window, ScrollFun cbfun)
        {
            currentScrollFun = cbfun;
            _SetScrollCallback(window, currentScrollFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetDropCallback")]
        private static extern void _SetDropCallback(IntPtr window, UnmanagedDropFun cbfun);

        private static UnmanagedDropFun currentDropFun;

        public static void SetDropCallback(IntPtr window, DropFun cbfun)
        {
            unsafe
            {
                void DropFun(IntPtr win, int count, sbyte** paths)
                {
                    var pathArray = new string[count];

                    for(int i = 0; i < count; i++)
                    {
                        pathArray[i] = new string(*(paths + i));
                    }

                    cbfun(win, count, pathArray);
                }

                //Prevents DropFun from being garbage collected
                currentDropFun = DropFun;

                _SetDropCallback(window, currentDropFun);
            }
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwJoystickPresent")]
        public static extern int JoystickPresent(int joy);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetJoystickAxes")]
        private static extern unsafe float* _GetJoystickAxes(int joy, out int count);

        public static float[] GetJoystickAxes(int joy, out int count)
        {
            unsafe
            {
                var arrayPtr = _GetJoystickAxes(joy, out count);
                var axes = new float[count];

                for(int i = 0; i < count; i++)
                {
                    axes[i] = *arrayPtr;
                    arrayPtr++;
                }

                return axes;
            }
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetJoystickButtons")]
        private static extern unsafe byte* _GetJoystickButtons(int joy, out int count);

        public static byte[] GetJoystickButtons(int joy, out int count)
        {
            unsafe
            {
                var arrayPtr = _GetJoystickButtons(joy, out count);
                var buttonStates = new byte[count];

                for(int i = 0; i < count; i++)
                {
                    buttonStates[i] = *arrayPtr;
                    arrayPtr++;
                }

                return buttonStates;
            }
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetJoystickName")]
        private static extern IntPtr _GetJoystickName(int joy);

        public static string GetJoystickName(int joy) => Marshal.PtrToStringAnsi(_GetJoystickName(joy));

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetJoystickCallback")]
        private static extern void _SetJoystickCallback(JoystickFun cbfun);

        private static JoystickFun currentJoystickFun;

        public static void SetJoystickCallback(JoystickFun cbfun)
        {
            currentJoystickFun = cbfun;
            _SetJoystickCallback(currentJoystickFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetClipboardString")]
        public static extern void SetClipboardString(IntPtr window, string str);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetClipboardString")]
        private static extern IntPtr _GetClipboardString(IntPtr window);

        public static string GetClipboardString(IntPtr window) => Marshal.PtrToStringAnsi(_GetClipboardString(window));

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetTime")]
        public static extern double GetTime();

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetTime")]
        public static extern void SetTime(double time);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetTimerValue")]
        public static extern ulong GetTimerValue();

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetTimerFrequency")]
        public static extern ulong GetTimerFrequency();

        [DllImport(Glfw3Dll, EntryPoint = "glfwMakeContextCurrent")]
        public static extern void MakeContextCurrent(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetCurrentContext")]
        public static extern IntPtr GetCurrentContext();

        [DllImport(Glfw3Dll, EntryPoint = "glfwSwapBuffers")]
        public static extern void SwapBuffers(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSwapInterval")]
        public static extern void SwapInterval(int interval);

        [DllImport(Glfw3Dll, EntryPoint = "glfwExtensionSupported")]
        public static extern int ExtensionSupported(string extension);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetProcAddress")]
        public static extern IntPtr GetProcAddress(string procname);

        [DllImport(Glfw3Dll, EntryPoint = "glfwVulkanSupported")]
        public static extern int VulkanSupported();

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetRequiredInstanceExtensions")]
        private static extern IntPtr _GetRequiredInstanceExtensions(out uint count);

        public static string[] GetRequiredInstanceExtensions(out uint count)
        {
            var arrayPtr = _GetRequiredInstanceExtensions(out count);
            var requiredInstanceExtensions = new string[count];

            for(int i = 0; i < count; i++)
            {
                requiredInstanceExtensions[i] = Marshal.PtrToStringAnsi(arrayPtr + i);
            }

            return requiredInstanceExtensions;
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwInitHint")]
        public static extern void InitHint(int hint, int value);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetError")]
        private static extern int _GetError(out IntPtr description);

        public static int GetError(out string description)
        {
            int code = _GetError(out var ptr);
            description = Marshal.PtrToStringAnsi(ptr);
            return code;
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetMonitorWorkarea")]
        public static extern void GetMonitorWorkarea(IntPtr monitor, out int xpos, out int ypox, out int width, out int height);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetMonitorContentScale")]
        public static extern void GetMonitorContentScale(IntPtr monitor, out float xscale, out float yscale);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetMonitorUserPointer")]
        public static extern IntPtr GetMonitorUserPointer(IntPtr monitor);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetMonitorUserPointer")]
        public static extern void SetMonitorUserPointer(IntPtr monitor, IntPtr pointer);

        [DllImport(Glfw3Dll, EntryPoint = "glfwWindowHintString")]
        public static extern void WindowHintString(int hint, string value);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetWindowContentScale")]
        public static extern void GetWindowContentScale(IntPtr window, out float xscale, out float yscale);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetWindowOpacity")]
        public static extern float GetWindowOpacity(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowOpacity")]
        public static extern void SetWindowOpacity(IntPtr window, float opacity);

        [DllImport(Glfw3Dll, EntryPoint = "glfwRequestWindowAttention")]
        public static extern void RequestWindowAttention(IntPtr window);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowAttrib")]
        public static extern void SetWindowAttrib(IntPtr window, int attrib, int value);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowMaximizeCallback")]
        private static extern void _SetWindowMaximizeCallback(IntPtr window, WindowMaximizeFun cbfun);

        private static WindowMaximizeFun currentWindowMaximizeFun;

        public static void SetWindowMaximizeCallback(IntPtr window, WindowMaximizeFun cbfun)
        {
            currentWindowMaximizeFun = cbfun;
            _SetWindowMaximizeCallback(window, currentWindowMaximizeFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetWindowContentScaleCallback")]
        private static extern void _SetWindowContentScaleCallback(IntPtr window, WindowContentScaleFun cbfun);

        private static WindowContentScaleFun currentWindowContentScaleFun;

        public static void SetWindowContentScaleCallback(IntPtr window, WindowContentScaleFun cbfun)
        {
            currentWindowContentScaleFun = cbfun;
            _SetWindowContentScaleCallback(window, currentWindowContentScaleFun);
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwRawMouseMotionSupported")]
        public static extern int RawMouseMotionSupported();

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetKeyScancode")]
        public static extern int GetKeyScancode(int key);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetJoystickHats")]
        private static extern IntPtr _GetJoystickHats(int jid, out int count);

        public static byte[] GetJoystickHats(int jid, out int count)
        {
            var arrayPtr = _GetJoystickHats(jid, out count);
            var hats = new byte[count];

            for(int i = 0; i < count; i++)
            {
                hats[i] = Marshal.ReadByte(arrayPtr + i);
            }

            return hats;
        }

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetJoystickGUID")]
        private static extern IntPtr _GetJoystickGUID(int jid);

        // ReSharper disable once InconsistentNaming
        public static string GetJoystickGUID(int jid) => Marshal.PtrToStringAnsi(_GetJoystickGUID(jid));

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetJoystickUserPointer")]
        public static extern IntPtr GetJoystickUserPointer(int jid);

        [DllImport(Glfw3Dll, EntryPoint = "glfwSetJoystickUserPointer")]
        public static extern void SetJoystickUserPointer(int jid, IntPtr pointer);

        [DllImport(Glfw3Dll, EntryPoint = "glfwJoystickIsGamepad")]
        public static extern int JoystickIsGamepad(int jid);

        [DllImport(Glfw3Dll, EntryPoint = "glfwUpdateGamepadMappings")]
        public static extern int UpdateGamepadMappings(string mappings);

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetGamepadName")]
        private static extern IntPtr _GetGamepadName(int jid);

        public static string GetGamepadName(int jid) => Marshal.PtrToStringAnsi(_GetGamepadName(jid));

        [DllImport(Glfw3Dll, EntryPoint = "glfwGetGamepadState")]
        private static extern int _GetGamepadState(int jid, IntPtr state);

        public static int GetGamepadState(int jid, out GamepadState state)
        {
            var managedState = new GamepadState(new byte[15], new float[6]);
            int success;

            unsafe
            {
                var unmanagedState = new UnmanagedGamepadState();
                success = _GetGamepadState(jid, new IntPtr(&unmanagedState));

                for(int i = 0; i < managedState.Buttons.Length; i++)
                {
                    managedState.Buttons[i] = unmanagedState.buttons[i];
                }

                for(int i = 0; i < managedState.Axes.Length; i++)
                {
                    managedState.Axes[i] = unmanagedState.axes[i];
                }
            }

            state = managedState;
            return success;
        }

        #endregion
    }
}