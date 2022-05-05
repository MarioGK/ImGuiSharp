namespace ImGuiSharp;

public unsafe delegate int ImGuiInputTextCallback(ImGuiInputTextCallbackData* data);
public unsafe delegate void ImGuiSizeCallback(ImGuiSizeCallbackData* data);
//public unsafe delegate void ImGuiErrorLogCallback(ImGuiErrorLogCallbackData* data);


//public delegate void PlatformCreateWindow(ImGuiViewportPtr vp); // Create a new platform window for the given viewport
//public delegate void PlatformDestroyWindow(ImGuiViewportPtr vp);
//public delegate void PlatformShowWindow(ImGuiViewportPtr vp);                      // Newly created windows are initially hidden so SetWindowPos/Size/Title can be called on them first
//public delegate void PlatformSetWindowPos(ImGuiViewportPtr vp, Vector2 pos);
//public unsafe delegate void PlatformGetWindowPos(ImGuiViewportPtr vp, Vector2* outPos);
//public delegate void PlatformSetWindowSize(ImGuiViewportPtr vp, Vector2 size);
//public unsafe delegate void PlatformGetWindowSize(ImGuiViewportPtr vp, Vector2* outSize);
//public delegate void PlatformSetWindowFocus(ImGuiViewportPtr vp); // Move window to front and set input focus
//public delegate byte PlatformGetWindowFocus(ImGuiViewportPtr vp);
//public delegate byte PlatformGetWindowMinimized(ImGuiViewportPtr vp);
//public delegate void PlatformSetWindowTitle(ImGuiViewportPtr vp, IntPtr title);