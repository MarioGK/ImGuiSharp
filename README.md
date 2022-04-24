# ImGuiSharp
ImGuiSharp is a binding library for [ImGui](https://github.com/ocornut/imgui) for C# that aims to expose as many apis as possible and stay at the most updated version of imgui and cimgui.

⚠️**Warning**: This is a beta version, and is not yet ready for use.⚠️

🔴**Observation**: The library is only compiled for Windows-x64 and only tested on windows for now.🔴

**WIP**: Nuget package and CI build are not yet ready.

This can be considered a fork of the awesome project by mellinoe [ImGui.Net](https://github.com/mellinoe/ImGui.NET), the main differences between the two are:

- This library will be "bloated" it will contain all ImGui's features including internal ones and 3rd party libraries as well, if you want/need a smaller version of ImGuiSharp, you can use the [ImGui.Net](https://github.com/mellinoe/ImGui.NET) instead.
- CodeGenerator is being refactored to be easier to read and modify.
- ImGuiSharp will expose the ImGui internal headers.
- ImPlot,ImNodes,ImGuizmo added to the list of supported libraries.
- Provides easy to use scripts to update, build and test ImGuiSharp.

# Status (WIP)
**ImGuiSharp**:

[![NuGet stable version](https://badgen.net/nuget/v/ImGuiSharp)](https://nuget.org/packages/ImGuiSharp)
[![NuGet pre version](https://badgen.net/nuget/v/ImGuiSharp/pre)](https://nuget.org/packages/ImGuiSharp)

**ImGuiSharp.Veldrid**:

[![NuGet stable version](https://badgen.net/nuget/v/ImGuiSharp.Veldrid)](https://nuget.org/packages/ImGuiSharp.Veldrid)
[![NuGet pre version](https://badgen.net/nuget/v/ImGuiSharp.Veldrid/pre)](https://nuget.org/packages/ImGuiSharp.Veldrid)

**ImNodesSharp**:

[![NuGet stable version](https://badgen.net/nuget/v/ImNodesSharp)](https://nuget.org/packages/ImNodesSharp)
[![NuGet pre version](https://badgen.net/nuget/v/ImNodesSharp/pre)](https://nuget.org/packages/ImNodesSharp)

**ImGuizmoSharp**:

[![NuGet stable version](https://badgen.net/nuget/v/ImGuizmoSharp)](https://nuget.org/packages/ImGuizmoSharp)
[![NuGet pre version](https://badgen.net/nuget/v/ImGuizmoSharp/pre)](https://nuget.org/packages/ImGuizmoSharp)

**ImPlotSharp**:

[![NuGet stable version](https://badgen.net/nuget/v/ImPlotSharp)](https://www.nuget.org/packages/ImPlotSharp)
[![NuGet pre version](https://badgen.net/nuget/v/ImPlotSharp/pre)](https://www.nuget.org/packages/ImPlotSharp)

# Community 

[![Discord](https://badgen.net/badge/icon/discord?icon=discord&label)](https://https://discord.com/)

# Credits

https://github.com/mellinoe/ImGui.NET
> This is a .NET wrapper for the immediate mode GUI library, Dear ImGui. ImGui.NET lets you build graphical interfaces using a simple immediate-mode style. ImGui.NET is a .NET Standard library, and can be used on all major .NET runtimes and operating systems.

https://github.com/mayuki/Cocona
> Micro-framework for .NET Core console application. Cocona makes it easy and fast to build console applications on .NET.🚀

https://github.com/ocornut/imgui

> Dear ImGui is designed to enable fast iterations and to empower programmers to create content creation tools and visualization / debug tools (as opposed to UI for the average end-user). It favors simplicity and productivity toward this goal, and lacks certain features normally found in more high-level libraries.

https://github.com/cimgui/cimgui
> This is a thin c-api wrapper for the excellent C++ intermediate gui imgui. This library is intended as a intermediate layer to be able to use imgui from other languages that can interface with C .

https://github.com/mellinoe/veldrid
>Veldrid is a cross-platform, graphics API-agnostic rendering and compute library for .NET. It provides a powerful, unified interface to a system's GPU and includes more advanced features than any other .NET library. Unlike other platform- or vendor-specific technologies, Veldrid can be used to create high-performance 3D applications that are truly portable.

https://github.com/epezent/implot
>ImPlot is an immediate mode, GPU accelerated plotting library for Dear ImGui. It aims to provide a first-class API that ImGui fans will love. ImPlot is well suited for visualizing program data in real-time or creating interactive plots, and requires minimal code to integrate. Just like ImGui, it does not burden the end user with GUI state management, avoids STL containers and C++ headers, and has no external dependencies except for ImGui itself.

https://github.com/Nelarius/imnodes
>Imnodes aims to provide a simple, immediate-mode interface for creating a node editor within an ImGui window. Imnodes provides simple, customizable building blocks that a user needs to build their node editor.

https://github.com/CedricGuillemet/ImGuizmo
> What started with the gizmo is now a collection of dear imgui widgets and more advanced controls.