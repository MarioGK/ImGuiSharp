cmake_minimum_required(VERSION 3.1)

project(cimgui)

set (CMAKE_CXX_STANDARD 11)

set(CMAKE_CXX_STANDARD_REQUIRED True)

add_definitions("-DIMGUI_DISABLE_OBSOLETE_FUNCTIONS=1")

#general settings
include_directories(cimgui)

file(GLOB IMGUI_SOURCES
    ./cimgui/cimgui.cpp
    ./cimgui/imgui/imgui.cpp
    ./cimgui/imgui/imgui_draw.cpp
    ./cimgui/imgui/imgui_demo.cpp
    ./cimgui/imgui/imgui_widgets.cpp
    ./cimgui/imgui/imgui_tables.cpp
)

option(IMGUI_STATIC "Static" OFF)

#add library and link
if (IMGUI_STATIC)
    add_library(cimgui STATIC ${IMGUI_SOURCES})
else (IMGUI_STATIC)
    add_library(cimgui SHARED ${IMGUI_SOURCES})
endif (IMGUI_STATIC)

target_compile_definitions(cimgui PUBLIC IMGUI_DISABLE_OBSOLETE_FUNCTIONS=1)
if (WIN32)
    target_compile_definitions(cimgui PUBLIC IMGUI_IMPL_API=extern\t\"C\"\t__declspec\(dllexport\))
else (WIN32)
    target_compile_definitions(cimgui PUBLIC IMGUI_IMPL_API=extern\t\"C\"\t)
endif (WIN32)