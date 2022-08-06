#Credits: https://github.com/sonoro1234/LuaJIT-ImGui/blob/docking_inter/CMakeLists.txt

cmake_minimum_required(VERSION 3.1)

project(cimgui)

set (CMAKE_CXX_STANDARD 11)

set(CMAKE_CXX_STANDARD_REQUIRED True)

add_definitions("-DIMGUI_DISABLE_OBSOLETE_FUNCTIONS=1")

#general settings
include_directories(cimgui)
include_directories(cimgui/imgui)

file(GLOB IMGUI_SOURCES
    ./cimgui/cimgui.cpp
    ./cimgui/imgui/imgui.cpp
    ./cimgui/imgui/imgui_draw.cpp
    ./cimgui/imgui/imgui_demo.cpp
    ./cimgui/imgui/imgui_widgets.cpp
    ./cimgui/imgui/imgui_tables.cpp
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