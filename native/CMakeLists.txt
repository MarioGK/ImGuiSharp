#Credits: https://github.com/sonoro1234/LuaJIT-ImGui/blob/docking_inter/CMakeLists.txt

cmake_minimum_required(VERSION 3.1)

project(cimgui)

set (CMAKE_CXX_STANDARD 11)

#general settings
include_directories(cimgui)
include_directories(cimgui/imgui)
include_directories(cimplot)
include_directories(cimplot/implot)
include_directories(cimguizmo)
include_directories(cimguizmo/ImGuizmo)
include_directories(cimguizmo_quat)
include_directories(cimguizmo_quat/imGuIZMO.quat)
include_directories(cimguizmo_quat/imGuIZMO.quat/imGuIZMO.quat)
include_directories(cimnodes)
include_directories(cimnodes/ImNodes)

#add_definitions("-DIMGUI_DISABLE_OBSOLETE_FUNCTIONS=1")
add_definitions(-DIMNODES_NAMESPACE=imnodes)

#general settings

file(GLOB IMGUI_SOURCES
    ./cimgui/cimgui.cpp
    ./cimgui/imgui/imgui.cpp
    ./cimgui/imgui/imgui_draw.cpp
    ./cimgui/imgui/imgui_demo.cpp
    ./cimgui/imgui/imgui_widgets.cpp
    ./cimgui/imgui/imgui_tables.cpp
	#cimplot
	./cimplot/cimplot.cpp
	./cimplot/implot/implot.cpp
	./cimplot/implot/implot_items.cpp  
	./cimplot/implot/implot_demo.cpp
	#cimguizmo
	./cimguizmo/cimguizmo.cpp
	./cimguizmo/ImGuizmo/ImGuizmo.cpp
	./cimguizmo_quat/imGuIZMO.quat/imGuIZMO.quat/imGuIZMOquat.cpp  
	./cimguizmo_quat/cimguizmo_quat.cpp
	#cimnodes
	./cimnodes/cimnodes.cpp
	./cimnodes/imnodes/imnodes.cpp
	./cimnodes_r/cimnodes_r.cpp
	./cimnodes_r/ImNodes/ImNodes.cpp
	./cimnodes_r/ImNodes/ImNodesEz.cpp
)


set(IMGUI_STATIC "no" CACHE STRING "Build as a static library")
set(IMGUI_FREETYPE "no" CACHE STRING "Build with freetype library")
set(IMGUI_LIBRARIES )

#optional adding implementations
if(IMGUI_FREETYPE)
	FIND_PACKAGE(freetype REQUIRED PATHS ${FREETYPE_PATH})
	list(APPEND IMGUI_LIBRARIES freetype)
	list(APPEND IMGUI_SOURCES imgui/misc/freetype/imgui_freetype.cpp)
	add_definitions("-DCIMGUI_FREETYPE=1")
endif(IMGUI_FREETYPE)

#add library and link
if (IMGUI_STATIC)
    add_library(cimgui STATIC ${IMGUI_SOURCES})
else (IMGUI_STATIC)
    add_library(cimgui SHARED ${IMGUI_SOURCES})
endif (IMGUI_STATIC)

target_compile_definitions(cimgui PUBLIC IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1)
if (WIN32)
    target_compile_definitions(cimgui PUBLIC IMGUI_IMPL_API=extern\t\"C\"\t__declspec\(dllexport\))
    list(APPEND IMGUI_LIBRARIES imm32)
else (WIN32)
    target_compile_definitions(cimgui PUBLIC IMGUI_IMPL_API=extern\t\"C\"\t)
endif (WIN32)


#install
install(TARGETS cimgui
    RUNTIME DESTINATION  .
    LIBRARY DESTINATION  .
    ARCHIVE DESTINATION  .
)