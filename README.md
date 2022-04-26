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

# [Credits](https://github.com/MarioGK/ImGuiSharp/blob/main/CREDITS.md)

Moved [credits](https://github.com/MarioGK/ImGuiSharp/blob/main/CREDITS.md) to its own file because it was getting too big.